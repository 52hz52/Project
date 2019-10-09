<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head lang="en">
    <meta charset="UTF-8">
    <title>书籍购买</title>
	<link rel="stylesheet" href="${pageContext.request.contextPath }/statics/css/User/Buybook.css">
</head> 

<body>
   
	<div class="col-md-2 col-sm-3" ></div>
	<div class="col-md-8 col-sm-6" style="margin-top: 50px">
	    
	      <div class="media mian">
	       <div class="media-left media-middle ">
	            <img class="media-object" src="${pageContext.request.contextPath }/statics/img/address.png" alt="photo">
	       </div>
	       <div class="media-body">
	           <h4 class="media-heading">${user.name} <span style="color: #c9c9c9">${user.phone}</span></h4>
	           <p>${user.address}</p>
	           <p style="color: orangered">收货不方便时，可选择免费暂存服务</p>
	       </div>
   	  	  </div>

		
	     <div class="media mian">
		       <div class="media-left">
		           <a href="#">
		               <img class="media-object" src="${pageContext.request.contextPath }/statics/${Book_buy.photo}" width="70px" height="100px"  alt="photo">
		           </a>
		       </div>
		       <div class="media-body">
		           <h4 class="media-heading" style="color:#FF5722 ">  ${Book_buy.name}</h4>
		           <h5 class="media-heading">【正品保证】  ${Book_buy.author} 注</h5>
		           <p>${Book_buy.bookinfo}</p>
		           <br/><br/>

					   <div>
							<span>商品折扣价</span>
							<div class=" pull-right" style="display: inline-block;">
									￥<span class="disPrice">${Book_buy.disprice}</span>
							</div>
	  				   </div>

					   <br/>

		               <div>
		                  <span >购买数量</span>
		                  <div class=" pull-right" style="display: inline-block;">   
		                 	 <button style="width: 30px; text-align: center;" class="bookJian">-</button><input style="width: 25px ; display: inline-block;text-align: center;" class="bookNum" type="text" value="1"/><button style="width: 30px; text-align: center;" class="bookJia">+</button>
		                  </div>
		               </div>
	
		
				   <br/>
		           <p>
		               配送方式 &nbsp; <span style="color: #c9c9c9">普通配送</span>
		               <span class="pull-right" style="color: black">快递免邮 <i class="layui-icon layui-icon-right" style="font-size: 30px; text-align: center; font-size: 14px" ></i> </span>
		           </p>
		
		           <p class="pull-right"> 共<span class="allbooknum" style="color:red;"></span>本 &nbsp;小计:￥<span style="color: orangered" class="allPrice">￥ xxx</span> </p>
		           
		         
		
		       </div>
		       <br/>
		
		   
<!-- 按钮触发模态框 -->
<button class="btn btn-danger btn-lg pull-right" data-toggle="modal" data-target="#myModal">购买</button>
<!-- 模态框（Modal） -->
<div class="modal fade" style="margin-top: 5%" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true" data-backdrop="false">
    <div class="modal-dialog">
        <div class="modal-content">
            <div class="modal-header">
                <button type="button" class="close" data-dismiss="modal" aria-hidden="true">&times;</button>
                <h4 class="modal-title" id="myModalLabel">支付</h4>
            </div>
            <div class="modal-body">
      
      <!--   标签页  -->
      
            <div>

				  <!-- Nav tabs -->
				  <ul class="nav nav-tabs" role="tablist">
				    <li role="presentation" class="active"><a href="#zifub" aria-controls="home" role="tab" data-toggle="tab">支付宝</a></li>
				    <li role="presentation"><a href="#wx" aria-controls="profile" role="tab" data-toggle="tab">微信</a></li>
				  </ul>
				
				  <!-- Tab panes -->
				  <div class="tab-content">
				    <div role="tabpanel" class="tab-pane active" id="zifub">
		 			  <br/>
		 			  <img src="${pageContext.request.contextPath }/statics/img/pay/zfb.jpg" class="center-block text-center"  width="120px" height="120px">
		 			  
		 			  
		 			  
		 			  </div>
				    <div role="tabpanel" class="tab-pane" id="wx">
				     <br/>
				    <img src="${pageContext.request.contextPath }/statics/img/pay/wx.png" class="center-block text-center" width="120px" height="120px">
				    
				    </div>
				  </div>
			<br/>
			
			<!-- =====  -->
			
			<div class="progress progress-striped active hide" style="height: 5px;">

			    <div class="progress-bar progress-bar-success" role="progressbar"
			
			        aria-valuenow="60" aria-valuemin="0" aria-valuemax="100"
			
			        style="width: 40%; ">
			
			        <span class="sr-only">40% 完成</span>
			
			    </div>

			</div>
			
		
		 
		    <!-- ======== -->	
			
			</div>
            
     
            </div>
            <div class="modal-footer">
                <button type="button" class="btn btn-default" data-dismiss="modal">支付失败</button>
                <button type="button" class="btn btn-primary paySucc">支付成功</button>
            </div>
        </div><!-- /.modal-content -->
    </div><!-- /.modal -->
</div>

				   
				   
   
   
		
	
	
	
	
		
     </div>
    </div>
	<div class="col-md-2 col-sm-3"></div>

<script src="${pageContext.request.contextPath }/statics/js/jquery.min.js"></script>
<script src="${pageContext.request.contextPath }/statics/layui.all.js"></script>
<script src="${pageContext.request.contextPath }/statics/js/bootstrap.min.js"></script>
<script src="${pageContext.request.contextPath }/statics/js/buybook.js"></script>

</body>


</html>
