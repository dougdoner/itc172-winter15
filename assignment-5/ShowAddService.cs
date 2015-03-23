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
    public void addShow(ShowData s, ShowDetailData sd, int venueKey, String artistName)
    {
        ShowTrackerEntities3 db = new ShowTrackerEntities3();

        var showArtist = from a in db.Artists
                         where a.ArtistName == artistName
                         select new { a.ArtistName, a.ArtistKey };

        foreach (var item in showArtist)
        {
            artKey = item.ArtistKey;
        }

        Show show = new Show();
        ShowDetail details = new ShowDetail();

        show.ShowName = s.showName;
        show.ShowDate = s.showDate;
        show.ShowTicketInfo = s.showTicketInfo;
        show.ShowDateEntered = DateTime.Now;
        show.ShowTime = s.showTime;
        show.VenueKey = venueKey;
       
        db.Shows.Add(show);

        details.ArtistKey = artKey;
        details.ShowDetailAdditional = sd.showDetailAdditional;
        details.ShowDetailArtistStartTime = sd.showDetailArtistStartTime;
        details.ShowKey = show.ShowKey;

        db.ShowDetails.Add(details);
        db.SaveChanges();
    }

    public void addArtist(ArtistData a)
    {
        ShowTrackerEntities3 db = new ShowTrackerEntities3();

        Artist artist = new Artist();

        artist.ArtistName = a.artistName;
        artist.ArtistEmail = a.artistEmail;
        artist.ArtistWebPage = a.artistWebPage;
        artist.ArtistDateEntered = DateTime.Now;

        db.Artists.Add(artist);

        db.SaveChanges();
    }

    public List<string> listArtists()
    {
        ShowTrackerEntities3 db = new ShowTrackerEntities3();

        var showArtist = from a in db.Artists
                         select new { a.ArtistName };

        List<string> returnList = new List<string>();

        foreach (var a in showArtist)
        {
            returnList.Add(a.ArtistName);
        }

        return returnList;
    }
}
