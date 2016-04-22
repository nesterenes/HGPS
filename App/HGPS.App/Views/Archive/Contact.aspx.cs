using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class Contact : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSubmit_Click(object sender, EventArgs e)
    {

        if (txtHumanTest.Text.ToLower() == "yes")
        {

            SendMessage();

        }
        else { lblHumanTest.Visible = true; } 
    }


    private void SendMessage()
    {
        MailAddress from = new MailAddress(txtCntEmail.Text);
        MailAddress to = new MailAddress("neoshaffer@gmail.com");
        MailMessage message = new MailMessage(from, to);
        message.Subject = "HalloweenGPS: " + txtCntName.Text;
        string MsgBody = "<b>Name:</b> " + txtCntName.Text;
        MsgBody += "<br /><b>Email:</b> " + txtCntEmail.Text;
        MsgBody += "<br /><b>Mssg:</b> " + txtSpecInst.Text;
        message.IsBodyHtml = true;

        message.Body = MsgBody;
        SmtpClient client = new SmtpClient();
       

        try
        {
            client.Send(message);
            Response.Redirect("ContactFormout.aspx");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught in SendMessage(): {0}",
                  ex.ToString());

        }
    }

    protected void rdoReason_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rdoReason.SelectedValue == "0")
        {
            Response.Redirect("AddLocation.aspx");
        }
        else { pnlContact.Visible = true; }

    }
}
