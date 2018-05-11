//植物

var aMovePea=new Array(); //豌豆射手类公用移动豌豆函数
var aMoveStar=new Array(); //杨桃子弹数组
//var oPeashooter,oSnowPea,oRepeater,oThreepeater,oSunFlower,oTwinSunflower,oPumpkinHead,oFlowerPot,oLilyPad,oPotatoMine,oGatlingPea,oTorchwood,oSpikeweed,oSpikerock,oWallNut,oTallNut,oGralic,oCherryBomb,oSquash

function PlantAttack(obPlantID,obZombieID,AttackDirection,Attack,Setbody,Freeze,Slow,AttackKind){
	//植物攻击函数
	//传递植物img对象，传递僵尸img对象，攻击进行的方向,攻击力,Setbody定身,Freeze冰冻,Slow减速-1表示减速0表示不变1表示消除减速,攻击类型：直线，投掷，穿透，地刺，溅射
	//函数不判断是否能攻击，是否能攻击由植物自身函数判断。
	var OZombie;
	var obZombie=document.getElementById(obZombieID);
	if(obZombie!='[object]'){return(false);}
	eval('OZombie='+obZombie.EName);
	switch(OZombie.Ornaments){
		case 0: //没有饰品
			obZombie.HP-=Attack;
			break;
		case 1: //I类饰品包括: 路障  铁桶  橄榄球帽  雪橇  气球  矿工帽;此类饰品在被移除之前  任何伤害(爆炸类除外)都无法直接作用于本体
			switch(true){
				case obZombie.OrnHP<=0:
					obZombie.HP-=Attack;
					break;
				case obZombie.OrnHP>Attack:
					obZombie.OrnHP-=Attack;
					break;
				case obZombie.OrnHP<Attack:
					obZombie.HP-=(Attack-obZombie.OrnHP);
				case obZombie.OrnHP==Attack:
					obZombie.OrnHP=0;
					obZombie.NormalGif=OZombie.OrnLostNormalGif;
					obZombie.AttackGif=OZombie.OrnLostAttackGif;
					if(obZombie.isAttacking==0){
						obZombie.src=obZombie.NormalGif;
					}else{
						obZombie.src=obZombie.AttackGif;
					}
					break;
			}
			break;
		case 2: //II类饰品包括: 报纸  铁栅门  铁梯;无法在任何情况下提供防护(地刺  溅射类 穿透类  以及来自背后的水平射击武器可直接作用于本体)
		
			break;
	}
	
	
	if(obZombie.HP<=OZombie.BreakPoint){ //临死，调用自身临死程序
		OZombie.GoingDie(obZombie);
		return(false);
	}
	
	//判断减速状态，更新obZombie的减速时间以及减速filter CSS
	switch(Slow){
		case -1: //减速
			var d = new Date();
			d.setSeconds(d.getSeconds() + 1000);//加10秒
			if(obZombie.FreeSlowTime==''){obZombie.Speed*=0.25;}
			obZombie.FreeSlowTime=d;
			obZombie.style.filter='Glow(Color=#99CCFF,Strength=5)';
			break;
		case 1: //火球取消减速
			if(obZombie.FreeSlowTime!=''){
				obZombie.FreeSlowTime='';
				if(obZombie.HP>OZombie.BreakPoint){obZombie.style.filter='';}
			}
			break;
	}
}

