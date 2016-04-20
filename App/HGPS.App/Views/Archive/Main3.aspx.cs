using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Main3 : System.Web.UI.Page
{
    string SelectedState;
    string URLType;

    protected void Page_Load(object sender, EventArgs e)
    {


        try
        {
            //Pull the ID varilable from the URL string
            URLType = Request.QueryString["Type"].ToString();
        }
        catch (Exception ex)
        { }

        if (IsPostBack != true)
        {
            SelectedState = StateCheck();

            QueryStringBuilder();
            //QueryCheckThenDataBind();
            CityDrpRefresh();
        }

    }  //END Page_Load


    protected void drpCity_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (drpCity.SelectedItem.Value != "All")
        {
            //string City = drpCity.SelectedItem.Text;
            //DSHalloween_SQL.SelectCommand = "SELECT * FROM [Location] " + 
            //  "WHERE (([LocAddress] IS NOT NULL) AND ([LocName] IS NOT NULL) AND ([LocState] = '" +
            //  SelectedState + "') AND ([LocCity] = '" + City + "'))";

            //dlMain.DataBind();

            QueryStringBuilder();

            //QueryCheckThenDataBind();

        }
        else
        {
            DSHalloween_SQL.SelectCommand = "SELECT DISTINCT * FROM [Location] WHERE " +
                "(([LocAddress] IS NOT NULL) AND ([LocName] IS NOT NULL) AND ([LocState] = '" +
                drpState.SelectedValue + "'))";

            dlMain.DataBind();
        }

    } //END drpCity_SelectedIndexChanged


    protected void drpStateSelector_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (drpStateSelector.SelectedValue != "")
        {
            Session["State"] = drpStateSelector.SelectedValue.ToString();
            drpState.SelectedValue = drpStateSelector.SelectedValue.ToString();

            Response.Redirect("Main3.aspx");
        }

    } //END drpStateSelector_SelectedIndexChanged

    protected void drpState_SelectedIndexChanged(object sender, EventArgs e)
    {
        SelectedState = drpState.SelectedValue;
        Session["State"] = SelectedState;

        CityDrpRefresh();

        QueryStringBuilder();
        //QueryCheckThenDataBind();

    }  //END drpState_SelectedIndexChanged


    protected string StateCheck()
    {
        //Pull the Query String into an object.
        SelectedState = (string)Session["State"];

        //Check if session object is empty. 
        //If NOTHING exists in the state queries... ask for it.
        if (SelectedState == null)
        {
            //Trigger Modal Dialog State Selector
            ModalStateSelector.Show();

        }

        return SelectedState;

    }  //END StateCheck

    protected void QueryStringBuilder()
    {

        try
        {
            //Pull the Query String into an object.
            SelectedState = (string)Session["State"];
        }
        catch (Exception j) { }

        if (SelectedState != null)
        {
            drpState.SelectedValue = SelectedState;

        }


        string MyQuery = "SELECT DISTINCT * FROM [Location] WHERE " +
                "(([LocAddress] IS NOT NULL) AND ([LocName] IS NOT NULL) ";

        //Append State
        MyQuery += "AND ([LocState] = '" + SelectedState + "') ";

        //Append City
        if (drpCity.SelectedItem.Value != "All")
        {
            MyQuery += "AND ([LocCity] = '" + drpCity.SelectedItem.Text + "') ";
        }

        //Append Type
        if (URLType != null)
        {
            MyQuery += "AND ([LocType] = '" + URLType + "')";

        }

        MyQuery += ")";

        DSHalloween_SQL.SelectCommand = MyQuery;

        dlMain.DataBind();




    } //END QueryStringBuilder()

    protected void QueryCheckThenDataBind()
    {

        if (SelectedState != null)
        {
            drpState.SelectedValue = SelectedState;

        }

        if (drpCity.SelectedItem.Value != "All" && URLType == null)
        {
            string City = drpCity.SelectedItem.Value;
            DSHalloween_SQL.SelectCommand = "SELECT DISTINCT * FROM [Location] WHERE " +
                "(([LocAddress] IS NOT NULL) AND ([LocName] IS NOT NULL) AND ([LocState] = '" +
                SelectedState + "') AND ([LocCity] = '" + City + "'))";

            dlMain.DataBind();

        }
        else if (drpCity.SelectedItem.Value != "All" && URLType != null)
        {
            string City = drpCity.SelectedItem.Value;
            DSHalloween_SQL.SelectCommand = "SELECT DISTINCT * FROM [Location] WHERE " +
                "(([LocAddress] IS NOT NULL) AND ([LocName] IS NOT NULL) AND ([LocState] = '" +
                SelectedState + "') AND ([LocCity] = '" + City + "') AND ([LocType] = '" + URLType + "'))";

            dlMain.DataBind();

        }
        else if (drpCity.SelectedItem.Value == "All" && URLType != null)
        {
            string City = drpCity.SelectedItem.Value;
            DSHalloween_SQL.SelectCommand = "SELECT DISTINCT * FROM [Location] WHERE " +
                "(([LocAddress] IS NOT NULL) AND ([LocName] IS NOT NULL) AND ([LocState] = '" +
                SelectedState + "') AND ([LocType] = '" + URLType + "'))";

            dlMain.DataBind();

        }
        else
        {
            DSHalloween_SQL.SelectCommand = "SELECT DISTINCT * FROM [Location] WHERE " +
                "(([LocAddress] IS NOT NULL) AND ([LocName] IS NOT NULL) AND ([LocState] = '" +
                SelectedState + "'))";

            dlMain.DataBind();
        }


    }

    protected void CityDrpRefresh()
    {
        drpCity.Items.Clear();
        drpCity.Items.Add("All");
        drpCity.SelectedIndex = 0;
        DS_City_SQL.SelectCommand = "SELECT DISTINCT [LocCity], [LocState] FROM [Location] WHERE " +
            "([LocState] = '" + SelectedState + "')";

        drpCity.DataBind();
    }



}

