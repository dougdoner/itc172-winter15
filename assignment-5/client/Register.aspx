<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Register.aspx.cs" Inherits="Register" %>
<!DOCTYPE html>
<html>
        <head runat="server">
        <title>Register a venue</title>
        <link rel="stylesheet" type="text/css" href="style.css" />
    </head>
    <body>
        <form id="form1" runat="server">
            <h1>Register</h1>
            <div>
                <div>
                    <p>Venue name</p>
                    <asp:TextBox ID="txtVenueName" runat="server"></asp:TextBox>
                </div>
            <div>
                <p>Venue Address</p>
                <asp:TextBox ID="txtVenueAddress" runat="server"></asp:TextBox>
            </div>
            <div>
                <p>City</p>
                <asp:TextBox ID="txtVenueCity" runat="server"></asp:TextBox>
            </div>
            <div>
                <p>State</p>
                <asp:TextBox ID="txtVenueState" runat="server"></asp:TextBox>
            </div>
            <div>
                <p>Zip code</p>
                <asp:TextBox ID="txtVenueZipCode" runat="server"></asp:TextBox>
            </div>
            <div>
                <p>Phone Number</p>
                <asp:TextBox ID="txtVenuePhoneNumber" runat="server"></asp:TextBox>
            </div>
            <div>
                <p>Age Restriction</p>
                <asp:TextBox ID="txtVenueAgeRestriction" runat="server"></asp:TextBox>
            </div>
            <div>
                <p>Email</p>
                <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
            </div>
            <div>
                <p>Web page address</p>
                <asp:TextBox ID="txtVenueWebPage" runat="server"></asp:TextBox>
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

<!--
        venue.VenueName = v.VenueName;
        venue.VenueAddress = v.VenueAddress;
        venue.VenueCity = v.VenueCity;
        venue.VenueState = v.VenueState;
        venue.VenueZipCode = v.VenueZipCode;
        venue.VenuePhone = v.VenuePhone;
        venue.VenueAgeRestriction = v.VenueAgeRestriction;
        venue.VenueEmail = v.VenueEmail;
        venue.VenueWebPage = v.VenueWebPage;
        venue.VenueDateAdded = DateTime.Now;

        db.Venues.Add(venue);

        login.VenueLoginUserName = vl.VenueLoginUserName;
        login.VenueLoginPasswordPlain = vl.VenueLoginPasswordPlain;
        login.VenueLoginHashed = hash.HashIt(vl.VenueLoginPasswordPlain, key.ToString());
        login.VenueLoginRandom = (int)key;
        login.VenueLoginDateAdded = DateTime.Now;
-->