/*-------------------豌豆射手---------------------------*/
function CPeashooter(){
	//豌豆射手对象
	//所有植物都有的属性
	this.EName='oPeashooter'; //英文名称
	this.CName='豌豆射手'; //中文名称
	this.width=71; //宽
	this.height=71; //高
	this.HP=300; //耐久
	this.SunNum=100;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/Peashooter.png'; //卡片图片
	this.normalGif='images/Plants/Peashooter/Peashooter.gif'; //普通动画
	this.canGrow='[草地][花盆][睡莲]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=7500; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20; //被攻击左点离pixelLeft偏移
	this.beAttackedPointR=51; //右点偏移

	//不是所有植物都有的属性
	this.AttackCoolTime=1400;
	this.attackGif='images/Plants/Peashooter/PeashooterAttack.gif'
	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	if(!dicPlantsGif.Exists('PeashooterBullet')){
		var tmpImg2=new Image();
		tmpImg2.src='images/Plants/PeashooterBullet.gif';
		dicPlantsGif.add('PeashooterBullet',tmpImg2);
	}
	//CardImage.push(this.cardImage+';'+this.EName+';'+this.CName);
}
CPeashooter.prototype.GetDeviationY=function(C,R){
	//GroundStr表示场地属性，比如'[草地]'
	//方法返回在某种属性场地上纵坐标的偏移量
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		case '[睡莲]':
			return(-20);
			break;
		default:
			return(0);
	}
}
CPeashooter.prototype.Birth=function(ob){
	//该植物种植后会使场地属性变为其他的属性，比如睡莲种植后使"水池"变成"睡莲"
	//不会改变的植物该方法为空
	ob.src=dicPlantsGif('oPeashooter').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	//this.DoTimer(ob);
	this.fAttack(ob.id);
}
CPeashooter.prototype.Die=function(ob){
	//植物死亡
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CPeashooter.prototype.fAttack=function(id){
	//每隔攻击冷却时间就检查是否有敌人，是就继续调用自身进行攻击
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //自身已经死亡
	if(!this.HaveEnemy(ob)){
		setTimeout('oPeashooter.fAttack("'+id+'")',this.AttackCoolTime);
		return(false); //判断没有敌人
	}
	var PeashooterBullet=document.createElement('img');
	var d=new Date(),s='';
	s += d.getHours()+'_'+d.getMinutes()+'_'+d.getSeconds()+'_'+d.getMilliseconds();
	PeashooterBullet.id='PeashooterBullet_'+ob.C+'_'+ob.R+'_'+s;
	PeashooterBullet.setAttribute('src',dicPlantsGif('PeashooterBullet').src);
	PeashooterBullet.style.position='absolute';
	PeashooterBullet.style.pixelLeft=ob.AttackedLX-12;
	PeashooterBullet.X=ob.AttackedLX;
	PeashooterBullet.C=ob.C;
	PeashooterBullet.R=ob.R;
	PeashooterBullet.style.pixelTop=ob.style.pixelTop+7;
	PeashooterBullet.style.zIndex=1+parseInt(ob.R);
	PeashooterBullet.style.display='none';
	PeashooterBullet.style.zIndex=3*ob.R+2;
	PeashooterBullet.AttackDirection=0; //攻击行进方向,0表示右，顺时针一直到7
	PeashooterBullet.Attack=20; //初始攻击力，变成火豌豆以后翻倍
	PeashooterBullet.BulletKind=0; //-1表示减速，0表示普通豌豆，1表示火豌豆
	PeashooterBullet.ChangeBulletC=0; //豌豆更改BulletKind的C,也就是是否经过了火炬树桩
	document.getElementById('dAll').appendChild(PeashooterBullet);
	setTimeout('var tmpOb=document.getElementById("'+PeashooterBullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',150);
	aMovePea.push(PeashooterBullet);
	setTimeout('oPeashooter.fAttack("'+id+'")',this.AttackCoolTime);
}
CPeashooter.prototype.HaveEnemy=function(ob){
	var C=parseInt(ob.C),R=parseInt(ob.R);
	if(oGP.aR[R]==0){return(false);}
	var m,n,zombieStr,atmp,obZombie,obZombieX;
	for(m=C;m<=oGP.MaxC+1;m++){ //豌豆攻击射程判定
		zombieStr=oGP.aZombie[m][R];
		if(zombieStr!=''){
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //循环获得最接近但是在植物前面的僵尸
				obZombie=document.getElementById(atmp[n]); //获得僵尸对象
				if(obZombie.WalkDirection==0){ //获得僵尸的被攻击点坐标
					obZombieX=obZombie.AttackedLX; //僵尸往左走，获取左被攻击点
				}else{
					obZombieX=obZombie.AttackedRX; //僵尸往右走，获取右被攻击点
				}
				if(obZombieX>=ob.AttackedLX){ //僵尸的被攻击点横坐标必须大于植物被攻击点横坐标
					return(true);
				}
			}
		}
	}
	return(false);
}
/*-------------------寒冰射手---------------------------*/
function CSnowPea(){
	//所有植物都有的属性
	this.EName='oSnowPea'; //英文名称
	this.CName='寒冰射手'; //中文名称
	this.width=71; //宽
	this.height=71; //高
	this.HP=300; //耐久
	this.SunNum=175;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/SnowPea.png'; //卡片图片
	this.normalGif='images/Plants/SnowPea/SnowPea.gif'; //普通动画
	this.canGrow='[草地][花盆][睡莲]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=7500; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20; //被攻击左点离pixelLeft偏移
	this.beAttackedPointR=51; //右点偏移

	//不是所有植物都有的属性
	this.AttackCoolTime=1400;
	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/Plants/SnowPeashooterBullet.gif';
	dicPlantsGif.add('SnowPeashooterBullet',tmpImg2);
	if(!dicPlantsGif.Exists('PeashooterBullet')){
		var tmpImg3=new Image();
		tmpImg3.src='images/Plants/PeashooterBullet.gif';
		dicPlantsGif.add('PeashooterBullet',tmpImg3);
	}
}
CSnowPea.prototype.GetDeviationY=function(C,R){
	//GroundStr表示场地属性，比如'[草地]'
	//方法返回在某种属性场地上纵坐标的偏移量
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		case '[睡莲]':
			return(-20);
			break;
		default:
			return(0);
	}
}
CSnowPea.prototype.Birth=function(ob){
	//该植物种植后会使场地属性变为其他的属性，比如睡莲种植后使"水池"变成"睡莲"
	//不会改变的植物该方法为空
	ob.src=dicPlantsGif('oSnowPea').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	//this.DoTimer(ob);
	this.fAttack(ob.id);
}
CSnowPea.prototype.Die=function(ob){
	//植物死亡
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CSnowPea.prototype.fAttack=function(id){
	//每隔攻击冷却时间就检查是否有敌人，是就继续调用自身进行攻击
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //自身已经死亡
	if(!this.HaveEnemy(ob)){
		setTimeout('oSnowPea.fAttack("'+id+'")',this.AttackCoolTime);
		return(false); //判断没有敌人
	}
	var PeashooterBullet=document.createElement('img');
	var d=new Date(),s='';
	s += d.getHours()+'_'+d.getMinutes()+'_'+d.getSeconds()+'_'+d.getMilliseconds();
	PeashooterBullet.id='SnowPeashooterBullet_'+ob.C+'_'+ob.R+'_'+s;
	PeashooterBullet.setAttribute('src',dicPlantsGif('SnowPeashooterBullet').src);
	PeashooterBullet.width=26;
	PeashooterBullet.height=26;
	PeashooterBullet.style.position='absolute';
	PeashooterBullet.style.pixelLeft=ob.AttackedLX-13;
	PeashooterBullet.X=ob.AttackedLX;
	PeashooterBullet.C=ob.C;
	PeashooterBullet.R=ob.R;
	PeashooterBullet.style.pixelTop=ob.style.pixelTop+7;
	PeashooterBullet.style.zIndex=1+parseInt(ob.R);
	PeashooterBullet.style.display='none';
	PeashooterBullet.style.zIndex=3*ob.R+1;
	PeashooterBullet.AttackDirection=0; //攻击行进方向,0表示右，顺时针一直到7
	PeashooterBullet.Attack=20; //初始攻击力
	PeashooterBullet.BulletKind=-1; //-1表示减速，0表示普通豌豆，1表示火豌豆
	PeashooterBullet.ChangeBulletC=0; //豌豆更改BulletKind的C,也就是是否经过了火炬树桩
	document.getElementById('dAll').appendChild(PeashooterBullet);
	setTimeout('var tmpOb=document.getElementById("'+PeashooterBullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',100);
	aMovePea.push(PeashooterBullet);
	setTimeout('oSnowPea.fAttack("'+id+'")',this.AttackCoolTime);
}
CSnowPea.prototype.HaveEnemy=function(ob){
	var C=parseInt(ob.C),R=parseInt(ob.R);
	if(oGP.aR[R]==0){return(false);}
	var m,n,zombieStr,atmp,obZombie,obZombieX;
	for(m=C;m<=oGP.MaxC+1;m++){ //豌豆攻击射程判定
		zombieStr=oGP.aZombie[m][R];
		if(zombieStr!=''){
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //循环获得最接近但是在植物前面的僵尸
				obZombie=document.getElementById(atmp[n]); //获得僵尸对象
				if(obZombie.WalkDirection==0){ //获得僵尸的被攻击点坐标
					obZombieX=obZombie.AttackedLX; //僵尸往左走，获取左被攻击点
				}else{
					obZombieX=obZombie.AttackedRX; //僵尸往右走，获取右被攻击点
				}
				if(obZombieX>=ob.AttackedLX){ //僵尸的被攻击点横坐标必须大于植物被攻击点横坐标
					return(true);
				}
			}
		}
	}
	return(false);
}
/*-------------------双发射手---------------------------*/
function CRepeater(){
	//双发射手对象
	this.EName='oRepeater'; //英文名称
	this.CName='双发射手'; //中文名称
	this.width=73; //宽
	this.height=71; //高
	this.HP=300; //耐久
	this.SunNum=200;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/Repeater.png'; //卡片图片
	this.normalGif='images/Plants/Repeater/Repeater.gif'; //普通动画
	this.canGrow='[草地][花盆][睡莲]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=7500; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=53;

	this.AttackCoolTime=1400;
	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	if(!dicPlantsGif.Exists('PeashooterBullet')){
		var tmpImg2=new Image();
		tmpImg2.src='images/Plants/PeashooterBullet.gif';
		dicPlantsGif.add('PeashooterBullet',tmpImg2);
	}
}
CRepeater.prototype.Birth=function(ob){
	//该植物种植后会使场地属性变为其他的属性，比如睡莲种植后使"水池"变成"睡莲"
	//不会改变的植物该方法为空
	ob.src=dicPlantsGif('oRepeater').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	this.fAttack(ob.id,1);
}
CRepeater.prototype.Die=function(ob){
	//植物死亡
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CRepeater.prototype.fAttack=function(id,NoPeashooterBullet){
	//每隔攻击冷却时间就检查是否有敌人，是就继续调用自身进行攻击
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //自身已经死亡
	if(!this.HaveEnemy(ob)){
		NoPeashooterBullet=1;
		setTimeout('oRepeater.fAttack("'+id+'",'+NoPeashooterBullet+')',this.AttackCoolTime);
		return(false); //判断没有敌人
	}
	var PeashooterBullet=document.createElement('img');
	var d=new Date(),s='';
	s += d.getHours()+'_'+d.getMinutes()+'_'+d.getSeconds()+'_'+d.getMilliseconds();
	PeashooterBullet.id='PeashooterBullet_'+ob.C+'_'+ob.R+'_'+s;
	PeashooterBullet.setAttribute('src',dicPlantsGif('PeashooterBullet').src);
	PeashooterBullet.width=24;
	PeashooterBullet.height=24;
	PeashooterBullet.style.position='absolute';
	PeashooterBullet.style.pixelLeft=ob.AttackedLX-12;
	PeashooterBullet.X=ob.AttackedLX;
	PeashooterBullet.style.pixelTop=ob.style.pixelTop+7;
	PeashooterBullet.C=ob.C;
	PeashooterBullet.R=ob.R;
	PeashooterBullet.style.zIndex=1+parseInt(ob.R);
	PeashooterBullet.style.display='none';
	PeashooterBullet.style.zIndex=3*ob.R+1;
	PeashooterBullet.AttackDirection=0; //攻击行进方向,0表示右，顺时针一直到7
	PeashooterBullet.Attack=20; //初始攻击力，变成火豌豆以后翻倍
	PeashooterBullet.BulletKind=0; //-1表示减速，0表示普通豌豆，1表示火豌豆
	PeashooterBullet.ChangeBulletC=0; //豌豆更改BulletKind的C,也就是是否经过了火炬树桩
	document.getElementById('dAll').appendChild(PeashooterBullet);
	setTimeout('var tmpOb=document.getElementById("'+PeashooterBullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',100);
	aMovePea.push(PeashooterBullet);
	if(NoPeashooterBullet==1){
		NoPeashooterBullet=2;
		setTimeout('oRepeater.fAttack("'+id+'",'+NoPeashooterBullet+')',300);
	}else{
		NoPeashooterBullet=1;
		setTimeout('oRepeater.fAttack("'+id+'",'+NoPeashooterBullet+')',this.AttackCoolTime);
	}
}
CRepeater.prototype.HaveEnemy=function(ob){
	var C=parseInt(ob.C),R=parseInt(ob.R);
	if(oGP.aR[R]==0){return(false);}
	var m,n,zombieStr,atmp,obZombie,obZombieX;
	for(m=C;m<=oGP.MaxC+1;m++){ //豌豆攻击射程判定
		zombieStr=oGP.aZombie[m][R];
		if(zombieStr!=''){
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //循环获得最接近但是在植物前面的僵尸
				obZombie=document.getElementById(atmp[n]); //获得僵尸对象
				if(obZombie.WalkDirection==0){ //获得僵尸的被攻击点坐标
					obZombieX=obZombie.AttackedLX; //僵尸往左走，获取左被攻击点
				}else{
					obZombieX=obZombie.AttackedRX; //僵尸往右走，获取右被攻击点
				}
				if(obZombieX>=ob.AttackedLX){ //僵尸的被攻击点横坐标必须大于植物被攻击点横坐标
					return(true);
				}
			}
		}
	}
	return(false);
}
CRepeater.prototype.GetDeviationY=function(C,R){
	//GroundStr表示场地属性，比如'[草地]'
	//方法返回在某种属性场地上纵坐标的偏移量
	var GroundStr=oGP.aPAfterGrow[C][R];

	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		case '[睡莲]':
			return(-20);
			break;
		default:
			return(0);
	}
}
/*-------------------三线射手---------------------------*/
function CThreepeater(){
	//双发射手对象
	this.EName='oThreepeater'; //英文名称
	this.CName='三线射手'; //中文名称
	this.width=73; //宽
	this.height=80; //高
	this.HP=300; //耐久
	this.SunNum=325;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/Threepeater.png'; //卡片图片
	this.normalGif='images/Plants/Threepeater/Threepeater.gif'; //普通动画
	this.canGrow='[草地][花盆][睡莲]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=7500; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=53;

	this.AttackCoolTime=1400;
	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	if(!dicPlantsGif.Exists('PeashooterBullet')){
		var tmpImg2=new Image();
		tmpImg2.src='images/Plants/PeashooterBullet.gif';
		dicPlantsGif.add('PeashooterBullet',tmpImg2);
	}
}
CThreepeater.prototype.Birth=function(ob){
	//该植物种植后会使场地属性变为其他的属性，比如睡莲种植后使"水池"变成"睡莲"
	//不会改变的植物该方法为空
	ob.src=dicPlantsGif('oThreepeater').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	this.fAttack(ob.id,1);
}
CThreepeater.prototype.Die=function(ob){
	//植物死亡
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CThreepeater.prototype.fAttack=function(id){
	//每隔攻击冷却时间就检查是否有敌人，是就继续调用自身进行攻击
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //自身已经死亡
	if(!this.HaveEnemy(ob)){
		setTimeout('oThreepeater.fAttack("'+id+'")',this.AttackCoolTime);
		return(false); //判断没有敌人
	}
	var R;
	for(R=ob.R-1;R<=ob.R+1;R++){
	if(R<1||R>oGP.MaxR){continue;}
	var PeashooterBullet=document.createElement('img');
	var d=new Date(),s='';
	s += d.getHours()+'_'+d.getMinutes()+'_'+d.getSeconds()+'_'+d.getMilliseconds();
	PeashooterBullet.id='PeashooterBullet_'+ob.C+'_'+R+'_'+s;
	PeashooterBullet.setAttribute('src',dicPlantsGif('PeashooterBullet').src);
	PeashooterBullet.width=24;
	PeashooterBullet.height=24;
	PeashooterBullet.style.position='absolute';
	PeashooterBullet.style.pixelLeft=ob.AttackedLX-12;
	PeashooterBullet.X=ob.AttackedLX-12;
	PeashooterBullet.C=ob.C;
	PeashooterBullet.R=R;
	PeashooterBullet.style.pixelTop=GetY(R)-50;
	PeashooterBullet.style.zIndex=1+parseInt(ob.R);
	PeashooterBullet.style.display='none';
	PeashooterBullet.style.zIndex=3*ob.R+1;
	PeashooterBullet.AttackDirection=0; //攻击行进方向,0表示右，顺时针一直到7
	PeashooterBullet.Attack=20; //初始攻击力，变成火豌豆以后翻倍
	PeashooterBullet.BulletKind=0; //-1表示减速，0表示普通豌豆，1表示火豌豆
	PeashooterBullet.ChangeBulletC=0; //豌豆更改BulletKind的C,也就是是否经过了火炬树桩
	document.getElementById('dAll').appendChild(PeashooterBullet);
	setTimeout('var tmpOb=document.getElementById("'+PeashooterBullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',100);
	aMovePea.push(PeashooterBullet);
	}
	setTimeout('oThreepeater.fAttack("'+id+'")',this.AttackCoolTime);
}
CThreepeater.prototype.HaveEnemy=function(ob){
	var C=parseInt(ob.C),R=parseInt(ob.R);
	var mC,mR,n,zombieStr,atmp,obZombie,obZombieX;
	for(mR=R-1;mR<=R+1;mR++){
		if(mR<1||mR>oGP.MaxR){continue;}
		if(oGP.aR[mR]==0){continue;}
		for(mC=C;mC<=oGP.MaxC+1;mC++){ //豌豆攻击射程判定
			zombieStr=oGP.aZombie[mC][mR];
			if(zombieStr!=''){
				atmp=zombieStr.split(',');
				for(n=0;n<atmp.length-1;n++){ //循环获得最接近但是在植物前面的僵尸
					obZombie=document.getElementById(atmp[n]); //获得僵尸对象
					if(obZombie.WalkDirection==0){ //获得僵尸的被攻击点坐标
						obZombieX=obZombie.AttackedLX; //僵尸往左走，获取左被攻击点
					}else{
						obZombieX=obZombie.AttackedRX; //僵尸往右走，获取右被攻击点
					}
					if(obZombieX>=ob.AttackedLX){ //僵尸的被攻击点横坐标必须大于植物被攻击点横坐标
						return(true);
					}
				}
			}
		}
	}
	return(false);
}
CThreepeater.prototype.GetDeviationY=function(C,R){
	//GroundStr表示场地属性，比如'[草地]'
	//方法返回在某种属性场地上纵坐标的偏移量
	var GroundStr=oGP.aPAfterGrow[C][R];

	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		case '[睡莲]':
			return(-20);
			break;
		default:
			return(0);
	}
}
/*-------------------向日葵---------------------------*/
function CSunFlower(){
	//向日葵
	this.EName='oSunFlower'; //英文名称
	this.CName='向日葵'; //中文名称
	this.width=73; //宽
	this.height=74; //高
	this.HP=300; //耐久
	this.SunNum=50;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/SunFlower.png'; //卡片图片
	this.normalGif='images/Plants/SunFlower/SunFlower.gif'; //普通动画
	this.canGrow='[草地][花盆][睡莲]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=7500; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=53;

	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
}
CSunFlower.prototype.Birth=function(ob){
	ob.src=dicPlantsGif('oSunFlower').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	setTimeout('oSunFlower.ProduceSun("'+ob.id+'")',6000); //6秒后启动生产阳光
}
CSunFlower.prototype.ProduceSun=function(id){
	//生产阳光
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //自身已经死亡
	var X,Y;
	X=GetX(ob.C);
	Y=GetY(ob.R);
	AppearSun(X,Y,25,0); //产生阳光
	if(Win==0){setTimeout('oSunFlower.ProduceSun("'+id+'")',24000);}
}
CSunFlower.prototype.Die=function(ob){
	//植物死亡
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CSunFlower.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	
	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		case '[睡莲]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------双子向日葵---------------------------*/
function CTwinSunflower(){
	//向日葵
	this.EName='oTwinSunflower'; //英文名称
	this.CName='双子向日葵'; //中文名称
	this.width=83; //宽
	this.height=84; //高
	this.HP=300; //耐久
	this.SunNum=150;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/TwinSunflower.png'; //卡片图片
	this.normalGif='images/Plants/TwinSunflower/TwinSunflower.gif'; //普通动画
	this.canGrow='[草地][花盆][睡莲]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=50000; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant='oSunFlower'; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=63;

	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
}
CTwinSunflower.prototype.Birth=function(ob){
	ob.src=dicPlantsGif('oTwinSunflower').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	setTimeout('oTwinSunflower.ProduceSun("'+ob.id+'")',6000); //6秒后启动生产阳光
}
CTwinSunflower.prototype.ProduceSun=function(id){
	//生产阳光
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //自身已经死亡
	var X,Y;
	X=GetX(ob.C);
	Y=GetY(ob.R);
	AppearSun(X-10,Y,25,0); //产生阳光
	AppearSun(X+10,Y,25,0);
	if(Win==0){setTimeout('oTwinSunflower.ProduceSun("'+id+'")',24000);}
}
CTwinSunflower.prototype.Die=function(ob){
	//植物死亡
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CTwinSunflower.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		case '[睡莲]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------南瓜头---------------------------*/
function CPumpkinHead(){
	//南瓜头
	this.EName='oPumpkinHead'; //英文名称
	this.CName='南瓜头'; //中文名称
	this.width=97; //宽
	this.height=67; //高
	this.HP=4000; //耐久
	this.SunNum=125;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=1; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/PumpkinHead.png'; //卡片图片
	this.normalGif='images/Plants/PumpkinHead/PumpkinHead.gif'; //普通动画
	this.canGrow='[草地][花盆][睡莲]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=30000; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=15;
	this.beAttackedPointR=82;

	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/Plants/PumpkinHead/PumpkinHead1.gif';
	dicPlantsGif.add('PumpkinHead1',tmpImg2);
	var tmpImg3=new Image();
	tmpImg3.src='images/Plants/PumpkinHead/PumpkinHead2.gif';
	dicPlantsGif.add('PumpkinHead2',tmpImg3);
	var tmpImg4=new Image();
	tmpImg4.src='images/Plants/PumpkinHead/pumpkin_damage1.gif';
	tmpImg4.width=97;
	tmpImg4.height=65;
	dicPlantsGif.add('PumpkinHeadHurt1',tmpImg4);
	var tmpImg5=new Image();
	tmpImg5.src='images/Plants/PumpkinHead/pumpkin_damage2.gif';
	tmpImg5.width=97;
	tmpImg5.height=65;
	dicPlantsGif.add('PumpkinHeadHurt2',tmpImg5);
	var tmpImg6=new Image();
	tmpImg6.src='images/Plants/PumpkinHead/Pumpkin_back.gif';
	tmpImg6.width=97;
	tmpImg6.height=65;
	dicPlantsGif.add('PumpkinHeadBackHurt',tmpImg6);
}
CPumpkinHead.prototype.Birth=function(ob){
	ob.src=dicPlantsGif('PumpkinHead1').src;
	ob.style.zIndex=3*ob.R+1;
	oGP.aPlant[ob.C][ob.R][1]=ob.id;
	var plant=new Image();
	var d=new Date(),s='';
	s += d.getHours()+'_'+d.getMinutes()+'_'+d.getSeconds()+'_'+d.getMilliseconds();
	plant.src=dicPlantsGif('PumpkinHead2').src;
	plant.id=ob.id+'_2';
	plant.name='Plants';
	plant.style.position='absolute';
	plant.style.pixelLeft=ob.style.pixelLeft;
	plant.style.pixelTop=ob.style.pixelTop;
	plant.style.zIndex=3*ob.R-1;
	document.getElementById('dAll').appendChild(plant);
}
CPumpkinHead.prototype.Die=function(ob){
	//植物死亡
	document.getElementById('dAll').removeChild(ob);
	document.getElementById('dAll').removeChild(document.getElementById(ob.id+'_2'));
	oGP.aPlant[ob.C][ob.R][1]='';
}
CPumpkinHead.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	
	switch(GroundStr){
		case '[草地]':
			return(-5);
			break;
		case '[花盆]':
			return(-13);
			break;
		case '[睡莲]':
			return(-10);
			break;
		default:
			return(0);
	}
}

/*-------------------花盆---------------------------*/
function CFlowerPot(){
	//花盆
	this.EName='oFlowerPot'; //英文名称
	this.CName='花盆'; //中文名称
	this.width=72; //宽
	this.height=68; //高
	this.HP=300; //耐久
	this.SunNum=25;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=1; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/FlowerPot.png'; //卡片图片
	this.normalGif='images/Plants/FlowerPot/FlowerPot.gif'; //普通动画
	this.canGrow='[草地][屋顶]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=7500; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=52;

	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
}
CFlowerPot.prototype.Birth=function(ob){
	var C=ob.C,R=ob.R;
	ob.src=dicPlantsGif('oFlowerPot').src;
	oGP.aPAfterGrow[C][R]='[花盆]';
	if(oGP.aGroundPlant[C][R][0]==''){
		oGP.aGroundPlant[C][R][0]=ob.id;
	}else{
		oGP.aGroundPlant[C][R][1]=ob.id;
	}
}
CFlowerPot.prototype.Die=function(ob){
	//植物死亡
	var C=ob.C;
	var R=ob.R;
	document.getElementById('dAll').removeChild(ob);
	oGP.aPAfterGrow[C][R]=oGP.aP[C][R];
	if(oGP.aGroundPlant[C][R][0]==ob.id){
		oGP.aGroundPlant[C][R][0]='';
	}else{
		oGP.aGroundPlant[C][R][1]='';
	}
}
CFlowerPot.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[草地]':
			return(3);
			break;
		case '[屋顶]':
			return(3);
			break;
		default:
			return(0);
	}
}

/*-------------------睡莲---------------------------*/
function CLilyPad(){
	//睡莲
	this.EName='oLilyPad'; //英文名称
	this.CName='睡莲'; //中文名称
	this.width=81; //宽
	this.height=61; //高
	this.HP=300; //耐久
	this.SunNum=25;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=1; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/LilyPad.png'; //卡片图片
	this.normalGif='images/Plants/LilyPad/LilyPad.gif'; //普通动画
	this.canGrow='[水池]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=7500; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=61;

	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
}
CLilyPad.prototype.Birth=function(ob){
	ob.src=dicPlantsGif('oLilyPad').src;
	var C=ob.C,R=ob.R;
	oGP.aPAfterGrow[C][R]='[睡莲]';
	if(oGP.aGroundPlant[C][R][0]==''){
		oGP.aGroundPlant[C][R][0]=ob.id;
	}else{
		oGP.aGroundPlant[C][R][1]=ob.id;
	}
}
CLilyPad.prototype.Die=function(ob){
	//植物死亡
	var C=ob.C,R=ob.R;
	document.getElementById('dAll').removeChild(ob);
	oGP.aPAfterGrow[C][R]=oGP.aP[C][R];
	if(oGP.aGroundPlant[C][R][0]==ob.id){
		oGP.aGroundPlant[C][R][0]='';
	}else{
		oGP.aGroundPlant[C][R][1]='';
	}
}
CLilyPad.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	
	switch(GroundStr){
		case '[水池]':
			return(0);
	}
}

