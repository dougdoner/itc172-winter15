using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

public class ShowSearchService : IShowSearchService
{
    ShowTrackerEntities db = new ShowTrackerEntities();
    public List<string> listArtists()
    {
        var artists = from a in db.Artists
                     select new { a.ArtistName };

        List<string> artistList = new List<string>();
        foreach (var a in artists)
        {
            artistList.Add(a.ArtistName);
        }
        return artistList;
    }

    public List<string> listGenres()
    {
        var genres = from g in db.Genres
                     select new { g.GenreName };

        List<string> genreList = new List<string>();
        foreach (var g in genres)
        {
            genreList.Add(g.GenreName);
        }
        return genreList;
    }

    public List<string> listVenues()
    {
        var venues = from v in db.Venues
                     select new { v.VenueName };

        List<string> venueList = new List<string>();
        foreach (var v in venues)
        {
            venueList.Add(v.VenueName);
        }
        return venueList;
    }

    public List<Shows> listShows(string searchType, string searchString)
    {
        List<Shows> returnList = new List<Shows>();
        //search for genres
        if (searchType == "genre")
        {
            var shows = from a in db.Artists
                        from d in a.ShowDetails
                        from g in a.Genres
                        where g.GenreName.Equals(searchString)
                        select new { d.Show.ShowName, d.Show.ShowTicketInfo, d.Show.ShowDate, d.Show.ShowTime, d.ShowDetailAdditional, d.ShowDetailArtistStartTime, d.Artist.ArtistName, g.GenreName, d.Show.Venue.VenueName };

            foreach (var s in shows)
            {
                Shows show = new Shows();
                show.showName = s.ShowName;
                show.showDate = s.ShowDate;
                show.showArtistName = s.ArtistName;
                show.showGenre = s.GenreName;
                show.showStartTime = s.ShowTime;
                show.showStartTimeAdditional = s.ShowDetailArtistStartTime;
                show.showTicketInfo = s.ShowTicketInfo;
                show.showTicketInfoAdditional = s.ShowDetailAdditional;
                show.showVenue = s.VenueName;
                returnList.Add(show);
            }

            return returnList;
        }
        //search for artists
        else if (searchType == "artist")
        {
            var shows = from a in db.Artists
                        from d in a.ShowDetails
                        from g in a.Genres
                        where a.ArtistName.Equals(searchString)
                        select new { d.Show.ShowName, d.Show.ShowTicketInfo, d.Show.ShowDate, d.Show.ShowTime, d.ShowDetailAdditional, d.ShowDetailArtistStartTime, d.Artist.ArtistName, g.GenreName, d.Show.Venue.VenueName };

            foreach (var s in shows)
            {
                Shows show = new Shows();
                show.showName = s.ShowName;
                show.showDate = s.ShowDate;
                show.showArtistName = s.ArtistName;
                show.showGenre = s.GenreName;
                show.showStartTime = s.ShowTime;
                show.showStartTimeAdditional = s.ShowDetailArtistStartTime;
                show.showTicketInfo = s.ShowTicketInfo;
                show.showTicketInfoAdditional = s.ShowDetailAdditional;
                show.showVenue = s.VenueName;
                returnList.Add(show);
            }

            return returnList;
        }
        //search for venues
        else
        {
            var shows = from a in db.Artists
                        from d in a.ShowDetails
                        from g in a.Genres
                        where d.Show.Venue.VenueName.Equals(searchString)
                        select new { d.Show.ShowName, d.Show.ShowTicketInfo, d.Show.ShowDate, d.Show.ShowTime, d.ShowDetailAdditional, d.ShowDetailArtistStartTime, d.Artist.ArtistName, g.GenreName, d.Show.Venue.VenueName };

            foreach (var s in shows)
            {
                Shows show = new Shows();
                show.showName = s.ShowName;
                show.showDate = s.ShowDate;
                show.showArtistName = s.ArtistName;
                show.showGenre = s.GenreName;
                show.showStartTime = s.ShowTime;
                show.showStartTimeAdditional = s.ShowDetailArtistStartTime;
                show.showTicketInfo = s.ShowTicketInfo;
                show.showTicketInfoAdditional = s.ShowDetailAdditional;
                show.showVenue = s.VenueName;
                returnList.Add(show);
            }

            return returnList;
        }
    }
}
