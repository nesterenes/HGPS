<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Main.master" AutoEventWireup="true" CodeFile="AddLocation.aspx.cs" Inherits="AddLocatiion" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

<title>Add a Location - Haunted Houses, Halloween Stores, Corn Mazes, and Pumpkin Patches. </title>

<style>
.lbl {
    width:160px;
    margin-bottom:10px;
}
#content-body 
{
min-height:615px;
}

</style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ColumnRight" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" Runat="Server">

    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>



<asp:Panel ID="pnlAddLocation" runat="server" Visible="true">
        

<fieldset>
<legend>Location Detail</legend>


    <p class="tmarg-20">This form is intended for individual locations. 
    If you are attempting to add multiple locations, feel free to contact us 
    directly for quantity pricing and bulk information loads.</p>

    <div class="col tmarg-20">

    
        <asp:Label ID="Label1" runat="server" CssClass="lbl" Text="Location Name"></asp:Label>
        <asp:TextBox ID="txtLocName" runat="server" CssClass="txt-sm" MaxLength="100"></asp:TextBox>    
        <asp:RequiredFieldValidator ID="vldFName" runat="server" Text="*" ErrorMessage="Location Name Required" 
        CssClass="vld" ControlToValidate="txtLocName" ForeColor="#FFFFFF"></asp:RequiredFieldValidator>
        <br />
        <!-- -->    

        <asp:Label ID="Label5" runat="server" CssClass="lbl" Text="Street Address"></asp:Label>
        <asp:TextBox ID="txtLocAddress" runat="server" CssClass="txt-sm" MaxLength="100"></asp:TextBox>    
        <asp:RequiredFieldValidator ID="VldAdrStr" runat="server" Text="*" ErrorMessage="Location Address Required" 
        CssClass="vld" ControlToValidate="txtLocAddress" ForeColor="#FFFFFF"></asp:RequiredFieldValidator>
        <br />
        <!-- -->    

        <asp:Label ID="Label6" runat="server" CssClass="lbl" Text="City"></asp:Label>
        <asp:TextBox ID="txtLocCity" runat="server" CssClass="txt-sm" MaxLength="100"></asp:TextBox>
        <asp:RequiredFieldValidator ID="VldAdrCity" runat="server" Text="*" ErrorMessage="Location City Required" 
        CssClass="vld" ControlToValidate="txtLocCity" ForeColor="#FFFFFF"></asp:RequiredFieldValidator>
        <br />


        <!-- -->    

        <asp:Label ID="Label7" runat="server" CssClass="lbl" Text="State"></asp:Label>

        <asp:DropDownList ID="drpLocState" runat="server" CssClass="txt-sm" CausesValidation="true">
            <asp:ListItem Value="" Selected="True"></asp:ListItem>
            <asp:ListItem Value="AL">Alabama</asp:ListItem>
            <asp:ListItem Value="AK">Alaska</asp:ListItem>
            <asp:ListItem Value="AZ">Arizona</asp:ListItem>
            <asp:ListItem Value="AR">Arkansas</asp:ListItem>
            <asp:ListItem Value="CA">California</asp:ListItem>
            <asp:ListItem Value="CO">Colorado</asp:ListItem>
            <asp:ListItem Value="CT">Connecticut</asp:ListItem>
            <asp:ListItem Value="DC">District of Columbia</asp:ListItem>
            <asp:ListItem Value="DE">Delaware</asp:ListItem>
            <asp:ListItem Value="FL">Florida</asp:ListItem>
            <asp:ListItem Value="GA">Georgia</asp:ListItem>
            <asp:ListItem Value="HI">Hawaii</asp:ListItem>
            <asp:ListItem Value="ID">Idaho</asp:ListItem>
            <asp:ListItem Value="IL">Illinois</asp:ListItem>
            <asp:ListItem Value="IN">Indiana</asp:ListItem>
            <asp:ListItem Value="IA">Iowa</asp:ListItem>
            <asp:ListItem Value="KS">Kansas</asp:ListItem>
            <asp:ListItem Value="KY">Kentucky</asp:ListItem>
            <asp:ListItem Value="LA">Louisiana</asp:ListItem>
            <asp:ListItem Value="ME">Maine</asp:ListItem>
            <asp:ListItem Value="MD">Maryland</asp:ListItem>
            <asp:ListItem Value="MA">Massachusetts</asp:ListItem>
            <asp:ListItem Value="MI">Michigan</asp:ListItem>
            <asp:ListItem Value="MN">Minnesota</asp:ListItem>
            <asp:ListItem Value="MS">Mississippi</asp:ListItem>
            <asp:ListItem Value="MO">Missouri</asp:ListItem>
            <asp:ListItem Value="MT">Montana</asp:ListItem>
            <asp:ListItem Value="NE">Nebraska</asp:ListItem>
            <asp:ListItem Value="NV">Nevada</asp:ListItem>
            <asp:ListItem Value="NH">New Hampshire</asp:ListItem>
            <asp:ListItem Value="NJ">New Jersey</asp:ListItem>
            <asp:ListItem Value="NM">New Mexico</asp:ListItem>
            <asp:ListItem Value="NY">New York</asp:ListItem>
            <asp:ListItem Value="NC">North Carolina</asp:ListItem>
            <asp:ListItem Value="ND">North Dakota</asp:ListItem>
            <asp:ListItem Value="OH">Ohio</asp:ListItem>
            <asp:ListItem Value="OK">Oklahoma</asp:ListItem>
            <asp:ListItem Value="OR">Oregon</asp:ListItem>
            <asp:ListItem Value="PA">Pennsylvania</asp:ListItem>
            <asp:ListItem Value="RI">Rhode Island</asp:ListItem>
            <asp:ListItem Value="SC">South Carolina</asp:ListItem>
            <asp:ListItem Value="SD">South Dakota</asp:ListItem>
            <asp:ListItem Value="TN">Tennessee</asp:ListItem>
            <asp:ListItem Value="TX">Texas</asp:ListItem>
            <asp:ListItem Value="UT">Utah</asp:ListItem>
            <asp:ListItem Value="VT">Vermont</asp:ListItem>
            <asp:ListItem Value="VA">Virginia</asp:ListItem>
            <asp:ListItem Value="WA">Washington</asp:ListItem>
            <asp:ListItem Value="WV">West Virginia</asp:ListItem>
            <asp:ListItem Value="WI">Wisconsin</asp:ListItem>
            <asp:ListItem Value="WY">Wyoming</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator InitialValue="" ID="RequiredFieldValidator9" runat="server" CssClass="vld" Visible="true"
        ControlToValidate="drpLocState" Text="*" ErrorMessage="Location State Required" ForeColor="#FFFFFF"></asp:RequiredFieldValidator>
        <br />
        <!-- -->    
        
        <asp:Label ID="Label8" runat="server" CssClass="lbl" Text="Zip Code"></asp:Label>
        <asp:TextBox ID="txtLocZip" runat="server" CssClass="txt-sm" MaxLength="10"></asp:TextBox> 
        <asp:RequiredFieldValidator ID="VldReqZip" runat="server" ControlToValidate="txtLocZip" 
        Text="*" ErrorMessage="Location Zip Code Required" CssClass="vld" Forecolor="#FFFFFF"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="VldZip" runat="server" 
            ErrorMessage="<b>Invalid Zip Code</b>" ControlToValidate="txtLocZip"  ForeColor="#FFFFFF"
            ValidationExpression="\d{5}(-\d{4})?" CssClass="vld"></asp:RegularExpressionValidator>
        <asp:FilteredTextBoxExtender ID="VldAjaxZip" runat="server"
            TargetControlID="txtLocZip" FilterType="Custom, Numbers" ValidChars="-">
        </asp:FilteredTextBoxExtender>
        <br />
        <!-- -->    

        <asp:Label ID="Label3" runat="server" CssClass="lbl" Text="Location Phone"></asp:Label>
        <asp:TextBox ID="txtLocPhone" runat="server" CssClass="txt-sm" MaxLength="12"></asp:TextBox>  
        <asp:MaskedEditExtender ID="vldAjaxPhone" runat="server" TargetControlID="txtLocPhone" 
        Mask="(999)999-9999"></asp:MaskedEditExtender>
        <br />
        <!-- -->     


        <asp:Label ID="Label2" runat="server" CssClass="lbl" Text="Web Site"></asp:Label>
        <asp:TextBox ID="txtWebsite" runat="server" CssClass="txt-sm" MaxLength="50"></asp:TextBox>  
        <br />
        <!-- -->   

        <asp:Label ID="Label10" runat="server" CssClass="lbl" Text="Facebook Address"></asp:Label>
        <asp:TextBox ID="txtFacebook" runat="server" CssClass="txt-sm" MaxLength="100"></asp:TextBox>  
        <!-- -->        
            
            
        <asp:Label ID="Label11" runat="server" CssClass="lbl" Text="Twitter Address"></asp:Label>
        <asp:TextBox ID="txtTwitter" runat="server" CssClass="txt-sm" MaxLength="100"></asp:TextBox>  
        <!-- -->  
 
        </div>  
        
        
        <div class="col tmarg-20">

        <asp:Label ID="Label9" runat="server" CssClass="lbl" Text="Location Type"></asp:Label>
        <asp:DropDownList ID="drpType" runat="server"  CssClass="txt-sm">
            <asp:ListItem Value="" Selected="True"></asp:ListItem>
            <asp:ListItem Value='1'>Haunted House</asp:ListItem>
            <asp:ListItem Value='2'>Halloween Store</asp:ListItem>
            <asp:ListItem Value='3'>Pumpkin Patch</asp:ListItem>
            <asp:ListItem Value='4'>Corn Maze</asp:ListItem>
        </asp:DropDownList>
        <asp:RequiredFieldValidator InitialValue="" ID="RequiredFieldValidator10" runat="server" CssClass="vld" 
        ControlToValidate="drpType" Text="*" ErrorMessage="Location Type Required" ForeColor="#FFFFFF"></asp:RequiredFieldValidator>
        <br />
        <!-- -->   

        <asp:Label ID="Label23" runat="server" CssClass="lbl" Text="Location Description"></asp:Label>
        <asp:TextBox ID="txtLocDesc" runat="server" CssClass="txt-sm bmarg-20" MaxLength="255" 
        TextMode="MultiLine" Rows="3" Columns="500"></asp:TextBox>  
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Text="*" ErrorMessage="Location Description Required" 
        CssClass="vld" ControlToValidate="txtLocDesc" ForeColor="#FFFFFF"></asp:RequiredFieldValidator>
        <!-- -->       

        <asp:Label ID="Label12" runat="server" CssClass="lbl" Text="Price Summary"></asp:Label>
        <asp:TextBox ID="txtPriceSum" runat="server" CssClass="txt-sm bmarg-20" MaxLength="255" 
        TextMode="MultiLine" Rows="3"></asp:TextBox>  
        <asp:RequiredFieldValidator ID="vldLName" runat="server" Text="*" ErrorMessage="Pricing Summary Required" 
        CssClass="vld" ControlToValidate="txtPriceSum" ForeColor="#FFFFFF"></asp:RequiredFieldValidator>
        <!-- -->       

        <asp:Label ID="Label13" runat="server" CssClass="lbl" Text="Hours Summary"></asp:Label>
        <asp:TextBox ID="txtSchedSum" runat="server" CssClass="txt-sm bmarg-20" MaxLength="255" 
        TextMode="MultiLine" Rows="4"></asp:TextBox>  
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" Text="*" ErrorMessage="Schedule Summary Required" 
        CssClass="vld" ControlToValidate="txtSchedSum" ForeColor="#FFFFFF"></asp:RequiredFieldValidator>
        <!-- -->     

    <br />

    </div>