/*-------------------土豆雷---------------------------*/
function CPotatoMine(){
	//土豆雷
	this.EName='oPotatoMine'; //英文名称
	this.CName='土豆雷'; //中文名称
	this.width=75; //宽
	this.height=55; //高
	this.HP=300; //耐久
	this.SunNum=25;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/PotatoMine.png'; //卡片图片
	this.normalGif='images/Plants/PotatoMine/PotatoMine.gif'; //普通动画
	this.canGrow='[草地][花盆]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=30000; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=0; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=55;

	this.Attack=1800;
	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/Plants/PotatoMine/PotatoMineNotReady.gif'; //土里
	dicPlantsGif.add('PotatoMineNotReady',tmpImg2);
	var tmpImg3=new Image();
	tmpImg3.src='images/Plants/PotatoMine/PotatoMine_mashed.gif'; //爆炸后土堆
	dicPlantsGif.add('PotatoMine_mashed',tmpImg3);
	var tmpImg4=new Image();
	tmpImg4.src='images/Plants/PotatoMine/ExplosionSpudow.gif'; //爆炸中文字
	dicPlantsGif.add('ExplosionSpudow',tmpImg4);
}
CPotatoMine.prototype.Birth=function(ob){
	ob.src=dicPlantsGif('PotatoMineNotReady').src;
	ob.isBoom=0; //是否爆炸状态
	var C=ob.C,R=ob.R;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	setTimeout('oPotatoMine.fBreakout("'+ob.id+'")',15000); //15秒后破土
}
CPotatoMine.prototype.fBreakout=function(id){
	//破土
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //自身已经死亡
	ob.src=dicPlantsGif('oPotatoMine').src; //更改gif
	 this.fAttack(ob.id)//已经破土，调用攻击判定
}
CPotatoMine.prototype.Die=function(ob){
	//植物死亡
	if(ob.isBoom==0){document.getElementById('dAll').removeChild(ob);} //如果是爆炸状态，移除图片由攻击计时器执行
	oGP.aPlant[ob.C][ob.R][0]='';
}
CPotatoMine.prototype.fAttack=function(id){
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //自身已经死亡
	var C=ob.C,R=ob.R;
	if(oGP.aPlant[C][R][1].substr(0,14)=='P_oPumpkinHead'){setTimeout('oPotatoMine.fAttack("'+ob.id+'")',100);return(false);}
	var zombieStr=oGP.aZombie[C-1][R]+oGP.aZombie[C][R]+oGP.aZombie[C+1][R];
	if(zombieStr!=''){ //起爆距离是当前格子,爆炸范围是当前格子的所有僵尸和后面进入
		var smallX='',smallZombie='',n,atmp,obZombie,LX,RX;
		atmp=zombieStr.split(',');
		LX=ob.style.pixelLeft;RX=ob.style.pixelLeft+ob.width; //获得地雷两边的X,以僵尸的左右攻击点进入X范围内判断是否起爆
		for(n=0;n<atmp.length-1;n++){ //循环获得僵尸
			obZombie=document.getElementById(atmp[n]); //循环获得最近的僵尸对象
			switch(true){
				case obZombie.AttackedLX>=LX&&obZombie.AttackedLX<=RX: //僵尸左攻击点在X范围内
				case obZombie.AttackedRX>=LX&&obZombie.AttackedRX<=RX: //僵尸右攻击点在X范围内
				case obZombie.AttackedLX<=LX&&obZombie.AttackedRX>=RX: //僵尸左点在X1左，右点在X2右
					if(obZombie.beAttacked==1){ob.unrivaled=1;this.fBoom(ob,atmp,LX,RX);return(false);}
					break;
			}
		}
	}
	setTimeout('oPotatoMine.fAttack("'+ob.id+'")',100);
}
CPotatoMine.prototype.fBoom=function(ob,atmp,LX,RX){
	//爆炸
	var C=ob.C,R=ob.R;
	var n,obZombie,MiddleX=(RX-LX)/2;
	for(n=0;n<atmp.length-1;n++){ //循环获得僵尸
		obZombie=document.getElementById(atmp[n]); //获得僵尸对象
		switch(true){
			case obZombie.AttackedLX>=LX&&obZombie.AttackedLX<=RX: //僵尸左攻击点在X范围内
			case obZombie.AttackedRX>=LX&&obZombie.AttackedRX<=RX: //僵尸右攻击点在X范围内
			case obZombie.AttackedLX<=LX&&obZombie.AttackedRX>=RX: //僵尸左点在X1左，右点在X2右
				if(obZombie.beAttacked==1){PlantAttack(ob.id,obZombie.id,0,this.Attack,0,'穿透');}
				break;
			case obZombie.AttackedRX<LX: //僵尸右点小于X1
				if(obZombie.beAttacked==1&&MiddleX-obZombie.AttackedRX<=50){PlantAttack(ob.id,obZombie.id,0,this.Attack,0,'穿透');}
				break;
			case obZombie.AttackedLX>RX: //僵尸左点大于X2
				if(obZombie.beAttacked==1&&obZombie.AttackedLX-MiddleX<=50){PlantAttack(ob.id,obZombie.id,0,this.Attack,0,'穿透');}
				break;
		}
	}
	ob.src=dicPlantsGif('PotatoMine_mashed').src; //更改成爆炸后的GIF,并且保持一段时间，然后再移除图片对象
	ob.style.pixelLeft-=40;
	ob.style.pixelTop-=20;
	var imgExplosionSpudow=new Image();
	imgExplosionSpudow.id='ExplosionSpudow_'+ob.id;
	imgExplosionSpudow.src=dicPlantsGif('ExplosionSpudow').src;
	imgExplosionSpudow.style.position='absolute';
	imgExplosionSpudow.style.pixelLeft=ob.style.pixelLeft-50;
	imgExplosionSpudow.style.pixelTop=ob.style.pixelTop-20;
	imgExplosionSpudow.style.zIndex=50;
	document.getElementById("dAll").appendChild(imgExplosionSpudow);
	ob.isBoom=1;
	this.Die(ob);
	setTimeout('document.getElementById("dAll").removeChild('+imgExplosionSpudow.id+');',1000);
	setTimeout('document.getElementById("dAll").removeChild('+ob.id+');',3000);
}


CPotatoMine.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		default:
			return(0);
	}
}

