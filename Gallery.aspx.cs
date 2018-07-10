using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class Gallery : System.Web.UI.Page
{
    hydra_cms obj = new hydra_cms();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            show_gallery();
        }
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        obj.gallery_title = txt_gallery_title.Text;
        obj.gallery_image_title = txt_gallery_caption.Text;
        obj.gallery_image_desc = txt_gallery_desc.Text;
        if (fu_gallery_image.HasFile)
        {
            string path = "./uploaded_files/gallery/" + fu_gallery_image.FileName;

            fu_gallery_image.SaveAs(Server.MapPath(path));
            obj.gallery_image = fu_gallery_image.FileName;
            obj.gallery_imagepath = path;
            int i = obj.insert_gallery();
            if (i > 0)
            {
                show_gallery();
            }
        }
        else
        {
            //  obj.about_image = "Topic.jpg";
            // obj.about_imagepath = "./img/Topic.jpg";
        }
     
    }


    public void show_gallery()
    {
        DataTable dt = obj.show_gallery();
        if (dt.Rows.Count > 0)
        {
            lv_show_gallery.DataSource = dt;
            lv_show_gallery.DataBind();
        }
    }
}