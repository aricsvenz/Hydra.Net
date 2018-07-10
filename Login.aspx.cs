using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Login : System.Web.UI.Page
{
    hydra_cms obj = new hydra_cms();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            if (Session["userid"] == "" || Session["userid"] == null)
            {
               // Response.Redirect("./login.aspx");
            }
            else
            {
                //Response.Redirect("./Default.aspx");
            }
        }
    }
    protected void btn_login_Click(object sender, EventArgs e)
    {
        obj.admin_email = txtemail.Text;
        obj.admin_password = txtpassword.Text;
        DataTable dt = obj.login();
        if (dt.Rows.Count > 0)
        {
            obj.admin_email = txtemail.Text;
            DataTable dt2 = obj.get_idbyemail();
            if (dt2.Rows.Count > 0)
            {
                int id = Convert.ToInt32(dt2.Rows[0]["admin_id"]);
                Session["userid"] = id;
                Response.Redirect("./Default.aspx");
            }
        }

    }
}