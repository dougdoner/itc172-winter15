<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Shows.aspx.cs" Inherits="Shows" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="Style.css" />
    <title>Search Shows</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Search for shows</h1>
        <div>
            <h2>Search by artist</h2>
            <asp:DropDownList ID="ArtistDropDownList" runat="server" OnSelectedIndexChanged="ArtistDropDownList_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
        </div>
        
        <div>
            <h2>Search by genre</h2>
            <asp:DropDownList ID="GenresDropDownList" runat="server" OnSelectedIndexChanged="GenresDropDownList_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
        </div>
        
        <div>
            <h2>Search by venue</h2>
            <asp:DropDownList ID="VenuesDropDownList" runat="server" OnSelectedIndexChanged="VenuesDropDownList_SelectedIndexChanged" AutoPostBack="True"></asp:DropDownList>
        </div>
        <asp:GridView ID="ShowGridView" runat="server"></asp:GridView>
    </div>
    </form>
</body>
</html>
