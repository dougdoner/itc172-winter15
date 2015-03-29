using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

[ServiceContract]
public interface IShowSearchService
{
    [OperationContract]
    List<string> listArtists();

    [OperationContract]
    List<string> listGenres();

    [OperationContract]
    List<Shows> listShows(string searchType, string searchString);

    [OperationContract]
    List<string> listVenues();
}

[DataContract]
public class Shows
{
    [DataMember]
    public string showName { set; get; }

    [DataMember]
    public string showArtistName { set; get; }
    
    [DataMember]
    public string showTicketInfo { set; get; }

    [DataMember]
    public DateTime showDate { set; get; }

    [DataMember]
    public TimeSpan showStartTime { set; get; }

    [DataMember]
    public string showTicketInfoAdditional { set; get; }

    [DataMember]
    public TimeSpan showStartTimeAdditional { set; get; }

    [DataMember]
    public string showGenre { set; get; }

    [DataMember]
    public string showVenue { set; get; }
}
