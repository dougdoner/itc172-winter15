
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //returns a key larger than zero if the login is successful
        FanLoginService.FanLoginService2Client fan = new FanLoginService.FanLoginService2Client();
        int key = fan.loginFan(txtUserName.Text, txtPassword1.Text);
        if (key > 0)
        {
            Session["key"] = key;
            Response.Redirect("Shows.aspx");
        }
        else
        {
            lblMessage.Text = "login failed";
        }
    }
}
