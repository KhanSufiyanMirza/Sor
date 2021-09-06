<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="system_on_rent.admin.adminlogin" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
  <head runat="server">
    <meta charset="UTF-8"/>
    <title>Admin Login</title>
    
    
    
    
        <link rel="stylesheet" href="logincss/style.css"/>

    
  </head>

  <body>

    
<form id="f1" runat="server" >
  <header>Login</header>
  <label>Username </label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="username must have ...!" ForeColor="Red" SetFocusOnError="true" ToolTip="username required" ></asp:RequiredFieldValidator>
    <br />
  <label>Password </label>
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" ></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="passsword required...!" ForeColor="Red" SetFocusOnError="true"></asp:RequiredFieldValidator>
   
    
   
    <br/>
  
<asp:Button ID="Button1" runat="server" Text="login" Width="159px" OnClick="Button1_Click" />
    <br/>
  <asp:Label ID="Label1" runat="server" Text="" style="text-align: left"></asp:Label><br />
</form>
      </body>
</html>