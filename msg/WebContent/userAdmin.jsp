<%@page import="com.msg.entity.User"%>
<%@page import="com.msg.entity.Message"%>
<%@page import="java.util.List"%>
<%@page import="com.msg.dao.UserDao"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
 <%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>   
<html><head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Insert title here</title>
<link type="text/css" rel="stylesheet" href="css/style.css">
<script type="text/javascript">
function doit(flag,id)
{
	if(flag=="del")
	{
		if(confirm("确认删除吗？")!=true)
			return;
	}
}
</script>
</head><body>

<div class="menu">

<table>
<tbody><tr><td>
<form method="post" action="">
<input name="flag" value="search" type="hidden"></form></td></tr>
</tbody></table>
</div>
<div class="main">

<div class="optitle clearfix">

		<div class="title">消息管理&gt;&gt;</div>
	</div>
	<div class="content">
<table class="list">
		<tr>
			<td>编号</td>
			<td>标题</td>
			<td>内容</td>
			<td>接收人</td>
			<td>时间</td>
		</tr>
	
	 <c:forEach items="${listMsg }" var="listMsg"> 
	    <tr>
			<td>${listMsg.msgid }</td>
			<td>${listMsg.title }</td>
			<td>${listMsg.msgcontent }></td>
			<td>${listMsg.sendto }</td>
			<td>${listMsg.msgCreateDate }</td>
		</tr>
	 
	 </c:forEach>
		
	 
	 

 </table>
</div>
</div>
</body></html>