/*-------------------机枪射手---------------------------*/
function CGatlingPea(){
	//机枪射手对象
	this.EName='oGatlingPea'; //英文名称
	this.CName='机枪射手'; //中文名称
	this.width=88; //宽
	this.height=84; //高
	this.HP=300; //耐久
	this.SunNum=250;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/GatlingPea.png'; //卡片图片
	this.normalGif='images/Plants/GatlingPea/GatlingPea.gif'; //普通动画
	this.canGrow='[草地][花盆][睡莲]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=50000; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant='oRepeater'; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=1; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=68;

	this.AttackCoolTime=1400;
	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	if(!dicPlantsGif.Exists('PeashooterBullet')){
		var tmpImg2=new Image();
		tmpImg2.src='images/Plants/PeashooterBullet.gif';
		dicPlantsGif.add('PeashooterBullet',tmpImg2);
	}
	this.AttackCoolTime=1400;
}
CGatlingPea.prototype.Birth=function(ob){
	//该植物种植后会使场地属性变为其他的属性，比如睡莲种植后使"水池"变成"睡莲"
	//不会改变的植物该方法为空
	ob.src=dicPlantsGif('oGatlingPea').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	this.fAttack(ob.id,1);
}
CGatlingPea.prototype.Die=function(ob){
	//植物死亡
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CGatlingPea.prototype.fAttack=function(id,NoPeashooterBullet){
	//每隔攻击冷却时间就检查是否有敌人，是就继续调用自身进行攻击
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //自身已经死亡
	if(!this.HaveEnemy(ob)){
		NoPeashooterBullet=1;
		setTimeout('oGatlingPea.fAttack("'+id+'",'+NoPeashooterBullet+')',this.AttackCoolTime);
		return(false); //判断没有敌人
	}
	var PeashooterBullet=document.createElement('img');
	var d=new Date(),s='';
	s += d.getHours()+'_'+d.getMinutes()+'_'+d.getSeconds()+'_'+d.getMilliseconds();
	PeashooterBullet.id='PeashooterBullet_'+ob.C+'_'+ob.R+'_'+s;
	PeashooterBullet.setAttribute('src',dicPlantsGif('PeashooterBullet').src);
	PeashooterBullet.width=24;
	PeashooterBullet.height=24;
	PeashooterBullet.style.position='absolute';
	PeashooterBullet.style.pixelLeft=ob.AttackedLX-12;
	PeashooterBullet.X=ob.AttackedLX;
	PeashooterBullet.style.pixelTop=ob.style.pixelTop+20;
	PeashooterBullet.C=ob.C;
	PeashooterBullet.R=ob.R;
	PeashooterBullet.style.display='none';
	PeashooterBullet.style.zIndex=3*ob.R+1;
	PeashooterBullet.AttackDirection=0; //攻击行进方向,0表示右，顺时针一直到7
	PeashooterBullet.Attack=20; //初始攻击力，变成火豌豆以后翻倍
	PeashooterBullet.BulletKind=0; //-1表示减速，0表示普通豌豆，1表示火豌豆
	PeashooterBullet.ChangeBulletC=0; //豌豆更改BulletKind的C,也就是是否经过了火炬树桩
	document.getElementById('dAll').appendChild(PeashooterBullet);
	aMovePea.push(PeashooterBullet);
	setTimeout('var tmpOb=document.getElementById("'+PeashooterBullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',100);
	switch(true){
		case NoPeashooterBullet>=1&&NoPeashooterBullet<=3:
			NoPeashooterBullet+=1;
			setTimeout('oGatlingPea.fAttack("'+id+'",'+NoPeashooterBullet+')',200)
			break;
		case NoPeashooterBullet==4:
			NoPeashooterBullet=1;
			setTimeout('oGatlingPea.fAttack("'+id+'",'+NoPeashooterBullet+')',this.AttackCoolTime)
	}
}
CGatlingPea.prototype.HaveEnemy=function(ob){
	var C=parseInt(ob.C),R=parseInt(ob.R);
	if(oGP.aR[R]==0){return(false);}
	var m,n,zombieStr,atmp,obZombie,obZombieX;
	for(m=C;m<=oGP.MaxC+1;m++){ //豌豆攻击射程判定
		zombieStr=oGP.aZombie[m][R];
		if(zombieStr!=''){
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //循环获得最接近但是在植物前面的僵尸
				obZombie=document.getElementById(atmp[n]); //获得僵尸对象
				if(obZombie.WalkDirection==0){ //获得僵尸的被攻击点坐标
					obZombieX=obZombie.AttackedLX; //僵尸往左走，获取左被攻击点
				}else{
					obZombieX=obZombie.AttackedRX; //僵尸往右走，获取右被攻击点
				}
				if(obZombieX>=ob.AttackedLX){ //僵尸的被攻击点横坐标必须大于植物被攻击点横坐标
					return(true);
				}
			}
		}
	}
	return(false);
}
CGatlingPea.prototype.GetDeviationY=function(C,R){
	//GroundStr表示场地属性，比如'[草地]'
	//方法返回在某种属性场地上纵坐标的偏移量
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		case '[睡莲]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------火炬树桩---------------------------*/
function CTorchwood(){
	this.EName='oTorchwood'; //英文名称
	this.CName='火炬树桩'; //中文名称
	this.width=73; //宽
	this.height=83; //高
	this.HP=300; //耐久
	this.SunNum=175;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/Torchwood.png'; //卡片图片
	this.normalGif='images/Plants/Torchwood/Torchwood.gif'; //普通动画
	this.canGrow='[草地][花盆][睡莲]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=7500; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=53;

	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/plants/FirePeashooterBullet.gif';
	dicPlantsGif.add('FirePeashooterBullet',tmpImg2);
}
CTorchwood.prototype.Birth=function(ob){
	var C=ob.C,R=ob.R;
	ob.src=dicPlantsGif('oTorchwood').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
}
CTorchwood.prototype.Die=function(ob){
	//植物死亡
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CTorchwood.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		case '[睡莲]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------地刺---------------------------*/
function CSpikeweed(){
	this.EName='oSpikeweed'; //英文名称
	this.CName='地刺'; //中文名称
	this.width=85; //宽
	this.height=35; //高
	this.HP=300; //耐久
	this.SunNum=100;
	this.canEat=0; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/Spikeweed.png'; //卡片图片
	this.normalGif='images/Plants/Spikeweed/Spikeweed.gif'; //普通动画
	this.canGrow='[草地]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=7500; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=0; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=65;

	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
}
CSpikeweed.prototype.Birth=function(ob){
	var C=ob.C,R=ob.R;
	ob.src=dicPlantsGif('oSpikeweed').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	this.fAttack(ob.id);
}
CSpikeweed.prototype.Die=function(ob){
	//植物死亡
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CSpikeweed.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[草地]':
			return(-10);
			break;
	}
}
CSpikeweed.prototype.fAttack=function(id){
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);}
	var obC=ob.C,obR=ob.R;
	if(oGP.aPlant[obC][obR][1].substr(0,14)=='P_oPumpkinHead'){setTimeout('oSpikeweed.fAttack("'+ob.id+'")',1000);return(false);}
	var	zombieStr=oGP.aZombie[obC-1][obR]+oGP.aZombie[obC][obR]+oGP.aZombie[obC+1][obR]; //获得子弹所在格子的僵尸字符串
	if(zombieStr!=''){ //分解僵尸字符串成僵尸数组
		var atmp=zombieStr.split(',');
		var LX=ob.style.pixelLeft,RX=ob.style.pixelLeft+ob.width,MX=ob.style.pixelLeft+ob.width/2;
		for(n=0;n<atmp.length-1;n++){ //循环获得最接近但是在植物前面的僵尸
			obZombie=document.getElementById(atmp[n]); //获得僵尸对象
			if(obZombie.beAttacked==1){ //僵尸不是临死状态,可以被攻击
				if(obZombie.WalkDirection==0){ //获得僵尸的被攻击点坐标
					switch(true){
						case obZombie.AttackedLX>=LX&&obZombie.AttackedLX<=MX:
						case obZombie.AttackedLX<=LX&&obZombie.AttackedRX>=RX:
						case obZombie.AttackedRX>=LX&&obZombie.AttackedRX<=MX:
							PlantAttack(ob.id,obZombie.id,0,20,0,0,0,'地刺');
					}
					//if(obZombie.FreeSlowTime==''){
					//	obZombie.style.filter='alpha(opacity=60)'; //受伤闪光
					//	setTimeout('if('+obZombie.id+'.beAttacked==1){'+obZombie.id+'.style.filter="";}else{'+obZombie.id+'.style.filter="gray";}',100);
					//}
				}else{
					switch(true){
						case obZombie.AttackedLX>=MX&&obZombie.AttackedLX<=RX:
						case obZombie.AttackedLX<=LX&&obZombie.AttackedRX>=RX:
						case obZombie.AttackedRX>=MX&&obZombie.AttackedRX<=RX:
							PlantAttack(ob.id,obZombie.id,0,20,0,0,0,'地刺');
					}
					//if(obZombie.FreeSlowTime==''){
					//	obZombie.style.filter='alpha(opacity=60)'; //受伤闪光
					//	setTimeout('if('+obZombie.id+'.beAttacked==1){'+obZombie.id+'.style.filter="";}else{'+obZombie.id+'.style.filter="gray";}',100);
					//}
				}
			}
		}
	}
	setTimeout('oSpikeweed.fAttack("'+id+'")',1000);
}

/*-------------------地刺王---------------------------*/
function CSpikerock(){
	this.EName='oSpikerock'; //英文名称
	this.CName='地刺王'; //中文名称
	this.width=84; //宽
	this.height=43; //高
	this.HP=450; //耐久
	this.SunNum=125;
	this.canEat=0; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/Spikerock.png'; //卡片图片
	this.normalGif='images/Plants/Spikerock/Spikerock.gif'; //普通动画
	this.canGrow='[草地]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=50000; //冷却时间
	this.BreakPoint=1; //临界点,耐久低于此即死亡
	this.onOtherPlant='oSpikeweed'; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=0; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=64;

	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
}
CSpikerock.prototype.Birth=function(ob){
	var C=ob.C,R=ob.R;
	ob.src=dicPlantsGif('oSpikerock').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	this.fAttack(ob.id);
}
CSpikerock.prototype.Die=function(ob){
	//植物死亡
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CSpikerock.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[草地]':
			return(-10);
			break;
	}
}
CSpikerock.prototype.fAttack=function(id){
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);}
	var obC=ob.C,obR=ob.R;
	if(oGP.aPlant[obC][obR][1].substr(0,14)=='P_oPumpkinHead'){setTimeout('oSpikerock.fAttack("'+ob.id+'")',1000);return(false);}
	var	zombieStr=oGP.aZombie[obC-1][obR]+oGP.aZombie[obC][obR]+oGP.aZombie[obC+1][obR]; //获得子弹所在格子的僵尸字符串
	if(zombieStr!=''){ //分解僵尸字符串成僵尸数组
		var atmp=zombieStr.split(',');
		var LX=ob.style.pixelLeft,RX=ob.style.pixelLeft+ob.width,MX=ob.style.pixelLeft+ob.width/2;
		for(n=0;n<atmp.length-1;n++){ //循环获得最接近但是在植物前面的僵尸
			obZombie=document.getElementById(atmp[n]); //获得僵尸对象
			if(obZombie.beAttacked==1){ //僵尸不是临死状态,可以被攻击
				if(obZombie.WalkDirection==0){ //获得僵尸的被攻击点坐标
					switch(true){
						case obZombie.AttackedLX>=LX&&obZombie.AttackedLX<=MX:
						case obZombie.AttackedLX<=LX&&obZombie.AttackedRX>=RX:
						case obZombie.AttackedRX>=LX&&obZombie.AttackedRX<=MX:
							PlantAttack(ob.id,obZombie.id,0,40,0,0,0,'地刺');
					}
					//if(obZombie.FreeSlowTime==''){
					//	obZombie.style.filter='alpha(opacity=60)'; //受伤闪光
					//	setTimeout('if('+obZombie.id+'.beAttacked==1){'+obZombie.id+'.style.filter="";}else{'+obZombie.id+'.style.filter="gray";}',100);
					//}
				}else{
					switch(true){
						case obZombie.AttackedLX>=MX&&obZombie.AttackedLX<=RX:
						case obZombie.AttackedLX<=LX&&obZombie.AttackedRX>=RX:
						case obZombie.AttackedRX>=MX&&obZombie.AttackedRX<=RX:
							PlantAttack(ob.id,obZombie.id,0,40,0,0,0,'地刺');
					}
					//if(obZombie.FreeSlowTime==''){
					//	obZombie.style.filter='alpha(opacity=60)'; //受伤闪光
					//	setTimeout('if('+obZombie.id+'.beAttacked==1){'+obZombie.id+'.style.filter="";}else{'+obZombie.id+'.style.filter="gray";}',100);
					//}
				}
			}
		}
	}
	setTimeout('oSpikerock.fAttack("'+id+'")',1000);
}

/*-------------------坚果墙---------------------------*/
function CWallNut(){
	this.EName='oWallNut'; //英文名称
	this.CName='坚果墙'; //中文名称
	this.width=65; //宽
	this.height=73; //高
	this.HP=4000; //耐久
	this.SunNum=50;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/WallNut.png'; //卡片图片
	this.normalGif='images/Plants/WallNut/WallNut.gif'; //普通动画
	this.canGrow='[草地][睡莲][花盆]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=30000; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=45;

	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/Plants/WallNut/Wallnut_cracked1.png';
	tmpImg2.width=65;
	tmpImg2.height=75;
	dicPlantsGif.add('WallNutHurt1',tmpImg2);
	var tmpImg3=new Image();
	tmpImg3.src='images/Plants/WallNut/Wallnut_cracked2.png';
	tmpImg3.width=65;
	tmpImg3.height=76;
	dicPlantsGif.add('WallNutHurt2',tmpImg3);
}
CWallNut.prototype.Birth=function(ob){
	var C=ob.C,R=ob.R;
	ob.src=dicPlantsGif('oWallNut').src;
	oGP.aPlant[C][R][0]=ob.id;
}
CWallNut.prototype.Die=function(ob){
	//植物死亡
	var C=ob.C;
	var R=ob.R;
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[C][R][0]='';
}
CWallNut.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	
	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		case '[睡莲]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------高坚果---------------------------*/
function CTallNut(){
	this.EName='oTallNut'; //英文名称
	this.CName='高坚果'; //中文名称
	this.width=83; //宽
	this.height=119; //高
	this.HP=8000; //耐久
	this.SunNum=125;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/TallNut.png'; //卡片图片
	this.normalGif='images/Plants/TallNut/TallNut.gif'; //普通动画
	this.canGrow='[草地][睡莲][花盆]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=30000; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=2; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=63;

	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/Plants/TallNut/TallnutCracked1.gif';
	tmpImg2.width=83;
	tmpImg2.height=122;
	dicPlantsGif.add('TallNutHurt1',tmpImg2);
	var tmpImg3=new Image();
	tmpImg3.src='images/Plants/TallNut/TallnutCracked2.gif';
	tmpImg3.width=83;
	tmpImg3.height=121;
	dicPlantsGif.add('TallNutHurt2',tmpImg3);
}
CTallNut.prototype.Birth=function(ob){
	var C=ob.C,R=ob.R;
	ob.src=dicPlantsGif('oTallNut').src;
	oGP.aPlant[C][R][0]=ob.id;
}
CTallNut.prototype.Die=function(ob){
	//植物死亡
	var C=ob.C;
	var R=ob.R;
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[C][R][0]='';
}
CTallNut.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	
	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		case '[睡莲]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------大蒜---------------------------*/
function CGralic(){
	this.EName='oGralic'; //英文名称
	this.CName='大蒜'; //中文名称
	this.width=60; //宽
	this.height=59; //高
	this.HP=400; //耐久
	this.SunNum=50;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/Gralic.png'; //卡片图片
	this.normalGif='images/Plants/Gralic/Gralic.gif'; //普通动画
	this.canGrow='[草地][睡莲][花盆]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=7500; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=45;

	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/Plants/Gralic/Garlic_body2.gif';
	dicPlantsGif.add('GarlicHurt1',tmpImg2);
	var tmpImg3=new Image();
	tmpImg3.src='images/Plants/Gralic/Garlic_body3.gif';
	dicPlantsGif.add('GarlicHurt2',tmpImg3);
}
CGralic.prototype.Birth=function(ob){
	var C=ob.C,R=ob.R;
	ob.src=dicPlantsGif('oGralic').src;
	ob.height=59;
	oGP.aPlant[C][R][0]=ob.id;
}
CGralic.prototype.Die=function(ob){
	//植物死亡
	var C=ob.C;
	var R=ob.R;
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[C][R][0]='';
}
CGralic.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	
	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		case '[睡莲]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------窝瓜---------------------------*/
