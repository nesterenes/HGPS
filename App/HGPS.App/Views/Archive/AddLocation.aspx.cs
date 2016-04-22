using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class AddLocatiion : System.Web.UI.Page
{
    Loc ThisLoc = new Loc();

    Loc CntInfo = new Loc();    

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        FillLoc();
        SendMessage();

        //Send to Database
        try
        {
            Loc.AddNewLoc(ThisLoc);
        }
        catch (Exception ex) { }

        Response.Redirect("AddLocationSample.aspx");
    }

    protected void FillLoc() {

        ThisLoc.Name = txtLocName.Text;
        ThisLoc.Address = txtLocAddress.Text;
        ThisLoc.City = txtLocCity.Text;
        ThisLoc.State = drpLocState.SelectedValue;
        ThisLoc.Zip = txtLocZip.Text;

        String LocPhone = txtLocPhone.Text;
        LocPhone = LocPhone.Replace("-", "");
        LocPhone = LocPhone.Replace("(", "");
        LocPhone = LocPhone.Replace(")", "");
        ThisLoc.Phone = LocPhone;

        ThisLoc.Email = "";

        ThisLoc.WebSite = txtWebsite.Text;
        ThisLoc.Facebook = txtFacebook.Text;
        ThisLoc.Twitter = txtTwitter.Text;

        ThisLoc.Type = drpType.SelectedItem.Text;
        ThisLoc.Desc = txtLocDesc.Text;
        ThisLoc.PriceSum = txtPriceSum.Text;
        ThisLoc.SchedSum = txtSchedSum.Text;
        //ThisLoc.Premium = rdoCost.SelectedItem.Value;

        CntInfo.Name = txtCntFName.Text + " " + txtCntLName.Text;
        CntInfo.FName = txtCntFName.Text;
        CntInfo.LName = txtCntLName.Text;
        //CntInfo.Address = txtCntAddress.Text;
        //CntInfo.City = txtCntCity.Text;
        //CntInfo.State = drpCntState.SelectedItem.Value;
        //CntInfo.Zip = txtCntZip.Text;
        //String CntPhone = txtCntPhone.Text;

        //CntPhone = CntPhone.Replace("-", "");
        //CntPhone = CntPhone.Replace("(", "");
        //CntPhone = CntPhone.Replace(")", "");

        //CntInfo.Phone = CntPhone;
        CntInfo.Email = txtCntEmail.Text;
        CntInfo.BusName = txtCntBusName.Text;
        //CntInfo.Premium = rdoCost.SelectedItem.Value;
    
            
        string[] LatLon = { "0", "0" };

        try
        {
            LatLon = Location.GetLatLon(ThisLoc.Address, ThisLoc.City, ThisLoc.State);
        }
        catch (Exception ex) { task.ErrorLog(ex.ToString()); }

        ThisLoc.Lat = LatLon[0];
        ThisLoc.Lon = LatLon[1];

        Session["ThisLoc"] = ThisLoc;
        Session["CntInfo"] = CntInfo;        

    }

    private void SendMessage()
    {
        MailAddress from = new MailAddress(txtCntEmail.Text);
        MailAddress to = new MailAddress("neoshaffer@gmail.com");
        MailMessage message = new MailMessage(from, to);
        message.Subject = "HalloweenGPS: " + ThisLoc.Name;

        message.IsBodyHtml = true;

        string MsgBody = "<br /><b>Mssg:</b> " + txtSpecInst.Text;


        MsgBody += "<br /><b>Loc Name:</b> " + ThisLoc.Name;
        MsgBody += "<br /><b>Description:</b> " + ThisLoc.Desc;
        MsgBody += "<br /><b>Address:</b> " + ThisLoc.Address;
        MsgBody += "<br /><b>City:</b> " + ThisLoc.City;
        MsgBody += "<br /><b>State:</b> " + ThisLoc.State;
        MsgBody += "<br /><b>Zip:</b> " + ThisLoc.Zip;
        MsgBody += "<br /><b>Phone:</b> " + ThisLoc.Phone;
        MsgBody += "<br /><b>WebSite:</b> " + ThisLoc.WebSite;
        MsgBody += "<br /><b>FaceBook:</b> " + ThisLoc.Facebook;
        MsgBody += "<br /><b>Twitter:</b> " + ThisLoc.Twitter;
        MsgBody += "<br /><b>Lat:</b> " + ThisLoc.Lat;
        MsgBody += "<br /><b>Lon:</b> " + ThisLoc.Lon;
        MsgBody += "<br /><b>PriceSum:</b> " + ThisLoc.PriceSum;
        MsgBody += "<br /><b>SchedSum:</b> " + ThisLoc.SchedSum;

        MsgBody += "<br /><b>BusName:</b> " + CntInfo.BusName;
        MsgBody += "<br /><br /><b>Cnt Name:</b> " + CntInfo.Name;
        MsgBody += "<br /><b>Address:</b> " + CntInfo.Address;
        MsgBody += "<br /><b>City:</b> " + CntInfo.City;
        MsgBody += "<br /><b>Zip:</b> " + CntInfo.Zip;
        MsgBody += "<br /><b>Phone:</b> " + CntInfo.Phone;
        MsgBody += "<br /><b>Email:</b> " + CntInfo.Email;
        //MsgBody += "<br /><b>Cost:</b> " + CntInfo.Premium;

        message.Body = MsgBody;
        SmtpClient client = new SmtpClient();


        try
        {
            client.Send(message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught in SendMessage(): {0}",
                  ex.ToString());

        }
    }


}
