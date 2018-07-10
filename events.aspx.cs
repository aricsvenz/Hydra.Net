using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class events : System.Web.UI.Page
{
    hydra_cms obj = new hydra_cms();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            show_events();
        }
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
       
        obj.event_title = txt_event_title.Text;
        obj.event_details = txt_event_content.Text;
        obj.event_date = txt_event_date.Text;
        obj.event_time = txt_event_time.Text;
        obj.event_place = txt_event_place.Text;
        obj.event_city = txt_event_city.Text;
        obj.event_time = txt_event_time.Text;
        if (fu_event_image.HasFile)
        {
            string path = "./uploaded_files/event/" + fu_event_image.FileName;

            fu_event_image.SaveAs(Server.MapPath(path));
            obj.event_image = fu_event_image.FileName;
            obj.event_image_path = path;
            int i = obj.insert_events();
            if (i > 0)
            {
                show_events();
            }
        }
        else
        {
            //  obj.about_image = "Topic.jpg";
            // obj.about_imagepath = "./img/Topic.jpg";
        }
     
    }


    public void show_events()
    {
        DataTable dt = obj.show_events();
        if (dt.Rows.Count > 0)
        {
            lv_show_events.DataSource = dt;
            lv_show_events.DataBind();
        }
    }

}