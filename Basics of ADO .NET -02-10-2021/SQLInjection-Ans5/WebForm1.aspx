<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="SQLInjection_Ans5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>SQL INJECTION</h1>
            <p>
                In order to demonestration sql injection technique,
                here i have used Stored Procedure in the place of string query.
            </p>
            <p>
                How to avoid SQL Injection attacks using Stored Procedures?<br />


                Some database programmers believe that by using stored procedures, their code are safe from SQL injection Attacks.
              
              That is not true because, if dynamic query is used inside the stored procedures and the dynamic query is constructed by concatenating the parameters it is at high risk of attack.
              
              The easiest way to prevent SQL injection from happening, is to use parameters and sp_executesql to execute the dynamically generated statement.

            </p>
            <h2> Non-Parameterised SP user here is:</h2>
            <p>
                create Procedure GetAllEmployee
                <br />
                as begin  
                <br />
                Declare @Sqlcmd NVARCHAR(MAX);
                <br />
                SET @Sqlcmd=N'Select * from Employee';
                <br />
                Execute sp_executesql @Sqlcmd
                <br />
                end
                <br />
            </p>

            <asp:GridView ID="GridViewEmpList" runat="server"></asp:GridView>
        </div>
        <div>
            <h3>Parameterised SP</h3>
            <div>
                <p>
                    Create Procedure Usp_EmpAddress
                    <br />
                    (
                    <br />
                    @Addr Varchar(50),
@Mobile numeric(10),
@Id int 
                    <br />
                    ) 
                    <br />
                    AS 
                    <br />
                    Begin 
                    <br />

                    DECLARE @sqlcmd NVARCHAR(MAX);
                    <br />

                    DECLARE @params NVARCHAR(MAX);
                    <br />

                    SET @sqlcmd = N'update Employee set Addr=@Addr , Mobile=@Mobile where Id=@Id';
                    <br />

                    SET @params = N'@Addr NVARCHAR(50),@Mobile numeric(10),@Id int';
                    <br />

                    EXECUTE sp_executesql @sqlcmd, @params, @Addr,@Mobile,@Id;
                    <br />

                    End
                    <br />
                </p>
            </div>
        </div>
        <div>
            <h2>Select Emp to update details.</h2>
            <asp:DropDownList ID="ddlEmp" runat="server" DataSourceID="SqlDataSource1" DataTextField="EmpName" DataValueField="Id"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:myDBConnectionString %>" SelectCommand="SELECT [Id], [EmpName] FROM [Employee]"></asp:SqlDataSource>
            <br />
            
            <asp:Label ID="Label1" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress" ControlToValidate="txtAddress" runat="server" ErrorMessage="Address is required."></asp:RequiredFieldValidator>
            <br />
            <asp:Label ID="Label2" runat="server" Text="MobileNumber"></asp:Label>
            <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox>            
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtMobile" runat="server" ErrorMessage="Mobile number is required."></asp:RequiredFieldValidator>            
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtMobile" 
                ErrorMessage="Invalid Mobile Number" ValidationExpression="\+?[0-9]{10}"></asp:RegularExpressionValidator>


            
            <br />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            
        </div>
    </form>
</body>
</html>
