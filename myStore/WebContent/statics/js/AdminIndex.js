$(function () {
	
//	点击查询所有用户信息
    $(".UserList").click(function () { 	
        $("#main").load("findAllUsers");
    });
    
//    添加书籍
    $(".Bookadd").click(function () {
        $("#main").load("addbook");
    });
    
    
});