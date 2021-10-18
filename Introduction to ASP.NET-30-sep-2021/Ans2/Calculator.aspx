<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="Ans2.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        table {
            margin: auto;
            background-color: #9dd2ea;
            width: 295px;
            height: 325px;
            text-align: center;
            border-radius: 4px;
        }
    </style>

</head>

<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr style="border-color: aquamarine;">
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Btn1" runat="server" Text="1" OnClick="Btn1_Click" />

                    </td>
                    <td>
                        <asp:Button ID="Btn2" runat="server" Text="2" OnClick="Btn2_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Btn3" runat="server" Text="3" OnClick="Btn3_Click" />
                    </td>
                    <td>
                        <asp:Button ID="BtnAdd" runat="server" Text="ADD" OnClick="BtnAdd_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Btn4" runat="server" Text="4" OnClick="Btn4_Click" />

                    </td>
                    <td>
                        <asp:Button ID="Btn5" runat="server" Text="5" OnClick="Btn5_Click" />
                    </td>
                    <td>
                        <asp:Button ID="Btn6" runat="server" Text="6" OnClick="Btn6_Click" />
                    </td>
                    <td>
                        <asp:Button ID="BtnSub" runat="server" Text="SUB" OnClick="BtnSub_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Btn7" runat="server" Text="7" OnClick="Btn7_Click" />

                    </td>
                    <td>
                        <asp:Button ID="Btn8" runat="server" Text="8" OnClick="Btn8_Click" />

                    </td>
                    <td>
                        <asp:Button ID="Btn9" runat="server" Text="9" OnClick="Btn9_Click" />

                    </td>
                    <td>
                        <asp:Button ID="BtnMul" runat="server" Text="MUL" OnClick="BtnMul_Click" />

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="BtnClear" runat="server" Text="CLEAR" OnClick="BtnClear_Click" />

                    </td>
                    <td>
                        <asp:Button ID="BtnZero" runat="server" Text="0" OnClick="BtnZero_Click" />

                    </td>
                    <td>
                        <asp:Button ID="BtnEqual" runat="server" Text="=" OnClick="BtnEqual_Click" />

                    </td>
                    <td>
                        <asp:Button ID="BtnDiv" runat="server" Text="DIV" OnClick="BtnDiv_Click" />

                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