</fieldset>        
   
    <fieldset class="tmarg-20">
    <legend>Contact Information</legend>
    
    <p class="tmarg-20">Contact information is used for correspondence only. 
    The below information will <b>not be published publicly</b>.</p>
    
    <div class="col tmarg-30">
    
    
        <asp:Label ID="Label15" runat="server" CssClass="lbl" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtCntFName" runat="server" CssClass="txt-sm" MaxLength="50"></asp:TextBox>    
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="*" ErrorMessage="Contact First Name Required" 
        CssClass="vld" ControlToValidate="txtCntFName" ForeColor="#FFFFFF"></asp:RequiredFieldValidator>
        <br />
        <!-- -->    
   
        <asp:Label ID="Label22" runat="server" CssClass="lbl" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtCntLName" runat="server" CssClass="txt-sm" MaxLength="50"></asp:TextBox>    
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Text="*" ErrorMessage="Contact Last Name Required"
        CssClass="vld" ControlToValidate="txtCntLName" ForeColor="#FFFFFF"></asp:RequiredFieldValidator>
        <br />
        <!-- -->    


        <asp:Label ID="Label16" runat="server" CssClass="lbl" Text="Business Name"></asp:Label>
        <asp:TextBox ID="txtCntBusName" runat="server" CssClass="txt-sm" MaxLength="100"></asp:TextBox>    
        <br />
        <!-- -->   

    
    <asp:Label ID="Label4" runat="server" CssClass="lbl" Text="Contact Email"></asp:Label>
    <asp:TextBox ID="txtCntEmail" runat="server" CssClass="txt-sm" MaxLength="100"></asp:TextBox>  
    <asp:RequiredFieldValidator ID="vldEmail" runat="server" Text="*" ErrorMessage="Contact Email Required" 
    CssClass="vld" ControlToValidate="txtCntEmail" ForeColor="#FFFFFF"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="vldRegExEmail" runat="server" ControlToValidate="txtCntEmail" 
    ErrorMessage="<b>Invalid Email</b>" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
    CssClass="vld" ForeColor="#FFFFFF"></asp:RegularExpressionValidator>
    <br />
    <!-- --> 

    <asp:Label ID="Label14" runat="server" CssClass="lbl" Text="Notes / Special Instructions"></asp:Label>
    <asp:TextBox ID="txtSpecInst" runat="server" CssClass="txt-sm bmarg-20" MaxLength="255" 
    TextMode="MultiLine" Rows="3"></asp:TextBox>  
    <!-- --> 



</div>

<div class="col tmarg-30">

    </div>

    <div align="right" style="clear:left; width: 95%; margin: 30px 0px 0 0">
    <asp:Button ID="btnSubmit" runat="server" Text="Review & Confirm Info" 
        Visible="true" CausesValidation="true" onclick="btnSubmit_Click" />
    </div>


    </fieldset>    


    </asp:Panel> <!-- END pnlAddLocation -->


</asp:Content>

