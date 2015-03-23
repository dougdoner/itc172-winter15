using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;


public class VenueRegisterService : IVenueRegisterService
{

    public void registerVenue(VenueUser v, VenueUserLogin vl)
    {
        ShowTrackerEntities1 db = new ShowTrackerEntities1();

        PasswordHash hash = new PasswordHash();

        Venue venue = new Venue();
        VenueLogin login = new VenueLogin();

        Random Rand = new Random();
        int key = Rand.Next(9999999);

        venue.VenueName = v.venueName;
        venue.VenueAddress = v.venueAddress;
        venue.VenueCity = v.venueCity;
        venue.VenueState = v.venueState;
        venue.VenueZipCode = v.venueZipCode;
        venue.VenuePhone = v.venuePhone;
        venue.VenueAgeRestriction = v.venueAgeRestriction;
        venue.VenueEmail = v.venueEmail;
        venue.VenueWebPage = v.venueWebPage;
        venue.VenueDateAdded = DateTime.Now;

        db.Venues.Add(venue);

        login.VenueLoginUserName = vl.venueLoginUserName;
        login.VenueLoginPasswordPlain = vl.venueLoginPasswordPlain;
        login.VenueLoginHashed = hash.HashIt(vl.venueLoginPasswordPlain, key.ToString());
        login.VenueLoginRandom = (int)key;
        login.VenueLoginDateAdded = DateTime.Now;

        db.VenueLogins.Add(login);

        db.SaveChanges();
    }

    public int venueLogin(string username, string password)
    {
        Login log = new Login(username, password);
        int key = log.validateLogin();

        return key;
    }
}
