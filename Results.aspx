<%@ Page Title="搜索结果" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Results.aspx.cs" Inherits="Results" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <div>
       <div Class="PageButton" style="width:364px">
            
            <asp:TextBox ID="txtSearch1" runat="server" Class="searchbox"></asp:TextBox>
        
 
            <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="Images/searchico3.png"  Class="searchbutton" onclick="Button2_Click"  />

        </div>
    </div>
        
    <div class="ResultPage">
        <div style="width:auto">
        <asp:GridView ID="GridViewSearchResult" runat="server"
                        AutoGenerateColumns="false" ShowHeader="false" 
                        BorderColor="White" AllowPaging="false" >
           <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <div Class="bingblock">
                            <asp:Hyperlink ID="lblTitle1" Class="bingtitle" runat="server" NavigateUrl='<%#Bind("Url") %>' Text='<%# Bind("Title") %>'
                                ></asp:Hyperlink>
                            </div>
                            
                            <div Class="bingblock">
                            <asp:Label ID="lblDescription" runat="server"  Text ='<%# Bind("Description") %>'></asp:Label>
                            </div>
                            
                            <div Class="binglink">
                            <asp:Label ID="HyperLink1"  runat="server" Text='<%#Bind("Url") %>'><%#Eval("Url") %></asp:Label>
                            </div>
                           
                            <br />
                        </ItemTemplate>
 
                    </asp:TemplateField>
           </Columns>
        </asp:GridView>
        </div>

        <div Class="PageButton">
            <div Class="PageButton">
            <asp:Button ID="BeginPage" Class="PageStyle" runat="server" Text="<<" OnClick="Page_1"/>
            <asp:Button ID="PreviousPage" Class="PageStyle" runat="server" Text="<" OnClick="Previous_Page"/>
            <asp:Button ID="Page1" Class="PageStyle" runat="server" Text="1" OnClick="Page_1" Visible = "false"/>
            <asp:Button ID="Page2" Class="PageStyle" runat="server" Text="2" OnClick="Page_2" Visible = "false"/>
            <asp:Button ID="Page3" Class="PageStyle" runat="server" Text="3" OnClick="Page_3" Visible = "false"/>
            <asp:Button ID="Page4" Class="PageStyle" runat="server" Text="4" OnClick="Page_4" Visible = "false"/>
            <asp:Button ID="Page5" Class="PageStyle" runat="server" Text="5" OnClick="Page_5" Visible = "false"/>
            <asp:Button ID="Page6" Class="PageStyle" runat="server" Text="6" OnClick="Page_6" Visible = "false"/>
            <asp:Button ID="Page7" Class="PageStyle" runat="server" Text="7" OnClick="Page_7" Visible = "false"/>
            <asp:Button ID="Page8" Class="PageStyle" runat="server" Text="8" OnClick="Page_8" Visible = "false"/>
            <asp:Button ID="Page9" Class="PageStyle" runat="server" Text="9" OnClick="Page_9" Visible = "false"/>
            <asp:Button ID="Page10" Class="PageStyle" runat="server" Text="10" OnClick="Page_10" Visible = "false"/>
            <asp:Button ID="Page11" Class="PageStyle" runat="server" Text="11" OnClick="Page_11" Visible = "false"/>
            <asp:Button ID="NextPage" Class="PageStyle" runat="server" Text=">" OnClick="Next_Page"/>
            <asp:Button ID="EndPage" Class="PageStyle" runat="server" Text=">>" OnClick="Page_11"/>
            </div>
        </div>

        <p style="text-align:right;font-family:'Microsoft YaHei'">Supported by <a href="http://cb.bing.com">Bing</a> and <a href="http://www.windowsazure.com/">WindowsAzure</a>.</p>

    </div>
    
    
</asp:Content>