<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="HelloWebApplication.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your application description page.click here</h3>
    <p>Use this area to provide additional information. Can i edit this??? Seems yes.<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Contact.aspx">click here for contact info</asp:HyperLink>
    </p>
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <p>
        <asp:FileUpload ID="FileUpload1" runat="server" />
    </p>
    <p>
        <asp:FormView ID="FormView1" runat="server">
        </asp:FormView>
    </p>
    <p>&nbsp;</p>
</asp:Content>
