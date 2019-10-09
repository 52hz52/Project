var con = document.getElementById("content");
var speed=1;
var playoffset = 1.7;
var airplaneoffset = 1;
var bulletoffset = 2;
var PlayerButtetSpeed = 5;
init();
function init() {
    //地图
    this.mapW = parseInt(getComputedStyle(con).width);
    this.mapH = parseInt(getComputedStyle(con).height);
    this.mapDiv = con;
    //分数
    this.score = 0;
    //存活时间
    this.time = 0;
    //汽油
    this.fuelW = 64;
    this.fuelH = 64;
    this.fuelX = 0;
    this.fuelY = 0;
    //敌机
    this.airplaneW = 81;
    this.airplaneH = 81;
    this.airplaneX = 0;
    this.airplaneY = 0;
    //玩家
    this.playerW = 81;
    this.playerH = 81;
    this.playerX = 0;
    this.playerY = this.mapH/2;
    //子弹
    this.playerBulletW = 37;
    this.playerBulletH = 17;
    this.playerBulletY =  parseInt(this.playerX + 35) ;
    this.playerBulletX = parseInt(this.playerX + 85);
    //玩家移动
    this.playerleft = false;
    this.playerright = false;
    this.playertop = false;
    this.playerbottom = false;
    StartGame();
}
function StartGame() {
    creatplayer();
    setInterval(function () {
        let apnum = document.getElementsByClassName("airplane").length;
        if(apnum<10){
            creatairplane();
        }
    },2000);
    setInterval(function () {
        creatAirBullet();
    },2000);
    setInterval(function () {
        airplanemove();
        playermove();
        this.playerBulletY = getplayerY()+35;
        this.playerBulletX = getplayerX()+81;
        this.PlayerBulletmove();
        this.AirBulletmove();
        this.CollisonDetection();
        this.ChangeValue();
    },speed);
    setInterval(function () {
        this.time++;
    },1000);
}
//创建玩家
function  creatplayer() {
    var player = document.createElement("div");
    player.style.width = this.playerW + 'px';
    player.style.height = this.playerH + 'px';
    player.style.position = 'absolute';
    player.style.top = this.playerY + 'px';
    player.style.left = this.playerX + 'px';
    this.mapDiv.appendChild(player).setAttribute('id','player');
}
//创建敌机
function creatairplane() {
    var airplane = document.createElement("div");
    airplane.style.width = this.airplaneW + 'px';
    airplane.style.height = this.airplaneH + 'px';
    airplane.style.position = 'absolute';
    this.airplaneY = Math.floor(Math.random()*(this.mapH/81));
    airplane.style.right = this.airplaneX + 'px';
    if(this.airplaneY == 10){
        airplane.style.top = this.mapH-81 + 'px';
    }else{
        airplane.style.top = this.airplaneY*81 + 'px';
    }
    this.mapDiv.appendChild(airplane).setAttribute('class','airplane');
}
//玩家移动
function playermove() {
    let playerDiv = document.getElementById("player");
    if(parseInt(playerDiv.style.left) > 0 && this.playerleft){
        playerDiv.style.left = parseInt(playerDiv.style.left) - playoffset + 'px';
    }
    if(parseInt(playerDiv.style.top)> 0 && this.playertop){
        playerDiv.style.top = parseInt(playerDiv.style.top) - playoffset + 'px';
    }
    if(parseInt(playerDiv.style.top) < this.mapH-81 && this.playerbottom){
        playerDiv.style.top = parseInt(playerDiv.style.top)+ playoffset + 'px';
    }
    if(parseInt(playerDiv.style.left) < this.mapW && this.playerright){
        playerDiv.style.left =  parseInt(playerDiv.style.left) + playoffset + 'px';
    }
}
function bindEvent() {
    document.onkeydown = function (e) {
        var code = e.code;
        setDerict(code);
    }
}
function setDerict(code) {
    switch (code.toString()) {
        case "KeyA":
            this.playerleft = true;
            this.playerright = false;
            this.playertop = false;
            this.playerbottom = false;
        break;
        case "KeyD":
            this.playerright = true;
            this.playerleft = false;
            this.playertop = false;
            this.playerbottom = false;
        break;
        case "KeyW":
            this.playertop = true;
            this.playerleft = false;
            this.playerright = false;
            this.playerbottom = false;
        break;
        case "KeyS":
            this.playerbottom = true;
            this.playerleft = false;
            this.playerright = false;
            this.playertop = false;
        break;
        case "Space":
            if(PlayerButtetSpeed == 5){
                PlayerButtetSpeed = 0;
                creatPlayerBullet();
                var PBS =setInterval(function () {
                    if(PlayerButtetSpeed <5 ){
                        PlayerButtetSpeed += 1;
                    }
                    if(PlayerButtetSpeed == 5){
                        clearInterval(PBS);
                    }
                },100)
            }else {
                break;
            }
            break;
    }
}
// 敌机移动
function airplanemove() {
    let airplanes = document.getElementsByClassName('airplane');
    for(let i = 0;i<airplanes.length;i++){
        airplanes[i].style.right = parseInt(airplanes[i].style.right) + airplaneoffset + 'px';
        if(parseInt(airplanes[i].style.right) > this.mapW){
            airplanes[i].setAttribute("class","detairplane");
            //删除越界敌机
            var delairplane = document.getElementsByClassName("detairplane");
            for(let index = 0 ; index < delairplane.length ; index++){
                delairplane[index].parentNode.removeChild(delairplane[index]);
            }
        }
    }
}
//敌机发射子弹
function creatAirBullet() {
    let airplane = document.getElementsByClassName("airplane");
    for (let i = 0 ; i<airplane.length ; i++) {
        if((Math.floor(Math.random()*10))%2 == 0){
            var AirBullet = document.createElement("div");
            AirBullet.style.width = this.playerBulletW + 'px';
            AirBullet.style.height = this.playerBulletH + 'px';
            AirBullet.style.position = 'absolute';
            AirBullet.style.top = parseInt(airplane[i].style.top )+ 35 + 'px';
            AirBullet.style.right = parseInt(airplane[i].style.right) + 81 + 'px';
            this.mapDiv.appendChild(AirBullet).setAttribute('class','AirBullet');
        }
    }
}
function AirBulletmove() {
    let AirBullet = document.getElementsByClassName("AirBullet");
    for (let i = 0;i < AirBullet.length; i++){
        AirBullet[i].style.right = parseInt(AirBullet[i].style.right) + bulletoffset + 'px';
        if(parseInt(AirBullet[i].style.right) > this.mapW - this.playerBulletW){
            AirBullet[i].setAttribute("class","detBullets");
            //删除越界敌机
            var detBullets = document.getElementsByClassName("detBullets");
            for(let index = 0 ; index < detBullets.length ; index++){
                detBullets[index].parentNode.removeChild(detBullets[index]);
            }
        }
    }
}
//玩家发射子弹
function creatPlayerBullet() {
    var PlayerBullet = document.createElement("div");
    PlayerBullet.style.width = this.playerBulletW + 'px';
    PlayerBullet.style.height = this.playerBulletH + 'px';
    PlayerBullet.style.position = 'absolute';
    PlayerBullet.style.top = this.playerBulletY + 'px';
    PlayerBullet.style.left = this.playerBulletX + 'px';
    this.mapDiv.appendChild(PlayerBullet).setAttribute('class','PlayerBullets');
}
function getplayerY() {
    var player = document.getElementById("player");
    var GetPY = parseInt(player.style.top);
    return  GetPY;
}
function getplayerX() {
    var player = document.getElementById("player");
    var GetPX = parseInt(player.style.left);
    return  GetPX;
}
// 玩家子弹移动
function PlayerBulletmove() {
    let PlayerBullets = document.getElementsByClassName("PlayerBullets");
    for (let i = 0;i<PlayerBullets.length;i++){
        PlayerBullets[i].style.left = parseInt(PlayerBullets[i].style.left) + bulletoffset + 'px';
        if(parseInt(PlayerBullets[i].style.left) > this.mapW - this.playerBulletW){
            PlayerBullets[i].setAttribute("class","detBullets");
            //删除越界子弹
            var detBullets = document.getElementsByClassName("detBullets");
            for(let index = 0 ; index < detBullets.length ; index++){
                detBullets[index].parentNode.removeChild(detBullets[index]);
            }
        }
    }
}
// //碰撞检测
// function CollisonDetection() {
//     let PlayerBullets = document.getElementsByClassName("PlayerBullets");
//     var Playerdiv = document.getElementById("player");
//     var rect1 = Playerdiv.getBoundingClientRect();
//     for(let pb=0; pb<PlayerBullets.length ;pb++){
//         //获取所需坐标与区域
//         let pbX = parseInt(PlayerBullets[pb].style.left) + this.playerBulletW;
//         let pbYmin = parseInt(PlayerBullets[pb].style.top);
//         let pbYmax = parseInt(PlayerBullets[pb].style.top) + this.playerBulletH;
//         let airplanes = document.getElementsByClassName("airplane");
//         let AirBullets = document.getElementsByClassName("AirBullet");
//         for (let ab = 0; ab<AirBullets.length ; ab++){
//             let abX = this.mapW - parseInt(AirBullets[ab].style.right) - this.playerBulletW;
//             let abYmin = parseInt(AirBullets[ab].style.top);
//             let abYmax = parseInt(AirBullets[ab].style.top) + this.playerBulletH;
//             if(Math.abs(pbX - abX) < 8&& pbYmax > abYmin && pbYmin < abYmax) {
//                 // 撞到敌方子弹
//                 PlayerBullets[pb].parentNode.removeChild(PlayerBullets[pb]);
//                 AirBullets[ab].parentNode.removeChild(AirBullets[ab]);
//                 break;
//             }
//                 var rect2 = AirBullets[ab].getBoundingClientRect();
//                 var overlap = !(rect1.right < rect2.left || rect1.left > rect2.right || rect1.bottom < rect2.top || rect1.top > rect2.bottom);
//                 console.log(overlap);
//         }
//         for(let ap=0; ap<airplanes.length ;ap++){
//                 let apX = this.mapW - parseInt(airplanes[ap].style.right) - 81;
//                 let apYmin = parseInt(airplanes[ap].style.top);
//                 let apYmax = parseInt(airplanes[ap].style.top)+81;
//                 // 开始判断
//                 if(Math.abs(pbX - apX) < 8&& pbYmax > apYmin && pbYmin < apYmax) {
//                     // 撞到敌机
//                     PlayerBullets[pb].parentNode.removeChild(PlayerBullets[pb]);
//                     airplanes[ap].parentNode.removeChild(airplanes[ap]);
//                     this.score += 1;
//                     break;
//                 }
//         }
//     }
// }

