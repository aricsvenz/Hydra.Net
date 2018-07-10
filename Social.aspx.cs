using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Social_media : System.Web.UI.Page
{
    hydra_cms obj = new hydra_cms();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            show_social();
        }

    }




    public void show_social()
    {
        DataTable dt = obj.show_social_media();
        if (dt.Rows.Count > 0)
        {
            lv_show_social.DataSource = dt;
            lv_show_social.DataBind();
        }
    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
        obj.facebook = txt_facebook.Text;
        obj.twitter = txt_twitter.Text;
        obj.linkdin = txt_linkedin.Text;
        obj.instagram = txt_instagram.Text;
        obj.googleplus = txt_googleplus.Text;
        obj.dribble = txt_dribble.Text;
        obj.pinterest = txt_pinterest.Text;
        obj.youtube = txt_youtube.Text;
        obj.personal_link = txt_personal_link.Text;
         int i = obj.insert_social_media();
            if (i > 0)
            {
                show_social();
            }
       
    }
}