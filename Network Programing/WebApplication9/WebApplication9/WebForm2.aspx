<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication9.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ID
        <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
        <br />
        Name
        <asp:TextBox runat="server" ID="TextBox2"></asp:TextBox>
        <br />
        Price
        <asp:TextBox runat="server" ID="TextBox3"></asp:TextBox>

            <asp:Button runat="server" Text="Button" ID="Button1" OnClick="Button1_Click"></asp:Button>

        </div>
    </form>
</body>
</html>
