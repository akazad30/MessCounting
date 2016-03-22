<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShowAll.aspx.cs" Inherits="Pages_ShowAll" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
            color: #82A7E3;
        }
        .auto-style2 {
            width: 100%;
            border-style: solid;
            border-width: 1px;
        }
        .auto-style3 {
            width: 405px;
            text-align: left;
        }
        .auto-style4 {
            width: 290px;
            text-align: right;
        }
        .auto-style6 {
            width: 265px;
        }
        .auto-style7 {
            width: 351px;
        }
        .auto-style8 {
            font-size: x-large;
            color: #999966;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    Student_id:<asp:TextBox ID="TextBox1StudentID" runat="server" OnTextChanged="TextBox1StudentID_TextChanged"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <br />
    Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
    <br />
    Meal:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxMeal" runat="server"></asp:TextBox>
    <br />
    Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBoxDate" runat="server"></asp:TextBox>
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style1">Showing Individual Result:<br />
    </span>
    <table class="auto-style2">
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4"><span class="auto-style8">Student_ID</span>:<asp:TextBox ID="TextBox1stID" runat="server" Font-Size="Large" Height="27px" Width="213px"></asp:TextBox>
            </td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Student_ID:<asp:TextBox ID="txtStudentID" runat="server" Height="28px" Width="273px"></asp:TextBox>
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtStudentName" runat="server" Height="19px" style="text-align: left" Width="267px"></asp:TextBox>
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Total_Meal:<asp:TextBox ID="txtStudentMeal" runat="server" Height="16px" Width="261px"></asp:TextBox>
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style3">Total_Bazar:<asp:TextBox ID="txtStudentBazar" runat="server" Height="25px" Width="255px"></asp:TextBox>
            </td>
            <td class="auto-style4">
                <asp:Button ID="Button2ShowResult" runat="server" Font-Size="Large" ForeColor="#999966" Height="63px" OnClick="Button2ShowResult_Click" Text="ShowResult" Width="104px" />
            </td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style6">&nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
</asp:Content>

