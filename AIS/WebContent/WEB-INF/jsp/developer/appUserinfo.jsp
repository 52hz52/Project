<%@ page language="java" contentType="text/html; charset=UTF-8"
	pageEncoding="UTF-8"%>
<%@include file="common/header.jsp"%>
<div class="clearfix"></div>
<div class="row">
  <div class="col-md-12 col-sm-12 col-xs-12">
    <div class="x_panel">
      <div class="x_title">
        <h2>个人账户信息维护 <i class="fa fa-user"></i><small>${devUesr.devName}</small></h2>
             <div class="clearfix"></div>
      </div>
      <div class="x_content">
           <div class="clearfix"></div>
        <form class="form-horizontal form-label-left" action="upUserInfo" method="post" enctype="multipart/form-data">
          <div class="item form-group">
            <label class="control-label col-md-3 col-sm-3 col-xs-12" for="name">开发者账号<span class="required">*</span>
            </label>
            <div class="col-md-6 col-sm-6 col-xs-12">
              <input id="softwareName" class="form-control col-md-7 col-xs-12" 
               data-validate-length-range="20" data-validate-words="1" name="kuserCode"  required="required"
               value="${devUesr.devCode }" type="text">
            </div>
          </div>
          <div class="item form-group">
            <label class="control-label col-md-3 col-sm-3 col-xs-12" for="name">开发者名称 <span class="required">*</span>
            </label>
            <div class="col-md-6 col-sm-6 col-xs-12">
              <input id="APKName" class="form-control col-md-7 col-xs-12" 
              	data-validate-length-range="20" data-validate-words="1" name="kuserName"   required="required"
              	value="${ devUesr.devName}" type="text">
            </div>
          </div>
          
          <div class="item form-group">
            <label class="control-label col-md-3 col-sm-3 col-xs-12" for="name">开发者密码 <span class="required">*</span>
            </label>
            <div class="col-md-6 col-sm-6 col-xs-12">
              <input id="supportROM" class="form-control col-md-7 col-xs-12" name="kuserPassword" 
              	data-validate-length-range="20" data-validate-words="1"   required="required"
              	value="${devUesr.devPassword}" type="text">
            </div>
          </div>
          
           <div class="item form-group">
            <label class="control-label col-md-3 col-sm-3 col-xs-12" for="name">开发者邮箱 <span class="required">*</span>
            </label>
            <div class="col-md-6 col-sm-6 col-xs-12">
              <input id="supportROM" class="form-control col-md-7 col-xs-12" name="kuserEmail" 
              	data-validate-length-range="20" data-validate-words="1"   required="required"
              	value="${devUesr.devEmail}" type="text">
            </div>
          </div>
          
          <div class="item form-group">
            <label class="control-label col-md-3 col-sm-3 col-xs-12" for="name">开发者简介<span class="required">*</span>
            </label>
            <div class="col-md-6 col-sm-6 col-xs-12">
              <input id="supportROM" class="form-control col-md-7 col-xs-12" name="kuserInfo" 
              	data-validate-length-range="20" data-validate-words="1"   required="required"
              	value="${devUesr.devInfo}" type="text">
            </div>
          </div>
              
         
          <div class="ln_solid"></div>
          <div class="form-group">
            <div class="col-md-6 col-md-offset-3">
              <button id="send" type="submit"  class="btn btn-success">修改</button>
              <button type="button" class="btn btn-primary" id="back">返回</button>
              <br/><br/>
            </div>
          </div>
        </form>
      </div>
    </div>
  </div>
</div>
<%@include file="common/footer.jsp"%>