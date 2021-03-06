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
        //instantiates new showtracker entity database model
        ShowTrackerEntities db = new ShowTrackerEntities();

        //LINQ notation select statement from fanLogin table
        var details = from f in db.FanLogins
                      where f.FanLoginUserName.Equals(userName)
                      select new { f.FanLoginKey, f.FanLoginHashed, f.FanLoginRandom };

        //assigns the selected login info to the private fields of Login
        foreach (var d in details)
        {
            seed = d.FanLoginRandom;
            currentHash = d.FanLoginHashed;
            key = d.FanLoginKey;
        }
    }

    //generates a new hash based on user input on the login screen
    private void genHash()
    {
        PasswordHash hash = new PasswordHash();
        compareHash = hash.HashIt(passWord, seed.ToString());
    }

    //compares the difference in byte array hashes, and if there is a match returns boolean true. Otherwise false
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

    //gets user details based on username input, generates a new hash from the input, and compares the hash of the input and the selected username
    //if result returns true, the Primary key is retruned (eventually stored in a session variable)
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
