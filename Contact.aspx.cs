using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Contact : System.Web.UI.Page
{
    hydra_cms obj = new hydra_cms();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            show_contact();
        }
    }

    public void show_contact()
    {
        DataTable dt = obj.show_about();
        if (dt.Rows.Count > 0)
        {
            

        }
        else
        {
            
        }
    }
}