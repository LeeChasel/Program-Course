<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="HW1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:RadioButtonList runat="server" ID="RadioButtonList1" RepeatDirection="Horizontal">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <br/>
            <asp:DropDownList runat="server" ID="DropDownList1">
                <asp:ListItem>Centimeter</asp:ListItem>
                <asp:ListItem>Inch</asp:ListItem>
                </asp:DropDownList>
            <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
            <br />
            <br />
            <asp:DropDownList runat="server" ID="DropDownList2">
                <asp:ListItem>Kilogram</asp:ListItem>
                <asp:ListItem>Pound</asp:ListItem>
                </asp:DropDownList>
            <asp:TextBox runat="server" ID="TextBox2"></asp:TextBox>
            <br />
            <br />
            <asp:Button runat="server" Text="Calculate" ID="Button1" OnClick="Button1_Click"></asp:Button>
            <p />
            <asp:Label runat="server" ID="Label1"></asp:Label>
        </div>
    </form>
</body>

</html>
