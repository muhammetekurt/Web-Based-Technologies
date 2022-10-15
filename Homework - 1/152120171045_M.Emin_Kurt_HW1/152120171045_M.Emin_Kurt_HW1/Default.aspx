<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Homework_1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 410px;
            height: 615px;
            margin-left: 0px;
        }
        .auto-style1 {
            margin-left: 40px;
        }
        .auto-style2 {
            margin-left: 80px;
            width: 270px;
        }
        .auto-style3 {
            width: 178px;
            height: 143px;
        }
    </style>
</head>
<body style="margin-left: 480px; height: 429px;">
    <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <img alt="kj" class="auto-style3" src="Image/payment.png" /></p>
    <form id="form1" runat="server">
        <div class="auto-style1">

            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

            <asp:Label ID="Label1" runat="server" Text="WELCOME TO PAYMENT PAGE" Font-Bold="True"></asp:Label>
            <br />
            <br />
            <asp:Image ID="visa" runat="server" Height="40px" ImageUrl="~/Image/visa.png" Width="60px" />
            <asp:Image ID="maestro" runat="server" Height="40px" ImageUrl="~/Image/maestro.jpg" Width="60px" />
            <asp:Image ID="mastercard" runat="server" Height="40px" ImageUrl="~/Image/mastercard.png" Width="60px" />
            <asp:Image ID="discover" runat="server" Height="40px" ImageUrl="~/Image/discover.jpg" Width="60px" />
            <asp:Image ID="american" runat="server" Height="40px" ImageUrl="~/Image/american.png" Width="60px" />
            <br class="auto-style1" />
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:Label ID="Label3" runat="server" Text="Enter Your Card Number"></asp:Label>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:TextBox ID="cardNumber" runat="server" Width="300px" MaxLength="16" onKeyUp="On_KeyUp()" ></asp:TextBox>

            <br class="auto-style1" />
            <br class="auto-style1" />
&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Month"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Year"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label7" runat="server" Text="CVV"></asp:Label>

        </div>
        <p aria-atomic="True" class="auto-style1">
            <asp:DropDownList ID="monthList" runat="server" Height="17px" Width="80px" >
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
                <asp:ListItem>5</asp:ListItem>
                <asp:ListItem>6</asp:ListItem>
                <asp:ListItem>7</asp:ListItem>
                <asp:ListItem>8</asp:ListItem>
                <asp:ListItem>9</asp:ListItem>
                <asp:ListItem>10</asp:ListItem>
                <asp:ListItem>11</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
            </asp:DropDownList>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:DropDownList ID="yearList" runat="server" Height="17px" Width="80px">
                <asp:ListItem>2022</asp:ListItem>
                <asp:ListItem>2023</asp:ListItem>
                <asp:ListItem>2024</asp:ListItem>
                <asp:ListItem>2025</asp:ListItem>
                <asp:ListItem>2026</asp:ListItem>
                <asp:ListItem>2027</asp:ListItem>
                <asp:ListItem>2028</asp:ListItem>
                <asp:ListItem>2029</asp:ListItem>
                <asp:ListItem>2030</asp:ListItem>
                <asp:ListItem>2031</asp:ListItem>
                <asp:ListItem>2032</asp:ListItem>
                <asp:ListItem>2033</asp:ListItem>
            </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="cvvnumber" runat="server" Width="68px" ViewStateMode="Enabled" MaxLength="3"  TextMode="Password"></asp:TextBox>
        </p>
        <p aria-atomic="True" class="auto-style1">
            <asp:Label ID="Label4" runat="server" Text="Enter Your Card Name"></asp:Label>
            <br class="auto-style1" />
            <br class="auto-style1" />
            <asp:TextBox ID="cardOwner" runat="server" Width="300px" MaxLength="55" onKeyUp="On_KeyUp()" ></asp:TextBox>

        </p>
        <p aria-atomic="True" class="auto-style1">
            &nbsp;</p>
        <p class="auto-style2">
            &nbsp;&nbsp;
            <asp:Button ID="enter" runat="server" Text="Enter" Height="50px" Width="100px" OnClick="enter_Click1" Font-Bold="True" />
        &nbsp;
            <asp:Label ID="Label2" runat="server" Text="   "></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Height="35px" OnClick="Button1_Click" Text="Reset" Width="75px" Font-Bold="True" />
        </p>
        <p class="auto-style2">
            <asp:Label ID="Label8" runat="server" Text="  "></asp:Label>
        </p>
        <br />
        <asp:Label ID="theResult" runat="server" Text="  "></asp:Label>
    </form>
</body>
</html>
