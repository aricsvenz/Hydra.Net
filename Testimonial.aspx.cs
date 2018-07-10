using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Testimonial : System.Web.UI.Page
{
    hydra_cms obj = new hydra_cms();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            show_testimonials();
        }
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        obj.testimonial_username = txt_username.Text;
        obj.testimonial_user_title = txt_user_title.Text;
        obj.testimonial_text = txt_testimonial_content.Text;
        obj.testmonial_date = System.DateTime.UtcNow.ToShortDateString();
        obj.testimonial_time = System.DateTime.UtcNow.ToShortTimeString();
        if (fu_user_image.HasFile)
        {
            string path = "./uploaded_files/users/" + fu_user_image.FileName;

            fu_user_image.SaveAs(Server.MapPath(path));
            obj.testimonial_user_image = fu_user_image.FileName;
            obj.testimonial_user_imagepath = path;
            int i = obj.
                insert_testimonials();
            if (i > 0)
            {
                show_testimonials();
            }
        }
        else
        {
            //  obj.about_image = "Topic.jpg";
            // obj.about_imagepath = "./img/Topic.jpg";
        }
    }

    public void show_testimonials()
    {
        DataTable dt = obj.show_testimonials();
        if (dt.Rows.Count > 0)
        {
            lv_show_testimonials.DataSource = dt;
            lv_show_testimonials.DataBind();
                       
        }
    }
}