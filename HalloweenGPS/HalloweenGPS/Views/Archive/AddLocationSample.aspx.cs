using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Artem.Web.UI.Controls;

public partial class AddLocationSample : System.Web.UI.Page
{
    string FullAddressPlus;
    protected void Page_Load(object sender, EventArgs e)
    {
        Loc ThisLoc = new Loc();
        Loc CntInfo = new Loc();

        try
        {
            ThisLoc = (Loc)(Session["ThisLoc"]);
            CntInfo = (Loc)(Session["CntInfo"]);
        }
        catch (Exception ex) { }


        //Updates the map and adds the point on the map.        
        PopulateMapQuery(ThisLoc);

        //Fills information within the details page
        PopulateDetails(ThisLoc);

        //Fills variables for the payment options
        //PopulateHiddenFields(CntInfo);
    }


    //Query the database 'Location' Table then maps a point on the map.
    protected void PopulateMapQuery(Loc ThisLoc)
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
            lblWebSite.Text = "<a href='http://" + ThisLoc.WebSite + "' target='_blank'>WebSite</a>";
        }


        lblFacebook.Text = "None";
        if (ThisLoc.Facebook != "")
        {
            lblFacebook.Text = "<a href='http://" + ThisLoc.Facebook + "' target='_blank'>Facebook Page</a>";
        }

        lblTwitter.Text = "None";
        if (ThisLoc.Twitter != "")
        {
            lblTwitter.Text = "<a href='http://" + ThisLoc.Twitter + "' target='_blank'>Twitter Page</a>";
        }

        lblCoupon.Text = "None";
        if (ThisLoc.Coupon != "")
        {
            lblCoupon.Text = ThisLoc.Coupon;
        }

        lblPrice.Text = ThisLoc.PriceSum;

        lblSchedSum.Text = ThisLoc.SchedSum;


    } //END PopulateDetails

    protected void PopulateHiddenFields(Loc CntInfo)
    {
        System.Text.StringBuilder sb = new System.Text.StringBuilder();
        sb.Append("<INPUT TYPE='hidden' NAME='first_name' VALUE='" + CntInfo.FName + "'>");
        sb.Append("<INPUT TYPE='hidden' NAME='last_name' VALUE='" + CntInfo.LName + "'>");
        sb.Append("<INPUT TYPE='hidden' NAME='address1' VALUE='" + CntInfo.Address + "'>");
        sb.Append("<INPUT TYPE='hidden' NAME='city' VALUE='" + CntInfo.City + "'>");
        sb.Append("<INPUT TYPE='hidden' NAME='state' VALUE='" + CntInfo.State + "'>");
        sb.Append("<INPUT TYPE='hidden' NAME='zip' VALUE='" + CntInfo.Zip + "'>");
        sb.Append("<INPUT TYPE='hidden' NAME='lc' VALUE='US'>");

        String Ph1 = CntInfo.Phone.Substring(0,3);
        String Ph2 = CntInfo.Phone.Substring(3, 3);
        String Ph3 = CntInfo.Phone.Substring(6, 4);

        sb.Append("<INPUT TYPE='hidden' NAME='night_phone_a' VALUE='" + Ph1 + "'>");
        sb.Append("<INPUT TYPE='hidden' NAME='night_phone_b' VALUE='" + Ph2 + "'>");
        sb.Append("<INPUT TYPE='hidden' NAME='night_phone_c' VALUE='" + Ph3 + "'>");
        sb.Append("<INPUT TYPE='hidden' name='cmd' value='_s-xclick'>");

        //if (CntInfo.Premium == "10") {
          //  sb.Append("<INPUT TYPE='hidden' name='hosted_button_id' value='ADTHSCV9GHAEY'>");
        //}
        //if (CntInfo.Premium == "40") {
          //  sb.Append("<INPUT TYPE='hidden' name='hosted_button_id' value='2GLRZP3DJWRG8'>");
        //}


        lblHiddenFields.Text = sb.ToString();
    }
    protected void btnConfirm_Click(object sender, EventArgs e)
    {
        Response.Redirect("OrderComplete.aspx");
    }
}
