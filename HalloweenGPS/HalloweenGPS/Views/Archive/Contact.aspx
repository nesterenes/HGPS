<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Main.master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

<title>Contact Us - Haunted Houses, Halloween Stores, Corn Mazes, and Pumpkin Patches. </title>

<style>
    .lbl {
    width:160px;
    margin-bottom:10px;
        top: 0px;
        left: 0px;
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


        

<fieldset style="min-height:400px">
<legend>Contact Form</legend>


    <p class="tmarg-20">Please select your reason for contacting us.</p>
   
    <asp:RadioButtonList ID="rdoReason" runat="server" RepeatDirection="Horizontal" 
        AutoPostBack="true" onselectedindexchanged="rdoReason_SelectedIndexChanged">
    <asp:ListItem Value="0">Add a Location</asp:ListItem>
    <asp:ListItem Value="1">Contact or Ask a Question</asp:ListItem>
    </asp:RadioButtonList>
   
    <asp:Panel ID="pnlContact" runat="server" Visible="false">    
    
    <p class="tmarg-20">Please submit your question below.</p>
    
    <div class="tmarg-30">

    <asp:Label ID="Label16" runat="server" CssClass="lbl" Text="Name"></asp:Label>
    <asp:TextBox ID="txtCntName" runat="server" CssClass="txt-sm" MaxLength="100"></asp:TextBox>    
<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" 
    CssClass="vld" ControlToValidate="txtCntName" ForeColor="#FFFFFF"></asp:RequiredFieldValidator>
    <br />
    <!-- -->   


    <asp:Label ID="Label21" runat="server" CssClass="lbl" Text="Contact Phone"></asp:Label>
    <asp:TextBox ID="txtCntPhone" runat="server" CssClass="txt-sm" MaxLength="12"></asp:TextBox>  
    <asp:MaskedEditExtender ID="MaskedEditExtender1" runat="server" TargetControlID="txtCntPhone" 
    Mask="(999)999-9999"></asp:MaskedEditExtender>
    <br />
    <!-- -->     
    
    <asp:Label ID="Label4" runat="server" CssClass="lbl" Text="Contact Email"></asp:Label>
    <asp:TextBox ID="txtCntEmail" runat="server" CssClass="txt-sm" MaxLength="100"></asp:TextBox>  
    <asp:RequiredFieldValidator ID="vldEmail" runat="server" ErrorMessage="*" 
    CssClass="vld" ControlToValidate="txtCntEmail" ForeColor="#FFFFFF"></asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="vldRegExEmail" runat="server" ControlToValidate="txtCntEmail" 
    ErrorMessage="<b>Invalid Email</b>" ForeColor="#FFFFFF" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
    CssClass="vld"></asp:RegularExpressionValidator>
    <br />
    <!-- --> 

    <asp:Label ID="Label14" runat="server" CssClass="lbl" Text="Message"></asp:Label>
    <asp:TextBox ID="txtSpecInst" runat="server" CssClass="bmarg-20 RelativeFloatLeft" MaxLength="255" 
    TextMode="MultiLine" Rows="3"></asp:TextBox>  
    <br />
    <!-- --> 

    <asp:Label ID="Label1" runat="server" CssClass="lbl" Text="Are you a human?<br />Please type the word 'yes' into the box."></asp:Label>
    <asp:TextBox ID="txtHumanTest" runat="server" CssClass="bmarg-20 txt-sm" MaxLength="3"></asp:TextBox>  
    <asp:Label ID="lblHumanTest" runat="server" CssClass="vld" ForeColor="#FFFFFF" Text="Please type 'yes'." Visible="false"></asp:Label>
    <br />
    <!-- --> 

    <div class="clearfloat">
    <asp:Button ID="btnSubmit" runat="server" Text="Send Message" 
        onclick="btnSubmit_Click" />
    </div>
    </div>
    
    </asp:Panel> <!-- END pnlTextBoxes -->


    </fieldset>    

</asp:Content>

