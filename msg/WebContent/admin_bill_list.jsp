<%@page import="java.util.List"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@page import="com.msg.entity.Message"%>
<%@page import="com.msg.entity.User"%>
<%@page import="com.msg.dao.UserDao"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>
 <%
 request.setCharacterEncoding("UTF-8");
 response.setCharacterEncoding("UTF-8");
%>
 
 
 
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
<title></title>
<link type="text/css" rel="stylesheet" href="css/style.css" />
</head>
<body>
<div class="menu">

<table>
<tbody><tr><td>
<form method="post" action="">
<input name="flag" value="search" type="hidden"></form></td></tr>
</tbody></table>
</div>

<div class="main">
<form action="sendServlet" method="post">
	<div class="optitle clearfix">
		<div class="title">发送消息&gt;&gt;
			<select  name="sendto" style="float:right; width: 70px ; height: 30px">
				<option>发送给:</option> 
				<c:forEach items="${listuser }" var="lis"> 
				<option value="${lis.username }">${lis.username }</option>
				</c:forEach>
			</select>
		</div>
	</div>
	<div class="content"><!-- list -->

			<p style="width: 500px; height: 50px; line-height: 50px;">标题:<input type="text" name="send_title"></p>
			<p><textarea rows="10" cols="60" name="send_content" style="margin-left: 30px" >请编辑发送的内容哦......</textarea></p>
   			<p  style="width: 200px;"><input style="width: 100px;margin: 20px 10px 10px 280px " type="submit" value="发送" ></p>

		

  </form>

<%-- 	  <%  
  if(row!=null&&row!=0+""){
      %>
       --%>
      <c:if test="${not empty row_s }">
      <p>>>>> 发送成功.... </p>  
      </c:if>
    <%
	 session.setAttribute("row_s", null); 
   %> 
   
	</div>
</div>
</body>
</html>
