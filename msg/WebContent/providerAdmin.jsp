<%@page import="org.apache.jasper.tagplugins.jstl.core.ForEach"%>
<%@page import="java.util.List"%>
<%@page import="com.msg.entity.Message"%>
<%@page import="com.msg.entity.User"%>
<%@page import="com.msg.dao.UserDao"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c" %>


<html xmlns="http://www.w3.org/1999/xhtml">
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
	window.location = "provider.do?id="+id+"&flag="+flag;
}
</script>
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
<div class="optitle clearfix">
<!-- <em><input value="添加数据" class="input-button" onclick="window.location='providerAdd.html'" type="button"></em> -->
		<div class="title">接收消息&gt;&gt;</div>
	</div>

    
	<div class="content" id="content">
     <table id="">
		<tr>
			<td>编号</td>
			<td>标题</td>
			<td>发送人</td>
			<td>状态</td>
			<td>时间</td>
			
		</tr>

	<c:forEach items="${arrayMsgs }" var="arrayMsg">
		<tr id="tr_remo">
			<td>${arrayMsg.msgid }</td>
			<td>${arrayMsg.title }</td>
			<td>${arrayMsg.username }</td>
			<td>
	  			<c:if test="${arrayMsg.state==0}"><img src='images/sms_readed.png' alt='已读状态' /></c:if>
	  			<c:if test="${arrayMsg.state==1}"><img src='images/sms_unReaded.png' alt='未读状态' /></c:if> 			
	  		</td>
			<td>${arrayMsg.msgCreateDate }</td>
			<td class="right_div"> 
	    		<a href="contServlet?title=${arrayMsg.title }
	   			 &cont=${arrayMsg.msgcontent }&uesrname=${arrayMsg.username }
	  			 &state=${arrayMsg.state }&sendto=${arrayMsg.sendto }
	   			 &date=${arrayMsg.msgCreateDate }
	    		">[ 详情   ]</a>
	    
	    	</td>
			<td class="right_div" onclick="delMsg(${arrayMsg.msgid })" > <a herf="#">[ 删除  ]</a></td>
		</tr>
	</c:forEach>
		
	
	
	
		
		
<%-- 	<%
	}
	%> --%>
		</table>
	<div>
	   <!--  var son_p = document.getElementById("tr_remo");
		son_p.remove(); -->
	
	<script type="text/javascript">
	function delMsg(id) {
		 window.location.href="delMsg?id="+id;
	}
	
	</script>



	</div>
</div>
</body></html>