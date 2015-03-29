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
        //instantiating a fanLoginservice reference object, and the two datacontracts for fan and login
        FanLoginService.FanLoginService2Client fs = new FanLoginService.FanLoginService2Client();
        FanLoginService.FanData fan = new FanLoginService.FanData();
        FanLoginService.FanLoginData login = new FanLoginService.FanLoginData();

        fan.fanName = txtFanName.Text;
        fan.fanEmail = txtEmail.Text;

        login.fanLoginPlainPassword = txtPassword1.Text;
        login.fanLoginUserName = txtUserName.Text;

        //registerFan returns true if user was added to database, otherwise returns false
        Boolean goodRegister = fs.registerFan(fan, login);
        if (goodRegister)
        {
            lblMessage.Text = "Registered Successfully";
        }
        else
        {
            lblMessage.Text = "Error in registration. Try again";
        }
    }
}
