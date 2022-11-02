<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication7.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
            <br />
            <%-- <asp:TextBox runat="server" ID="TextBox2"></asp:TextBox>--%>
            <asp:Button runat="server" Text="Button" ID="Button1" OnClick="Button1_Click"></asp:Button>

        </div>
    </form>
</body>

</html>
