<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="ShoopinWebSite.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="width: 900px; height: 147px; margin-left: 281px">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label1" runat="server" BackColor="#FFFFCC" BorderColor="#993366" Font-Bold="True" Font-Names="Myanmar Text" Font-Overline="False" Font-Size="X-Large" Font-Strikeout="False" ForeColor="#9999FF" Text="SHOPPING CART"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ImageButton ID="ImageButton1" runat="server" Height="40px" ImageUrl="~/images/home.png" OnClick="ImageButton1_Click" Width="40px" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label48" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="Medium" ForeColor="#0033CC" Text="    "></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Total Price:
            <asp:Label ID="Label47" runat="server" Font-Bold="True" Font-Size="Large" ForeColor="Red" Text="0 TL"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
        <asp:Panel ID="Panel3" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label7" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image2" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label9" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image3" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel5" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label11" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image4" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel6" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label13" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image5" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel7" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label15" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image6" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel8" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label17" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image7" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel9" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label19" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image8" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel10" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label21" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image9" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel11" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label23" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label24" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image10" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel12" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label25" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label26" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image11" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel13" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label27" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label28" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image12" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel14" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label29" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label30" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image13" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel15" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label31" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label32" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image14" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel16" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label33" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label34" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image15" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel17" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label35" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label36" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image16" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel18" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label37" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label38" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image17" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel19" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label39" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label40" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image18" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel20" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label41" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label42" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image19" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel21" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label43" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label44" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image20" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel22" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Ürün Adı:
            <asp:Label ID="Label45" runat="server" Text=" "></asp:Label>
            <br />
            Fiyat:
            <asp:Label ID="Label46" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Image ID="Image21" runat="server" Height="75px" Width="75px" />
            <br />
        </asp:Panel>
    </form>
</body>
</html>
