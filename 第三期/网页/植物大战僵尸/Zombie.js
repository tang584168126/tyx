/**
	��дһ����ʬ��
	blood:Ѫ��
	speed:�ƶ��ٶ�
	ap:������
	dp:������
	rowIndex:�ڵڼ���
	left:������
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
			//�ж��Ƿ���ǰ��
			if(isTouchingPlants(this.Zombie)){
				//ֹͣ������
				clearInterval(interval);
				interval = null;
				//�л�ͼƬ
				img.src = "images/Zombies/BucketheadZombie/BucketheadZombieAttack.gif";
			}
		},GLOBAL_FRAME);
	};
	var toDie = function(){
		//�Ƴ�Ԫ��
		img.parentElement.removeChild(img);
		//�ͷŴ˱հ���Դ
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