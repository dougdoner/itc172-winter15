using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Shows : System.Web.UI.Page
{
    ShowSearchServiceReference.ShowSearchServiceClient ss = new ShowSearchServiceReference.ShowSearchServiceClient();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //data-binds string lists to drop down lists, to be used for searching for shows by artist, venue, or genre
            List<string> artistsList = ss.listArtists().ToList();

            ArtistDropDownList.DataSource = artistsList;
            ArtistDropDownList.DataBind();

            List<string> genresList = ss.listGenres().ToList();

            GenresDropDownList.DataSource = genresList;
            GenresDropDownList.DataBind();

            List<string> venuesList = ss.listVenues().ToList();

            VenuesDropDownList.DataSource = venuesList;
            VenuesDropDownList.DataBind();
        }
    }
    protected void ArtistDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        //binds the resulting string-list to the grid view
        string searchString = ArtistDropDownList.SelectedItem.Text;
        List<ShowSearchServiceReference.Shows> showList = ss.listShows("artist", searchString).ToList();
        ShowGridView.DataSource = showList;
        ShowGridView.DataBind();
    }
    protected void GenresDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        string searchString = GenresDropDownList.SelectedItem.Text;
        List<ShowSearchServiceReference.Shows> showList = ss.listShows("genre", searchString).ToList();
        ShowGridView.DataSource = showList;
        ShowGridView.DataBind();
    }
    protected void VenuesDropDownList_SelectedIndexChanged(object sender, EventArgs e)
    {
        string searchString = VenuesDropDownList.SelectedItem.Text;
        List<ShowSearchServiceReference.Shows> showList = ss.listShows("venue", searchString).ToList();
        ShowGridView.DataSource = showList;
        ShowGridView.DataBind();
    }
}
