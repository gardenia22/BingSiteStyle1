
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bing;

public partial class _Default : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string url;
        if (txtSearch.Text != "")
        {
            url = "results.aspx?query=" + txtSearch.Text + "&page=" + "1";
            Response.Redirect(url);
        }
        else
        {
            Response.Redirect("default.aspx");
        }
    }



}