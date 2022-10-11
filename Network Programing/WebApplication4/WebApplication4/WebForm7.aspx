<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm7.aspx.cs" Inherits="WebApplication4.WebForm7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            User:
            <asp:TextBox id="TextBox1" runat="server"></asp:TextBox>
            <br />
            Message:
            <asp:TextBox id="TextBox2" runat="server" Height="208" Width="804" TextMode="MultiLine"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submmit" OnClick="Unnamed1_Click"></asp:Button>
            <asp:Button ID="Button2" runat="server" Text="Clear" OnClick="Unnamed2_Click"></asp:Button>
            <br /><br />
            <asp:Label id="Label1" runat="server"></asp:Label>


        </div>
    </form>
</body>
</html>
