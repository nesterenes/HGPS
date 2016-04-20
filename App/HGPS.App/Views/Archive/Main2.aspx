<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Main.master" AutoEventWireup="true" CodeFile="Main2.aspx.cs" Inherits="Main2" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

    <style type="text/css">
table {
    border: solid 1px #FFFFFF;
}
    
td {
    border-color:#FFFFFF;
}

</style>

<link href="css/AjaxStyles.css" rel="stylesheet" type="text/css" />

<!-- BEGIN Page specific Java Script  -->

<!-- END Page specific JavaScript  -->

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ColumnRight" Runat="Server">

    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>

    <asp:Button ID="btnRunLatLon" runat="server" Text="btnRunLatLon" 
        onclick="btnRunLatLon_Click" />

<strong>
Sort by City:
</strong> 

<br /> 

<asp:DropDownList ID="drpCity" runat="server" AutoPostBack="True" 
    DataSourceID="DS_City_SQL" DataTextField="LocCity" 
    DataValueField="LocCity" AppendDataBoundItems="True">
    <asp:ListItem>All</asp:ListItem>
</asp:DropDownList>
<br /> 
<br /> 

<asp:Label ID="lblStateTest" runat="server" Text=""></asp:Label>

<asp:SqlDataSource ID="DS_City_SQL" runat="server" 
        ConnectionString="<%$ ConnectionStrings:CS_h8675309 %>" 
        SelectCommand="SELECT DISTINCT [LocCity], [LocState] FROM [Location] WHERE ([LocState] = @LocState)">
    <SelectParameters>
        <asp:ControlParameter ControlID="lblStateTest" DefaultValue="MI" 
            Name="LocState" PropertyName="Text" Type="String" />
    </SelectParameters>
    </asp:SqlDataSource>
    

<!--END ColumnRight -->
</asp:Content> 

<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" Runat="Server">


    <asp:DataList runat="server" id="dlMain" 
        Border="1" CellPadding="4" RepeatColumns="2" DataKeyField="UPN" 
        DataSourceID="DSHalloween_SQL" Font-Names="Verdana" BorderColor="#ffffff" Width="75%" >
        
   <ItemTemplate>
    <div class="repeater-item">
       <strong>
       <asp:Label ID="LocNameLabel" runat="server" Text='<%# Eval("LocName") %>' />
       </strong>
       <br />
       <asp:Label ID="LocCityLabel" runat="server" Text='<%# Eval("LocCity") %>' />, 
       <asp:Label ID="LocStateLabel" runat="server" Text='<%# Eval("LocState") %>' />
       <br />
       <br />
       
       <asp:Label ID="Label1" runat="server" Text='<%# Eval("LocDesc") %>' />
       <br /><br />
   
       
       <a href="Detail_V2.aspx?ID=<%# Eval("UPN") %>">More Info</a>       

       <br />
       <br />
    </div>
   </ItemTemplate>
</asp:DataList> 


    <asp:SqlDataSource ID="DSHalloween_SQL" runat="server" 
        ConnectionString="<%$ ConnectionStrings:CS_h8675309 %>" 
        SelectCommand="SELECT DISTINCT * FROM [Location] WHERE (([LocAddress] IS NOT NULL) AND ([LocName] IS NOT NULL))"></asp:SqlDataSource>



<!-- BEGIN Modal Popup 'State Selector' -->

<asp:ModalPopupExtender ID="ModalStateSelector" runat="server" 
DynamicServicePath="" Enabled="True" BackgroundCssClass="modalBackground"
PopupControlID="pnlStateSelector" TargetControlID="pnlStateSelector" DropShadow="true">
</asp:ModalPopupExtender>

<asp:Panel ID="pnlStateSelector" runat="server" CssClass="ModalBox" style="display:none;" >

<div style="margin:15px">
<br />
<h2>Please Select Your State:</h2>
<br />

    <asp:DropDownList ID="drpStateSelector" runat="server" AutoPostBack="True" 
        onselectedindexchanged="drpStateSelector_SelectedIndexChanged">
        <asp:ListItem Value=""></asp:ListItem>
        <asp:ListItem Value="CA">California</asp:ListItem>
        <asp:ListItem Value="CO">Colorado</asp:ListItem>
        <asp:ListItem Value="GA">Georgia</asp:ListItem>
        <asp:ListItem Value="MI">Michigan</asp:ListItem>
    </asp:DropDownList>
    <br /><br /><br />

</div>

</asp:Panel>

<!-- END  Modal Popup 'State Selector' -->





</asp:Content>
