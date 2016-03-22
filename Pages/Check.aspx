<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Check.aspx.cs" Inherits="Pages_Check" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    
<asp:PlaceHolder ID = "PlaceHolder2" runat="server" />
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <br />
    
<asp:PlaceHolder ID = "PlaceHolder1" runat="server" />
    <br />
    hi all<br />
    <br />
    <table>
        <tr>
            <td>&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
          <tr>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 26px" Text="Button" />
              </td>
        </tr>  
        <tr>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
</asp:Content>



