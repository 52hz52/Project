<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head lang="en">
    <meta charset="UTF-8">
    <title>用户基本信息</title>
</head> 

<body>

<br/>
<br/>

    <div class="container">

        <div class="col-md-12 col-lg-12 col-sm-12">

            <form action="updateUserINFO" onsubmit="return myFun()"  method="post" class="form-horizontal">
                <div class="form-group">
                    <label for="inputEmail3" class="col-sm-2 control-label">编号</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" name="id" value="${u_info.id }">
                    </div>
                </div>

                <div class="form-group">
                    <label for="inputPassword3" class="col-sm-2 control-label">姓名</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" name="name" value="${u_info.name }">
                    </div>
                </div>

                <div class="form-group">
                    <label for="inputPassword3" class="col-sm-2 control-label">邮箱</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" name="email" value="${u_info.email }">
                    </div>
                </div>

                <div class="form-group">
                    <label for="inputPassword3" class="col-sm-2 control-label">电话</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" name="phone" value="${u_info.phone }">
                    </div>
                </div>

                <div class="form-group">
                    <label for="inputPassword3" class="col-sm-2 control-label">密码</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" name="password" value="${u_info.password }">
                    </div>
                </div>

                <div class="form-group">
                    <label for="inputPassword3" class="col-sm-2 control-label">地址</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" name="address" value="${u_info.address }">
                    </div>
                </div>


                <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <button type="submit"  class="btn btn-default">保存并返回</button>
                    </div>
                </div>
            </form>


        </div>

    </div>



</body>


    <script>
        function myFun(){
            if( window.confirm('你确定要修改信息吗？') ){
                    return true;
                }else{
                    return false;
                }

        }

    </script>


</html>
