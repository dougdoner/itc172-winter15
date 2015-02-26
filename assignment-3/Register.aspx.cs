using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    //when  registration form is submitted via the btnRegister click event
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        //using try-catch to prevent crashing and visual error-reporting
        try
        {
            //instantiates new ShowTracker database entity model
            ShowTrackerEntities1 db = new ShowTrackerEntities1();
            
            //instantiate both the fanLogin object and the fan object (one stores username and password info, other one stores name and email)
            FanLogin f = new FanLogin();
            Fan fan = new Fan();

            fan.FanName = txtFirstName.Text + " " + txtLastName.Text;
            fan.FanEmail = txtEmail.Text;
            f.FanLoginUserName = txtUserName.Text;
            f.FanLoginPasswordPlain = txtPassword1.Text;

            Random Rand = new Random();
            int key = Rand.Next(9999999);

            PasswordHash hash = new PasswordHash();
            
            //generates hashed password using random key as seed for hashing
            Byte[] hashedPass = hash.HashIt(txtPassword1.Text, key.ToString());
            
            //stores the seed and hashed password in the fanlogin object
            f.FanLoginRandom = key;
            f.FanLoginHashed = hashedPass;

            //adds the new objects to the db model
            db.Fans.Add(fan);
            db.FanLogins.Add(f);
            
            //saves changes to database
            db.SaveChanges();

            //display success message to user
            lblMessage.Text = "Successfully registered";
        }
        catch(Exception ex)
        {
            //if an error occurs after form validation and in the process of hashing the password or saving to the databse, an error message will appear for the user
            lblMessage.Text = ex.Message;
        }
    }
}
