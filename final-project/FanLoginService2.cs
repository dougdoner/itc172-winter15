using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class FanLoginService2 : IFanLoginService2
{
    public Boolean registerFan(FanData f, FanLoginData fl)
    {
        try
        {
            ShowTrackerEntities db = new ShowTrackerEntities();

            PasswordHash hash = new PasswordHash();

            Fan fan = new Fan();
            FanLogin login = new FanLogin();

            Random rand = new Random();

            int key = rand.Next(9999999);

            fan.FanName = f.fanName;
            fan.FanEmail = f.fanEmail;
            fan.FanDateEntered = DateTime.Now;

            db.Fans.Add(fan);

            login.FanLoginUserName = fl.fanLoginUserName;
            login.FanLoginPasswordPlain = fl.fanLoginPlainPassword;
            login.FanLoginHashed = hash.HashIt(fl.fanLoginPlainPassword, key.ToString());
            login.FanLoginDateAdded = DateTime.Now;
            login.Fan = fan;
            login.FanLoginRandom = (int)key;

            db.FanLogins.Add(login);

            db.SaveChanges();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }
    }

    public int loginFan(string username, string password)
    {
        Login log = new Login(username, password);
        int key = log.validateLogin();
        return key;
    }
}
