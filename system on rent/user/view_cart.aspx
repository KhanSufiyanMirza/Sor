<%@ Page Title="" Language="C#" MasterPageFile="~/user/user.Master" AutoEventWireup="true" CodeBehind="view_cart.aspx.cs" Inherits="system_on_rent.user.view_cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>

            <asp:GridView ID="dlgridview" runat="server" AutoGenerateColumns="False" Height="122px" CellPadding="4" ForeColor="#333333" GridLines="None" Width="490px">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="Images">
                        <ItemTemplate>
                            <img src='../<%#Eval("product_images") %>' height="100" width="100" alt="" />
                           <%-- <asp:Image ID="Image1" runat="server" ImageUrl='../<%# Eval("product_images") %>' />--%>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="product name">
                        <ItemTemplate>
                        <%#Eval("product_name") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                      <asp:TemplateField HeaderText="product desc">
                        <ItemTemplate>
                       <%#Eval("product_desc") %>
                        </ItemTemplate>
                    </asp:TemplateField><asp:TemplateField HeaderText="quantity">
                        <ItemTemplate>
                       <%#Eval("product_qty") %>
                        </ItemTemplate>
                    </asp:TemplateField>
                  
                    <asp:TemplateField HeaderText="Delete">
                        <ItemTemplate>
                        <a href="delete_cart.aspx?id=<%#Eval("id") %>">delete</a>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

                <EditRowStyle BackColor="#7C6F57" />
                <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#E3EAEB" />
                <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F8FAFA" />
                <SortedAscendingHeaderStyle BackColor="#246B61" />
                <SortedDescendingCellStyle BackColor="#D4DFE1" />
                <SortedDescendingHeaderStyle BackColor="#15524A" />

            </asp:GridView>
           
  <%--  <asp:DataList ID="dl" runat="server" >
        <HeaderTemplate>
               <table border="1">   
                    <tr style="background-color:cadetblue;color:white;font-weight:bold">
                         <td>product image</td>
                         <td>product name</td>
                         <td>product desc</td>
                         <td>product price</td>
                    <td>  product quantity</td>
                    <td>delete</td>
                         
                    </tr>
        </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                       <td><img src='../<%#Eval("product_images") %>' height="100" width="100" alt="" /></td>
                         <td><%#Eval("product_name") %></td>
                         <td><%#Eval("product_desc") %></td>
                         <td><%#Eval("product_price") %></td>
                         <td><%#Eval("product_qty") %></td>
                         
                      
                     
                       <td><a href="delete_cart.aspx?id=<%#Eval("id") %>">delete</a> </td>
                        </tr>
                </ItemTemplate>
       <FooterTemplate>
                 </table>
                 </FooterTemplate>
            
         </asp:DataList>--%>
            <br/>
            <table>
                <tr>
                    <td>
                        enter starting date 
                    </td>
                    <td>
                       
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="DateTime" ValidationGroup="vc"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Required" ControlToValidate="TextBox1" SetFocusOnError="True" ValidationGroup="vc"></asp:RequiredFieldValidator>

                    </td>
                   
                </tr>
                <tr>
                    <td>
                       Number of months:
                    </td>
                     <td>
                         <asp:TextBox ID="TextBox2" runat="server"  ValidationGroup="vc" TextMode="Number"></asp:TextBox>
                         <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Required" ControlToValidate="TextBox2" SetFocusOnError="True" ValidationGroup="vc"></asp:RequiredFieldValidator>
                         <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="please enter between 1 to 12 " ControlToValidate="TextBox2" MaximumValue="12" MinimumValue="1" ValidationGroup="vc"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center">

                     <b>    <asp:Label ID="Label2" runat="server"></asp:Label></b>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" style="text-align:center">
                         <asp:Button ID="b1" runat="server" Text="checkout" OnClick="b1_Click" ValidationGroup="vc" />

                    </td>
                </tr>
            </table>
                
                
                 
        
               
                <br/>
               
                <p>
    </div>
</asp:Content>
