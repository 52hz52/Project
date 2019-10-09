<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN" "http://www.w3.org/TR/html4/loose.dtd">
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=UTF-8">
<title>APP开发者用户注册</title>

<!-- Bootstrap -->
	<link href="${pageContext.request.contextPath }/statics/css/bootstrap.min.css" rel="stylesheet">

	
	
	
</head>

<style>
input{border-radius: 10px}
body .row{background: #ccc;}
.tith{margin-left: 10%}

</style>

<body>
<div class="row">
  <div class="col-md-12 col-sm-12 col-xs-12">
    <div class="x_panel">
      <div class="x_title">
        <h2 class="tith">开发者注册</h2>
             <div class="clearfix"></div>
      </div>
      <div class="x_content">
           <div class="clearfix"></div>
        <form class="form-horizontal form-label-left" action="addUserInfo" method="post" enctype="multipart/form-data">
          <div class="item form-group">
            <div class="col-md-1"></div>
            <label class="control-label col-md-3 col-sm-3 col-xs-12" for="name">开发者账号<span class="required">*</span>
            </label>
            <div class="col-md-4 col-sm-6 col-xs-12">
              <input id="softwareName" class="form-control col-md-7 col-xs-12" 
               data-validate-length-range="20" data-validate-words="1" name="kuserCodeadd"  required="required"
               type="text">
            </div>
          </div>
          <div class="item form-group">
           <div class="col-md-1"></div>
            <label class="control-label col-md-3 col-sm-3 col-xs-12" for="name">开发者名称 <span class="required">*</span>
            </label>
            <div class="col-md-4 col-sm-6 col-xs-12">
              <input id="APKName" class="form-control col-md-7 col-xs-12" 
              	data-validate-length-range="20" data-validate-words="1" name="kuserNameadd"   required="required"
               type="text">
            </div>
          </div>
          
          <div class="item form-group">
           <div class="col-md-1"></div>
            <label class="control-label col-md-3 col-sm-3 col-xs-12" for="name">开发者密码 <span class="required">*</span>
            </label>
            <div class="col-md-4 col-sm-6 col-xs-12">
              <input id="supportROM" class="form-control col-md-7 col-xs-12" name="kuserPasswordadd" 
              	data-validate-length-range="20" data-validate-words="1"   required="required"
              	 type="text">
            </div>
          </div>
          
           <div class="item form-group">
            <div class="col-md-1"></div>
            <label class="control-label col-md-3 col-sm-3 col-xs-12" for="nameadd">开发者邮箱 <span class="required">*</span>
            </label>
            <div class="col-md-4 col-sm-6 col-xs-12">
              <input id="supportROM" class="form-control col-md-7 col-xs-12" name="kuserEmailadd" 
              	data-validate-length-range="20" data-validate-words="1"   required="required"
              	 type="text">
            </div>
          </div>
          
          <div class="item form-group">
           <div class="col-md-1"></div>
            <label class="control-label col-md-3 col-sm-3 col-xs-12" for="name">开发者简介<span class="required">*</span>
            </label>
            <div class="col-md-4 col-sm-6 col-xs-12">
              <input id="supportROM" class="form-control col-md-7 col-xs-12" name="kuserInfoadd" 
              	data-validate-length-range="20" data-validate-words="1"   required="required"
              	" type="text">
            </div>
          </div>
              
         
          <div class="ln_solid"></div>
          <div class="form-group">
            <div class="col-md-6 col-md-offset-4">
              <button id="send" type="submit"  class="btn btn-success">注册</button>
              <a href="dev/login"><button type="button" class="btn btn-primary" id="back" >返回</button></a>
              <br/><br/>
            </div>
          </div>
        </form>
      </div>
    </div>
  </div>
</div>

</body>
</html>