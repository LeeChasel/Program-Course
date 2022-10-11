<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:RadioButtonList id="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>
            <br /><br />
            Name
        <asp:TextBox id="TextBox1" runat="server"></asp:TextBox>
            <br /><br />
            Skills
            <br /><br />
            <asp:CheckBoxList runat="server" ID="CheckBoxList1">
                <asp:ListItem>Java</asp:ListItem>
                <asp:ListItem>C#</asp:ListItem>
                <asp:ListItem>C</asp:ListItem>
            </asp:CheckBoxList>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click"></asp:Button>
            <br /><br />
            <asp:Label runat="server" ID="Label1"></asp:Label>

        </div>
    </form>
</body>
</html>
