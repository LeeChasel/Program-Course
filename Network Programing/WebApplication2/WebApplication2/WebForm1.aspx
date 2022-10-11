<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

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
             + 
            <asp:TextBox id="TextBox2" runat="server"></asp:TextBox>
        <asp:Button runat="server" Text="=" OnClick="Button1_Click"></asp:Button>
            <asp:Label id="label1" runat="server"></asp:Label>
        </div>
    </form>
</body>

</html>
