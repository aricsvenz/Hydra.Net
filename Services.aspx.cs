using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Services : System.Web.UI.Page
{
    hydra_cms obj = new hydra_cms();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            show_services();
        }
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        obj.service_title = txt_service_title.Text;
        obj.service_description = txt_sevice_desc.Text;
        if (fu_service_image.HasFile)
        {
            string path = "./uploaded_files/services/" + fu_service_image.FileName;

            fu_service_image.SaveAs(Server.MapPath(path));
            obj.service_image = fu_service_image.FileName;
            obj.service_imagepath = path;
            int i = obj.insert_services();
            if (i > 0)
            {
                show_services();
            }
        }
        else
        {
            //  obj.about_image = "Topic.jpg";
            // obj.about_imagepath = "./img/Topic.jpg";
        }
    }

    public void show_services()
    {
        DataTable dt = obj.show_services();
        if (dt.Rows.Count > 0)
        {
            lv_show_services.DataSource = dt;
            lv_show_services.DataBind();
        }
    }
}