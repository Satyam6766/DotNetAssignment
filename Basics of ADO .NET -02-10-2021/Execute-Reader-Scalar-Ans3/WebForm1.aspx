<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Execute_Reader_Scalar_Ans3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Demonsetration of Execute reader,Execute nonquery and Execute scalar commands of SQLCommand</h2>
            <h3>Execute reader</h3>
            <asp:GridView ID="GridViewEmp" runat="server" OnSelectedIndexChanged="GridViewEmp_SelectedIndexChanged">
            </asp:GridView>
            <hr />
            <h3>Execute non query</h3>
            <asp:DropDownList ID="lblEmpId" runat="server" DataSourceID="SqlDataSource1" DataTextField="EmpName" DataValueField="Id"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:myDBConnectionString %>" SelectCommand="SELECT [Id], [EmpName] FROM [Employee]"></asp:SqlDataSource>
            <asp:TextBox ID="TxtAddress" runat="server"></asp:TextBox>
            <asp:Button ID="btnUpdateAddress" runat="server" Text="Update" OnClick="btnUpdateAddress_Click" />
            <p>Select Employee who's address is to be updated.</p>
            <hr />
            <h3>Execute Scalar</h3>
            <asp:TextBox ID="TxtCount" runat="server"></asp:TextBox>
            <p>
                Executes the query, and returns the first column of the first row in the result set returned by the query. 
                Additional columns or rows are ignored.
            </p>
        </div>
    </form>
</body>
</html>
