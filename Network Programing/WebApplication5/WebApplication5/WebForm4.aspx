<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication5.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButton ID="RadioButton1" runat="server" Text="Male" GroupName="gender"></asp:RadioButton>
            <asp:RadioButton ID="RadioButton2" runat="server" Text="Female" GroupName="gender"></asp:RadioButton>
            <br /><br />
            Name:<asp:TextBox id="TextBox1" runat="server"></asp:TextBox>
            <br /><br />
            Skills:<br />

        <asp:CheckBox runat="server" ID="CheckBox1" Text="Java"></asp:CheckBox><br />
        <asp:CheckBox runat="server" ID="CheckBox2" Text="C#"></asp:CheckBox><br />
        <asp:CheckBox runat="server" ID="CheckBox3" Text="C"></asp:CheckBox><br /><br />
            <asp:Button runat="server" ID="Button1" Text="Button" OnClick="Button1_Click"></asp:Button>
            <br /><br />
            <asp:Label id="Label1" runat="server"></asp:Label>





        </div>
    </form>
</body>

</html>
