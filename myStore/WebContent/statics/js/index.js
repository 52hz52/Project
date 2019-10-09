
$(function () {

	 var num =  $(".pageNum").text() ;
	 var totalPageNum = $(".totalPageNum").text();

	 
//	 基本信息
	 $(".userinfo").click(function () {
	     var user = $(this).attr("id");
//	     alert(user);
         $("#con").load("UserInfo?username="+user);
     });

//  详情
    $(".Productbtn").click(function () {
    	var pro_id = $(this).attr("id");
    	console.log("编号:===>  "+pro_id);
        $("#main").load("bookProduct?pro_id="+pro_id);

    });
    

//  购买
    $(".buyBook").click(function () {
        var  buy_id = $(this).attr("id");
        console.log("购买书籍编号:===>  "+buy_id);
        $("#con").load("bookBuys?buy_id="+buy_id);
    });

//  上一页
    $(".pageGo").click(function () {
        console.log("页码-："+num);
        if(num<=1){
            num = 1;
        }else if(num>1){
            num--;
        }
//        alert(num);
        $(".pageNum").html(num);
        window.location.href = "findbook?pageIndex="+encodeURI($(".pageNum").text());
       

    });

//  下一页
    $(".pageNext").click(function () {
    	
    
    	if(num>0 && num < totalPageNum){
    		 num++;
    	}

    	console.log(num);
    
        $(".pageNum").html(num);
        window.location.href = "findbook?pageIndex="+encodeURI($(".pageNum").text());
      
    	
    	
    });
    
//    长时间页面未操作 退出登录
    var lastTime = new Date().getTime();
    var currentTime = new Date().getTime();
    var timeOut =   5 * 10 * 1000; //设置超时时间： 50 秒    分
	console.log("超时:"+timeOut);
    $(function(){
        /* 鼠标移动事件 */
        $(document).mouseover(function(){
            lastTime = new Date().getTime(); //更新操作时间

        });
    });

    function testTime(){
        currentTime = new Date().getTime(); //更新当前时间
        if(currentTime - lastTime > timeOut){ //判断是否超时
        	var name = $(".userName_exit").text();
        	window.location.href= "exitLogin?name="+name;
        }
    }

    /* 定时器  间隔1秒检测是否长时间未操作页面  */
    window.setInterval(testTime, 1000);
    
  
    

});


