<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE html>
<html>
<head lang="en">
    <meta charset="UTF-8">
    <title>全部用户信息</title>
</head> 

<style>
th , td{
text-align: center;
}


</style>

<body>
<br/>
<br/>
    <div class="col-sm-1"></div>
	<div class="row col-sm-10">
		<table class="table table-hover">
	
		    <tr>
		        <th>ID</th>
		        <th>姓名</th>
		        <th>邮箱</th>
		        <th>手机号</th>
		        <th>密码</th>
		        <th>地址</th>
		    </tr>
		    <c:forEach items="${userList }" var="user">
			    <tr>
			        <td>${user.id }</td>
			        <td>${user.name }</td>
			        <td>${user.email }</td>
			        <td>${user.phone }</td>
			        <td>${user.password }</td>
			        <td>${user.address }</td>
			    </tr>
			</c:forEach>
		
		</table>


	</div>
	<div class="col-sm-1"></div>

</body>


</html>
