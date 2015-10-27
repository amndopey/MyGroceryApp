<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Logon_Page.aspx.cs" Inherits="GroceryApp.Logon_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Logon</title>
    <link href="CSS/Logon_Page.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div id="Login_Div">
            <asp:Login ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" DisplayRememberMe="False" Font-Names="Verdana" Font-Size="10pt" OnAuthenticate="Login1_Authenticate">
            <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
        </asp:Login>
    </div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    </form>
</body>
</html>
