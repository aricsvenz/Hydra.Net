using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class About : System.Web.UI.Page
{
    hydra_cms obj = new hydra_cms(); // create object from class

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            show_aboutus();
        }
    }
   
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        obj.about_title = txt_about_title.Text;
        obj.about_content = txt_about_content.Text;
        
        if (fu_about_image.HasFile)
        {
            string path = "./uploaded_files/about/" + fu_about_image.FileName;

            fu_about_image.SaveAs(Server.MapPath(path));
            obj.about_image = fu_about_image.FileName;
            obj.about_imagepath = path;
            int i = obj.insert_about();
            if (i > 0)
            {
                show_aboutus();
            }
        }
        else
        {
           //  obj.about_image = "Topic.jpg";
           // obj.about_imagepath = "./img/Topic.jpg";
        }
    }

    public void show_aboutus()
    {
        DataTable dt = obj.show_about();
        if (dt.Rows.Count > 0)
        {
            lv_show_aboutus.DataSource = dt;
            lv_show_aboutus.DataBind();
        }
    }
}