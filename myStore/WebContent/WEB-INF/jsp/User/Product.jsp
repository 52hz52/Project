<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head lang="en">
    <meta charset="UTF-8">
    <title>商品详情页</title>
</head> 

<body>

<div class="media">
  <div class="media-left media-middle">
    <a href="#">
      <img class="media-object" src="${pageContext.request.contextPath }/statics/${Book_pro.photo}" width="260px" height="390px" alt="photo">
    </a>
  </div>
  <div class="media-body">
    <h3 class="media-heading h3">${Book_pro.name }</h3>
    <h4 class="h4">作者: ${Book_pro.author}</h4>
    <h4 class="h4">出版时间: ${Book_pro.time }</h4>
    <div>${Book_pro.bookinfo }</div>

  </div>

  <div class="media-bottom media-right" style="width:980px">

    <button class="btn btn-primary" >加入购物车</button>
    <button class="btn btn-danger" >购买</button>

  </div>



</div>



</body>

<script src="${pageContext.request.contextPath }/statics/js/jquery.min.js"></script>

</html>
