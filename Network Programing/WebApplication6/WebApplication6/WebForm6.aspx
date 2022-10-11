<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm6.aspx.cs" Inherits="WebApplication6.WebForm6" %>

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
            <br /><br />

            <asp:Button runat="server" Text="Save" ID="Button1" OnClick="Button1_Click"></asp:Button>
            <asp:Button runat="server" Text="Resume" ID="Button2" OnClick="Button2_Click"></asp:Button>
            <asp:Button runat="server" Text="Submit" ID="Button3" OnClick="Button3_Click"></asp:Button>
            <br /><br />
            <asp:Label runat="server" ID="Label1"></asp:Label>
        </div>
    </form>
</body>

</html>
