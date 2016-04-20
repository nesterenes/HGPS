<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/Main.master" AutoEventWireup="true" CodeFile="Main3.aspx.cs" Inherits="Main3" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

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
<asp:Content ID="Content2" ContentPlaceHolderID="ColumnRight" Runat="Server">

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
        onselectedindexchanged="drpState_SelectedIndexChanged" AutoPostBack="true">
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
<asp:Label ID="lblStateTest" runat="server" Text=""></asp:Label>

<asp:SqlDataSource ID="DS_City_SQL" runat="server" 
        ConnectionString="<%$ ConnectionStrings:CS_h8675309 %>" 
        SelectCommand="SELECT DISTINCT [LocCity], [LocState] FROM [Location] WHERE ([LocState] = @LocState)">
    <SelectParameters>
        <asp:ControlParameter ControlID="drpCity" DefaultValue="MI" 
            Name="LocState" PropertyName="SelectedValue" Type="String" />
    </SelectParameters>
    </asp:SqlDataSource>
    

<!--END ColumnRight -->
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentBody" Runat="Server">

    <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
    </asp:ToolkitScriptManager>

    <asp:DataList runat="server" id="dlMain" CssClass="row-width-50 bk-blk"
        Border="1" CellPadding="4" RepeatColumns="2" DataKeyField="UPN" 
        DataSourceID="DSHalloween_SQL" Font-Names="Verdana" BorderColor="#CCCCCC" 
        Width="75%"  >
        
        
   <ItemTemplate>
    <div class="repeater-item">
       <strong class="plus-15">
       <asp:Label ID="LocNameLabel" runat="server" Text='<%# Eval("LocName") %>' />
       </strong>
       <br />
       <asp:Label ID="LocCityLabel" runat="server" Text='<%# Eval("LocCity") %>' />, 
       <asp:Label ID="LocStateLabel" runat="server" Text='<%# Eval("LocState") %>' />
       <br />
       <br />
       
       <asp:Label ID="Label1" runat="server" Text='<%# Eval("LocDesc") %>' />
       <br /><br />
   
       
       <a href="Detail.aspx?ID=<%# Eval("UPN") %>">More Info</a>       

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
<h2 style="color:Black">Please Select Your State:</h2>
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

