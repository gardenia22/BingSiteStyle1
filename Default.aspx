<%@ Page Title="Foropo|在校大学生的搜索引擎" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>FOR Our Potential Options</h1>
            </hgroup>
            <p>
                在校大学生的搜索引擎                
            </p>
            <p>综合各大求职信息平台、出国论坛、考研论坛信息</p>
            <p>轻松找到实习、留学、考研的各种资讯及攻略</p>
        </div>
    </section>
</asp:Content>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

     <div style="margin-top:50px" class="PageButton">     
        <div Class="PageButton" style="width:364px">      
     
               <asp:TextBox ID="txtSearch" runat="server" Class="searchbox"></asp:TextBox>

               <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="Images/searchico3.png"  Class="searchbutton" onclick="Button1_Click"  />

        </div>
    </div>

    <div style="margin-top:40px;text-align:center;">
        
        <p><a Class="Red" href="Results.aspx?query=香港Mphil申请"; target="_blank">香港Mphil</a> <a Class="Blue" href="Results.aspx?query=百度暑期实习"; target="_blank">百度暑期实习</a> <a Class="Gray" href="Results.aspx?query=MIT CS申请"; target="_blank">MIT CS申请</a> <a Class="Orange" href="Results.aspx?query=北大历史考研"; target="_blank">北大历史考研</a></p>
        <p><a Class="Teal" href="Results.aspx?query=人大人力资源考研"; target="_blank">人大人力资源考研</a> <a Class="Purple" href="Results.aspx?query=财科所 考研"; target="_blank">财科所 考研</a> <a Class="Green" href="Results.aspx?query=CMU MIS 申请"; target="_blank">CMU MIS</a> <a Class="Pink" href="Results.aspx?query=四大 面试经验"; target="_blank">四大面试经验</a></p>
    </div>

    <div style="margin:0 auto; text-align:center;">
    <p><a href="http://www.minerrights.org" target="_blank">【请关注矿工权益，呼吁我国签订第176号公约】</a></p>
    </div>


    <div  id="bdshare"style="margin-left:38%" class="bdshare_t bds_tools get-codes-bdshare" >
        
        <a class="bds_renren"></a>
        <a class="bds_tsina"></a>
        <a class="bds_douban"></a>
        <a class="bds_qzone"></a>
        <a class="bds_tqq"></a>
        <a class="bds_diandian"></a>
        <a class="bds_fx"></a>
        <span class="bds_more">更多</span>
        <a class="shareCount"></a>
    </div>

    <script type="text/javascript" id="bdshare_js" data="type=tools&amp;uid=6687919" ></script>
    <script type="text/javascript" id="bdshell_js"></script>
    <script type="text/javascript">
        document.getElementById("bdshell_js").src = "http://bdimg.share.baidu.com/static/js/shell_v2.js?cdnversion=" + Math.ceil(new Date() / 3600000)
    </script>

</asp:Content>