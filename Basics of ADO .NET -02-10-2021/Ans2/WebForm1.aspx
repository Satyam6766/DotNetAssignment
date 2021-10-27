<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ans2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Connection Pooling attributes used in defining connection string web.config file </h1>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" Text="WebForm2" NavigateUrl="~/WebForm2.aspx" >WebForm2</asp:HyperLink>

        <div>
            <h3>Employee record with Connection Oriented Architecture using Execute reader.</h3>
            <asp:GridView ID="GridViewEmployee" runat="server"></asp:GridView>
        </div>
        <div>
            <h3>Country record with Connected Architecture using Execute reader.</h3>
            <asp:GridView ID="GridViewCountry" runat="server"></asp:GridView>
        </div>
        <div>
            <h3>Course record with Connected Architecture using Execute reader.</h3>
            <asp:GridView ID="GridViewCourse" runat="server"></asp:GridView>
        </div>

    </form>
</body>
</html>
