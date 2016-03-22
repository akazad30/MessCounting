<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="RegistrationPage.aspx.cs" Inherits="Pages_RegistrationPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        font-size: x-large;
        color: #990000;
        text-align: center;
    }
    .auto-style2 {
        width: 76%;
        height: 217px;
    }
    .auto-style3 {
        width: 190px;
        text-align: right;
    }
    .auto-style4 {
        width: 201px;
        text-align: left;
    }
    .auto-style5 {
        width: 793px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style1">
    <em>WelCome to Registration Page</em></p>
<table class="auto-style2">
    <tr>
        <td class="auto-style3">Stu_ID:</td>
        <td class="auto-style4">
            <asp:TextBox ID="txtID" runat="server" Height="26px" Width="170px"></asp:TextBox>
        </td>
        <td class="auto-style5">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtID" ErrorMessage="Student ID is required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Name:</td>
        <td class="auto-style4">
            <asp:TextBox ID="txtName" runat="server" Height="23px" Width="164px"></asp:TextBox>
        </td>
        <td class="auto-style5">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtName" ErrorMessage="Name Is  Required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Dept:</td>
        <td class="auto-style4">
            <asp:TextBox ID="txtDept" runat="server" Height="24px" Width="167px"></asp:TextBox>
        </td>
        <td class="auto-style5">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDept" ErrorMessage="Dept is Required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Contact_No:</td>
        <td class="auto-style4">
            <asp:TextBox ID="txtContactNo" runat="server" Height="23px" Width="159px"></asp:TextBox>
        </td>
        <td class="auto-style5">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtContactNo" ErrorMessage="Contact No is Required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Password:</td>
        <td class="auto-style4">
            <asp:TextBox ID="txtPassword" runat="server" Height="19px" Width="161px" TextMode="Password"></asp:TextBox>
        </td>
        <td class="auto-style5">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is Required" ForeColor="Red"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Confirm Password:</td>
        <td class="auto-style4">
            <asp:TextBox ID="txtConfirmPass" runat="server" Height="24px" Width="161px" TextMode="Password"></asp:TextBox>
        </td>
        <td class="auto-style5">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtConfirmPass" ErrorMessage="Confirm Password is Required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPass" ErrorMessage="Both Password Must Be Same" ForeColor="Red"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">&nbsp;</td>
        <td class="auto-style4">&nbsp;</td>
        <td class="auto-style5">
            <asp:Button ID="Button1" runat="server" Font-Size="Large" ForeColor="#999966" Text="Submit" OnClick="Button1_Click" />
        </td>
    </tr>
</table>
<br />
<br />
</asp:Content>

