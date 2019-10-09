<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head lang="en">
    <meta charset="UTF-8">
    <title>支付成功</title>
	<link rel="stylesheet" href="${pageContext.request.contextPath }/statics/css/User/Buybook.css">
</head> 

<body>



	<div style="margin-top:10%">

		<img src="${pageContext.request.contextPath }/statics/img/pay/success.png" class="center-block text-center">

		<h1 class="text-center">购买成功</h1>

		<h5 class="text-center ">您已购买成功,<span class="distime" style="color:red;">5</span> 秒后返回商城首页</h5>

	</div>

</body>


	<script>

	var num = $(".distime").text();
	var t = setInterval(function () {
		$(".distime").text(--num);
		if(num == 0){
			clearInterval(t);
			window.location.href ="findbook?id=1";
		}

	},1000);



	</script>


</html>
