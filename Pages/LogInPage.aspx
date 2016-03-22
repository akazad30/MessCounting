<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="LogInPage.aspx.cs" Inherits="Pages_LogInPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            text-align: center;
            color: #996633;
            background-color: #CC9900;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
            width: 113px;
            text-align: right;
        }
        .auto-style5 {
            width: 113px;
            text-align: right;
        }
        .auto-style6 {
            width: 113px;
            font-size: x-large;
            text-align: right;
        }
        .auto-style7 {
            height: 23px;
            width: 184px;
        }
        .auto-style8 {
            width: 184px;
        }
        .auto-style9 {
            height: 23px;
            width: 257px;
        }
        .auto-style10 {
            width: 257px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style1">
        <em>WelCome To LogINPage</em></p>
    <br />
    <table class="auto-style2">
        <tr>
            <td class="auto-style4">Name:</td>
            <td class="auto-style7">
                <asp:TextBox ID="TextBox1Name" runat="server" Height="24px" Width="184px"></asp:TextBox>
            </td>
            <td class="auto-style9">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1Name" ErrorMessage="Name is Required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">Password:</td>
            <td class="auto-style8">
                <asp:TextBox ID="TextBox2Pass" runat="server" Height="24px" Width="183px" TextMode="Password"></asp:TextBox>
            </td>
            <td class="auto-style10">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2Pass" ErrorMessage="Password is Required" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style10">
                <asp:Button ID="Button1" runat="server" Font-Size="X-Large" ForeColor="#990000" Height="33px" OnClick="Button1_Click" Text="Submit" Width="114px" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6">&nbsp;</td>
            <td class="auto-style8">&nbsp;</td>
            <td class="auto-style10">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

