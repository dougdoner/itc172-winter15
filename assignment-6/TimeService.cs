using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

public class TimeService : ITimeService
{
	public string getTime()
	{
        return DateTime.Now.ToLongTimeString();
	}
}
