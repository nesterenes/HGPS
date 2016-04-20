<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Main.master" AutoEventWireup="true" CodeFile="AddLocationSample.aspx.cs" Inherits="AddLocationSample" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

<title>Add a Location Sample - Haunted Houses, Halloween Stores, Corn Mazes, and Pumpkin Patches. </title>

<meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
<script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>



<script type="text/javascript">



</script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ColumnRight" Runat="Server">

<div style="position:relative; float:left; margin-left: -330px;">

<artem:GoogleMap CssClass="bk" ID="GoogleMap1" runat="server" Width="300px" Height="300px" 
 Address="USA" Key="AIzaSyA2irsnGcaVEZLG38Qda13mABZXfWE5kTA" Zoom="5">
</artem:GoogleMap>
</div>
<!--END ColumnRight -->

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" Runat="Server">

<fieldset style="margin:0px 10px 15px 0; width:42%; position:relative; float:left">
<legend>Preview</legend>
<p class="bmarg-20">Your information is previewed below. Please double check this information 
then click the yes button to submit your information.</p> 

<p class="bmarg-20">If your map location is not displaying properly, then please <a href="Contact.aspx">contact us</a> and 
we'll work with you directly to customize the posting.</p>

<asp:Label ID="lblHiddenFields" runat="server" Text=""></asp:Label>


<b>
<asp:Button ID="btnConfirm" runat="server" Text="Yes - this information is correct" 
        onclick="btnConfirm_Click" />
<!--<asp:LinkButton ID="adfadfadf" runat="server" href="javascript:theForm.__VIEWSTATE.value='';theForm.encoding='application/x-www-form-urlencoded';theForm.action='https://www.paypal.com/cgi-bin/webscr';theForm.submit();">Select Payment Method</asp:LinkButton> -->
</b>

</fieldset>

<div style="margin:0px 10px 15px 0; width:42%; position:relative; float:left">


            <br />
            <h3>
            <asp:Label ID="lblName" runat="server" Text="" />
            </h3>
            <br />
            
            
            <!-- ~~~~~~~~~~~ -->
            <div class="bmarg-20 txt-detail">
            <asp:Label ID="lblDesc" runat="server" Text="" />
            </div>
            
            
            <!-- ~~~~~~~~~~~ -->
            <span class="lbl">Address:</span>
            <div class="bmarg-20 txt-detail">
            <asp:Label ID="lblAddress" runat="server" 
                Text='<%# Eval("LocAddress") %>' /><br /> 
                <asp:Label ID="lblCity" runat="server" Text="" /> 
                <asp:Label ID="lblState" runat="server" Text="" /> 
                <asp:Label ID="lblZip" runat="server" Text="" /><br />
                <asp:Label ID="lblGetDirections" runat="server" Text="" />
            </div>
            <br />


            <!-- ~~~~~~~~~~~ -->            
            <span class="lbl">Type:</span>
            <div class="bmarg-20 txt-detail">
            <asp:Label ID="lblType" runat="server" Text="" />
            </div>
   

            <!-- ~~~~~~~~~~~ -->            
            <span class="lbl">Phone:</span>
            <div class="bmarg-20 txt-detail">
            <asp:Label ID="lblPhone" runat="server" Text="" />
            </div>
            
            <!-- ~~~~~~~~~~~ -->             
            <span class="lbl">Web Site:</span>
            <div class="bmarg-20 txt-detail">
            <asp:Label ID="lblWebSite" runat="server" Text="" />
            </div>
            <br />


            <!-- ~~~~~~~~~~~    
            <span class="lbl">Email:</span>
            <div class="bmarg-20 txt-detail">
            <asp:Label ID="LocEmail" runat="server" Text="" />
            </div>
            --> 
            
            <!-- ~~~~~~~~~~~ -->    
            <span class="lbl">Facebook:</span>
            <div class="bmarg-20 txt-detail">
            <asp:Label ID="lblFacebook" runat="server" Text="" />
            </div>
            
            
            <!-- ~~~~~~~~~~~ -->    
            <span class="lbl">Twitter:</span>
            <div class="bmarg-20 txt-detail">
            <asp:Label ID="lblTwitter" runat="server" 
                Text="" />
            </div>
            
            
            <!-- ~~~~~~~~~~~ -->    
            <span class="lbl">Coupon:</span>
            <div class="bmarg-20 txt-detail">
            <asp:Label ID="lblCoupon" runat="server" Text="" />
            </div>
            
            
            <!-- ~~~~~~~~~~~ -->    
            <span class="lbl">Price:</span>
            <div class="bmarg-20 txt-detail">
            <asp:Label ID="lblPrice" runat="server" Text="" />
            </div>
            
            
            <!-- ~~~~~~~~~~~ -->    
            <span class="lbl">Hours:</span>
            <div class="bmarg-20 txt-detail">
            <asp:Label ID="lblSchedSum" runat="server" Text="" />
            </div>
            <br />

            <br />


</div>



<br class="clearfloat" />

</asp:Content>



