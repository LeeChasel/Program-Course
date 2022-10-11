<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm3.aspx.cs" Inherits="WebApplication2.WebForm3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
            Base: <asp:TextBox id="TextBox1" runat="server"></asp:TextBox><br/><br/>
            Power: <asp:TextBox id="TextBox2" runat="server"></asp:TextBox>
        </div>
            <asp:Button id="Button1" runat="server" Text="Cal" OnClick="Button1_Click"></asp:Button><br/>
<asp:Label id="Label1" runat="server" Text="Ans"></asp:Label>
    </form>

</body>


</html>
