<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<%@ taglib uri="http://java.sun.com/jsp/jstl/core" prefix="c"%>
<!DOCTYPE html>
<html>
<head lang="en">
    <meta charset="UTF-8">
    <title>添加书籍</title>
</head> 

<body>
<br/>
<br/>
 <div class="login">

                <form class="form-horizontal" enctype="multipart/form-data" action="addBookinfo" method="post">
                
                   <div class="form-group">
                        <label for="inputEmail3" class="col-sm-2 control-label">书名</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="inputEmail3" placeholder="bookName" name="name">
                        </div>
                    </div>


                    
                     <div class="form-group">
                        <label for="inputEmail3" class="col-sm-2 control-label">书籍图片</label>
                        <div class="col-sm-6">
                            <div class="input-group">
                                <input id='location' name="uploadPhoto" placeholder="Book Photo" class="form-control" onclick="$('#i-file').click();">
                                <label class="input-group-btn">
                                    <input type="button" id="i-check"  value="浏览文件" class="btn btn-primary" onclick="$('#i-file').click();">
                                </label>
                            </div>
                        </div>

                        <input type="file" name="file" id='i-file'  accept=".png, .jpg , .bmp" onchange="$('#location').val($('#i-file').val());" style="display: none">

                     </div>
                     
                   <!--    		上传文件1：<input type="file" name="file"><br/> -->
                
                    <div class="form-group">
                        <label for="inputEmail3" class="col-sm-2 control-label">作者</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="inputEmail3" placeholder="bookAuthor" name="author">
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="inputPassword3" class="col-sm-2 control-label">出版社</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="inputPassword3" placeholder="bookHouse" name="house">
                        </div>
                    </div>
                     <div class="form-group">
                        <label for="inputPassword3" class="col-sm-2 control-label">出版时间</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="inputPassword3" placeholder="bookTime" name="time">
                        </div>
                    </div>
                    
                     <div class="form-group">
                        <label for="inputPassword3" class="col-sm-2 control-label">书籍信息</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="inputPassword3" placeholder="bookInfo" name="bookinfo">
                        </div>
                    </div>
                    
                     <div class="form-group">
                        <label for="inputPassword3" class="col-sm-2 control-label">书籍价钱</label>
                        <div class="col-sm-10">
                            <input type="number" class="form-control" id="inputPassword3" placeholder="bookPrice" name="price">
                        </div>
                    </div>
                    
                     
                     <div class="form-group">
                        <label for="inputPassword3" class="col-sm-2 control-label">书籍折扣价</label>
                        <div class="col-sm-10">
                            <input type="number" class="form-control" id="inputPassword3" placeholder="bookDisprice" name="disprice">
                        </div>
                    </div>
    
                    
                    <div class="form-group">
                        <label for="inputPassword3" class="col-sm-2 control-label">书籍类型</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="inputPassword3" placeholder="bookType" name="booktype">
                        </div>
                    </div>
                    
                    <div class="form-group">
                        <label for="inputPassword3" class="col-sm-2 control-label">书籍榜</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="inputPassword3" placeholder="bookAttr" name="attrbute">
                        </div>
                    </div>
                    
                    
                    <div class="form-group">
                        <div class="col-sm-offset-2 col-sm-10">
                            <div class="checkbox">
                                <label>
                                    <input type="checkbox"> Remember me
                                </label>
                            </div>
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-sm-offset-2 col-sm-10">
                            <button type="submit" class="btn btn-default">Insert</button>
                        </div>
                    </div>
                </form>
                
                
            </div>

  
  
  
  
  
  
</body>


</html>
