<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication8.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox runat="server" ID="ListBox1" DataTextField="UID" DataValueField="UPASS" DataSourceID="SqlDataSource1"></asp:ListBox>
            <br />
            <asp:SqlDataSource runat="server" ConnectionString="<%$ ConnectionStrings:imConnectionString %>" SelectCommand="SELECT * FROM [Uaccount]" ID="SqlDataSource1"></asp:SqlDataSource>
        </div>
    </form>
</body>

</html>
