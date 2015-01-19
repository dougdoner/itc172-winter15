using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //instantiates Data entities for Show tracker database entries
    ShowTrackerEntities showEntities = new ShowTrackerEntities();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //LINQ notation for selecting data from ADO data entity
            var artists = from a in showEntities.Artists
                          orderby a.ArtistName
                          select new { a.ArtistName, a.ArtistKey };

            DropDownList1.DataSource = artists.ToList();
            DropDownList1.DataTextField = "ArtistName";
            DropDownList1.DataValueField = "ArtistKey";
            DropDownList1.DataBind();
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var details = from s in showEntities.Shows
                      from a in showEntities.Artists
                      from d in s.ShowDetails
                      from g in a.Genres
                      where a.ArtistName == DropDownList1.SelectedItem.Text
                      select new{ s.ShowName, s.ShowDate, s.ShowDetails, a.ArtistName, d.ShowDetailArtistStartTime};
        GridView1.DataSource = details.ToList();
        GridView1.DataBind();
    }
}
