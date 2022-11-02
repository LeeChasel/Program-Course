<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm4.aspx.cs" Inherits="WebApplication7.WebForm4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="Scripts/jquery-1.4.4.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="TextBox1"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ErrorMessage="Input Data" ControlToValidate="TextBox1" ID="RequiredFieldValidator1" EnableClientScript="False" ForeColor="#FF3300"></asp:RequiredFieldValidator>
<br />
                        <asp:TextBox runat="server" ID="TextBox2"></asp:TextBox>
            <asp:RangeValidator runat="server" ErrorMessage="18 ~ 100" ID="RangeValidator1" ForeColor="#FF3300" ControlToValidate="TextBox2" EnableClientScript="False" Type="Integer" MaximumValue="100" MinimumValue="18"></asp:RangeValidator>
            <br />
            
            <asp:TextBox runat="server" ID="TextBox3"></asp:TextBox><asp:RegularExpressionValidator runat="server" ErrorMessage="Wrong email format" ForeColor="#FF3300" EnableClientScript="False" ControlToValidate="TextBox3" ValidationExpression="[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@"></asp:RegularExpressionValidator>
<br /><br />
            <asp:Button runat="server" Text="Button" ID="Button1" OnClick="Button1_Click"></asp:Button><asp:CompareValidator runat="server" ErrorMessage="Retype password" ControlToCompare="TextBox1" ControlToValidate="TextBox2" EnableClientScript="False"></asp:CompareValidator>
            <br />
        </div>
    </form>
</body>


</html>
