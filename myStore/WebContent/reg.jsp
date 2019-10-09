<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Book Store Reg</title>
    <link rel="stylesheet" href="statics/css/bootstrap.min.css">
    <style>
        body{
            background: url(statics/img/background-1.jpg)  100% 100%;
        }
        .login{
            background: rgba(255, 255, 255, 0.1);
            border-radius: 10px;
            box-shadow: 5px 5px 5px #000000;
            color: white;
            padding: 50px 30px 50px 20px;
        }
        .h1{
            background: rgba(255, 255, 255, 0.1);
            border-radius: 10px;
            box-shadow: 5px 5px 5px #000000;
            color: white;
            padding: 5px;
        }
    </style>

</head>
<body>
<div class="container">
    <div class="row" style="margin-top: 13%">
        <div class="col-md-3 col-sm-2"></div>

        <div class="col-md-6 col-sm-8">
            <h1 class="h1 text-center" >购书-系统-注册</h1>
            <br/>
            <div class="login">

                <form class="form-horizontal" action="toReg" method="post">
                
                   <div class="form-group">
                        <label for="inputEmail3" class="col-sm-2 control-label">User Name</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="inputEmail3" placeholder="User Name" name="name">
                        </div>
                    </div>
                    
                     <div class="form-group">
                        <label for="inputEmail3" class="col-sm-2 control-label">Phone</label>
                        <div class="col-sm-10">
                            <input type="number" class="form-control" id="inputEmail3" placeholder="Phone" name="phone">
                        </div>
                    </div>
                
                    <div class="form-group">
                        <label for="inputEmail3" class="col-sm-2 control-label">Email</label>
                        <div class="col-sm-10">
                            <input type="text" class="form-control" id="inputEmail3" placeholder="Email" name="Email">
                        </div>
                    </div>
                    <div class="form-group">
                        <label for="inputPassword3" class="col-sm-2 control-label">Password</label>
                        <div class="col-sm-10">
                            <input type="password" class="form-control" id="inputPassword3" placeholder="Password" name="password">
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
                            <button type="submit" class="btn btn-default">Reg in</button>
                        </div>
                    </div>
                </form>
                
                
            </div>

        </div>

        <div class="col-md-3 col-sm-2"></div>
    </div>
</div>




<script src="statics/js/jquery.min.js"></script>
<script src="statics/js/bootstrap.min.js"></script>
</body>
</html>