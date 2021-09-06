<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="product_desc.aspx.cs" Inherits="system_on_rent.user.product_desc" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="d2" runat="server">
    
    <HeaderTemplate>
        </HeaderTemplate>
        <ItemTemplate>
            <div style="height: 300px; width: 600px; border-style: solid; border-width: 1px;">
                <div style="height: 300px; width: 200px; float: left; border-style: solid; border-width: 0px;">
                    <img src='../<%#Eval("product_images") %>' height="300" width="200" />
                </div>
                <div style="height: 300px; width: 395px; float: left; border-style: solid; border-width: 0px;">
                    <table>
                        <tr>
                            <td style="color:Black; font-weight:bold; font-size:12px">
                                item name
                            </td>
                            </tr>
                            <tr>
                            <td>
                                <%#Eval("product_name") %>
                            </td>
                        </tr>
                      
                        <tr>
                            <td style="color:Black; font-weight:bold; font-size:12px">
                                product desc
                            </td>
                            </tr>
                            <tr>
                            <td>
                                <%#Eval("product_desc") %>
                            </td>
                        </tr>
                        <tr>
                            <td style="color:Black; font-weight:bold; font-size:12px">
                                product price
                            </td>
                            </tr>
                            <tr>
                            <td>
                                <%#Eval("product_price") %>
                            </td>
                        </tr>
                        <tr>
                            <td style="color:Black; font-weight:bold; font-size:12px">
                                product qty
                            </td>
                            </tr>
                            <tr>
                            <td>
                                <%#Eval("product_qty") %>
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </ItemTemplate>
        <FooterTemplate>
        </FooterTemplate>
    </asp:Repeater>
    <br />
    <table>
        <tr>
            <td>
                <asp:Label ID="l2" runat="server" Text="enter quantity"></asp:Label>
            </td>
            <td>
                  <asp:TextBox ID="t1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="b1" runat="server" Text="add to cart" OnClick="b1_Click" />
            </td>
        </tr>
        <tr>
            <td colspan="3">
                 <asp:Label ID="l1" runat="server" forecolor="red" Text=""></asp:Label>
            </td>
        </tr>
    </table>
      
    
    
</asp:Content>
