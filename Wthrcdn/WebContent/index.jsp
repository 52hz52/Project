<%@ page language="java" contentType="text/html;charset=UTF-8" pageEncoding="UTF-8" %> 
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html;charset=UTF-8">
<title>天气预报系统</title>
<link rel="stylesheet" type="text/css" href="css/index.css"/>
</head>

<body>
	<header>
    <img alt="" src="">
    <h1>天气预报系统</h1>
    <form action="WeatherServlet" method="post">
    <div id="weather_search">
       <input id="text" name="cityName" type="text" placeholder="请输入您要查询的城市,默认查询上海" />
        <input id="btn" type="submit" value="" />
    </div>
    </form>
</header>

 <section>
 		<!--今日天气-->
        <div id="today_container">
           <dl>
           	<dt><img src="images/${today.pic}" /></dt>
            <dd class="today-city">
            	${today.cityName}&nbsp;&nbsp;|&nbsp;&nbsp;
            	${today.timDate}&nbsp;&nbsp;|&nbsp;&nbsp;
               ${today.week}&nbsp;&nbsp;|&nbsp;&nbsp;
                ${today.weather}
            </dd>
            <dd class="today-info">
            	当前温度：${today.wendu}℃&nbsp;&nbsp;
                风力：${today.fengli}&nbsp;&nbsp;
                风向：${today.fengxiang}&nbsp;&nbsp;
            </dd>
            <dd class="today-ganmao">
            	感冒指数：${today.ganmao}
            </dd>
           </dl>
        </div>
        
        <!--未来四天天气信息-->
         <div id="future_container">
         	<c:forEach items="${listForecast}" var="future">
         
         	<dl>
         		
         		<dt><img src="images/${future.img }" /></dt>
         	
                <dd>${future.date }</dd>
                <dd>${future.high }</dd>
                <dd>${future.fengli }</dd>
                <dd>${future.low }</dd>
                <dd>${future.fengxiang }</dd>
                <dd>${future.type }</dd>
         	
            
            </dl>
            </c:forEach>
         </div>
</body>
</html>