<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeRegister.aspx.cs" Inherits="AspNetAns9.EmployeeRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h3>Employee Register Form</h3>
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

</body>
</html>


<%--<script type="text/javascript">
    function ValidateDOB(sender, args) {
        //Get the date from the TextBox.
        var dateString = document.getElementById(sender.controltovalidate).value;
        var regex = /(((0|1)[0-9]|2[0-9]|3[0-1])\/(0[1-9]|1[0-2])\/((19|20)\d\d))$/;

        //Check whether valid dd/MM/yyyy Date Format.
        if (regex.test(dateString)) {
            var parts = dateString.split("/");
            var dtDOB = new Date(parts[1] + "/" + parts[0] + "/" + parts[2]);
            var dtCurrent = new Date();
            sender.innerHTML = "Eligibility 18 years ONLY."
            if (dtCurrent.getFullYear() - dtDOB.getFullYear() < 18) {
                args.IsValid = false;
                return;
            }

            if (dtCurrent.getFullYear() - dtDOB.getFullYear() == 18) {

                //CD: 11/06/2018 and DB: 15/07/2000. Will turned 18 on 15/07/2018.
                if (dtCurrent.getMonth() < dtDOB.getMonth()) {
                    args.IsValid = false;
                    return;
                }
                if (dtCurrent.getMonth() == dtDOB.getMonth()) {
                    //CD: 11/06/2018 and DB: 15/06/2000. Will turned 18 on 15/06/2018.
                    if (dtCurrent.getDate() < dtDOB.getDate()) {
                        args.IsValid = false;
                        return;
                    }
                }
            }
            args.IsValid = true;
        } else {
            sender.innerHTML = "Enter date in dd/MM/yyyy format ONLY."
            args.IsValid = false;
        }
    }
</script>--%>
