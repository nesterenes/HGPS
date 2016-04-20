using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Web.Configuration;
using System.Configuration;

/// <summary>
/// Summary description for Location
/// </summary>
public class Location
{
	public Location()
	{
		//
		// TODO: Add constructor logic here
		//
	}




    public static string[] GetLatLon(string street, string city, string state)
    {

        string[] LatLon = { "0", "0" };
        try {
            string geocoderUri = string.Format("http://rpc.geocoder.us/service/rest?address={0},{1},{2}", street, city, state);
            XmlDocument geocoderXmlDoc = new XmlDocument();
            geocoderXmlDoc.Load(geocoderUri);
            XmlNamespaceManager nsMgr = new XmlNamespaceManager(geocoderXmlDoc.NameTable);
            nsMgr.AddNamespace("geo", @"http://www.w3.org/2003/01/geo/wgs84_pos#");
            string sLong = geocoderXmlDoc.DocumentElement.SelectSingleNode(
                    @"//geo:long", nsMgr).InnerText;
            string sLat = geocoderXmlDoc.DocumentElement.SelectSingleNode(
                    @"//geo:lat", nsMgr).InnerText;

            double latitude = Double.Parse(sLat);
            double longitude = Double.Parse(sLong);

            LatLon[0] = latitude.ToString();
            LatLon[1] = longitude.ToString();        
        }
        catch (Exception e) {
            task.ErrorLog(e.ToString());
        }

        return LatLon;

    } //END GetLatLon Function

    public static string MapDetail(string lat, string lon)
    {

        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append(@"<script type='text/javascript'>");
        sb.Append(@"function initialize() {");
        sb.Append(@"var latlng = new google.maps.LatLng(" + lat + ", " + lon + ");");
        sb.Append(@"var settings = {");
        sb.Append(@"zoom: 15,");
        sb.Append(@"center: latlng,");
        sb.Append(@"mapTypeControl: true,");
        sb.Append(@"mapTypeControlOptions: { style: google.maps.MapTypeControlStyle.DROPDOWN_MENU },");
        sb.Append(@"navigationControl: true,");
        sb.Append(@"navigationControlOptions: { style: google.maps.NavigationControlStyle.SMALL },");
        sb.Append(@"mapTypeId: google.maps.MapTypeId.ROADMAP");
        sb.Append(@"};");
        sb.Append(@"var map = new google.maps.Map(document.getElementById('map_canvas'), settings);");


        sb.Append(@"var companyShadow = new google.maps.MarkerImage('images/logo_shadow.png',");
        sb.Append(@"new google.maps.Size(130, 50),");
        sb.Append(@"new google.maps.Point(0, 0),");
        sb.Append(@"new google.maps.Point(65, 50)");
        sb.Append(@");");

        sb.Append(@"var companyImage = new google.maps.MarkerImage('images/logo.png',");
        sb.Append(@"new google.maps.Size(100, 50),");
        sb.Append(@"new google.maps.Point(0, 0),");
        sb.Append(@"new google.maps.Point(50, 50)");
        sb.Append(@");");

        sb.Append(@"var companyPos = new google.maps.LatLng(" + lat + ", " + lon + ");");
        sb.Append(@"var companyMarker = new google.maps.Marker({");
        sb.Append(@"position: companyPos,");
        sb.Append(@"map: map,");
        sb.Append(@"icon: companyImage,");
        sb.Append(@"shadow: companyShadow,");
        sb.Append(@"title: 'Høgenhaug',");
        sb.Append(@"zIndex: 3");
        sb.Append(@"});");


        sb.Append(@"}");
        sb.Append(@"initialize()");
        sb.Append(@"</script>");



        return sb.ToString();

    }

    public static string MapMultipleAssembler() {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append(@"<script type='text/javascript'>");
        sb.Append(@"function initialize() {");

        int count = 1;
        string lat = "35.635262";
        string lon = "-117.692324";

        sb = MapMultipleBody(sb, count, lat, lon);

        sb.Append(@"}");
        sb.Append(@"initialize()");
        sb.Append(@"</script>");

        return sb.ToString();
    }

