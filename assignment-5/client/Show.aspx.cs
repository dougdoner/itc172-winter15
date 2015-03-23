using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Show : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        ShowAddServiceReference.ShowAddServiceClient sr = new ShowAddServiceReference.ShowAddServiceClient();
        //although I wrote the service to return a List<string>, it returns a string array, so I had to work around populating the dropdownlist values with an array
        string[] artistList = sr.listArtists();

        foreach (var item in artistList)
        {
            ArtistDropDownList.Items.Add(item);
        }
    }
    protected void btnAddArtist_Click(object sender, EventArgs e)
    {
        //instantiates a service object, as well as a datacontract object for artist
        ShowAddServiceReference.ShowAddServiceClient sr = new ShowAddServiceReference.ShowAddServiceClient();
        ShowAddServiceReference.ArtistData artist = new ShowAddServiceReference.ArtistData();

        artist.artistName = txtArtistName.Text;
        artist.artistEmail = txtArtistEmail.Text;
        artist.artistWebPage = txtArtistWebPage.Text;

        sr.addArtist(artist);
        lblMessage.Text = "Artist Added";
    }
    protected void btnShowAdd_Click(object sender, EventArgs e)
    {
        //instantiates objects for both dataContracts (show and showDetails), and for the service methods object
        ShowAddServiceReference.ShowAddServiceClient sr = new ShowAddServiceReference.ShowAddServiceClient();
        ShowAddServiceReference.ShowData show = new ShowAddServiceReference.ShowData();
        ShowAddServiceReference.ShowDetailData details = new ShowAddServiceReference.ShowDetailData();

        TimeSpan showStartTime;
        TimeSpan showStartTimeAdditional;
        show.showName = txtShowName.Text;
        show.showDate = calendarShowDate.SelectedDate;
        TimeSpan.TryParse(txtShowStartTime.Text, out showStartTime);
        show.showTime = showStartTime;
        show.showTicketInfo = txtShowTicketInfo.Text;

        details.showDetailAdditional = txtShowAdditionalInfo.Text;
        TimeSpan.TryParse(txtShowAdditionalStartTime.Text, out showStartTimeAdditional);
        details.showDetailArtistStartTime = showStartTimeAdditional;
        sr.addShow(show, details, (int)Session["key"], ArtistDropDownList.SelectedValue);

        lblMessage.Text = "Show added";
    }
}
