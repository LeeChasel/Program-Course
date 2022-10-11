<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication4.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox id="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox id="TextBox2" runat="server"></asp:TextBox>
            <asp:TextBox id="TextBox3" runat="server"></asp:TextBox>
            <asp:TextBox id="TextBox4" runat="server"></asp:TextBox>
            <asp:TextBox id="TextBox5" runat="server"></asp:TextBox>

            <asp:Button id="Button1" runat="server" Text="Click me" OnClick="Button1_Click"></asp:Button>

            <br />
            <asp:Label id="Label1" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>


</html>
