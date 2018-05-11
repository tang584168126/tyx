/**
	书写一个僵尸类
	blood:血量
	speed:移动速度
	ap:攻击力
	dp:防御力
	rowIndex:在第几排
	left:横坐标
	*/
function Zombie(blood, speed, ap, dp, rowIndex, left){
	var blood = blood;
	var speed = speed;
	var ap = ap;
	var dp = dp;
	var y = convertIndex(rowIndex, 120);
	var x = left;
	var img = document.createElement("img");
	img.src = "images/Zombies/BucketheadZombie/BucketheadZombie.gif";
	img.style.position = "absolute";
	img.style.top = y;
	img.style.left = x;
	
	this.getLocation = function(){
		return {"x":x, "y":y};
	};
	this.getTag = function(){
		return img;
	};
	this.move = function(){
		var interval = setInterval(function(){
			img.style.left = parseInt(img.style.left) - speed;
			//判断是否能前进
			if(isTouchingPlants(this.Zombie)){
				//停止计算器
				clearInterval(interval);
				interval = null;
				//切换图片
				img.src = "images/Zombies/BucketheadZombie/BucketheadZombieAttack.gif";
			}
		},GLOBAL_FRAME);
	};
	var toDie = function(){
		//移除元素
		img.parentElement.removeChild(img);
		//释放此闭包资源
		blood = null;
		speed = null;
		ap = null;
		dp = null;
		x = null;
		y = null;
		img = null;
		this.Zombie = null;
	};
}