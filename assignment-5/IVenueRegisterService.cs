using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IVenueRegisterService" in both code and config file together.
[ServiceContract]
public interface IVenueRegisterService
{
    [OperationContract]
    void registerVenue(VenueUser v, VenueUserLogin vl);
    [OperationContract]
    int venueLogin(string username, string password);
}

[DataContract]
public class VenueUser
{
    [DataMember]
    public string venueName { set; get; }

    [DataMember]
    public string venueAddress { set; get; }

    [DataMember]
    public string venueCity { set; get; }

    [DataMember]
    public string venueState { set; get; }

    [DataMember]
    public string venueZipCode { set; get; }

    [DataMember]
    public string venuePhone { set; get; }

    [DataMember]
    public int venueAgeRestriction { set; get; }

    [DataMember]
    public string venueEmail { set; get; }

    [DataMember]
    public string venueWebPage { set; get; }
}

public class VenueUserLogin
{
    [DataMember]
    public string venueLoginUserName { set; get; }

    [DataMember]
    public string venueLoginPasswordPlain { set; get; }
}


