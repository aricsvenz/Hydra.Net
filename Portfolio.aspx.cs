using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Portfolio : System.Web.UI.Page
{
    hydra_cms obj = new hydra_cms();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            show_portfolio();
        }
    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {
        obj.portfolio_title = txt_portfolio_title.Text;
        obj.portfolio_description = txt_portfolio_description.Text;

        if (fu_portfolio_img.HasFile)
        {
            string path = "./uploaded_files/portfolio/" + fu_portfolio_img.FileName;

            fu_portfolio_img.SaveAs(Server.MapPath(path));
            obj.portfolio_image = fu_portfolio_img.FileName;
            obj.portfolio_imagepath = path;
            int i = obj.insert_portfolio();
            if (i > 0)
            {
                show_portfolio();
            }
        }
        else
        {

        }
    }

    public void show_portfolio()
    {
        DataTable dt = obj.show_portfolio();
        if (dt.Rows.Count > 0)
        {
            lv_show_portfolio.DataSource = dt;
            lv_show_portfolio.DataBind();
        }
    }
}