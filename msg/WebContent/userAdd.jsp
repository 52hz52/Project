<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<html xmlns="http://www.w3.org/1999/xhtml">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Insert title here</title>
<link type="text/css" rel="stylesheet" href="css/style.css">
<script type="text/javascript" src="js/jquery-1.12.4.min.js"></script>
<script type="text/javascript">


	$(function(){

		$("#username").blur(function () {
           var name = $(this).val();
			$.ajax(
				{
					"url":"loginOkServlet",
					"type":"POST",
					"data":"u="+name,
					success:function (restext) {
					    if(restext==0){
                            $("#username").next().text("该用户名可以使用");
						}else if(restext==1) {
                            $("#username").next().text("该用户名已被占用");
						}
                    }


				}
			)
        });

	});























function checkit()
{
	//判断是否是数字的正则表达式
	return true;
}
</script>
</head>
<body>
<div class="main">
	<div class="optitle clearfix">
		<div class="title">用户注册&gt;&gt;</div>

	</div>
	<form id="form1" name="form1" method="post" action="doreg">
		<div class="content">
			<div>
				<%
					String reginfo  = (String)session.getAttribute("reginfo");
					if(reginfo!=null){
						%>
						 <p style="color:red"><%=reginfo%></p>
						<%
					}
				%>
			</div>
			<table class="box"><font color="red"></font>
			
			<tr>
					<td class="field">用户名称：</td>
					<td><input type="text" name="username" class="text" id="username" /> <span color="red">*</span></td>
				</tr>
				<tr>
					<td class="field">用户密码：</td>

					<td><input type="password" name="password" class="text" id="textfield2" /> <span color="red">*</span></td>
				</tr>
			<tr>
					<td class="field">确认密码：</td>
					<td><input type="password" name="password1" class="text"/> <span color="red">*</span></td>
				</tr>

				

				<tr>
					<td class="field">用户邮箱：</td>
					<td><input type="text" name="email" class="text" id="textfield2"/> <span color="red">*</span></td>

				</tr>

	
			</table>
		</div>
		<div class="buttons">
			 <input type="submit" name="button" id="button" value="注册" class="input-button"/>
			  <input type="button" name="button" id="button" onclick="window.location='user.do';" value="返回" class="input-button"/> 
		</div>

	</form>
</div>
</body>
</html>
