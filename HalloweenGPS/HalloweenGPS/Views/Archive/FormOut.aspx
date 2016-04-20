<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormOut.aspx.cs" Inherits="FormOut" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

<INPUT TYPE='hidden' NAME='first_name' VALUE='John'>
<INPUT TYPE="hidden" NAME="address1" VALUE="9 Elm Street">
<input type="hidden" name="cmd" value="_s-xclick">
<input type="hidden" name="hosted_button_id" value="AE9PBCPENAB9J">
<table>
<tr><td><input type="hidden" name="on0" value="Options">Options</td></tr>
<tr><td><select name="os0">
	<option value="Web Site Only">Web Site Only$10.00 USD</option>
	<option value="Mobile App &amp; Web Site">Mobile App &amp; Web Site$40.00 USD</option>
</select> </td></tr>
</table>
<input type="hidden" name="currency_code" value="USD">
<a id="paypal_btn" href="javascript:theForm.__VIEWSTATE.value='';theForm.encoding='application/x-www-form-urlencoded';theForm.action='https://www.paypal.com/cgi-bin/webscr';theForm.submit();"><img src="https://www.paypalobjects.com/en_US/i/btn/btn_buynowCC_LG.gif" border="0"></a>
<img alt="" border="0" src="https://www.paypalobjects.com/en_US/i/scr/pixel.gif" width="1" height="1">    
    
    
    </form>
</body>
</html>
