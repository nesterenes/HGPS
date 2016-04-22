using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Configuration;
using System.Web.UI.WebControls;
using System.Web.Security;

public partial class Main2 : System.Web.UI.Page
{
    string SelectedState;


    protected void Page_Load(object sender, EventArgs e)
    {

        SelectedState = StateCheck();

        if (SelectedState != null)
        {
            lblStateTest.Text = SelectedState;
        }

        if (drpCity.SelectedItem.Value != "All")
        {
            string City = drpCity.SelectedItem.Value;
            DSHalloween_SQL.SelectCommand = "SELECT DISTINCT * FROM [Location] WHERE " +
                "(([LocAddress] IS NOT NULL) AND ([LocName] IS NOT NULL) AND ([LocState] = '" +
                SelectedState + "') AND ([LocCity] = '" + City + "'))";

            dlMain.DataBind();

        }
        else
        {
            DSHalloween_SQL.SelectCommand = "SELECT DISTINCT * FROM [Location] WHERE " +
                "(([LocAddress] IS NOT NULL) AND ([LocName] IS NOT NULL) AND ([LocState] = '" +
                SelectedState + "'))";

            dlMain.DataBind();
        }

    }  //END Page_Load


    protected void drpCity_SelectedIndexChanged(object sender, EventArgs e)
    {

        if (drpCity.SelectedItem.Value != "All")
        {
            string City = drpCity.SelectedItem.Value;
            DSHalloween_SQL.SelectCommand = "SELECT DISTINCT * FROM [Location] " +
                "WHERE (([LocAddress] IS NOT NULL) AND ([LocName] IS NOT NULL) AND ([LocState] = '" +
                lblStateTest.Text + "') AND ([LocCity] = " + City + "))";

            dlMain.DataBind();

        }
        else
        {
            DSHalloween_SQL.SelectCommand = "SELECT DISTINCT * FROM [Location] WHERE " +
                "(([LocAddress] IS NOT NULL) AND ([LocName] IS NOT NULL) AND ([LocState] = '" +
                lblStateTest.Text + "'))";

            dlMain.DataBind();
        }

    } //END drpCity_SelectedIndexChanged


    protected void drpStateSelector_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (drpStateSelector.SelectedValue != "")
        {
            Session["State"] = drpStateSelector.SelectedValue.ToString();
            lblStateTest.Text = drpStateSelector.SelectedValue.ToString();

            Response.Redirect("Main.aspx");
        }

    } //END drpStateSelector_SelectedIndexChanged


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


    protected void btnRunLatLon_Click(object sender, EventArgs e)
    {
        //Location.QueryUpdateLatLon();
    }
}