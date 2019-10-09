$(function () {
    //商品数量
    var num = 1;
    //商品单价
    var disprice =  $(".disPrice").text();
    //总计
    var all = num * disprice;
    $(".allPrice").text(all);
    //默认数量
    $(".allbooknum").text(num);

//   点击加号
    $(".bookJia").click(function () {
        num++;
        $(".bookNum").val(num);
        //点击后总价的变化
        all = num * disprice;
        $(".allPrice").text(all);
        //点击后数量的变化
        $(".allbooknum").text(num);

    });

//    点击减号
    $(".bookJian").click(function () {
        num--;
        if(num<1){
            num = 1 ;
        }
        $(".bookNum").val(num);
        //点击后总价的变化
        all = num * disprice;
        $(".allPrice").text(all);
        //点击后数量的变化
        $(".allbooknum").text(num);
    });


//    进度条 控制

//    点击购买
    $(".paySucc").click(function () {

        $("#con").load("payOK");

    });






});