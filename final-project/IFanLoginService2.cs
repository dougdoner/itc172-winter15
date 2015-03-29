using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

[ServiceContract]
public interface IFanLoginService2
{

    [OperationContract]
    Boolean registerFan(FanData f, FanLoginData fl);

    [OperationContract]
    int loginFan(string username, string password);
}

[DataContract]
public class FanData
{
    [DataMember]
    public string fanName { get; set; }

    [DataMember]
    public string fanEmail { get; set; }
}

[DataContract]
public class FanLoginData
{
    [DataMember]
    public string fanLoginUserName { get; set; }

    [DataMember]
    public string fanLoginPlainPassword { set; get; }
}
