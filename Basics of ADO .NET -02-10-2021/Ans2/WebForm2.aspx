<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Ans2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
   
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:HyperLink ID="HyperLink1" runat="server" Text="WebForm1" NavigateUrl="~/WebForm1.aspx" >WebForm1</asp:HyperLink>

        <div>
            <h3>Employee record with Connectionless Architecture using Dataset and sql DataAdapter.</h3>
            <asp:GridView ID="GridViewEmployee" runat="server"></asp:GridView>
        </div>
        <div>
            <h3>Country record with Connectionless Architecture using Dataset and sql DataAdapter.</h3>
            <asp:GridView ID="GridViewCountry" runat="server"></asp:GridView>
        </div>
        <div>
            <h3>Course record with Connectionless Architecture using Dataset and sql DataAdapter.</h3>
            <asp:GridView ID="GridViewCourse" runat="server"></asp:GridView>
        </div>

    </form>
</body>
</html>
