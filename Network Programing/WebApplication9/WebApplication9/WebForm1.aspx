<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication9.WebForm1" %>

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

            <asp:Button runat="server" Text="Search" OnClick="Button1_Click" ID="Button1"></asp:Button>

            <br />
            Name : <asp:Label runat="server" ID="Label1"></asp:Label>
            <br />
            Price : <asp:Label runat="server" ID="Label2"></asp:Label>

            
        </div>
    </form>
</body>


</html>
