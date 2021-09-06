<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="contact.aspx.cs" Inherits="system_on_rent.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <!-- /header -->

   

    <section id="contact-page" class="container">
        <div class="row-fluid">
            <div class="span8">
                <h4>Contact Form</h4>
                <div class="status alert alert-success" style="display: none"></div>
                    <div class="row-fluid">
                        <div class="span5">
                            <label>Full Name</label>
                            <asp:TextBox ID="TextBox1" runat="server"  required="required" placeholder="Your Full Name"></asp:TextBox>
                            
                            <label>Email Address</label>
                               <asp:TextBox ID="TextBox2" runat="server"  required="required" placeholder="Your Email Address" class="input-block-level" TextMode="Email"></asp:TextBox>
                          
                            <label>Telephone</label>
                            <asp:TextBox ID="TextBox3" runat="server"  required="required" placeholder="Your telephone number" class="input-block-level" TextMode="Number" ToolTip="your telephone number"></asp:TextBox>
                        </div>
                        <div class="span7">
                            <label>Message</label>
                           <asp:TextBox ID="TextBox4" runat="server"  required="required" placeholder="Your Email Address" class="input-block-level" Rows="8" Height="85px" TextMode="MultiLine" ToolTip="give your suggestion" Width="352px"></asp:TextBox>
                    </div>
                    <asp:Button ID="Button1" runat="server" Text="Send Message" class="btn btn-primary btn-large pull-right"/>
          </div>
            </div>
            </section>
</asp:Content>
