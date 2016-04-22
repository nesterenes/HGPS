using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web.Configuration;

/// <summary>
/// Summary description for Loc
/// </summary>
public class Loc
{
	public Loc()
	{
        UPN = 0;
        BusName= "";
        FName= "";
        LName= "";
        Name= "";
        Type= "";
        Desc= "";
        Address= "";
        City= "";
        State= "";
        Zip= "";
        //Phone= "";
        //WebSite= "";
        //Email= "";
        //Facebook= "";
        //Twitter= "";
        //Coupon= "";
        //Lat= "";
        //Lon= "";
        //Premium= "";
        //PriceSum= "";
        //SchedSum= "";

	}


    //Private constructors
    private int _UPN;
    private String _BusName;
    private String _FName;
    private String _LName;
    private String _Name;
    private String _Type;
    private String _Desc;
    private String _Address;
    private String _City;
    private String _State;
    private String _Zip;
    private String _Phone;
    private String _WebSite;
    private String _Email;
    private String _Facebook;
    private String _Twitter;
    private String _Coupon;
    private String _Lat;
    private String _Lon;
    private String _Premium;
    private String _PriceSum;
    private String _SchedSum;


    //BEGIN Public Class Methods


    public int UPN
    {
        get { return _UPN; }
        set { _UPN = value; }
    }

    public String BusName
    {
        get { return _BusName; }
        set { _BusName = value; }
    }

    public String Name
    {
        get { return _Name; }
        set { _Name = value; }
    }

    public String FName
    {
        get { return _FName; }
        set { _FName = value; }
    }

    public String LName
    {
        get { return _LName; }
        set { _LName = value; }
    }

    public String Type
    {
        get { return _Type; }
        set { _Type = value; }
    }

    public String Desc
    {
        get { return _Desc; }
        set { _Desc = value; }
    }

    public String Address
    {
        get { return _Address; }
        set { _Address = value; }
    }

    public String City
    {
        get { return _City; }
        set { _City = value; }
    }

    public String State
    {
        get { return _State; }
        set { _State = value; }
    }

    public String Zip
    {
        get { return _Zip; }
        set { _Zip = value; }
    }

    public String Phone
    {
        get { return _Phone; }
        set { _Phone = value; }
    }

    public String WebSite
    {
        get { return _WebSite; }
        set { _WebSite = value; }
    }

    public String Email
    {
        get { return _Email; }
        set { _Email = value; }
    }

    public String Facebook
    {
        get { return _Facebook; }
        set { _Facebook = value; }
    }

    public String Twitter
    {
        get { return _Twitter; }
        set { _Twitter = value; }
    }

    public String Coupon
    {
        get { return _Coupon; }
        set { _Coupon = value; }
    }

    public String Lat
    {
        get { return _Lat; }
        set { _Lat = value; }
    }

    public String Lon
    {
        get { return _Lon; }
        set { _Lon = value; }
    }

    public String Premium
    {
        get { return _Premium; }
        set { _Premium = value; }
    }

    public String PriceSum
    {
        get { return _PriceSum; }
        set { _PriceSum = value; }
    }

    public String SchedSum
    {
        get { return _SchedSum; }
        set { _SchedSum = value; }
    }

    

    //END Public Class Methods

    public static int AddNewLoc(Loc ThisLoc)
    {
        string strConn = ConfigurationManager.ConnectionStrings["CS_h8675309"].ConnectionString;
 
        SqlConnection cn = new SqlConnection(strConn);

        //Insert Statement
        SqlCommand cm = new SqlCommand("nester_nesterenes.LocInsert", cn);
        cm.CommandType = CommandType.StoredProcedure;

        SqlParameter pm = new SqlParameter("@UPN", SqlDbType.Int);
        pm.Direction = ParameterDirection.Output;
        cm.Parameters.Add(pm);


        pm = new SqlParameter("@LocName", SqlDbType.VarChar, 100);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.Name;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocType", SqlDbType.VarChar, 50);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.Type;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocDesc", SqlDbType.VarChar, 200);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.Desc;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocAddress", SqlDbType.VarChar, 100);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.Address;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocCity", SqlDbType.VarChar, 100);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.City;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocState", SqlDbType.VarChar, 2);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.State;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocZip", SqlDbType.VarChar, 20);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.Zip;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocPhone", SqlDbType.VarChar, 20);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.Phone;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocWebSite", SqlDbType.VarChar, 50);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.WebSite;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocEmail", SqlDbType.VarChar, 50);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.Email;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocFacebook", SqlDbType.VarChar, 50);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.Facebook;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocTwitter", SqlDbType.VarChar, 50);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.Twitter;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocCoupon", SqlDbType.VarChar, 50);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.Coupon;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocLat", SqlDbType.VarChar, 20);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.Lat;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocLon", SqlDbType.VarChar, 20);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.Lon;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocPremium", SqlDbType.VarChar, 2);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.Premium;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocPriceSum", SqlDbType.VarChar, 250);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.PriceSum;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@LocSchedSum", SqlDbType.VarChar, 250);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisLoc.SchedSum;
        cm.Parameters.Add(pm);

        cn.Open();

        string MyError = "";
        try
        {
            cm.ExecuteNonQuery();

            //Return UPN created by the Database
            //ThisLoc.UPN = cm.Parameters("@UPN").Value

        }
        catch (SqlException e)
        {
            task.ErrorLog(e.ToString());
        }

        cn.Close();
        cn = null;

        ThisLoc.UPN = 1;

        return ThisLoc.UPN;

    }   //END AddNewLoc

}  