//碰撞检测
function CollisonDetection() {
    let PlayerBullets = document.getElementsByClassName("PlayerBullets");
    var Playerdiv = document.getElementById("player");
    var rect1 = Playerdiv.getBoundingClientRect();
    for(let pb=0; pb<PlayerBullets.length ;pb++){
        //获取所需坐标与区域
        let pbXMax = parseInt(PlayerBullets[pb].style.left) + this.playerBulletW;
        let pbXMin = parseInt(PlayerBullets[pb].style.left);
        let pbYmin = parseInt(PlayerBullets[pb].style.top);
        let pbYmax = parseInt(PlayerBullets[pb].style.top) + this.playerBulletH;
        let airplanes = document.getElementsByClassName("airplane");
        let AirBullets = document.getElementsByClassName("AirBullet");
        for (let ab = 0; ab<AirBullets.length ; ab++){

            let abXMin = this.mapW - parseInt(AirBullets[ab].style.right) - this.playerBulletW;
            let abXMax = this.mapW - parseInt(AirBullets[ab].style.right);
            let abYmin = parseInt(AirBullets[ab].style.top);
            let abYmax = parseInt(AirBullets[ab].style.top) + this.playerBulletH;
            if(pbXMax<abXMin||pbXMin>abXMax||pbYmin>abYmax||pbYmax<abYmin){
                continue;
            }else {
                    PlayerBullets[pb].parentNode.removeChild(PlayerBullets[pb]);
                    AirBullets[ab].parentNode.removeChild(AirBullets[ab]);
                    break;
            }
        }
        
        for(let ap=0; ap<airplanes.length ;ap++){
            let apXMin = this.mapW - parseInt(airplanes[ap].style.right) - 81;
            let apXMax = this.mapW - parseInt(airplanes[ap].style.right);
            let apYmin = parseInt(airplanes[ap].style.top);
            let apYmax = parseInt(airplanes[ap].style.top)+81;
            // 开始判断
            if(pbXMax<apXMin||pbXMin>apXMax||pbYmin>apYmax||pbYmax<apYmin){
                continue;
            }else {
                PlayerBullets[pb].parentNode.removeChild(PlayerBullets[pb]);
                airplanes[ap].parentNode.removeChild(airplanes[ap]);
                break;
            }
        }
    }
}

function ChangeValue() {
    let scoreSpan = document.getElementById("score");
    let timeSpan = document.getElementById("time");
    scoreSpan.innerText =  this.score;
    timeSpan.innerText = this.time;
}