using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Team : System.Web.UI.Page
{
    hydra_cms obj = new hydra_cms();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            show_team();   
        }
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        obj.team_name = txt_username.Text;
        obj.team_about = txt_user_about.Text;
        obj.team_designation = txt_user_designation.Text;
        obj.team_facebook = txt_facebook.Text;
        obj.team_twitter = txt_twitter.Text;
        obj.team_linkdin = txt_linkedin.Text;
        obj.team_instagram = txt_instagram.Text;
        obj.team_googleplus = txt_googleplus.Text;
        obj.team_dribble = txt_dribble.Text;
        obj.team_pinterest = txt_pinterest.Text;
        obj.team_youtube = txt_youtube.Text;
        obj.team_personal_link = txt_personal_link.Text;
    
        if (fu_user_image.HasFile)
        {
            string path = "./uploaded_files/users/" + fu_user_image.FileName;

            fu_user_image.SaveAs(Server.MapPath(path));
            obj.team_image = fu_user_image.FileName;
            obj.team_imagepath = path;
            int i = obj.insert_team();
            if (i > 0)
            {
                show_team();
            }
        }
        else
        {
            //  obj.about_image = "Topic.jpg";
            // obj.about_imagepath = "./img/Topic.jpg";
        }
    }

    public void show_team()
    {
        DataTable dt = obj.show_team();
        if (dt.Rows.Count > 0)
        {
            lv_show_team.DataSource = dt;
            lv_show_team.DataBind();

        }
    }
}