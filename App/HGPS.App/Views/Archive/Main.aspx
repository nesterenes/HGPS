<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Main.master" AutoEventWireup="true" CodeFile="Main.aspx.cs" Inherits="Main" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

<title>Find Haunted Houses, Halloween Stores, Corn Mazes, and Pumpkin Patches. </title>

    <style type="text/css">
table {
    border: solid 1px #BBBBBB;
}
    
td {
    border-color:#BBBBBB;
}

</style>

<link href="css/AjaxStyles.css" rel="stylesheet" type="text/css" />

<!-- BEGIN Page specific Java Script  -->

<!-- END Page specific JavaScript  -->

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ColumnRight" Runat="Server" class="bk-blk" >

    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>

<strong>
Sort by City:
</strong> 

<br /> 

<asp:DropDownList ID="drpCity" runat="server" AutoPostBack="True" 
    DataSourceID="DS_City_SQL" DataTextField="LocCity" onselectedindexchanged="drpCity_SelectedIndexChanged"
    DataValueField="LocCity" AppendDataBoundItems="True">
    <asp:ListItem>All</asp:ListItem>
</asp:DropDownList>
<br /> 
<br /> 
<strong>
Select a different State:
</strong> 
        <asp:DropDownList ID="drpState" runat="server" CssClass="txt-sm"  
         DataSourceID="DS_State_All_Rt" DataTextField="LocState" DataValueField="LocState"
         AppendDataBoundItems="true" onselectedindexchanged="drpState_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem Value="" Selected="True"></asp:ListItem>
        </asp:DropDownList>
<asp:Label ID="lblStateTest" runat="server" Text=""></asp:Label>

<asp:SqlDataSource ID="DS_City_SQL" runat="server" 
        ConnectionString="<%$ ConnectionStrings:CS_h8675309 %>" 
        SelectCommand="SELECT DISTINCT [LocCity], [LocState] FROM [Location] WHERE ([LocState] = @LocState)">
    <SelectParameters>
        <asp:ControlParameter ControlID="drpCity" DefaultValue="MI" 
            Name="LocState" PropertyName="SelectedValue" Type="String" />
    </SelectParameters>
    </asp:SqlDataSource>
    
    <asp:SqlDataSource ID="DS_State_All_Rt" runat="server" 
        ConnectionString="<%$ ConnectionStrings:CS_h8675309 %>" 
        SelectCommand="SELECT DISTINCT [LocState] FROM [Location]">
    </asp:SqlDataSource>

<!--END ColumnRight -->
</asp:Content> 

<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" Runat="Server">


    <asp:DataList runat="server" id="dlMain" CssClass="row-width-50 bk-blk"
        Border="1" CellPadding="4" RepeatColumns="2" DataKeyField="UPN" 
        DataSourceID="DSHalloween_SQL" Font-Names="Verdana" BorderColor="#CCCCCC" 
        Width="75%"  >
        
        
   <ItemTemplate>
    <div class="repeater-item">
       <h4>
       <asp:Label ID="LocNameLabel" runat="server" Text='<%# Eval("LocName") %>' />
       </h4>
       <p>
       <asp:Label ID="LocCityLabel" runat="server" Text='<%# Eval("LocCity") %>' />, 
       <asp:Label ID="LocStateLabel" runat="server" Text='<%# Eval("LocState") %>' />
       <br />
       <br />
       
       <asp:Label ID="Label1" runat="server" Text='<%# Eval("LocDesc") %>' />
       <br /><br />
   
       
       <a href="Detail.aspx?ID=<%# Eval("UPN") %>">More Info</a>       

       </p>
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
<h2 style="color:Black">Please Select Your State:</h2>
<br />

    <asp:DropDownList ID="drpStateSelector" runat="server" AutoPostBack="True" 
        onselectedindexchanged="drpStateSelector_SelectedIndexChanged" 
         DataSourceID="DS_States_All" DataTextField="LocState" DataValueField="LocState"
        AppendDataBoundItems="true">
        <asp:ListItem Value=""></asp:ListItem>
    </asp:DropDownList>
    <br /><br /><br />

</div>

</asp:Panel>

<!-- END  Modal Popup 'State Selector' -->

    <asp:SqlDataSource ID="DS_States_All" runat="server" 
        ConnectionString="<%$ ConnectionStrings:CS_h8675309 %>" 
        SelectCommand="SELECT DISTINCT [LocState] FROM [Location]">
    </asp:SqlDataSource>


</asp:Content>