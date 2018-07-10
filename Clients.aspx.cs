using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Clients : System.Web.UI.Page
{

    hydra_cms obj = new hydra_cms();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            show_clients();
        }
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    { 
        obj.client_name = txt_client_title.Text;
       
        if (fu_clientlogo_image.HasFile)
        {
            string path = "./uploaded_files/Client/" + fu_clientlogo_image.FileName;

            fu_clientlogo_image.SaveAs(Server.MapPath(path));
            obj.client_logo = fu_clientlogo_image.FileName;
            int i = obj.insert_clients();
            if (i > 0)
            {
                show_clients();
            }
        }
        else
        {
            //  obj.about_image = "Topic.jpg";
            // obj.about_imagepath = "./img/Topic.jpg";
        }
     
    }

    

    public void show_clients()
    {
        DataTable dt = obj.show_clients();
        if (dt.Rows.Count > 0)
        {
            lv_show_client.DataSource = dt;
            lv_show_client.DataBind();
        }
    }
}