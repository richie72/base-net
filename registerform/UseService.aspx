<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UseService.aspx.cs" Inherits="registerform.UseService" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <h3>Using the service</h3>
    <br /> <br />
            
            <asp:Label ID="lblmessage" runat="server"></asp:Label>
            
            <br /> <br />
            
            <asp:Button ID="btnpostback" runat="server" onclick="Button1_Click" Text="Post Back" style="width:132px" />
               
            <asp:Button ID="btnservice" runat="server" onclick="btnservice_Click"  Text="Get Stock" style="width:99px" />
    </div>
    </form>
</body>
</html>
