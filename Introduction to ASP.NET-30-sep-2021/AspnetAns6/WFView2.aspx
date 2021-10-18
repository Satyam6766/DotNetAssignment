<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WFView2.aspx.cs" Inherits="AspnetAns6.WFView2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
            <asp:TextBox ID="txtBox" runat="server"></asp:TextBox>
            <asp:Button ID="btnCount" runat="server" Text="Button" OnClick="btnCount_Click" />
        </div>
    </form>
</body>
</html>
