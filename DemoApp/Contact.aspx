<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="DemoApp.Contact" %>
<%@ Register Src="~/ContactForm.ascx" TagName="ContactForm" TagPrefix="uc" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>

    <h3>Contact Us</h3>
    
    <uc:ContactForm runat="server" ID="cfMsg" />
    <asp:Button Text="Send" ID="btnSend" runat="server"  OnClick="BtnSend_Click"/>
    <p>
        <asp:Label ID="lblOutput" runat="server"></asp:Label>
    </p>
</asp:Content>
