<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title></title>
<link type="text/css" rel="stylesheet" href="css/style.css" />
</head>
<body class="frame-bd">
<ul class="left-menu">
	<li><a href="userAdmin.jsp" target="mainFrame"><img src="images/btn_bill.gif" /></a></li>
	<li><a href="proMsgServlet" target="mainFrame"><img src="images/btn_suppliers.gif" /></a></li>
	<li><a href="admin_bill_list.jsp" target="mainFrame"><img src="images/btn_users.gif" /></a></li>
	<li><a href="#" onClick="out()"><img src="images/btn_exit.gif" /></a></li>
</ul>
<script>
function out() {
	window.parent.location.href="login.jsp";
	//window.open('','_top');
	//window.top.close();
}

</script>
</body>

</html>
