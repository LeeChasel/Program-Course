<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication6.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ListBox runat="server" ID="ListBox1" SelectionMode="Multiple">
                <asp:ListItem Value="10">Apple</asp:ListItem>
                <asp:ListItem Value="20">Banana</asp:ListItem>
                <asp:ListItem Value="30">Potato</asp:ListItem>
            </asp:ListBox>
         
            <asp:ListBox runat="server" ID="ListBox2" SelectionMode="Multiple"></asp:ListBox>
            <asp:Label runat="server" ID="Label1"></asp:Label>

            <br /><br />
            <asp:Button runat="server" Text="Add" ID="Button1" OnClick="Button1_Click"></asp:Button>
            <asp:Button runat="server" Text="Remove" ID="Button2" OnClick="Button2_Click"></asp:Button>
            

        </div>
    </form>
</body>


</html>
