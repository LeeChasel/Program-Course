<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication7.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label runat="server" Text="Label1" ID="Label1"></asp:Label>
            <br />
            <asp:Label runat="server" Text="Label2" ID="Label2"></asp:Label>
            <br />
            <asp:Button runat="server" Text="Button" ID="Button1" OnClick="Button1_Click"></asp:Button>
        </div>
    </form>
</body>

</html>