    public static StringBuilder MapMultipleBody(StringBuilder sb, int count, string lat, string lon)
    {

        string CountVariableA = "A" + count.ToString();
        string CountVariableB = "B" + count.ToString();
        string CountVariableC = "C" + count.ToString();
        string CountVariableD = "D" + count.ToString();
        string CountVariableE = "E" + count.ToString();
        string CountVariableF = "F" + count.ToString();
        string LocationType = "Haunted House";

        sb.Append(@"var " + CountVariableA + " = new google.maps.LatLng(" + lat + ", " + lon + ");");
        sb.Append(@"var settings = {");
        sb.Append(@"zoom: 15,");
        sb.Append(@"center: " + CountVariableA + ",");
        sb.Append(@"mapTypeControl: true,");
        sb.Append(@"mapTypeControlOptions: { style: google.maps.MapTypeControlStyle.DROPDOWN_MENU },");
        sb.Append(@"navigationControl: true,");
        sb.Append(@"navigationControlOptions: { style: google.maps.NavigationControlStyle.SMALL },");
        sb.Append(@"mapTypeId: google.maps.MapTypeId.ROADMAP");
        sb.Append(@"};");
        sb.Append(@"var " + CountVariableF + " = new google.maps.Map(document.getElementById('map_canvas'), settings);");


        sb.Append(@"var " + CountVariableB + " = new google.maps.MarkerImage('images/logo_shadow.png',");
        sb.Append(@"new google.maps.Size(130, 50),");
        sb.Append(@"new google.maps.Point(0, 0),");
        sb.Append(@"new google.maps.Point(65, 50)");
        sb.Append(@");");

        sb.Append(@"var " + CountVariableC + "  = new google.maps.MarkerImage('images/logo.png',");
        sb.Append(@"new google.maps.Size(100, 50),");
        sb.Append(@"new google.maps.Point(0, 0),");
        sb.Append(@"new google.maps.Point(50, 50)");
        sb.Append(@");");

        sb.Append(@"var " + CountVariableD + " = new google.maps.LatLng(" + lat + ", " + lon + ");");
        sb.Append(@"var " + CountVariableE + " = new google.maps.Marker({");
        sb.Append(@"position: " + CountVariableD + ",");
        sb.Append(@"map: " + CountVariableF + ",");
        sb.Append(@"icon: " + CountVariableC + " ,");
        sb.Append(@"shadow: " + CountVariableB + ",");
        sb.Append(@"title: ' " + LocationType + " ',");
        sb.Append(@"zIndex: 3");
        sb.Append(@"});");





        return sb;

    }


//LatLon Code below 
    //SQL Query for search and retrieve a row stored procedure 
    public static List<Loc> QueryLatLonByState(String ThisState)
    {

        string strConn = ConfigurationManager.ConnectionStrings["CS_h8675309"].ConnectionString;

        List<Loc> LocList = new List<Loc> { };

        

        //create connection 
        SqlConnection cn = new SqlConnection(strConn);

        try
        {
            
            //create command
            SqlCommand cm = new SqlCommand("nester_nesterenes.Loc_Query_LatLon", cn);
            cm.CommandType = CommandType.StoredProcedure;

            //store results of query
            SqlDataReader dr = default(SqlDataReader);
            
            //open connection
            cn.Open();

            //add parameter to command
            SqlParameter pm = new SqlParameter("@LocState", SqlDbType.VarChar, 2);
            pm.Direction = ParameterDirection.Input;
            pm.Value = ThisState;
            cm.Parameters.Add(pm);


            //run command
            dr = cm.ExecuteReader();

            int counter = 0;

            while (dr.Read())
            {
                counter++;
                Loc ThisLoc = new Loc();
                ThisLoc.UPN = (int)dr["UPN"];
                ThisLoc.Name = (string)dr["LocName"];
                ThisLoc.Address = (string)dr["LocAddress"];
                ThisLoc.City = (string)dr["LocCity"];
                ThisLoc.State = (string)dr["LocState"];
                ThisLoc.Lat = (string)dr["LocLat"];
                ThisLoc.Lon = (string)dr["LocLon"];
                //string[] LatLon = { "0", "0" };

                //LatLon = GetLatLon(ThisLoc.Address, ThisLoc.City, ThisLoc.State);
                //ThisLoc.Lat = LatLon[0];
                //ThisLoc.Lon = LatLon[1];

                LocList.Add(ThisLoc);

            }

        }
        catch (Exception e) { }

        finally
        {
            //Connection Cleanup
            cn.Close();
            cn = null;

        } //END Try / Catch

        //UpdateLatLon(ThisLoc);

        return LocList;

    }  //END Query  



    public static void UpdateLatLon(Loc ThisLoc)
    {

        string strConn = ConfigurationManager.ConnectionStrings["CS_h8675309"].ConnectionString;

        SqlConnection cn = new SqlConnection(strConn);
        SqlCommand cm = new SqlCommand("nester_nesterenes.LOC_UPDATE_LatLon", cn);
        cm.CommandType = CommandType.StoredProcedure;

        SqlParameter pm = new SqlParameter("@UPN", SqlDbType.Int);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.UPN;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocLat", SqlDbType.VarChar, 20);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.Lat;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocLon", SqlDbType.VarChar, 20);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.Lon;
        cm.Parameters.Add(pm);

        cn.Open();
        try
        {
            cm.ExecuteNonQuery();
        }
        catch (Exception e) {
            task.ErrorLog(e.ToString());
        }

        finally
        {
            cn.Close();
            cn = null;
        }


    }

}
