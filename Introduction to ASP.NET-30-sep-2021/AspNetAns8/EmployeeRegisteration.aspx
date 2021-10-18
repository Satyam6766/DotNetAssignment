<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EmployeeRegisteration.aspx.cs" Inherits="AspNetAns8.EmployeeRegisteration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
  
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
         <h2>Employee Registeration</h2>
            <div>
            <p>Name:</p>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName" ErrorMessage="Name is required"></asp:RequiredFieldValidator>
            <p>Mobile:</p>
            <asp:TextBox ID="txtMobile" runat="server"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorMobile" runat="server" ControlToValidate="txtMobile" ErrorMessage="Mobile number required"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="revMobile" runat="server" ControlToValidate="txtMobile" ValidationExpression="[0-9]{10}" ErrorMessage="Invalid mobile number"></asp:RegularExpressionValidator>
            <p>DOB:</p>
            <asp:TextBox ID="txtDOB" runat="server" placeholder="yyyy-mm-dd"></asp:TextBox>            
            <br />
            <p>Address:</p>
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox><br />
            <asp:RequiredFieldValidator ID="rfvAddress" runat="server" ControlToValidate="txtAddress" ErrorMessage="Address is required"></asp:RequiredFieldValidator>
            <p>Salary:</p>
            <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox><br /><span>*Insert salary in 5 digits.</span>
            <p>ZipCode</p>
            <asp:TextBox ID="txtZipCode" runat="server"></asp:TextBox><br />
            <asp:RegularExpressionValidator ID="revZipCode" runat="server" ControlToValidate="txtZipCode" ValidationExpression="^[1-9]{1}[0-9]{2}\s{0,1}[0-9]{3}$" ErrorMessage="Invalid zip code"></asp:RegularExpressionValidator>
            <p>Is Active</p>
            <asp:RadioButtonList ID="rblIsActive" runat="server">
                <asp:ListItem Value="1">Active</asp:ListItem>
                <asp:ListItem Value="0">DeActive</asp:ListItem>
            </asp:RadioButtonList>
            <p>Country</p>
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="Id"></asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:myDBConnectionString2 %>" SelectCommand="SELECT [Id], [name] FROM [Country]"></asp:SqlDataSource>
            <p>Gender</p>
            <asp:RadioButtonList ID="rblGender" runat="server">
                <asp:ListItem Value="m">male</asp:ListItem>
                <asp:ListItem Value="f">female</asp:ListItem>
            </asp:RadioButtonList>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" /><br />
            <asp:Label ID="lblStatus" runat="server" Text="Label" Visible="false" Font-Bold ForeColor="Red"></asp:Label>
        </div>
        <div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
        </div>
        <hr />
        <asp:GridView ID="GridViewEmployee" runat="server"></asp:GridView>
     </form>
</asp:Content>
