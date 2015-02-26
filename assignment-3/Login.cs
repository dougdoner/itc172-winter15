using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Login
/// </summary>
public class Login
{
    private string userName;
    private string passWord;
    private int seed;
    private byte[] currentHash;
    private int key;
    private byte[] compareHash;

	public Login(string userName, string passWord)
	{
        this.userName = userName;
        this.passWord = passWord;
	}

    private void getFanDetails()
    {
        ShowTrackerEntities1 db = new ShowTrackerEntities1();

        var details = from f in db.FanLogins
                      where f.FanLoginUserName.Equals(userName)
                      select new { f.FanLoginKey, f.FanLoginHashed, f.FanLoginRandom };

        foreach (var d in details)
        {
            seed = d.FanLoginRandom;
            currentHash = d.FanLoginHashed;
            key = d.FanLoginKey;
        }
    }

    private void genHash()
    {
        PasswordHash hash = new PasswordHash();
        compareHash = hash.HashIt(passWord, seed.ToString());
    }

    private bool hashCompare()
    {
        bool loginGood = false;

        if (compareHash != null)
        {
            if (compareHash.SequenceEqual(currentHash))
            {
                return true;
            }
        }
        return loginGood;
    }

    public int validateLogin()
    {
        getFanDetails();
        genHash();
        bool result = hashCompare();

        if (!result)
        {
            key = 0;
        }

        return key;
    }
}
