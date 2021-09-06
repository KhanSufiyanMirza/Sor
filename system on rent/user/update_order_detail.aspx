<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="update_order_detail.aspx.cs" Inherits="system_on_rent.user.update_order_detail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>
                FirstName
            </td>
            <td>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            </td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required" ControlToValidate="TextBox1" SetFocusOnError="True" ValidationGroup="up">*</asp:RequiredFieldValidator>
            
        </tr>
        <tr>
            <td>
                LastName
            </td>
            <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

            </td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required" ControlToValidate="TextBox2" SetFocusOnError="True" ValidationGroup="up"></asp:RequiredFieldValidator>

        </tr>
        <tr>
            <td>
                Address
            </td>
            <td>
            <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine" Height="114px" Width="196px"></asp:TextBox>

            </td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Required" ControlToValidate="TextBox3" SetFocusOnError="True" ValidationGroup="up"></asp:RequiredFieldValidator>

        </tr>
        <tr>
            <td>
                City
            </td>
            <td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

            </td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Required" ControlToValidate="TextBox4" SetFocusOnError="True" ValidationGroup="up"></asp:RequiredFieldValidator>

        </tr>
        <tr>
            <td>
                State
            </td>
            <td>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>

            </td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Required" ControlToValidate="TextBox5" SetFocusOnError="True" ValidationGroup="up"></asp:RequiredFieldValidator>

        </tr>
        <tr>
            <td>
              Mobile
            </td>
            <td>
            <asp:TextBox ID="TextBox6" runat="server" TextMode="Phone"></asp:TextBox>

            </td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Required" ControlToValidate="TextBox6" SetFocusOnError="True" ValidationGroup="up"></asp:RequiredFieldValidator>

        </tr>
        <tr>
            <td colspan="2" style="text-align:center">
                <asp:Button ID="Button1" runat="server" Text="update and continue->" OnClick="Button1_Click" ValidationGroup="up" />

            </td>
        </tr>
    </table> 
</asp:Content>
