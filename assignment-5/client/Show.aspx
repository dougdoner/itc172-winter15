<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Show.aspx.cs" Inherits="Show" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" type="text/css" href="style.css" />
    <title>Add show</title>
</head>
<body>
    <form id="form1" runat="server">
        <!-- addArtist section -->
        <div class="formSection">
            <div>
                <h2>Add Artist</h2>
                <div>
                    Artist name<asp:TextBox ID="txtArtistName" runat="server"></asp:TextBox>
                </div>
                <div>
                    Artist email<asp:TextBox ID="txtArtistEmail" runat="server"></asp:TextBox>
                </div>
                <div>
                    Artist Web page<asp:TextBox runat="server" ID="txtArtistWebPage"></asp:TextBox>
                </div>
                <asp:Button ID="btnAddArtist" OnClick="btnAddArtist_Click" Text="Add artist" runat="server" />
            </div>
        </div><!-- end addArtist section -->

        <!-- addShow section -->
        <div class="formSection">
            <div>
                <h2>Add Show</h2>
                <div>
                    Show name<asp:TextBox ID="txtShowName" runat="server"></asp:TextBox>
                </div>
                <div>
                    Show start time<asp:TextBox ID="txtShowStartTime" runat="server"></asp:TextBox>
                </div>
                <div>
                    Artist
                    <asp:DropDownList runat="server" ID="ArtistDropDownList">
                    </asp:DropDownList>
                </div>
                <div>
                    Show Date
                    <asp:Calendar ID="calendarShowDate" runat="server"></asp:Calendar>
                </div>
                <div>
                    Ticket info<asp:TextBox runat="server" ID="txtShowTicketInfo"></asp:TextBox>
                </div>
                <div>
                    Additional ticket info<asp:TextBox runat="server" ID="txtShowAdditionalInfo"></asp:TextBox>
                </div>
                <div>
                    Additional Start time<asp:TextBox runat="server" ID="txtShowAdditionalStartTime"></asp:TextBox>
                </div>
                <asp:Button ID="btnShowAdd" onclick="btnShowAdd_Click" Text="Add Show" runat="server" />
            </div>
        </div><!-- end addShow section -->

        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
