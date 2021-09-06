<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.Master" AutoEventWireup="true" CodeBehind="add_product.aspx.cs" Inherits="system_on_rent.admin.add_product" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table> 
        <tr>
            <td> product name</td>
            <td>
            <asp:TextBox ID="T1" runat="server"></asp:TextBox> </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="product name is required" ControlToValidate="T1" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                &nbsp;</td>
            </tr>
         <tr>
            <td> product description</td>
            <td>
            <asp:TextBox ID="T2" runat="server" TextMode="MultiLine"></asp:TextBox> </td>
            <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="product descriptio is required...!" ControlToValidate="T2" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                &nbsp;</td>
            </tr>
         <tr>
            <td class="auto-style1"> product price</td>
            <td class="auto-style1">
            <asp:TextBox ID="T3" runat="server" TextMode="Number"></asp:TextBox> </td>
            <td class="auto-style1"> <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="product price is required...!" ControlToValidate="T3" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                &nbsp;</td>
            </tr>
         <tr>
            <td> product qantity</td>
            <td>
            <asp:TextBox ID="T4" runat="server" TextMode="Number"></asp:TextBox> </td>
            <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="product quantity is required...!" ControlToValidate="T4" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                &nbsp;</td>
            </tr>
         <tr>
            <td> product image</td>
            <td>
                <asp:FileUpload ID="img1" runat="server" /></td>
          
            <td> <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="please select image...!" ControlToValidate="img1" ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
                &nbsp;</td>
          
            </tr>
         <tr>
            <td colspan="2" style="align-content:center">
                <asp:Button ID="Button2" runat="server" Text="upload" OnClick="Button2_Click" /></td>
            
            
            
            </tr>
    </table>
</asp:Content>
