<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>
<!DOCTYPE html>
<html>
        <head runat="server">
        <title>Register a fan</title>
        <link rel="stylesheet" type="text/css" href="Style.css" />
    </head>
    <body>
        <form id="form1" runat="server">
            <h1>Register</h1>
            <div>
                <div>
                    <p>Fan name</p>
                    <asp:TextBox ID="txtFanName" runat="server"></asp:TextBox>
                </div>
            <div>
                <p>Email</p>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>
            <div>
                <p>Username</p>
                <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
            </div>
            <div>
                <p>Password</p>
                <asp:TextBox ID="txtPassword1" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div>
                <p>Confirm Password</p>
                <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password"></asp:TextBox>
            </div>
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            <div>
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            </div>
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="Default.aspx" CausesValidation="false">Login</asp:LinkButton>
            </div>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Passwords must match" ControlToValidate="txtPassword1" ControlToCompare="txtPassword2" Operator="Equal"></asp:CompareValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Must enter valid email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ControlToValidate="txtEmail"></asp:RegularExpressionValidator>
        </form>
    </body>
</html>
