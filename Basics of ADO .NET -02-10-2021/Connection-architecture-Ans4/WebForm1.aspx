<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Connection_architecture_Ans4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Connection Architecture</h1>
            <hr />
            <h3>Data Set:Disconnected Architecture</h3>
            <p>
                To achieve this you need to use DataAdapter which work as a mediator 
                between Database and DataSet.
            </p>
        </div>
        <asp:GridView ID="GridViewEmp" runat="server">
        </asp:GridView>
        <hr />
        <h3>DataReader:Connection Oriented Architecture</h3>
        <p>
            It is a connected architecture, which means when you require  data from the database you need to
            connect with database and fetch the data from there. You can use if you need updated data from
            the database in a faster manner. DataReader is Read/Forward only that means we can only get the 
            data using this but we cannot update or insert the data into the database. 
            It fetches the record one by one.
        </p>

    </form>
</body>
</html>
