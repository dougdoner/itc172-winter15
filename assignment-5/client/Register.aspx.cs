using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        VenueRegisterServiceReference.VenueRegisterServiceClient vr = new VenueRegisterServiceReference.VenueRegisterServiceClient();

        VenueRegisterServiceReference.VenueUser user = new VenueRegisterServiceReference.VenueUser();
        VenueRegisterServiceReference.VenueUserLogin login = new VenueRegisterServiceReference.VenueUserLogin();

        int ageRestriction = 0;

        user.venueName = txtVenueName.Text;
        user.venueAddress = txtVenueAddress.Text;
        user.venueCity = txtVenueCity.Text;
        user.venueState = txtVenueState.Text;
        user.venueZipCode = txtVenueZipCode.Text;
        user.venuePhone = txtVenuePhoneNumber.Text;

        Boolean goodAge = int.TryParse(txtVenueAgeRestriction.Text, out ageRestriction);
        user.venueAgeRestriction = ageRestriction;

        user.venueEmail = txtEmail.Text;
        user.venueWebPage = txtVenueWebPage.Text;

        login.venueLoginPasswordPlain = txtPassword1.Text;
        login.venueLoginUserName = txtUserName.Text;

        vr.registerVenue(user, login);
    }
}