function CSquash(){
	this.EName='oSquash'; //英文名称
	this.CName='窝瓜'; //中文名称
	this.width=73; //宽
	this.height=85; //高
	this.HP=300; //耐久
	this.SunNum=50;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/Squash.png'; //卡片图片
	this.normalGif='images/Plants/Squash/Squash.gif'; //普通动画
	this.canGrow='[草地][睡莲][花盆]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=30000; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=53;

	this.Attack=1800;
	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/Plants/Squash/SquashAttack.gif';
	dicPlantsGif.add('SquashAttack',tmpImg2);
}
CSquash.prototype.Birth=function(ob){
	var C=ob.C,R=ob.R;
	ob.src=dicPlantsGif('oSquash').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	ob.isBoom=0;
	this.fAttack(ob.id);
}
CSquash.prototype.Die=function(ob){
	//植物死亡
	if(ob.isBoom==0){document.getElementById('dAll').removeChild(ob);} //如果是爆炸状态，移除图片由攻击计时器执行
	oGP.aPlant[ob.C][ob.R][0]='';
}
CSquash.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		case '[睡莲]':
			return(-20);
			break;
		default:
			return(0);
	}
}
CSquash.prototype.fAttack=function(id){
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //自身已经死亡
	var C=ob.C,R=ob.R;
	var zombieStr=oGP.aZombie[C-1][R]+oGP.aZombie[C][R]+oGP.aZombie[C+1][R];
	if(C<oGP.MaxC){zombieStr+=oGP.aZombie[C+2][R];}
	if(zombieStr!=''){
		var smallX='',smallZombie='',n,atmp,obZombie,LX,RX,obZombieX,MiddleX;
		atmp=zombieStr.split(',');
		LX=ob.style.pixelLeft-40;RX=ob.style.pixelLeft+ob.width+120; //获得窝瓜攻击X范围，左40右120,以僵尸的左右攻击点进入X范围内判断是否起砸
		MiddleX=ob.style.pixelLeft+ob.width/2; //窝瓜的中点X
		for(n=0;n<atmp.length-1;n++){ //循环获得僵尸
			obZombie=document.getElementById(atmp[n]); //循环获得最近的僵尸对象
			switch(true){
				case obZombie.AttackedLX>=LX&&obZombie.AttackedLX<=RX: //僵尸左攻击点在X范围内
				case obZombie.AttackedRX>=LX&&obZombie.AttackedRX<=RX: //僵尸右攻击点在X范围内
				case obZombie.AttackedLX<=LX&&obZombie.AttackedRX>=RX: //僵尸左点在X1左，右点在X2右
					if(obZombie.beAttacked==1){
						if(smallX==''){
							switch(obZombie.WalkDirection){
								case 0: //僵尸往左走，取左攻击点作为距离判定
									smallX=obZombie.AttackedLX;
									break;
								default: //往右走取右攻击点
									smallX=obZombie.AttackedRX;
							}
							smallZombie=obZombie;
						}else{
							switch(obZombie.WalkDirection){
								case 0: //僵尸往左走，取左攻击点作为距离判定
									obZombieX=obZombie.AttackedLX;
									break;
								default: //往右走取右攻击点
									obZombieX=obZombie.AttackedRX;
							}
							if(Math.abs(MiddleX-obZombieX)<Math.abs(MiddleX-smallX)){
								smallX=obZombieX;
								smallZombie=obZombie;
							}
						}
					}
					break;
			}
		}
		if(smallX!=''){
			ob.unrivaled=1;
			ob.style.pixelLeft=obZombie.style.pixelLeft+(obZombie.width-dicPlantsGif('SquashAttack').width)/2;
			ob.style.pixelTop=ob.style.pixelTop-(dicPlantsGif('SquashAttack').height-ob.height);
			ob.src=dicPlantsGif('SquashAttack').src;
			ob.width=dicPlantsGif('SquashAttack').width;
			ob.height=dicPlantsGif('SquashAttack').height;
			setTimeout('oSquash.fBoom('+ob.id+','+obZombie.C+')',600); //起砸程序
			return(false);
		}
	}
	setTimeout('oSquash.fAttack("'+ob.id+'")',100);
}
CSquash.prototype.fBoom=function(ob,C){
	//砸
	var obZombie;
	var R=ob.R;
	var zombieStr=oGP.aZombie[C][R];
	if(C>0){zombieStr+=oGP.aZombie[C-1][R];}
	if(C<=oGP.MaxC){zombieStr+=oGP.aZombie[C+1][R];}
	var n,atmp,LX,RX;
	LX=ob.style.pixelLeft;
	RX=ob.style.pixelLeft+ob.width;
	atmp=zombieStr.split(',');
	for(n=0;n<atmp.length-1;n++){ //循环获得僵尸
		obZombie=document.getElementById(atmp[n]); //获得僵尸对象
		switch(true){
			case obZombie.AttackedLX>=LX&&obZombie.AttackedLX<=RX: //僵尸左攻击点在X范围内
			case obZombie.AttackedRX>=LX&&obZombie.AttackedRX<=RX: //僵尸右攻击点在X范围内
			case obZombie.AttackedLX<=LX&&obZombie.AttackedRX>=RX: //僵尸左点在X1左，右点在X2右
				if(obZombie.beAttacked==1){
					PlantAttack(ob.id,obZombie.id,0,this.Attack,0,'穿透');
				}
				break;
		}
	}
	ob.isBoom=1;
	this.Die(ob);
	setTimeout('document.getElementById("dAll").removeChild('+ob.id+');',1000);
}

/*-------------------樱桃炸弹---------------------------*/
function CCherryBomb(){
	this.EName='oCherryBomb'; //英文名称
	this.CName='樱桃炸弹'; //中文名称
	this.width=112; //宽
	this.height=81; //高
	this.HP=300; //耐久
	this.SunNum=150;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/CherryBomb.png'; //卡片图片
	this.normalGif='images/Plants/CherryBomb/CherryBomb.gif'; //普通动画
	this.canGrow='[草地][花盆][睡莲]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=50000; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=92;

	this.Attack=1800;
	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/Plants/CherryBomb/Boom.gif'; //爆炸后土堆
	dicPlantsGif.add('CherryBombBoom',tmpImg2);
}
CCherryBomb.prototype.Birth=function(ob){
	var C=ob.C,R=ob.R;
	ob.src=dicPlantsGif('oCherryBomb').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	ob.unrivaled=1;
	setTimeout('oCherryBomb.fBoom('+ob.id+')',630);
}
CCherryBomb.prototype.Die=function(ob){
	//植物死亡
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CCherryBomb.prototype.fBoom=function(ob){
	//爆炸
	var C=ob.C,R=ob.R;
	var R1;
	var zombieStr=oGP.aZombie[C-1][R]+oGP.aZombie[C][R]+oGP.aZombie[C+1][R];
	if(R>1){R1=R-1;zombieStr+=oGP.aZombie[C-1][R1]+oGP.aZombie[C][R1]+oGP.aZombie[C+1][R1];}
	if(R<oGP.MaxR){R1=R+1;zombieStr+=oGP.aZombie[C-1][R1]+oGP.aZombie[C][R1]+oGP.aZombie[C+1][R1];}
	var n,atmp,obZombie;
	atmp=zombieStr.split(',');
	for(n=0;n<atmp.length-1;n++){ //循环获得僵尸
		obZombie=document.getElementById(atmp[n]); //获得僵尸对象
		PlantAttack(ob.id,obZombie.id,0,this.Attack,0,'穿透')
	}
	var img=new Image();
	img.src=dicPlantsGif('CherryBombBoom').src;
	img.style.pixelLeft=ob.style.pixelLeft-50;
	img.style.pixelTop=ob.style.pixelTop-30;
	img.style.zIndex=50;
	img.style.position='absolute';
	img.id=ob.id+'_Boom';
	document.getElementById("dAll").appendChild(img);
	this.Die(ob);
	setTimeout('document.getElementById("dAll").removeChild('+img.id+');',650);
}
CCherryBomb.prototype.GetDeviationY=function(C,R){
	//GroundStr表示场地属性，比如'[草地]'
	//方法返回在某种属性场地上纵坐标的偏移量
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		case '[睡莲]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------火爆辣椒---------------------------*/
function CJalapeno(){
	this.EName='oJalapeno'; //英文名称
	this.CName='火爆辣椒'; //中文名称
	this.width=68; //宽
	this.height=89; //高
	this.HP=300; //耐久
	this.SunNum=150;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/Jalapeno.png'; //卡片图片
	this.normalGif='images/Plants/Jalapeno/Jalapeno.gif'; //普通动画
	this.canGrow='[草地][花盆][睡莲]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=50000; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=48;

	this.Attack=1800;
	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/Plants/Jalapeno/JalapenoAttack.gif'; //爆炸后
	tmpImg2.width=800;
	dicPlantsGif.add('JalapenoBoom',tmpImg2);
}
CJalapeno.prototype.Birth=function(ob){
	var C=ob.C,R=ob.R;
	ob.src=dicPlantsGif('oJalapeno').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	ob.unrivaled=1;
	setTimeout('oJalapeno.fBoom('+ob.id+')',720);
}
CJalapeno.prototype.Die=function(ob){
	//植物死亡
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CJalapeno.prototype.fBoom=function(ob){
	//爆炸
	var C=ob.C,R=ob.R;
	var R1,n;
	var zombieStr='';
	for(n=0;n<=oGP.MaxC+1;n++){
		zombieStr+=oGP.aZombie[n][R];
	}
	var n,atmp,obZombie;
	atmp=zombieStr.split(',');
	for(n=0;n<atmp.length-1;n++){ //循环获得僵尸
		obZombie=document.getElementById(atmp[n]); //获得僵尸对象
		PlantAttack(ob.id,obZombie.id,0,this.Attack,0,'穿透')
	}
	var img=new Image();
	img.src=dicPlantsGif('JalapenoBoom').src;
	img.style.pixelLeft=20;
	img.style.pixelTop=GetY(R)-dicPlantsGif('JalapenoBoom').height;
	img.style.zIndex=50;
	img.style.position='absolute';
	img.id=ob.id+'_Boom';
	document.getElementById("dAll").appendChild(img);
	this.Die(ob);
	setTimeout('document.getElementById("dAll").removeChild('+img.id+');',1350);
}
CJalapeno.prototype.GetDeviationY=function(C,R){
	//GroundStr表示场地属性，比如'[草地]'
	//方法返回在某种属性场地上纵坐标的偏移量
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		case '[睡莲]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------大嘴花---------------------------*/
function CChomper(){
	this.EName='oChomper'; //英文名称
	this.CName='大嘴花'; //中文名称
	this.width=101; //宽
	this.height=98; //高
	this.HP=300; //耐久
	this.SunNum=150;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/Chomper.png'; //卡片图片
	this.normalGif='images/Plants/Chomper/Chomper.gif'; //普通动画
	this.canGrow='[草地][睡莲][花盆]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=7500; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=81;

	this.Attack=40;
	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/Plants/Chomper/ChomperAttack.gif';
	dicPlantsGif.add('ChomperAttack',tmpImg2);
	var tmpImg3=new Image();
	tmpImg3.src='images/Plants/Chomper/ChomperDigest.gif';
	dicPlantsGif.add('ChomperDigest',tmpImg3);
}
CChomper.prototype.Birth=function(ob){
	var C=ob.C,R=ob.R;
	ob.src=dicPlantsGif('oChomper').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	this.fAttack(ob.id);
}
CChomper.prototype.Die=function(ob){
	//植物死亡
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CChomper.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		case '[睡莲]':
			return(-20);
			break;
		default:
			return(0);
	}
}
CChomper.prototype.fAttack=function(id){
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //自身已经死亡
	var C=ob.C,R=ob.R;
	var zombieStr=oGP.aZombie[C][R]+oGP.aZombie[C+1][R];
	if(C<oGP.MaxC){zombieStr+=oGP.aZombie[C+2][R];}
	if(zombieStr!=''){
		var smallX='',smallZombie='',n,atmp;
		atmp=zombieStr.split(',');
		var obZombie=document.getElementById(atmp[0]);
		for(n=0;n<atmp.length-1;n++){ //循环获得僵尸
			obZombie=document.getElementById(atmp[n]); //循环获得最近的僵尸对象
			if(smallX==''&&obZombie.beAttacked==1){
				smallX=obZombie.style.pixelLeft;
				smallZombie=obZombie;
			}else{
				if(obZombie.beAttacked==1&&obZombie.style.pixelLeft<smallX&&obZombie.style.pixelLeft>=ob.style.pixelLeft+ob.width/2){
					smallX=obZombie.style.pixelLeft;
					smallZombie=obZombie;
				}
			}
		}
		if(Math.abs((smallZombie.style.pixelLeft+smallZombie.beAttackedPointL)-(ob.style.pixelLeft+ob.width/2))<=150||Math.abs((smallZombie.style.pixelLeft+smallZombie.beAttackedPointR)-(ob.style.pixelLeft+ob.width/2))<=150){
			ob.style.pixelTop-=15;
			ob.src=dicPlantsGif('ChomperAttack').src;
			setTimeout('oChomper.fAttackSuccessFail("'+id+'","'+smallZombie.id+'")',540);
			return(false);
		}
	}
	setTimeout('oChomper.fAttack("'+ob.id+'")',100);
}
CChomper.prototype.fAttackSuccessFail=function(id,zombieid){
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //自身死亡
	var obZombie=document.getElementById(zombieid);
	if(obZombie!='[object]'||obZombie.beAttacked!=1){ //攻击的僵尸已经不存在
		setTimeout('oChomper.fNormal("'+id+'")',400);
	}else{
		var OZombie;
		eval('OZombie='+obZombie.EName);
		if(OZombie.againstRaven==0){ //不免疫吞食,吞噬以后
			OZombie.Die(obZombie);
			setTimeout('oChomper.fDigest("'+id+'")',400);
		}else{ //免疫吞食,相当于攻击40点,攻击以后回复成正常姿态
			PlantAttack(id,zombieid,0,this.Attack,0,0,0,'直线');
			setTimeout('oChomper.fNormal("'+id+'")',400);
		}
	}
}
CChomper.prototype.fDigest=function(id){
	//咀嚼姿态
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);}
	ob.style.pixelTop+=30;
	ob.width=dicPlantsGif('ChomperDigest').width;
	ob.height=dicPlantsGif('ChomperDigest').height;
	ob.src=dicPlantsGif('ChomperDigest').src;
	setTimeout('oChomper.fNormal("'+id+'")',42000);
}

CChomper.prototype.fNormal=function(id){
	//恢复成平常姿态
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);}
	if(ob.src==dicPlantsGif('ChomperDigest').src){
		ob.style.pixelTop-=15;
	}else{
		ob.style.pixelTop+=15;
	}
	ob.src=dicPlantsGif('oChomper').src;
	this.fAttack(id);
}

