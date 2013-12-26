using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bing;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;



public class PageClass
{

}
public partial class Results : System.Web.UI.Page
{
    protected String query;
    protected void Page_Load(object sender, EventArgs e)
    {

        query = Request.QueryString["query"];
        String page;
        page = Request.QueryString["page"];
        int pagenum = 1;
        if (page != null)
            pagenum = Int32.Parse(page);
        

        var objBing = new Bing.BingSearchContainer(new Uri("https://api.datamarket.azure.com/Bing/SearchWeb/v1/Web"));
        //Replace this Account Key with you Account Key
        var accountKey = "etto0aKJ66V3m9fLMdEX/G2KZwEmS3Y1J+mZzI1Cmn0";
        //Passing the Credintial
        objBing.Credentials = new System.Net.NetworkCredential(accountKey, accountKey);
        //Following Line is used to get the Search Result as DataSource.
        //设置搜索范围
        string WebSites = "(site:01hr.com " + "OR site:guolairen.com " + "OR site:51job.com " +
            "OR site:chinahr.com " + "OR site:dajie.com " + "OR site:yjbys.com " + "OR site:hykaoyan.org " +
            "OR site:kaoyan.eol.cn " + "OR site:cskaoyan.com " + "OR site:kaoyan.com " +
            "OR site:chinakaoyan.com " + "OR site:drcnet.com.cn  " + "OR site:cnedu.cn " +
            "OR site:abroadstar.com " + "OR site:sharewithu.com " + "OR site:taisha.org " + "OR site:gter.net )";
        //得到搜索结果
        var webResult = objBing.Web(query + WebSites, null, null, null, null, null, null, null, 20, pagenum);
        //绑定搜索结果Binding the Resultant DataSource to the GridView
        GridViewSearchResult.DataSource = webResult;
        GridViewSearchResult.DataBind();
        //Change the page button visibility
        if (pagenum < 5)
        {
            Page1.Visible = true;
            Page2.Visible = true;
            Page3.Visible = true;
            Page4.Visible = true;
            Page5.Visible = true;
            if (pagenum == 1)
            {
                BeginPage.Visible = false;
                PreviousPage.Visible = false;
                Page1.Style.Add("background-color", "#7ac0da");
            }
            if (pagenum == 2)
            {
                Page2.Style.Add("background-color", "#7ac0da");
            }
            if (pagenum == 3)
            {
                Page3.Style.Add("background-color", "#7ac0da");
            }
            if (pagenum == 4)
            {
                Page4.Style.Add("background-color", "#7ac0da");
            }
        }
        if (pagenum == 5)
        {
            Page2.Visible = true;
            Page3.Visible = true;
            Page4.Visible = true;
            Page5.Visible = true;
            Page6.Visible = true;
            Page5.Style.Add("background-color", "#7ac0da");
        }
        if (pagenum == 6)
        {
            Page7.Visible = true;
            Page3.Visible = true;
            Page4.Visible = true;
            Page5.Visible = true;
            Page6.Visible = true;
            Page6.Style.Add("background-color", "#7ac0da");
        }
        if (pagenum == 7)
        {
            Page7.Visible = true;
            Page8.Visible = true;
            Page4.Visible = true;
            Page5.Visible = true;
            Page6.Visible = true;
            Page7.Style.Add("background-color", "#7ac0da");
        }
        if (pagenum == 8)
        {
            Page7.Visible = true;
            Page8.Visible = true;
            Page9.Visible = true;
            Page5.Visible = true;
            Page6.Visible = true;
            Page8.Style.Add("background-color", "#7ac0da");
        }
        if (pagenum == 9)
        {
            Page7.Visible = true;
            Page8.Visible = true;
            Page9.Visible = true;
            Page10.Visible = true;
            Page6.Visible = true;
            Page9.Style.Add("background-color", "#7ac0da");
        }
        if (pagenum == 10)
        {
            Page7.Visible = true;
            Page8.Visible = true;
            Page9.Visible = true;
            Page10.Visible = true;
            Page11.Visible = true;
            Page10.Style.Add("background-color", "#7ac0da");
        }
        if (pagenum == 11)
        {
            Page7.Visible = true;
            Page8.Visible = true;
            Page9.Visible = true;
            Page10.Visible = true;
            Page11.Visible = true;
            NextPage.Visible = false;
            EndPage.Visible = false;
            Page11.Style.Add("background-color", "#7ac0da");
        }

    }
    //分页页码设置
    protected void Next_Page(object sender, EventArgs e)
    {


        String page;
        page = Request.QueryString["page"];
        int pagenum = 1;
        if (page != "")
            pagenum = Int32.Parse(page);
        string url;
        query = query + " init:sharewithu";
        if (pagenum <= 10) url = "results.aspx?query=" + query + "&page=" + (pagenum + 1).ToString();
        else url = "results.aspx?query=" + query + "&page=" + page;
        Response.Redirect(url);
    }
    protected void Page_1(object sender, EventArgs e)
    {
        string url;
        url = "results.aspx?query=" + query + "&page=" + "1";
        Response.Redirect(url);
    }
    protected void Page_2(object sender, EventArgs e)
    {
        string url;
        url = "results.aspx?query=" + query + "&page=" + "2";
        Response.Redirect(url);
    }
    protected void Page_3(object sender, EventArgs e)
    {
        String query;
        query = Request.QueryString["query"];
        string url;
        url = "results.aspx?query=" + query + "&page=" + "3";
        Response.Redirect(url);
    }
    protected void Page_4(object sender, EventArgs e)
    {

        string url;
        url = "results.aspx?query=" + query + "&page=" + "4";
        Response.Redirect(url);
    }
    protected void Page_5(object sender, EventArgs e)
    {

        string url;
        url = "results.aspx?query=" + query + "&page=" + "5";
        Response.Redirect(url);

    }
    protected void Page_6(object sender, EventArgs e)
    {

        string url;
        url = "results.aspx?query=" + query + "&page=" + "6";
        Response.Redirect(url);
    }
    protected void Page_7(object sender, EventArgs e)
    {
        string url;
        url = "results.aspx?query=" + query + "&page=" + "7";
        Response.Redirect(url);
    }
    protected void Page_8(object sender, EventArgs e)
    {
        string url;
        url = "results.aspx?query=" + query + "&page=" + "8";
        Response.Redirect(url);
    }
    protected void Page_9(object sender, EventArgs e)
    {
        string url;
        url = "results.aspx?query=" + query + "&page=" + "9";
        Response.Redirect(url);
    }
    protected void Page_10(object sender, EventArgs e)
    {
        string url;
        url = "results.aspx?query=" + query + "&page=" + "10";
        Response.Redirect(url);

    }
    protected void Page_11(object sender, EventArgs e)
    {

        string url;
        url = "results.aspx?query=" + query + "&page=" + "11";
        Response.Redirect(url);


    }
    protected void Previous_Page(object sender, EventArgs e)
    {


        String page;
        page = Request.QueryString["page"];
        int pagenum = 1;
        if (page != "")
            pagenum = Int32.Parse(page);
        string url;
        if (pagenum > 1) url = "results.aspx?query=" + query + "&page=" + (pagenum - 1).ToString();
        else url = "results.aspx?query=" + query + "&page=" + page;
        Response.Redirect(url);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        string url;
        if (txtSearch1.Text != "")
        {
            url = "results.aspx?query=" + txtSearch1.Text + "&page=" + "1";
            Response.Redirect(url);
        }
        else
        {
            Response.Redirect("default.aspx");
        }
    }
   
}