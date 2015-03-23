using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IShowAddService" in both code and config file together.
[ServiceContract]
public interface IShowAddService
{
    [OperationContract]
    void addShow(ShowData s, ShowDetailData sd, int venueKey, String artistName);

    [OperationContract]
    void addArtist(ArtistData a);

    [OperationContract]
    List<string> listArtists();
}

[DataContract]
public class ArtistData
{
    [DataMember]
    public string artistName { set; get; }

    [DataMember]
    public string artistEmail { set; get; }

    [DataMember]
    public string artistWebPage { set; get; }
}

public class ShowData
{
    [DataMember]
    public string showName { set; get; }

    [DataMember]
    public DateTime showDate { set; get; }

    [DataMember]
    public string showTicketInfo { set; get; }

    [DataMember]
    public TimeSpan showTime { set; get; }
}

public class ShowDetailData
{
    [DataMember]
    public string showDetailAdditional { set; get; }

    [DataMember]
    public TimeSpan showDetailArtistStartTime { set; get; }
}
