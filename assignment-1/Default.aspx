<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>ITC 172 | Age Calculator</title>
    <link href="StyleSheet.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>Enter your birthdate: <asp:TextBox ID="txtAgeInput" runat="server"></asp:TextBox></p>
    </div>
    <div>
        <asp:Button ID="btnSubmit" runat="server" Text="Get your age" OnClick="btnSubmit_Click" />
        <asp:Label ID="lblOutput" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
