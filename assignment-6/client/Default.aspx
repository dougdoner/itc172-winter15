<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>The current time</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>The current time:</h1>
        <div>
            <asp:Image ID="Img1" runat="server" ImageUrl="~/awesome.png"/>
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Timer ID="Timer1" runat="server" Enabled="true" OnTick="Timer1_Tick" Interval="1000"></asp:Timer>
                    <asp:Label ID="lblDisplayTime" runat="server" Text=""></asp:Label>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
