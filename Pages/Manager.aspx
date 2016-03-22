<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Manager.aspx.cs" Inherits="Pages_Manager" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            color: #999966;
            font-size: x-large;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            width: 188px;
        }
        .auto-style4 {
            width: 188px;
            font-size: x-large;
        }
        .auto-style5 {
            width: 186px;
        }
        .auto-style6 {
            width: 188px;
            height: 25px;
        }
        .auto-style7 {
            width: 186px;
            height: 25px;
        }
        .auto-style8 {
            height: 25px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p class="auto-style1">
        Welcome to Manager Page:</p>
    <table class="auto-style2">
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">ShowAll:</td>
            <td class="auto-style5">
                <asp:DropDownList ID="DropDownList1" runat="server" style="font-size: large; margin-left: 0px;" Font-Size="XX-Large" Height="74px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="138px">
                    <asp:ListItem>ShowAll</asp:ListItem>
                    <asp:ListItem>For Meal</asp:ListItem>
                    <asp:ListItem>For Bazar</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Font-Italic="False" ForeColor="Black" Height="69px" Text="SubmitShowAll" Width="195px" OnClick="Button1_Click" BorderColor="#CC6600" Font-Size="X-Large" />
            </td>
        </tr>
        <tr>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Individual:</td>
            <td class="auto-style5">
                <asp:Button ID="Button2" runat="server" Height="69px" Text="ShowIndividual" Font-Size="X-Large" OnClick="Button2_Click" Width="173px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style6"></td>
            <td class="auto-style7"></td>
            <td class="auto-style8"></td>
        </tr>
    </table>
</asp:Content>