/*-------------------分裂射手---------------------------*/
function CSplitPea(){
	this.EName='oSplitPea'; //英文名称
	this.CName='分裂射手'; //中文名称
	this.width=92; //宽
	this.height=72; //高
	this.HP=300; //耐久
	this.SunNum=125;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/SplitPea.png'; //卡片图片
	this.normalGif='images/Plants/SplitPea/SplitPea.gif'; //普通动画
	this.canGrow='[草地][花盆][睡莲]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=7500; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20;
	this.beAttackedPointR=72;

	this.AttackCoolTime=1400;
	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	if(!dicPlantsGif.Exists('PeashooterBullet')){
		var tmpImg2=new Image();
		tmpImg2.src='images/Plants/PeashooterBullet.gif';
		dicPlantsGif.add('PeashooterBullet',tmpImg2);
	}
}
CSplitPea.prototype.Birth=function(ob){
	//该植物种植后会使场地属性变为其他的属性，比如睡莲种植后使"水池"变成"睡莲"
	//不会改变的植物该方法为空
	ob.src=dicPlantsGif('oSplitPea').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	this.fAttack(ob.id,1);
}
CSplitPea.prototype.Die=function(ob){
	//植物死亡
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CSplitPea.prototype.fAttack=function(id,NoPeashooterBullet){
	//每隔攻击冷却时间就检查是否有敌人，是就继续调用自身进行攻击
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //自身已经死亡
	
	if(this.HaveEnemyL(ob)){
		var PeashooterBullet=document.createElement('img');
		var d=new Date(),s='';
		s += d.getHours()+'_'+d.getMinutes()+'_'+d.getSeconds()+'_'+d.getMilliseconds();
		PeashooterBullet.id='PeashooterBullet_'+ob.C+'_'+ob.R+'_L_'+s;
		PeashooterBullet.setAttribute('src',dicPlantsGif('PeashooterBullet').src);
		PeashooterBullet.width=24;
		PeashooterBullet.height=24;
		PeashooterBullet.style.position='absolute';
		PeashooterBullet.style.pixelLeft=ob.AttackedRX-12;
		PeashooterBullet.X=ob.AttackedRX;
		PeashooterBullet.style.pixelTop=ob.style.pixelTop+7;
		PeashooterBullet.C=ob.C;
		PeashooterBullet.R=ob.R;
		PeashooterBullet.style.zIndex=1+parseInt(ob.R);
		PeashooterBullet.style.display='none';
		PeashooterBullet.style.zIndex=3*ob.R+1;
		PeashooterBullet.AttackDirection=4; //攻击行进方向,0表示右，顺时针一直到7
		PeashooterBullet.Attack=20; //初始攻击力，变成火豌豆以后翻倍
		PeashooterBullet.BulletKind=0; //-1表示减速，0表示普通豌豆，1表示火豌豆
		PeashooterBullet.ChangeBulletC=0; //豌豆更改BulletKind的C,也就是是否经过了火炬树桩
		document.getElementById('dAll').appendChild(PeashooterBullet);
		setTimeout('var tmpOb=document.getElementById("'+PeashooterBullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',200);
		aMovePea.push(PeashooterBullet);
	}
	if(NoPeashooterBullet==1){
	if(this.HaveEnemyR(ob)){
		var PeashooterBullet2=document.createElement('img');
		var d=new Date(),s='';
		s += d.getHours()+'_'+d.getMinutes()+'_'+d.getSeconds()+'_'+d.getMilliseconds();
		PeashooterBullet2.id='PeashooterBullet_'+ob.C+'_'+ob.R+'_R_'+s;
		PeashooterBullet2.setAttribute('src',dicPlantsGif('PeashooterBullet').src);
		PeashooterBullet2.width=24;
		PeashooterBullet2.height=24;
		PeashooterBullet2.style.position='absolute';
		PeashooterBullet2.style.pixelLeft=ob.AttackedLX-12;
		PeashooterBullet2.X=ob.AttackedLX;
		PeashooterBullet2.style.pixelTop=ob.style.pixelTop+7;
		PeashooterBullet2.C=ob.C;
		PeashooterBullet2.R=ob.R;
		PeashooterBullet2.style.zIndex=1+parseInt(ob.R);
		PeashooterBullet2.style.display='none';
		PeashooterBullet2.style.zIndex=3*ob.R+1;
		PeashooterBullet2.AttackDirection=0; //攻击行进方向,0表示右，顺时针一直到7
		PeashooterBullet2.Attack=20; //初始攻击力，变成火豌豆以后翻倍
		PeashooterBullet2.BulletKind=0; //-1表示减速，0表示普通豌豆，1表示火豌豆
		PeashooterBullet2.ChangeBulletC=0; //豌豆更改BulletKind的C,也就是是否经过了火炬树桩
		document.getElementById('dAll').appendChild(PeashooterBullet2);
		setTimeout('var tmpOb=document.getElementById("'+PeashooterBullet2.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',200);
		aMovePea.push(PeashooterBullet2);
	}
	}
	if(NoPeashooterBullet==1){
			setTimeout('oSplitPea.fAttack("'+id+'",2)',300);
	}else{
		setTimeout('oSplitPea.fAttack("'+id+'",1)',this.AttackCoolTime);
	}
}
CSplitPea.prototype.HaveEnemyR=function(ob){
	//判断右边是否有僵尸
	var C=parseInt(ob.C),R=parseInt(ob.R);
	if(oGP.aR[R]==0){return(false);}
	var m,n,zombieStr,atmp,obZombie,obZombieX;
	for(m=C;m<=oGP.MaxC+1;m++){ //豌豆攻击射程判定
		zombieStr=oGP.aZombie[m][R];
		if(zombieStr!=''){
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //循环获得最接近但是在植物前面的僵尸
				obZombie=document.getElementById(atmp[n]); //获得僵尸对象
				if(obZombie.WalkDirection==0){ //获得僵尸的被攻击点坐标
					obZombieX=obZombie.AttackedLX; //僵尸往左走，获取左被攻击点
				}else{
					obZombieX=obZombie.AttackedRX; //僵尸往右走，获取右被攻击点
				}
				if(obZombieX>=ob.AttackedLX){ //僵尸的被攻击点横坐标必须大于植物被攻击点横坐标
					return(true);
				}
			}
		}
	}
	return(false);
}
CSplitPea.prototype.HaveEnemyL=function(ob){
	//判断左边是否有僵尸
	var C=parseInt(ob.C),R=parseInt(ob.R);
	if(oGP.aR[R]==0){return(false);}
	var m,n,zombieStr,atmp,obZombie,obZombieX;
	for(m=0;m<=C;m++){ //豌豆攻击射程判定
		zombieStr=oGP.aZombie[m][R];
		if(zombieStr!=''){
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //循环获得最接近但是在植物前面的僵尸
				obZombie=document.getElementById(atmp[n]); //获得僵尸对象
				if(obZombie.WalkDirection==0){ //获得僵尸的被攻击点坐标
					obZombieX=obZombie.AttackedLX; //僵尸往左走，获取左被攻击点
				}else{
					obZombieX=obZombie.AttackedRX; //僵尸往右走，获取右被攻击点
				}
				if(obZombieX<=ob.AttackedRX){ //僵尸的被攻击点横坐标必须大于植物被攻击点横坐标
					return(true);
				}
			}
		}
	}
	return(false);
}

CSplitPea.prototype.GetDeviationY=function(C,R){
	//GroundStr表示场地属性，比如'[草地]'
	//方法返回在某种属性场地上纵坐标的偏移量
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[草地]':
			return(-15);
			break;
		case '[花盆]':
			return(-23);
			break;
		case '[睡莲]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------杨桃---------------------------*/
function CStarfruit(){
	//所有植物都有的属性
	this.EName='oStarfruit'; //英文名称
	this.CName='杨桃'; //中文名称
	this.width=77; //宽
	this.height=70; //高
	this.HP=300; //耐久
	this.SunNum=125;
	this.canEat=1; //能被僵尸吃掉
	this.isGroundPlant=0; //是否容器植物
	this.isProtectPlant=0; //是否保护性植物，比如南瓜
	this.cardImage='images/Card/Plants/Starfruit.png'; //卡片图片
	this.normalGif='images/Plants/Starfruit/Starfruit.gif'; //普通动画
	this.canGrow='[草地][花盆][睡莲]'; //可以种植在什么属性的场地,场地属性保存在CGroundPool.aP[n]数组中
	this.coolTime=7500; //冷却时间
	this.BreakPoint=0; //临界点,耐久低于此即死亡
	this.onOtherPlant=''; //必须种植在其他植物上，""表示不能，“植物EName”表示必须种植在该种植物上
	this.onOtherPlantNum=0; //必须种在几个植物上，值为1表示该格，为2表示相邻要有两个，在周围8个格子中搜索（比如玉米炮）
	this.Stature=1; //身高类型0表示矮小型，小喷菇阳光菇地刺，1表示普通，2表示高大型，高坚果
	this.againstSecKill=0; //是否免疫秒杀
	this.beAttackedPointL=20; //被攻击左点离pixelLeft偏移
	this.beAttackedPointR=57; //右点偏移

	//不是所有植物都有的属性
	var tmpImg=new Image();
	tmpImg.src=this.cardImage;
	tmpImg.C=this.EName;
	tmpImg.alt=this.CName;
	dicCardGif.add(this.EName,tmpImg);
	var tmpImg1=new Image();
	tmpImg1.src=this.normalGif;
	dicPlantsGif.add(this.EName,tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/Plants/Starfruit/Star.gif';
	dicPlantsGif.add('Star',tmpImg2);
}
CStarfruit.prototype.GetDeviationY=function(C,R){
	//GroundStr表示场地属性，比如'[草地]'
	//方法返回在某种属性场地上纵坐标的偏移量
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[草地]':
			return(-10);
			break;
		case '[花盆]':
			return(-18);
			break;
		case '[睡莲]':
			return(-15);
			break;
	}
}
CStarfruit.prototype.Birth=function(ob){
	//该植物种植后会使场地属性变为其他的属性，比如睡莲种植后使"水池"变成"睡莲"
	//不会改变的植物该方法为空
	ob.src=dicPlantsGif('oStarfruit').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	this.fAttack(ob.id);
}
CStarfruit.prototype.Die=function(ob){
	//植物死亡
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CStarfruit.prototype.fAttack=function(id){
	//每隔攻击冷却时间就检查是否有敌人，是就继续调用自身进行攻击
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //自身已经死亡
	if(this.HaveEnemy(ob)){this.AttackAll(ob);}
	setTimeout('oStarfruit.fAttack("'+id+'")',1400);
}
CStarfruit.prototype.HaveEnemy=function(ob){
	if(this.HaveEnemyRU(ob)){return(true);}
	if(this.HaveEnemyRD(ob)){return(true);}
	if(this.HaveEnemyD(ob)){return(true);}
	if(this.HaveEnemyL(ob)){return(true);}
	if(this.HaveEnemyU(ob)){return(true);}
}
CStarfruit.prototype.AttackAll=function(ob){
	this.AttackRU(ob);
	this.AttackRD(ob);
	this.AttackD(ob);
	this.AttackL(ob);
	this.AttackU(ob);
}
CStarfruit.prototype.HaveEnemyRD=function(ob){
	//判断右下边是否有僵尸
	var C=parseInt(ob.C),R=parseInt(ob.R);
	var m,l,n,tmpl,zombieStr,atmp,obZombie,obZombieX,obZombieC;
	var StarMY=ob.style.pixelTop+15; //星星子弹的中点Y坐标
	var FlyTime,SS; //子弹纵向飞行达到僵尸所在行需要的时间，子弹纵向飞行达到僵尸所在行时僵尸已经行进的距离
	for(m=R+1;m<=oGP.MaxR;m++){
		if(oGP.aR[m]==0){continue;}
		tmpl=C-1+2*(m-R);
		if(tmpl>oGP.MaxC){break;}
		zombieStr='';
		for(l=tmpl;l<=tmpl+3;l++){ //每行最左列是C+1+(m-1-R)*2,最右列是C+1+(m-1-R)*2+3
			if(l>oGP.MaxC+1){break;}
			zombieStr+=oGP.aZombie[l][m];
		}
		if(zombieStr!=''){
			FlyTime=(GetY(m)-StarMY)*4; //纵坐标飞行速度是每毫秒0.25,(StarMY-GetY(m))/0.25=飞行时间
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //循环获得僵尸
				obZombie=document.getElementById(atmp[n]); //获得僵尸对象
				if(obZombie.WalkDirection==0){ //获得僵尸的被攻击点坐标
					obZombieX=obZombie.AttackedLX; //僵尸往左走，获取左被攻击点
					SS=-obZombie.Speed*Math.floor(FlyTime*0.008);
				}else{
					obZombieX=obZombie.AttackedRX; //僵尸往右走，获取右被攻击点
					SS=obZombie.Speed*Math.floor(FlyTime*0.008);
				}
				obZombieX+=SS;
				obZombieC=GetC(obZombieX);
				if(obZombieC<tmpl+3&&obZombieC>tmpl){ //僵尸预计行进到的列等于子弹飞行到的列
					return(true);
				}
			}
		}
	}
	return(false);
}
CStarfruit.prototype.AttackRD=function(ob){
	//添加往右下飞的子弹
	var Bullet=document.createElement('img');
	var d=new Date(),s='';
	s += d.getHours()+'_'+d.getMinutes()+'_'+d.getSeconds()+'_'+d.getMilliseconds();
	Bullet.id='Star_'+ob.C+'_'+ob.R+'_RD_'+s;
	Bullet.setAttribute('src',dicPlantsGif('Star').src);
	Bullet.style.position='absolute';
	var MX=ob.style.pixelLeft+ob.width/2;
	Bullet.style.pixelLeft=MX-15;
	Bullet.X=MX;
	Bullet.C=ob.C;
	Bullet.R=ob.R;
	Bullet.style.pixelTop=ob.style.pixelTop+15;
	Bullet.style.zIndex=1+parseInt(ob.R);
	Bullet.style.display='none';
	Bullet.style.zIndex=3*ob.R+2;
	Bullet.AttackDirection=1; //攻击行进方向,0表示右，顺时针一直到7
	document.getElementById('dAll').appendChild(Bullet);
	setTimeout('var tmpOb=document.getElementById("'+Bullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',100);
	aMoveStar.push(Bullet);
}

CStarfruit.prototype.HaveEnemyRU=function(ob){
	//判断右上边是否有僵尸
	var C=parseInt(ob.C),R=parseInt(ob.R);
	var m,l,n,tmpl,zombieStr,atmp,obZombie,obZombieX,obZombieC;
	var StarMY=ob.style.pixelTop+15; //星星子弹的中点Y坐标
	var FlyTime,SS; //子弹纵向飞行达到僵尸所在行需要的时间，子弹纵向飞行达到僵尸所在行时僵尸已经行进的距离
	for(m=R-1;m>=1;m--){
		if(oGP.aR[m]==0){continue;}
		tmpl=C-1+2*(R-m);
		if(tmpl>oGP.MaxC){break;}
		zombieStr='';
		for(l=tmpl;l<=tmpl+3;l++){ //每行最左列是C+1+(R-m-1)*2,最右列是C+1+(R-m-1)*2+3
			if(l>oGP.MaxC+1){break;}
			zombieStr+=oGP.aZombie[l][m];
		}
		if(zombieStr!=''){
			FlyTime=(StarMY-GetY(m))*4; //纵坐标飞行速度是每毫秒0.25,(StarMY-GetY(m))/0.25=飞行时间
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //循环获得僵尸
				obZombie=document.getElementById(atmp[n]); //获得僵尸对象
				if(obZombie.WalkDirection==0){ //获得僵尸的被攻击点坐标
					obZombieX=obZombie.AttackedLX; //僵尸往左走，获取左被攻击点
					SS=-obZombie.Speed*Math.floor(FlyTime*0.008);
				}else{
					obZombieX=obZombie.AttackedRX; //僵尸往右走，获取右被攻击点
					SS=obZombie.Speed*Math.floor(FlyTime*0.008);
				}
				obZombieX+=SS;
				obZombieC=GetC(obZombieX);
				if(obZombieC<tmpl+3&&obZombieC>tmpl){ //僵尸预计行进到的列等于子弹飞行到的列
					return(true);
				}
			}
		}
	}
	return(false);
}
CStarfruit.prototype.AttackRU=function(ob){
	//添加往右上飞的子弹
	var Bullet=document.createElement('img');
	var d=new Date(),s='';
	s += d.getHours()+'_'+d.getMinutes()+'_'+d.getSeconds()+'_'+d.getMilliseconds();
	Bullet.id='Star_'+ob.C+'_'+ob.R+'_RU_'+s;
	Bullet.setAttribute('src',dicPlantsGif('Star').src);
	Bullet.style.position='absolute';
	var MX=ob.style.pixelLeft+ob.width/2;
	Bullet.style.pixelLeft=MX-15;
	Bullet.X=MX;
	Bullet.C=ob.C;
	Bullet.R=ob.R;
	Bullet.style.pixelTop=ob.style.pixelTop+15;
	Bullet.style.zIndex=1+parseInt(ob.R);
	Bullet.style.display='none';
	Bullet.style.zIndex=3*ob.R+2;
	Bullet.AttackDirection=7; //攻击行进方向,0表示右，顺时针一直到7
	document.getElementById('dAll').appendChild(Bullet);
	setTimeout('var tmpOb=document.getElementById("'+Bullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',100);
	aMoveStar.push(Bullet);
}

CStarfruit.prototype.HaveEnemyL=function(ob){
	//判断左边是否有僵尸
	var C=parseInt(ob.C),R=parseInt(ob.R);
	if(oGP.aR[R]==0){return(false);}
	var m,n,zombieStr,atmp,obZombie,obZombieX;
	for(m=C;m>=0;m--){
		zombieStr=oGP.aZombie[m][R];
		if(zombieStr!=''){
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //循环获得最接近但是在植物前面的僵尸
				obZombie=document.getElementById(atmp[n]); //获得僵尸对象
				if(obZombie.WalkDirection==0){ //获得僵尸的被攻击点坐标
					obZombieX=obZombie.AttackedLX; //僵尸往左走，获取左被攻击点
				}else{
					obZombieX=obZombie.AttackedRX; //僵尸往右走，获取右被攻击点
				}
				if(obZombieX<=ob.AttackedRX){ //僵尸的被攻击点横坐标必须小于植物被攻击点横坐标
					return(true);
				}
			}
		}
	}
	return(false);
}
CStarfruit.prototype.AttackL=function(ob){
	//添加往左飞的子弹
	var Bullet=document.createElement('img');
	var d=new Date(),s='';
	s += d.getHours()+'_'+d.getMinutes()+'_'+d.getSeconds()+'_'+d.getMilliseconds();
	Bullet.id='Star_'+ob.C+'_'+ob.R+'_L_'+s;
	Bullet.setAttribute('src',dicPlantsGif('Star').src);
	Bullet.style.position='absolute';
	Bullet.style.pixelLeft=ob.AttackedRX-15;
	Bullet.X=ob.AttackedRX;
	Bullet.C=ob.C;
	Bullet.R=ob.R;
	Bullet.style.pixelTop=ob.style.pixelTop+15;
	Bullet.style.zIndex=1+parseInt(ob.R);
	Bullet.style.display='none';
	Bullet.style.zIndex=3*ob.R+2;
	Bullet.AttackDirection=4; //攻击行进方向,0表示右，顺时针一直到7
	document.getElementById('dAll').appendChild(Bullet);
	setTimeout('var tmpOb=document.getElementById("'+Bullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',150);
	aMoveStar.push(Bullet);
}
CStarfruit.prototype.HaveEnemyU=function(ob){
	//判断上边是否有僵尸
	var C=parseInt(ob.C),R=parseInt(ob.R);
	var m,n,zombieStr,atmp,obZombie,obZombieX;
	var StarMY=ob.style.pixelTop+15; //星星子弹的中点Y坐标
	var FlyTime,SS; //子弹纵向飞行达到僵尸所在行需要的时间，子弹纵向飞行达到僵尸所在行时僵尸已经行进的距离
	for(m=R;m>=1;m--){
		if(oGP.aR[m]==0){continue;}
		zombieStr=oGP.aZombie[C-1][m]+oGP.aZombie[C][m]+oGP.aZombie[C+1][m];
		if(zombieStr!=''){
			FlyTime=(StarMY-GetY(m))*2;
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //循环获得僵尸
				obZombie=document.getElementById(atmp[n]); //获得僵尸对象
				if(obZombie.WalkDirection==0){ //获得僵尸的被攻击点坐标
					obZombieX=obZombie.AttackedLX; //僵尸往左走，获取左被攻击点
					SS=-obZombie.Speed*Math.floor(FlyTime*0.008);
				}else{
					obZombieX=obZombie.AttackedRX; //僵尸往右走，获取右被攻击点
					SS=obZombie.Speed*Math.floor(FlyTime*0.008);
				}
				obZombieX+=SS;
				if(GetC(obZombieX)==C){ //僵尸预计行进到的列等于子弹飞行到的列
					return(true);
				}
			}
		}
	}
	return(false);
}
CStarfruit.prototype.AttackU=function(ob){
	//添加往上飞的子弹
	var Bullet=document.createElement('img');
	var d=new Date(),s='';
	s += d.getHours()+'_'+d.getMinutes()+'_'+d.getSeconds()+'_'+d.getMilliseconds();
	Bullet.id='Star_'+ob.C+'_'+ob.R+'_U_'+s;
	Bullet.setAttribute('src',dicPlantsGif('Star').src);
	Bullet.style.position='absolute';
	var MX=ob.style.pixelLeft+ob.width/2;
	Bullet.style.pixelLeft=MX-15;
	Bullet.X=MX;
	Bullet.C=ob.C;
	Bullet.R=ob.R;
	Bullet.style.pixelTop=ob.style.pixelTop+15;
	Bullet.style.zIndex=1+parseInt(ob.R);
	Bullet.style.display='none';
	Bullet.style.zIndex=3*ob.R+2;
	Bullet.AttackDirection=6; //攻击行进方向,0表示右，顺时针一直到7
	document.getElementById('dAll').appendChild(Bullet);
	setTimeout('var tmpOb=document.getElementById("'+Bullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',100);
	aMoveStar.push(Bullet);
}
CStarfruit.prototype.HaveEnemyD=function(ob){
	//判断下边是否有僵尸
	var C=parseInt(ob.C),R=parseInt(ob.R);
	var m,n,zombieStr,atmp,obZombie,obZombieX;
	var StarMY=ob.style.pixelTop+15; //星星子弹的中点Y坐标
	var FlyTime,SS; //子弹纵向飞行达到僵尸所在行需要的时间，子弹纵向飞行达到僵尸所在行时僵尸已经行进的距离
	for(m=R;m<=oGP.MaxR;m++){
		if(oGP.aR[m]==0){continue;}
		zombieStr=oGP.aZombie[C-1][m]+oGP.aZombie[C][m]+oGP.aZombie[C+1][m];
		if(zombieStr!=''){
			FlyTime=(StarMY-GetY(m))*2;
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //循环获得僵尸
				obZombie=document.getElementById(atmp[n]); //获得僵尸对象
				if(obZombie.WalkDirection==0){ //获得僵尸的被攻击点坐标
					obZombieX=obZombie.AttackedLX; //僵尸往左走，获取左被攻击点
					SS=-obZombie.Speed*Math.floor(FlyTime*0.008);
				}else{
					obZombieX=obZombie.AttackedRX; //僵尸往右走，获取右被攻击点
					SS=obZombie.Speed*Math.floor(FlyTime*0.008);
				}
				obZombieX+=SS;
				if(GetC(obZombieX)==C){ //僵尸预计行进到的列等于子弹飞行到的列
					return(true);
				}
			}
		}
	}
	return(false);
}
CStarfruit.prototype.AttackD=function(ob){
	//添加往下飞的子弹
	var Bullet=document.createElement('img');
	var d=new Date(),s='';
	s += d.getHours()+'_'+d.getMinutes()+'_'+d.getSeconds()+'_'+d.getMilliseconds();
	Bullet.id='Star_'+ob.C+'_'+ob.R+'_D_'+s;
	Bullet.setAttribute('src',dicPlantsGif('Star').src);
	Bullet.style.position='absolute';
	var MX=ob.style.pixelLeft+ob.width/2;
	Bullet.style.pixelLeft=MX-15;
	Bullet.X=MX;
	Bullet.C=ob.C;
	Bullet.R=ob.R;
	Bullet.style.pixelTop=ob.style.pixelTop+15;
	Bullet.style.zIndex=1+parseInt(ob.R);
	Bullet.style.display='none';
	Bullet.style.zIndex=3*ob.R+2;
	Bullet.AttackDirection=2; //攻击行进方向,0表示右，顺时针一直到7
	document.getElementById('dAll').appendChild(Bullet);
	setTimeout('var tmpOb=document.getElementById("'+Bullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',100);
	aMoveStar.push(Bullet);
}
function MovePeashooterBullet(){
	//移动豌豆子弹的公用函数，豌豆射手，双发射手，三线射手，机枪射手，分裂豌豆射手，冰豌豆射手
	var m=0;
	if(aMovePea.length==0){setTimeout('MovePeashooterBullet()',20);return(false);}
	while(true){
		if(m>aMovePea.length-1){break;}
		var ob=aMovePea[m];
		var zombieStr;
		var atmp,tmpX='',obZombie,tmpOb='';
		var obC=GetC(ob.X); //子弹的格子C
		var obR=ob.R; //子弹的格子R
		var MX=ob.style.pixelLeft+ob.width/2; //子弹的中点X坐标
		var side=(ob.AttackDirection==0)?10:-10; //攻击方向，+10表示右，-10表示左
		if(obC>1){
			zombieStr=oGP.aZombie[obC-1][obR]+oGP.aZombie[obC][obR]; //获得子弹所在格子的僵尸字符串
		}else{
			zombieStr=oGP.aZombie[obC][obR];
		}
		if(zombieStr!=''){ //分解僵尸字符串成僵尸数组
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //循环获得最接近的僵尸
				obZombie=document.getElementById(atmp[n]); //获得僵尸对象
				switch(ob.AttackDirection){
					case 0: //向右攻击的豌豆
						if(ob.X>=obZombie.AttackedLX&&ob.X<=obZombie.AttackedRX){ //子弹的中点坐标在僵尸左右受攻击点之间表示可以攻击
							obZombieX=obZombie.AttackedLX;
							if(tmpX==''){
								tmpX=obZombieX;
								tmpOb=obZombie;
							}else{
								if(Math.abs(obZombieX-MX)<Math.abs(tmpX-MX)){
									tmpX=obZombieX;
									tmpOb=obZombie;
								}
							}
						}
						break;
					case 4: //向左攻击的豌豆
						if(ob.X>=obZombie.AttackedLX&&ob.X<=obZombie.AttackedRX){ //子弹的中点坐标在僵尸左右受攻击点之间表示可以攻击
							obZombieX=obZombie.AttackedRX;
							if(tmpX==''){
								tmpX=obZombieX;
								tmpOb=obZombie;
							}else{
								if(Math.abs(obZombieX-MX)<Math.abs(tmpX-MX)){
									tmpX=obZombieX;
									tmpOb=obZombie;
								}
							}
						}
						break;
				}
			}
			if(tmpOb=='[object]'){
				if(tmpOb.beAttacked==1){ //僵尸不是临死状态,可以被攻击
					PlantAttack(ob.id,tmpOb.id,0,ob.Attack,0,0,ob.BulletKind,'直线');
					//if(tmpOb.FreeSlowTime==''){
						//tmpOb.style.filter='alpha(opacity=60)'; //受伤闪光
						//setTimeout('if('+tmpOb.id+'.beAttacked==1){'+tmpOb.id+'.style.filter="";}else{'+tmpOb.id+'.style.filter="gray";}',100);
					//}
				}
				//僵尸是临死状态则吸收攻击，僵尸生命匀速减少，由僵尸自身function执行
				document.getElementById('dAll').removeChild(ob);
				aMovePea.splice(m,1);
				continue;
			}
		}
		//过火焰树桩
		if(obC<=oGP.MaxC&&obC>=1&&ob.ChangeBulletC!=obC){
			if(oGP.aPlant[obC][obR][0].substr(0,12)=='P_oTorchwood'){
				switch(ob.BulletKind){
					case -1: //冰豌豆变成普通豌豆
						ob.src=dicPlantsGif('PeashooterBullet').src;
						ob.width=dicPlantsGif('PeashooterBullet').width;
						ob.height=dicPlantsGif('PeashooterBullet').height;
						ob.BulletKind=0;
						ob.ChangeBulletC=obC;
						ob.X=ob.style.pixelLeft+12;
						break;
					case 0: //普通豌豆变成火豌豆
						ob.src=dicPlantsGif('FirePeashooterBullet').src;
						if(ob.AttackDirection==0){ //往右飞
							ob.X=ob.style.pixelLeft+40;
						}else{
							ob.X=ob.style.pixelLeft+16;
							ob.style.filter='FlipH'; //往左飞的火豌豆翻转GIF图片
						}
						ob.Attack*=2;
						ob.width=dicPlantsGif('FirePeashooterBullet').width;
						ob.height=dicPlantsGif('FirePeashooterBullet').height;
						ob.BulletKind=1;
						ob.ChangeBulletC=obC;
						
						break;
				}
			}
		}
		ob.style.pixelLeft+=side;
		ob.X+=side;
		//边界
		if(ob.X>oGP.MaxWidth-10||ob.X<10){
			document.getElementById('dAll').removeChild(ob);
			aMovePea.splice(m,1);
			continue;
		}
		m+=1;
	}
	setTimeout('MovePeashooterBullet()',20);
}

function MoveStarBullet(){
	//移动杨桃子弹
	var m=0;
	if(aMoveStar.length==0){setTimeout('MoveStarBullet()',20);return(false);}
	while(true){
		if(m>aMoveStar.length-1){break;}
		var ob=aMoveStar[m];
		var zombieStr;
		var atmp,tmpX='',obZombie,tmpOb='',obZombieX;
		var obC=GetC(ob.X); //子弹的格子C
		var obR=GetR(ob.style.pixelTop+15); //子弹的格子R
		var MX=ob.style.pixelLeft+ob.width/2; //子弹的中点X坐标
		switch(ob.AttackDirection){
			case 1: //向右下攻击
				if(obC>0){zombieStr=oGP.aZombie[obC-1][obR];}
				zombieStr+=oGP.aZombie[obC][obR];
				if(obC<=oGP.MaxC){zombieStr+=oGP.aZombie[obC+1][obR];}
				if(zombieStr!=''){
					atmp=zombieStr.split(',');
					for(n=0;n<atmp.length-1;n++){
						obZombie=document.getElementById(atmp[n]);
						switch(obZombie.WalkDirection){
							case 0: //向左走的僵尸
								obZombieX=obZombie.AttackedLX;
								break;
							default:
								obZombieX=obZombie.AttackedRX;
								break;
						}
						if(ob.X>=obZombie.AttackedLX&&ob.X<=obZombie.AttackedRX){
							if(tmpX==''){
								tmpX=obZombieX;
								tmpOb=obZombie;
							}else{
								if(Math.abs(obZombieX-MX)<Math.abs(tmpX-MX)){
									tmpX=obZombieX;
									tmpOb=obZombie;
								}
							}
						}
					}
					if(tmpOb=='[object]'){
						if(tmpOb.beAttacked==1){ //僵尸不是临死状态,可以被攻击
							PlantAttack(ob.id,tmpOb.id,0,20,0,0,0,'直线');
							//if(tmpOb.FreeSlowTime==''){
							//	tmpOb.style.filter='alpha(opacity=60)'; //受伤闪光
							//	setTimeout('if('+tmpOb.id+'.beAttacked==1){'+tmpOb.id+'.style.filter="";}else{'+tmpOb.id+'.style.filter="gray";}',50);
							//}
						}
						document.getElementById('dAll').removeChild(ob);
						aMoveStar.splice(m,1);
						continue;
					}
				}
				ob.style.pixelTop+=5;
				ob.style.pixelLeft+=8.6;
				ob.X+=8.6;
				if(ob.style.pixelTop>=oGP.MaxHeight-5){document.getElementById('dAll').removeChild(ob);aMoveStar.splice(m,1);continue;}
				if(ob.style.pixelLeft>=oGP.MaxWidth-8){document.getElementById('dAll').removeChild(ob);aMoveStar.splice(m,1);continue;}
				break;
			case 7: //向右上攻击
				if(obC>0){zombieStr=oGP.aZombie[obC-1][obR];}
				zombieStr+=oGP.aZombie[obC][obR];
				if(obC<=oGP.MaxC){zombieStr+=oGP.aZombie[obC+1][obR];}
				if(zombieStr!=''){
					atmp=zombieStr.split(',');
					for(n=0;n<atmp.length-1;n++){
						obZombie=document.getElementById(atmp[n]);
						switch(obZombie.WalkDirection){
							case 0: //向左走的僵尸
								obZombieX=obZombie.AttackedLX;
								break;
							default:
								obZombieX=obZombie.AttackedRX;
								break;
						}
						if(ob.X>=obZombie.AttackedLX&&ob.X<=obZombie.AttackedRX){
							if(tmpX==''){
								tmpX=obZombieX;
								tmpOb=obZombie;
							}else{
								if(Math.abs(obZombieX-MX)<Math.abs(tmpX-MX)){
									tmpX=obZombieX;
									tmpOb=obZombie;
								}
							}
						}
					}
					if(tmpOb=='[object]'){
						if(tmpOb.beAttacked==1){ //僵尸不是临死状态,可以被攻击
							PlantAttack(ob.id,tmpOb.id,0,20,0,0,0,'直线');
							//if(tmpOb.FreeSlowTime==''){
							//	tmpOb.style.filter='alpha(opacity=60)'; //受伤闪光
							//	setTimeout('if('+tmpOb.id+'.beAttacked==1){'+tmpOb.id+'.style.filter="";}else{'+tmpOb.id+'.style.filter="gray";}',50);
							//}
						}
						document.getElementById('dAll').removeChild(ob);
						aMoveStar.splice(m,1);
						continue;
					}
				}
				ob.style.pixelTop-=5;
				ob.style.pixelLeft+=8.6;
				ob.X+=8.6;
				if(ob.style.pixelTop<=5){document.getElementById('dAll').removeChild(ob);aMoveStar.splice(m,1);continue;}
				if(ob.style.pixelLeft>=oGP.MaxWidth-8){document.getElementById('dAll').removeChild(ob);aMoveStar.splice(m,1);continue;}
				break;
			case 2: //向下攻击
				zombieStr=oGP.aZombie[obC][obR];
				if(zombieStr!=''){
					atmp=zombieStr.split(',');
					for(n=0;n<atmp.length-1;n++){
						obZombie=document.getElementById(atmp[n]);
						switch(obZombie.WalkDirection){
							case 0: //向左走的僵尸
								obZombieX=obZombie.AttackedLX;
								break;
							default:
								obZombieX=obZombie.AttackedRX;
								break;
						}
						if(tmpX==''){
							tmpX=obZombieX;
							tmpOb=obZombie;
						}else{
							if(Math.abs(obZombieX-MX)<Math.abs(tmpX-MX)){
								tmpX=obZombieX;
								tmpOb=obZombie;
							}
						}
					}
					if(tmpOb.beAttacked==1){ //僵尸不是临死状态,可以被攻击
						PlantAttack(ob.id,tmpOb.id,0,20,0,0,0,'直线');
						//if(tmpOb.FreeSlowTime==''){
						//	tmpOb.style.filter='alpha(opacity=60)'; //受伤闪光
						//	setTimeout('if('+tmpOb.id+'.beAttacked==1){'+tmpOb.id+'.style.filter="";}else{'+tmpOb.id+'.style.filter="gray";}',50);
						//}
					}
					document.getElementById('dAll').removeChild(ob);
					aMoveStar.splice(m,1);
					continue;
				}
				ob.style.pixelTop+=10;
				if(ob.style.pixelTop>=oGP.MaxHeight-10){document.getElementById('dAll').removeChild(ob);aMoveStar.splice(m,1);continue;}
				break;
			case 6: //向上攻击
				zombieStr=oGP.aZombie[obC][obR];
				if(zombieStr!=''){
					atmp=zombieStr.split(',');
					for(n=0;n<atmp.length-1;n++){
						obZombie=document.getElementById(atmp[n]);
						switch(obZombie.WalkDirection){
							case 0: //向左走的僵尸
								obZombieX=obZombie.AttackedLX;
								break;
							default:
								obZombieX=obZombie.AttackedRX;
								break;
						}
						if(tmpX==''){
							tmpX=obZombieX;
							tmpOb=obZombie;
						}else{
							if(Math.abs(obZombieX-MX)<Math.abs(tmpX-MX)){
								tmpX=obZombieX;
								tmpOb=obZombie;
							}
						}
					}
					if(tmpOb.beAttacked==1){ //僵尸不是临死状态,可以被攻击
						PlantAttack(ob.id,tmpOb.id,0,20,0,0,0,'直线');
						//if(tmpOb.FreeSlowTime==''){
						//	tmpOb.style.filter='alpha(opacity=60)'; //受伤闪光
						//	setTimeout('if('+tmpOb.id+'.beAttacked==1){'+tmpOb.id+'.style.filter="";}else{'+tmpOb.id+'.style.filter="gray";}',50);
						//}
					}
					document.getElementById('dAll').removeChild(ob);
					aMoveStar.splice(m,1);
					continue;
				}
				ob.style.pixelTop-=10;
				if(ob.style.pixelTop<=10){document.getElementById('dAll').removeChild(ob);aMoveStar.splice(m,1);continue;}
				break;
			case 4: //向左攻击
				if(obC>0){zombieStr=oGP.aZombie[obC-1][obR];}
				zombieStr+=oGP.aZombie[obC][obR];
				if(obC<=oGP.MaxC){zombieStr+=oGP.aZombie[obC+1][obR];}
				if(zombieStr!=''){
					atmp=zombieStr.split(',');
					for(n=0;n<atmp.length-1;n++){
						obZombie=document.getElementById(atmp[n]);
						obZombieX=obZombie.AttackedRX;
						if(ob.X>=obZombie.AttackedLX&&ob.X<=obZombie.AttackedRX){
							if(tmpX==''){
								tmpX=obZombieX;
								tmpOb=obZombie;
							}else{
								if(Math.abs(obZombieX-MX)<Math.abs(tmpX-MX)){
									tmpX=obZombieX;
									tmpOb=obZombie;
								}
							}
						}
					}
					if(tmpOb=='[object]'){
						if(tmpOb.beAttacked==1){ //僵尸不是临死状态,可以被攻击
							PlantAttack(ob.id,tmpOb.id,0,20,0,0,0,'直线');
							//if(tmpOb.FreeSlowTime==''){
							//	tmpOb.style.filter='alpha(opacity=60)'; //受伤闪光
							//	setTimeout('if('+tmpOb.id+'.beAttacked==1){'+tmpOb.id+'.style.filter="";}else{'+tmpOb.id+'.style.filter="gray";}',50);
							//}
						}
						//僵尸是临死状态则吸收攻击，僵尸生命匀速减少，由僵尸自身function执行
						document.getElementById('dAll').removeChild(ob);
						aMoveStar.splice(m,1);
						continue;
					}
				}
				ob.style.pixelLeft-=10;
				ob.X-=10;
				if(ob.X<=10){document.getElementById('dAll').removeChild(ob);aMoveStar.splice(m,1);continue;}
				break;
		}
		m+=1;
	}
	setTimeout('MoveStarBullet()',20);
}