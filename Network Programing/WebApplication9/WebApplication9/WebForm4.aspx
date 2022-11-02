<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication9.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox runat="server" ID="ListBox1" DataTextField="Cname" DataValueField="Cname" DataSourceID="SqlDataSource1"></asp:ListBox>
            <asp:SqlDataSource runat="server" ID="SqlDataSource1" ConnectionString="<%$ ConnectionStrings:productConnectionString %>" SelectCommand="SELECT * FROM [customer]"></asp:SqlDataSource>
        </div>
    </form>
</body>

</html>
