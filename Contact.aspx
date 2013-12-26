<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1><%: Title %></h1>
        <h2>联系方式</h2>
    </hgroup>


    <section class="contact">
        <header>
            <h3>电邮:</h3>
        </header>
        <p>
            <span><a href=mailto:nanshu.wang@gmail.com>nanshu.wang@gmail.com</a></span>
        </p>
    </section>

    <section class="contact">
        <header>
            <h3>博客:</h3>
        </header>
        <p>
            <span><a href="http://codinglygardenia.diandian.com" target="_blank">codinglygardenia</a></span>
        </p>
        <header>
            <h3>豆瓣:</h3>
        </header>
        <p>
            <span><a href="http://www.douban.com/people/gardenia22" target="_blank">www.douban.com/people/gardenia22</a></span>
        </p>
        <header>
            <h3>新浪微博:</h3>
        </header>
        <p>
            <span><a href="http://weibo.com/gardenia22" target="_blank">http://weibo.com/gardenia22</a></span>
        </p>

    </section>
</asp:Content>