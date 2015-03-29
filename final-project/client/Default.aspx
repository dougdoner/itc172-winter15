<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" type="text/css" href="Style.css" />
<title>Fan Login</title>
</head>
<body>
<form id="form1" runat="server">
<h1>Fan Login</h1>
<div>
<p>Username</p>
<asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
</div>
<div>
<p>Password</p>
<asp:TextBox ID="txtPassword1" runat="server" TextMode="Password"></asp:TextBox>
</div>
<asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
<div>
<asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
</div>
<div>
<asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="Register.aspx" CausesValidation="false">Register</asp:LinkButton>
</div>
</form>
</body>
</html>
