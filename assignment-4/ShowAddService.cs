using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ShowAddService" in code, svc and config file together.
public class ShowAddService : IShowAddService
{
    private int artKey;
    public void addShow(Show s, ShowDetail sd, int venueKey, String artistName)
    {
        ShowTrackerEntities1 db = new ShowTrackerEntities1();

        var showArtist = from a in db.Artists
                         where a.ArtistName == artistName
                         select new { a.ArtistName, a.ArtistKey };

        foreach (var item in showArtist)
        {
            artKey = item.ArtistKey;
        }

        Show show = new Show();
        ShowDetail details = new ShowDetail();

        show.ShowName = s.ShowName;
        show.ShowDate = s.ShowDate;
        show.ShowTicketInfo = s.ShowTicketInfo;
        show.Venue = s.Venue;
        show.ShowDateEntered = DateTime.Now;
        show.ShowTime = s.ShowTime;
        show.VenueKey = venueKey;
       
        db.Shows.Add(show);

        details.ArtistKey = artKey;
        details.ShowDetailAdditional = sd.ShowDetailAdditional;
        details.ShowDetailArtistStartTime = sd.ShowDetailArtistStartTime;
        details.ShowKey = show.ShowKey;

        db.ShowDetails.Add(details);
        db.SaveChanges();
    }

    public void addArtist(Artist a)
    {
        ShowTrackerEntities1 db = new ShowTrackerEntities1();

        Artist artist = new Artist();

        artist.ArtistName = a.ArtistName;
        artist.ArtistEmail = a.ArtistEmail;
        artist.ArtistWebPage = a.ArtistWebPage;
        artist.ArtistDateEntered = DateTime.Now;

        db.Artists.Add(artist);

        db.SaveChanges();
    }
}
