using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Configuration;
using System.Web.Configuration;
using Artem.Web.UI.Controls;

public partial class Detail : System.Web.UI.Page
{

    String FullAddressPlus;
    string cnString = (WebConfigurationManager.ConnectionStrings["CS_h8675309"]).ToString();

    protected void Page_Load(object sender, EventArgs e)
    {


        //Pull the ID varilable from the URL string
        string URL = Request.QueryString["ID"].ToString();

        //Set the DataSource for DataList
        DSHalloween_SQL.SelectCommand = "SELECT DISTINCT * FROM [Location] WHERE " +
            "(([LocAddress] IS NOT NULL) AND ([LocName] IS NOT NULL) AND ([UPN] = + " + URL + "))";


        //Returns information regarding that location into 'ThisLoc'
        Loc ThisLoc = new Loc();
        ThisLoc = PopulateThisLoc(URL, ThisLoc);

        //Updates the map and adds the point on the map.        
        PopulateMapQuery(ThisLoc);

        //Fills information within the details page
        PopulateDetails(ThisLoc);
    }


    //Query the database 'Location' Table then maps a point on the map.
    protected Loc PopulateThisLoc(String URL, Loc ThisLoc)
    {
        //Creates the connection to the data source
        SqlConnection cn = default(SqlConnection);


        //create the connection instance    
        cn = new SqlConnection(cnString);

        //define an SQL string
        string sqlQuery = "SELECT DISTINCT * FROM [Location] WHERE (([LocAddress] IS NOT NULL) AND ([LocName] IS NOT NULL) AND ([UPN] = + " + URL + "))";

        //Placeholder string
        string Address = "";

        try
        {
            cn.Open();
            SqlCommand cm = new SqlCommand(sqlQuery, cn);
            SqlDataReader SQLReader = cm.ExecuteReader();


            //Loops the reader and pulls the address from Columns 4-7
            while (SQLReader.Read())
            {

                ThisLoc.UPN = (int)SQLReader["UPN"];
                ThisLoc.Name = (string)SQLReader["LocName"];
                ThisLoc.Desc = (string)SQLReader["LocDesc"];
                ThisLoc.Type = (string)SQLReader["LocType"];
                ThisLoc.Address = (string)SQLReader["LocAddress"];
                ThisLoc.City = (string)SQLReader["LocCity"];
                ThisLoc.State = (string)SQLReader["LocState"];
                ThisLoc.Zip = (string)SQLReader["LocZip"];
                ThisLoc.Phone = (string)SQLReader["LocPhone"];
                ThisLoc.Lat = (string)SQLReader["LocLat"];
                ThisLoc.Lon = (string)SQLReader["LocLon"];
                ThisLoc.WebSite = (string)SQLReader["LocWebSite"];
                ThisLoc.Facebook = (string)SQLReader["LocFacebook"];
                ThisLoc.Twitter = (string)SQLReader["LocTwitter"];
                ThisLoc.Coupon = (string)SQLReader["LocCoupon"];
                ThisLoc.SchedSum = (string)SQLReader["LocSchedSum"];
                ThisLoc.PriceSum = (string)SQLReader["LocPriceSum"];

                FullAddressPlus = ThisLoc.Address + " " + ThisLoc.City + " " + ThisLoc.State + " " + ThisLoc.Zip;
                FullAddressPlus = FullAddressPlus.Replace(' ', '+');

                //Address += SQLReader.GetString(4) + ", ";
                //Address += SQLReader.GetString(5) + ", ";
                //Address += SQLReader.GetString(6) + ", ";
                //Address += SQLReader.GetString(7); 
            }
            SQLReader.Close();
            cm.Dispose();
            cn.Close();
        }
        catch (Exception ex)
        {

        }

        return ThisLoc;

    } // END PopulateMapQuery

