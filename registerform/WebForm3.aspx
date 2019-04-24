<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="registerform.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <p style="height: 108px">
        File Upload
        </p>
    <p style="height: 145px">
        &nbsp;
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <br />
        <br />

        <asp:Button ID="Button1" runat="server" Text="Upload" onclick="Button1_Click" />
        <br />
        <br />

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>


</asp:Content>
