<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="system_on_rent.user.registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table>
        <tr>
            <td>firstname</td>
            
            <td><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>lastname</td>
            
            <td><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>email</td>
            
            <td><asp:TextBox ID="TextBox3" runat="server" TextMode="Email"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>password</td>
            
            <td><asp:TextBox ID="TextBox4" runat="server" TextMode="Password"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>address</td>
            
            <td><asp:TextBox ID="TextBox5" runat="server" Height="63px" TextMode="MultiLine" Width="194px"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>city</td>
            
            <td><asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>state</td>
            
            <td><asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>pincode</td>
            
            <td><asp:TextBox ID="TextBox8" runat="server" TextMode="Number"></asp:TextBox></td>
            
        </tr>
        <tr>
            <td>mobile</td>
            
            <td><asp:TextBox ID="TextBox9" runat="server" TextMode="Phone"></asp:TextBox></td>
            
        </tr>
        <tr>
            
            
            <td colspan="2" style="text-align:center"><asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" /></td>
            
        </tr>
        <tr>
            <td colspan="2" style="text-align:center">
                <asp:Label ID="Label1" runat="server" Text=""></asp:Label>

            </td>
            
           
            
        </tr>
    </table>
</asp:Content>
