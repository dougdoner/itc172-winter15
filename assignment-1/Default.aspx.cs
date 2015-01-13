using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    /// <summary>
    /// This is for itc 172
    /// Assignment-1
    /// 
    /// Author: Douglas Doner
    /// Date: 1/11/2015
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        //declares a DateTime variable birthDate for storing the input in DateTime format
        DateTime birthDate;
        //stores the current date in a DateTime variable called now
        DateTime now = DateTime.Now;

        //birthDate will only be assigned the input if it is in proper DateTime format
        bool goodDate = DateTime.TryParse(txtAgeInput.Text, out birthDate);

        int months;

        //a year in months is added to now.month if the birthdate month value is larger than the current date month value
        if (now.Month < birthDate.Month)
        {
            months = 12 + now.Month - birthDate.Month;
        }
        else
        {
            months = now.Month - birthDate.Month;
        }

        //this method is adding the negative value of -birthDate.Day to now.Days
        int currentDay = now.AddDays(-birthDate.Day).Day;

        if (now.Day < birthDate.Day && months >= 1)
        {
            months--;
        }

        //subtracts the current date year from the inputted birthdate year
        int years = now.Year - birthDate.Year;

        // subtracts one year from the age if the person's birthday hasn't happened yet
        if (now.Month <= birthDate.Month && now.Day < birthDate.Day)
        {
            years--;
        }

        lblOutput.Text = "You are " + years + " years, " + months + " months, and " + currentDay + " days old.";
    }
}
