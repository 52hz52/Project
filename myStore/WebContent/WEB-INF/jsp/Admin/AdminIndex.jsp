<%@ page language="java" contentType="text/html; charset=UTF-8"
pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html lang="en" class="no-ie" style="overflow:hidden;">

<head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1">
    <title>BOOK STORE Admin</title>



    <link rel="stylesheet" href="${pageContext.request.contextPath }/statics/css/layui.css">
    <link rel="stylesheet" href="${pageContext.request.contextPath }/statics/css/bootstrap.min.css">
    <link rel="stylesheet" href="${pageContext.request.contextPath }/statics/css/Admin/AdminUser.css">



    <style type="text/css">
        /*
            核心在于 外层 overflow:hidden;position:relative; 内层 position: absolute;right: -17px;,
            内层的width不合适的话可以单独调整
            边框显示是为了方便识别 body、外层、内层边界
        */
        * {
            margin:0;
        }
        #container-outer {
            height: 100%;
            width: 100%;
            overflow: hidden;
            position: relative;
        }
        #container-inner {
            position: absolute;
            top: 0px;
            bottom: 0px;
            left: 0px;
            right: -17px;
            overflow: auto;
        }
        html, body {
            height: 100%;
            overflow:hidden;
        }
        
       .layui-nav-tree .layui-nav-item a:hover {	 
		    text-decoration: none;
		}
        
        
    </style>


</head>

<body class="layui-layout-body" style="overflow:Scroll;overflow-y:hidden">


<div id="container-outer">
    <div id="container-inner">

        <div id="all" class="layui-layout layui-layout-admin">
            <div class="layui-header">
                <div class="layui-logo">Book Store</div>
                <!-- 头部区域（可配合layui已有的水平导航） -->
                
                <ul class="layui-nav layui-layout-right">
                    <li class="layui-nav-item">
                        <a href="javascript:;">
                            <img src="${pageContext.request.contextPath }/statics/img/adminUser.png" height="64" width="64" class="layui-nav-img"/>
                            <span>${auser.a_name}</span>
                        </a>
                        <dl class="layui-nav-child">
                            <dd>
                                <a href="">基本资料</a>
                            </dd>
                            <dd>
                                <a href="">安全设置</a>
                            </dd>
                        </dl>
                    </li>
                    <li class="layui-nav-item">
                        <a href="">退出</a>
                    </li>
                </ul>
            </div>


            <div id="con">


                <div class="layui-side layui-bg-black">
                    <div class="layui-side-scroll">
                        <!-- 左侧导航区域（可配合layui已有的垂直导航） -->
                        <ul class="layui-nav layui-nav-tree" lay-filter="test">
                            <li class="layui-nav-item layui-nav-itemed">
                                <a class="" href="adminIndex">系统首页</a>
                                <!-- <dl class="layui-nav-child">
                                    <dd>
                                        <a href="#">列表一</a>
                                    </dd>
                                    <dd>
                                        <a href="#">列表二</a>
                                    </dd>
                                    <dd>
                                        <a href="#">列表三</a>
                                    </dd>
                                    <dd>
                                        <a href="">超链接</a>
                                    </dd>
                                </dl> -->
                            </li>
                            <li class="layui-nav-item">
                                <a href="#" class="UserList">用户列表</a>
                            </li>
                            <li class="layui-nav-item">
                                <a href="#" class="Bookadd">发布书籍</a>
                            </li>
                            <li class="layui-nav-item">
                                <a href="">系统设置</a>
                            </li>
                        </ul>
                    </div>
                </div>

                <div class="layui-body">
                    <!-- 内容主体区域 -->
                    <div class="container" id="main">
                    
                    	  <div class="row" style="padding:20px"><h2 class="h2">BOOK STORE ADMIN&nbsp;!</h2></div>
                   		  <div class="row">
		                        <div class="col-md-4 col-sm-12">
		                            <div class="one text-center ">今日在线人数  <span style="color:red; font-weight: bold;"> ${num }</span> 人</div>
		                        </div>
		                        <div class="col-md-4 col-sm-12">
		                            <div class="two text-center ">昨日在线人数</div>
		                        </div>
		                        <div class="col-md-4 col-sm-12">
		                            <div class="three text-center">用户总人数    <span style="color:red;font-weight: bold;"> ${allnum }</span> 人</div>
		                        </div>
                   		 </div>
		                 <br/>
		                 <br/>
	                    <div class="row">
	                        <div class="col-md-8 col-sm-12 col-xs-12">
	                            <div class="four">xxxxx</div>
	                        </div>
	                        <div class="col-md-4 col-sm-12 col-xs-12">
	                            <div class="five">xxxxx</div>
	                        </div>
	                    </div>
    
                    </div>

                </div>



                <div class="layui-footer">
                    <!-- 底部固定区域 -->
                    © layui.com - 底部固定区域
                </div>



            </div>




        </div>

    </div>
</div>


<script src="${pageContext.request.contextPath }/statics/js/jquery.min.js"></script>
<script src="${pageContext.request.contextPath }/statics/layui.all.js"></script>
<script src="${pageContext.request.contextPath }/statics/js/bootstrap.min.js"></script>
<script src="${pageContext.request.contextPath }/statics/js/AdminIndex.js"></script>



<script>
    //JavaScript代码区域
    layui.use('element', function() {
        var element = layui.element;
    });

    /*为了更好兼容各大浏览器，可以使用下面的js代码 - inlojv.com */
    var parent = document.getElementById('container-outer');
    var child = document.getElementById('container-inner');
    child.style.right = child.clientWidth - child.offsetWidth + "px";

</script>

</body>

</html>