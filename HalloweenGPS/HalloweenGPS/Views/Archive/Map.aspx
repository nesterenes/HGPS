<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Main.master" AutoEventWireup="true" CodeFile="Map.aspx.cs" Inherits="Test_Map2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

<title>Location Map - Find Haunted Houses, Halloween Stores, Corn Mazes, and Pumpkin Patches. </title>

<!DOCTYPE html>
<meta name="viewport" content="initial-scale=1.0, user-scalable=no" />
<script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>

<style>
.lbl {
    width:160px;
    margin-bottom:10px;
}
#content-body 
{
min-height:615px;
}

.bk 
{
    color:#000000;
}

</style>


</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ColumnRight" Runat="Server">


<!--END ColumnRight -->
</asp:Content> 

<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" Runat="Server">
<br />
<div style="float:left; position:relative">
<artem:GoogleMap CssClass="bk" ID="GoogleMap1" runat="server" Width="720px" Height="600px" 
Key="AIzaSyA2irsnGcaVEZLG38Qda13mABZXfWE5kTA" Zoom="6">
</artem:GoogleMap>
</div>


</asp:Content>

