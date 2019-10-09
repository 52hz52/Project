<%@page import="com.oracle.webservices.internal.api.EnvelopeStyle.Style"%>
<%@page import="com.msg.entity.Message"%>
<%@page import="java.util.List"%>
<%@page import="com.msg.dao.UserDao"%>
<%@page import="com.msg.entity.User"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>    
<%--  <%
  String title = request.getParameter("title");
 String cont = request.getParameter("cont");
 String uesrname = request.getParameter("uesrname");
 String state = request.getParameter("state");
 String sendto = request.getParameter("sendto");
 String date = request.getParameter("date");
  
UserDao userdao = new UserDao();
List<Message> arrayMsg = userdao.selectMsg(user.getUsername()); // 登陆账号的人接收消息 */
session.setAttribute("userdao", userdao);
  int a = userdao.UpdateState(sendto,cont);
out.println("正在阅读....");

%>
     --%>
    
    
    
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=ISO-8859-1">
<title>消息详情</title>
</head>
<body>



<%-- ${userdao.UpdateState(${param.sendto},${param.cont }) } --%>
<%-- 	${userdao.UpdateState("tom","1") } --%>
	<div id="content_div">
	<p>正在阅读......</p>
	<table id="table">
		<tr>
			<td>来至:</td>
			<td><font color="red">${param.uesrname }</font></td>
		</tr>
		<tr>
			<td>标题:</td>
			<td>${param.title }</td>
		</tr>
		
		<tr>
			<td>内容:</td>
			<td>${param.cont }</td>
		</tr>
		
		<tr>
			<td>时间:</td>
			<td>${param.date }</td>
		</tr>
		
		<tr>
			<td onclick="div_cont()">[ 回复   ]</td>
			<td onclick="div_remove()">[ 返回  ]</td>
		</tr>
	</table>
	
	</div>
	
<%-- 	
	<%
	}
	%>
 --%>
<script type="text/javascript">


function div_cont() {
	window.location.href="admin_bill_list.jsp";
}
function div_remove() {
// 	window.location.href="providerAdmin.jsp";
 	window.location.href="proMsgServlet"; 
	
	
}
</script>


</body>
</html>