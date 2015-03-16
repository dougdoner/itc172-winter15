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
    public void registerVenue(Venue v, VenueLogin vl)
    {
        ShowTrackerEntities1 db = new ShowTrackerEntities1();

        PasswordHash hash = new PasswordHash();

        Venue venue = new Venue();
        VenueLogin login = new VenueLogin();

        Random Rand = new Random();
        int key = Rand.Next(9999999);

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
