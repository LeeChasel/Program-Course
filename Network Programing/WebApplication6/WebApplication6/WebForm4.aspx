<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication6.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" ID="Label1"></asp:Label>
            <asp:Button runat="server" Text="Button" ID="Button1" OnClick="Button1_Click"></asp:Button>
            <br />
            <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
            <br/><br />
            <asp:Button runat="server" Text="WebForm6" ID="Button2" OnClick="Button2_Click"></asp:Button>
        </div>
    </form>
</body>
</html>