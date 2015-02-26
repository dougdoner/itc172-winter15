<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <p>Enter your username</p>
            <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        </div>
        <div>
            <p>Enter your password</p>
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        <div>
            <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
        </div>
        <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="Register.aspx" CausesValidation="false">Register</asp:LinkButton>
    </div>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Username Required" ControlToValidate="txtUserName"></asp:RequiredFieldValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Password Required" ControlToValidate="txtPassword"></asp:RequiredFieldValidator>
    </form>
</body>
</html>
