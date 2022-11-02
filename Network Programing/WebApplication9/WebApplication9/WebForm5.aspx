<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm5.aspx.cs" Inherits="WebApplication9.WebForm5" %>

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
            <br />
            
            <asp:FormView runat="server" ID="FormView1" DataSourceID="DataSource1" DataKeyNames="Cid"></asp:FormView>


            <br />
            <asp:SqlDataSource runat="server" ID="DataSource1" ConnectionString="<%$ ConnectionStrings:productConnectionString %>" SelectCommand="SELECT [Cname], [Cid] FROM [customer] WHERE ([Cid] = @Cid)"></asp:SqlDataSource>
            
            
        </div>
    </form>
</body>


</html>