    //Query the database 'Location' Table then maps a point on the map.
    protected  void PopulateMapQuery(Loc ThisLoc)
    {
            GoogleMarker marker = new GoogleMarker();
            marker.Address = ThisLoc.Address + ", " + ThisLoc.City + ", " + ThisLoc.State + " " + ThisLoc.Zip;
            //marker.Latitude = Convert.ToDouble(ThisLoc.Lat);
            //marker.Longitude = Convert.ToDouble(ThisLoc.Lon);


            marker.Text = ThisLoc.Name;
            marker.Text += "<br />" + ThisLoc.Address;
            marker.Text += "<br />" + ThisLoc.City + ", " + ThisLoc.State + " " + ThisLoc.Zip;
            marker.Text += "<br />" + "<a href='http://maps.google.com/?q=" + FullAddressPlus + "' target='_blank'>Get Directions</a>";

            GoogleMap1.Markers.Add(marker);

            GoogleMap1.Address = ThisLoc.Address + "," + ThisLoc.City + ", " + ThisLoc.State + "," + ThisLoc.Zip;
            GoogleMap1.Zoom = 12;

    } // END PopulateMapQuery


    //Query the database 'EventDetail' Table then populates the Calendar.
    protected void PopulateCalendarQuery(string ThisUPN)
    {
        //Creates the connection to the data source
        SqlConnection cn = default(SqlConnection);

        //create the connection instance
        cn = new SqlConnection(cnString);

        //define an SQL string
        string sqlQuery = "SELECT * FROM [EventDetails] WHERE (UPN = " + ThisUPN + ")";

        //Placeholder strings
        string EvtDate;
        string EvtHours;
        string EvtPrice;

        try
        {
            cn.Open();
            SqlCommand cm = new SqlCommand(sqlQuery, cn);
            SqlDataReader selected = cm.ExecuteReader();

            //Loops the database pulling Date, Hours, and Price; then pushing to Calendar.
            while (selected.Read())
            {
                //int testing = selected.GetInt16(1);
                EvtDate = selected.GetDateTime(2).Day.ToString();
                EvtHours = selected.GetString(3);
                EvtPrice = selected.GetString(4);

                //Generic container label for populating the calendar.
                Label CalLabel;
                //CalLabel = (Label)pnlCalendar.FindControl("lblCal_Oct" + EvtDate.ToString());

                //Pushing the text into the label
                //CalLabel.Text = "Date: " + EvtDate + "<br />Hours: "
                 //   + EvtHours + "<br />Price: " + EvtPrice;

            }
            selected.Close();
            cm.Dispose();
            cn.Close();
        }
        catch (Exception ex)
        {

        }



    }


    //Fills information within the details page
    protected void PopulateDetails(Loc ThisLoc)
    {
        lblName.Text = ThisLoc.Name;

        lblDesc.Text = ThisLoc.Desc;

        lblType.Text = ThisLoc.Type;

        lblAddress.Text = ThisLoc.Address;

        lblCity.Text = ThisLoc.City;

        lblState.Text = ThisLoc.State;

        lblZip.Text = ThisLoc.Zip;

        FullAddressPlus = ThisLoc.Address + " " + ThisLoc.City + " " + ThisLoc.State + " " + ThisLoc.Zip;
        FullAddressPlus = FullAddressPlus.Replace(' ', '+');

        lblGetDirections.Text = "<a href='http://maps.google.com/?q=" + FullAddressPlus + "' target='_blank'>Get Directions</a>";

        lblPhone.Text = ThisLoc.Phone;

        lblWebSite.Text = "None";
        if (ThisLoc.WebSite != "")
        {
            lblWebSite.Text = "<a href='" + task.HTTPChecker(ThisLoc.WebSite) + "' target='_blank'>WebSite</a>";
        }


        lblFacebook.Text = "None";
        if (ThisLoc.Facebook != "")
        { 
            lblFacebook.Text = "<a href='" + task.HTTPChecker(ThisLoc.Facebook) + "' target='_blank'>Facebook Page</a>";
        }

        lblTwitter.Text = "None";
        if (ThisLoc.Twitter != "")
        {
            lblTwitter.Text = "<a href='" + task.HTTPChecker(ThisLoc.Twitter) + "' target='_blank'>Twitter Page</a>";
        }

        lblCoupon.Text = "None";
        if (ThisLoc.Coupon != "")
        {
            lblCoupon.Text = ThisLoc.Coupon;
        }
                
        lblPrice.Text = ThisLoc.PriceSum;

        lblSchedSum.Text = ThisLoc.SchedSum;


    } //END PopulateDetails



    
}
