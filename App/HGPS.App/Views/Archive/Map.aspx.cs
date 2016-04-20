using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using Artem.Web.UI.Controls;

public partial class Test_Map2 : System.Web.UI.Page
{


    protected void Page_Load(object sender, EventArgs e)
    {
        string CurrentState = (string)Session["State"];
        if (CurrentState != null)
        {
            GoogleMap1.Address = CurrentState;
        }
        List<Loc> LocList = Location.QueryLatLonByState(CurrentState);

        //GoogleMarker marker = new GoogleMarker();
        //marker.Address = "CA";
        //marker.Text = "Hello World!";
        //marker.IconUrl = "images/logo.png";
        //marker.IconSize = new GoogleSize(100, 50);
        //GoogleMap1.Markers.Add(marker);


        //GoogleMarker marker2 = new GoogleMarker();
        //marker2.Latitude = 35.63863;
        //marker2.Longitude = -117.680118;
        //marker2.Text = "Hello World2!";
        //GoogleMap1.Markers.Add(marker2);  


	for (int i = 0; i < LocList.Count; i++) // Loop through List with for
	{
        Loc ThisLoc = new Loc();
        ThisLoc = LocList[i];

        GoogleMarker marker = new GoogleMarker();
        
        marker.Latitude = Convert.ToDouble(ThisLoc.Lat);
        marker.Longitude = Convert.ToDouble(ThisLoc.Lon);
        marker.Text = ThisLoc.Name;
        marker.Text += "<br />" + ThisLoc.Address;
        marker.Text += "<br />" + ThisLoc.City + ", " + ThisLoc.State + " " + ThisLoc.Zip;
        //marker.IconUrl = "images/logo.png";
        //marker.IconSize = new GoogleSize(100, 50);
        GoogleMap1.Markers.Add(marker);        

	}
    
    }


}
