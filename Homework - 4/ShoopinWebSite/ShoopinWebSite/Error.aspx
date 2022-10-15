<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="ShoopinWebSite.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            You could not login. Try
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" Font-Overline="False" Font-Underline="True" ForeColor="#0000CC" NavigateUrl="~/Login.aspx">logging</asp:HyperLink>
&nbsp;in again.<br />
        </div>
    </form>
</body>
</html>
