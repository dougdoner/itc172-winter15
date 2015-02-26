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
    protected void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            ShowTrackerEntities1 db = new ShowTrackerEntities1();
            FanLogin f = new FanLogin();
            Fan fan = new Fan();

            fan.FanName = txtFirstName.Text + " " + txtLastName.Text;
            fan.FanEmail = txtEmail.Text;
            f.FanLoginUserName = txtUserName.Text;
            f.FanLoginPasswordPlain = txtPassword1.Text;

            Random Rand = new Random();
            int key = Rand.Next(9999999);

            PasswordHash hash = new PasswordHash();

            Byte[] hashedPass = hash.HashIt(txtPassword1.Text, key.ToString());

            f.FanLoginRandom = key;
            f.FanLoginHashed = hashedPass;

            db.Fans.Add(fan);
            db.FanLogins.Add(f);

            db.SaveChanges();

            lblMessage.Text = "Successfully registered";
        }
        catch(Exception ex)
        {
            lblMessage.Text = ex.Message;
        }
    }
}
