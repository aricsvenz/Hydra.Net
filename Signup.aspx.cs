using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Signup : System.Web.UI.Page
{
    hydra_cms obj = new hydra_cms();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
        
        }

    }

  
    protected void btn_add_admin_Click(object sender, EventArgs e)
    {
        obj.admin_name = txtname.Text;
        obj.admin_email = txtemail.Text;
        obj.admin_phone = txtphone.Text;
        obj.admin_password = txtpassword.Text;
        obj.admin_image = "";
        int i = obj.insert_admin();
        if (i > 0)
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