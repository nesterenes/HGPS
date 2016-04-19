using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Web;


/// <summary>
/// Summary description for Loc
/// </summary>
public class Event
{
	public Event()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    //Private constructors
    private int _UPN;
    private String _EvtCalendarYear;
    private DateTime _EvtDate;
    private String _EvtHours;
    private String _EvtPrice;
    private String _EvtGroupRate;
    private String _EvtGroupRatePrice;


    //BEGIN Public Class Methods


    public int UPN
    {
        get { return _UPN; }
        set { _UPN = value; }
    }

    public String EvtCalendarYear
    {
        get { return _EvtCalendarYear; }
        set { _EvtCalendarYear = value; }
    }

    public DateTime EvtDate
    {
        get { return _EvtDate; }
        set { _EvtDate = value; }
    }

    public String EvtHours
    {
        get { return _EvtHours; }
        set { _EvtHours = value; }
    }

    public String EvtPrice
    {
        get { return _EvtPrice; }
        set { _EvtPrice = value; }
    }

    public String EvtGroupRate
    {
        get { return _EvtGroupRate; }
        set { _EvtGroupRate = value; }
    }

    public String EvtGroupRatePrice
    {
        get { return _EvtGroupRatePrice; }
        set { _EvtGroupRatePrice = value; }
    }

    //END Public Class Methods


    public static int AddNewEvent(Event ThisEv)
    {
        string strConn = ConfigurationManager.ConnectionStrings["CS_h8675309"].ConnectionString;

        SqlConnection cn = new SqlConnection(strConn);

        //Insert Statement
        SqlCommand cm = new SqlCommand("nester_nesterenes.EvDetailInsert", cn);
        cm.CommandType = CommandType.StoredProcedure;

        SqlParameter pm = new SqlParameter("@ID", SqlDbType.Int);
        pm.Direction = ParameterDirection.Output;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@UPN", SqlDbType.Int);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisEv.UPN;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@EvtCalendarYear", SqlDbType.VarChar, 10);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisEv.EvtCalendarYear;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@EvtDate", SqlDbType.DateTime);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisEv.EvtDate;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@EvtHours", SqlDbType.VarChar, 50);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisEv.EvtHours;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@EvtPrice", SqlDbType.VarChar, 10);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisEv.EvtPrice;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@EvtGroupRate", SqlDbType.VarChar, 10);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisEv.EvtGroupRate;
        cm.Parameters.Add(pm);

        pm = new SqlParameter("@EvtGroupRatePrice", SqlDbType.VarChar, 10);
        pm.Direction = ParameterDirection.Input;
        pm.Value = ThisEv.EvtGroupRatePrice;
        cm.Parameters.Add(pm);




        cn.Open();

        string MyError = "";
        try
        {
            cm.ExecuteNonQuery();

            //Return UPN created by the Database
            //ThisEv.UPN = cm.Parameters("@UPN").Value

        }
        catch (SqlException e)
        {
            task.ErrorLog(e.ToString());
        }

        cn.Close();
        cn = null;

        ThisEv.UPN = 1;

        return ThisEv.UPN;
    }  //END AddNewEvent

}  
