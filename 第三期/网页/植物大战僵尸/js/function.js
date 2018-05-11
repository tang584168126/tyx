function SelectZombie(){
	//选择上场僵尸
	var AlreadySelectNum=oGP.ArrayZombies.length;
	var SelectNum=10-AlreadySelectNum;
	var n,m;
	if(oGP.CanSelectZombies!=''){
		var aSelect=oGP.CanSelectZombies.split(',');
		for(n=1;n<=SelectNum;n++){
			if(aSelect.length==0){break;}
			m=Math.floor(Math.random()*aSelect.length);
			oGP.ArrayZombies.push(aSelect[m]);
			aSelect.splice(m,1);
		}
	}
	var OZombie,HP;
	for(n=0;n<oGP.ArrayZombies.length;n++){
		eval('OZombie='+oGP.ArrayZombies[n]);
		HP=OZombie.HP+OZombie.OrnHP;
		switch(true){
			case HP<420:
				ArrayZombies[1].push(oGP.ArrayZombies[n]);
				break;
			case HP>=420&&HP<1300:
				ArrayZombies[2].push(oGP.ArrayZombies[n]);
				break;
			default:
				ArrayZombies[3].push(oGP.ArrayZombies[n]);			
		}
	}
}

function StartGame(){
	oGP.BeginCool(); //卡片的开场冷却
	oGP.Monitor(); //全局监控计时器
	SunCoolTime=Math.floor(5+Math.random()*4); //随机时间5－8秒开局掉落阳光
	SunCoolTime*=1000;
	setTimeout('AutoProduceSun(25)',SunCoolTime); //阳光掉落计时器
	MovePeashooterBullet(); //移动豌豆计时器，只有选择了豌豆家族才执行计时器
	MoveStarBullet(); //移动杨桃子弹
	setTimeout('AddZombiesFlag();MoveZombies();',15000); //开局刷怪//移动所有僵尸的公用计时器，开场调用
}
function AutoProduceSun(num){
	//自动掉落阳光的计时器
	if(Win==1||Win==-1){return(false);}
	var rC,rR;
	var SunCoolTime;
	rC=Math.floor(1+Math.random()*oGP.MaxC); //阳光的随机格子坐标
	rR=Math.floor(1+Math.random()*oGP.MaxR);
	SunCoolTime=Math.floor(9+Math.random()*3); //随机时间9－11秒
	SunCoolTime*=1000;
	setTimeout('AutoProduceSun('+num+')',SunCoolTime);
	AppearSun(GetX(rC),GetY(rR),num,1);
}
function MoveDropSun(id,num,MaxY){
	//自然掉落阳光过程计时器
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);}
	if(ob.click==1){return(false);}
	if(ob.style.pixelTop<MaxY-33-20){ //还没掉到最大Y值，继续掉落
		ob.style.pixelTop+=4;
		window.setTimeout('MoveDropSun("'+ob.id+'",'+num+','+MaxY+')',50);
	}else{
		window.setTimeout('DisappearSun("'+ob.id+'")',8000); //调用阳光消失function
	}
}
function AppearSun(X,Y,num,ifBeginMove){
	//产生阳光,XY表示坐标，num表示阳光数量，ifBeginMove表示是否开启阳光向下移动计时器，向日葵产生的阳光不开启，自然产生的阳光立即开启
	if(Win==1||Win==-1){return(false);} //胜利，取消产生阳光
	var obImg=new Image();
	obImg.src=dicGroundGif('Sun').src;
	obImg.id='Sun_'+NumSun;
	obImg.width=65;
	obImg.height=67;
	obImg.style.position='absolute';
	obImg.style.pixelLeft=X;
	obImg.style.cursor='hand';
	obImg.style.zIndex=25;
	obImg.style.filter='alpha(opacity=90) Glow(Color="#FFFFFF",Strength="3")';
	obImg.click=0;
	obImg.SunNum=num;
	NumSun+=1;
	if(ifBeginMove==1){
		obImg.style.pixelTop=90-obImg.height/2;
		document.getElementById('dAll').appendChild(obImg);
		document.getElementById(obImg.id).onclick=function(){ClickSun(obImg);}
		window.setTimeout('MoveDropSun("'+obImg.id+'",'+num+','+Y+')',100);
	}else{
		obImg.style.pixelTop=Y-obImg.height/2-20;
		document.getElementById('dAll').appendChild(obImg);
		document.getElementById(obImg.id).onclick=function(){ClickSun(obImg);}
		window.setTimeout('DisappearSun("'+obImg.id+'")',8000); //调用阳光消失function
	}
}
function DisappearSun(id){
	//阳光消失
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);}
	document.getElementById('dAll').removeChild(ob);
}
function ClickSun(ob){
	//拾取阳光
	if(ob.click==1){return(false);}
	oGP.SunNum+=ob.SunNum;
	if(oGP.SunNum>=9990){oGP.SunNum=9990;}
	ob.click=1;
	document.getElementById('tSunNum').innerText=oGP.SunNum;
	MoveClickSun(ob);
}
function MoveClickSun(ob){
	//移动拾取的阳光到左上角
	var X1=9,Y1=6;
	var X2=ob.style.pixelLeft,Y2=ob.style.pixelTop;
	var X,Y;
	X=X2-30;
	Y=(X-X1)/(X2-X1)*(Y2-Y1)+Y1;
	ob.style.pixelLeft=X;
	ob.style.pixelTop=Y;
	if(ob.style.pixelLeft>9){
		window.setTimeout('MoveClickSun('+ob.id+')',10);
	}else{
		document.getElementById('dAll').removeChild(ob);
	}
}
function CanGrow(C,R){
	//是否可以种植选定植物
	if(ChoseClassName.canGrow.match(oGP.aPAfterGrow[C][R])==null){ //先判断当前场地属性是否可以种植
		return(false); //不能种植
	}
	if(ChoseClassName.isGroundPlant==1){ //是容器植物
		if(oGP.aPlant[C][R][0]!=''||oGP.aPlant[C][R][1]!=''){ //已经有普通植物了，不能再种植容器植物
			return(false);
		}
		if(oGP.aGroundPlant[C][R][0]!=''&&oGP.aGroundPlant[C][R][1]!=''){ //场地已经有两种容器植物了
			return(false);
		}
	}else{ //不是容器植物
		if(ChoseClassName.isProtectPlant==1){ //是保护性植物
			if(oGP.aPlant[C][R][1]!=''){ //已经有保护性植物了
				return(false);
			}
		}else{ //不是保护性植物
			if(oGP.aPlant[C][R][0]!=''){ //已经有植物了
				if(ChoseClassName.onOtherPlant==''){ //选择植物必须单独种植，不能种植在其他植物上
					return(false);
				}else{
					var ob=document.getElementById(oGP.aPlant[C][R][0]); //获取选择格子上的植物
					if(ChoseClassName.onOtherPlant!=ob.EName){ //必须种植的植物不是格子上的植物
						return(false);
					}
				}
			}else{
				if(ChoseClassName.onOtherPlant!=''){return(false);}
			}
		}
	}
	return(true);
}

function InitCard(){
	//放置所有卡片
	var n,a;
	var I=(new VBArray(dicCardGif.Items())).toArray();
	if(dicCardGif.Count==0){return(false);}
	for(n=0;n<I.length;n++){
		document.getElementById('tCard'+n).innerHTML='<img id="Card'+n+'" C="'+I[n].C+'" border="0" src="'+I[n].src+'" alt="'+I[n].alt+'" style="filter:gray;position:absolute;left:0;top:5;" onclick="ChosePlant(this.id);" HaveEnoughSun="0" isReady="0">';
	}
/*
	for(n=1;n<CardImage.length;n++){
		a=CardImage[n].split(';');
		document.getElementById('tCard'+n).innerHTML='<img id="Card'+n+'" C="'+a[1]+'" border="0" src="'+a[0]+'" alt="'+a[2]+'" style="filter:gray;position:absolute;left:0;top:5;" onclick="ChosePlant(this.id);" HaveEnoughSun="0" isReady="0">';
	}
*/
}

function CancelPlant(){
	//放弃种植
	ChoseCard.style.filter='';
	ChoseClassName=null;
	Chose=0;
	document.getElementById('dAll').removeChild(document.getElementById('movePlant'));
	document.getElementById('dAll').removeChild(document.getElementById('movePlantAlpha'));
}
function CancelShovel(){
	//放弃铲子
	var ob=document.getElementById('imgShovel');
	ob.style.position='relative';
	ob.style.pixelLeft=0;
	ob.style.pixelTop=0;
	ob.style.zIndex=1;
	Chose=0;

}
function ChoseShovel(){
	//选择铲子
	if(Chose==1){CancelPlant();}
	Chose=-1;
	var ob=document.getElementById('imgShovel');
	ob.style.position='absolute';
	ob.style.pixelLeft=event.clientX-40;
	ob.style.pixelTop=event.clientY-40;
	ob.style.zIndex=50;
}

function ChosePlant(ID){
	//选择植物
	ChoseCard=document.getElementById(ID);
	if(ChoseCard.HaveEnoughSun==0||ChoseCard.isReady==0){return(false);}
	ChoseCard.style.filter='gray';
	eval('ChoseClassName='+ChoseCard.C);
	Chose=1;
	var movePlant=new Image();
	var movePlantAlpha=new Image();
	movePlant.src=dicPlantsGif(ChoseClassName.EName).src;
	movePlantAlpha.src=dicPlantsGif(ChoseClassName.EName).src;
	movePlant.id='movePlant';
	//movePlant.setAttribute('src',dicPlantsGif(ChoseClassName.EName).src);
	movePlant.width=ChoseClassName.width;
	movePlant.height=ChoseClassName.height;
	movePlant.style.position='absolute';
	movePlant.style.pixelLeft=event.clientX-ChoseClassName.width/2;
	movePlant.style.pixelTop=event.clientY-ChoseClassName.height/2;
	movePlant.style.zIndex=31;

	//movePlantAlpha.setAttribute('src',dicPlantsGif(ChoseClassName.EName).src);
	movePlantAlpha.style.filter='alpha(opacity=40)';
	movePlantAlpha.style.zIndex=30;

	movePlantAlpha.id='movePlantAlpha';
	movePlantAlpha.width=ChoseClassName.width;
	movePlantAlpha.height=ChoseClassName.height;
	movePlantAlpha.style.position='absolute';	
	movePlantAlpha.style.display='none';
	document.getElementById('dAll').appendChild(movePlant);
	document.getElementById('dAll').appendChild(movePlantAlpha);

}
function DoCoolTimer(n,a,b){
	//冷却计时器
	var ob=document.getElementById('Card'+n+'_1');
	ob.style.clip='rect(0,'+ob.width+','+ob.height*(a-b)+',0)';
	if(a-b>0){
		window.setTimeout('DoCoolTimer('+n+','+(a-b)+','+b+')',1000);
	}else{
		document.getElementById('tCard'+n).removeChild(ob);
		document.getElementById('Card'+n).isReady=1;
	}
}
function GrowPlant(X,Y){
	//放置某个植物
	//X,Y:鼠标实际坐标
	var rX,rY; //rX,rY:植物底边中点坐标
	var pX,pY; //pX,pY:植物的实际坐标
	var R,C;   //R,C:列,行
	var aX,aY; //临时数组
	rX=ChosePlantX(X)
	rY=ChosePlantY(Y+document.body.scrollTop);
	if(rY==0){
		CancelPlant();
		return(false);
	}
	C=GetPlantC(rX);R=GetPlantR(rY);
	pX=rX-ChoseClassName.width/2;
	pY=rY-ChoseClassName.height+ChoseClassName.GetDeviationY(C,R);
	//判断能否种植在该场地上
	if(!CanGrow(C,R)){return(false);}
	Chose=0;
	ChoseCard.style.filter='';
	var plant=new Image();
	var d=new Date(),s='';
	s += d.getHours()+'_'+d.getMinutes()+'_'+d.getSeconds()+'_'+d.getMilliseconds();
	plant.id='P_'+ChoseClassName.EName+'_'+s;
	//plant.setAttribute('src',ChoseClassName.normalGif);
	plant.EName=ChoseClassName.EName;
	plant.name='Plants';
	plant.C=C;
	plant.R=R;
	plant.beAttackedPointL=ChoseClassName.beAttackedPointL;
	plant.beAttackedPointR=ChoseClassName.beAttackedPointR;
	plant.HP=ChoseClassName.HP;
	plant.width=ChoseClassName.width;
	plant.height=ChoseClassName.height;
	plant.style.position='absolute';
	plant.style.pixelLeft=pX;
	plant.style.pixelTop=pY;
	plant.AttackedLX=pX+plant.beAttackedPointL; //左受攻击点的X
	plant.AttackedRX=pX+plant.beAttackedPointR; //右受攻击点的X
	plant.style.zIndex=3*R;
	plant.unrivaled=0; //是否无敌
	plant.onmousedown=function(){if(event.button==1&&Chose==-1){fShovel(plant.id);}} //铲除植物
	plant.onmousemove=function(){if(Chose==-1){SelectShovel(plant.id);}} //选择要铲除的植物，发光
	plant.onmouseout=function(){if(Chose==-1){CancelSelectShovel(plant.id);}}
	//减少阳光
	oGP.SunNum=parseInt(oGP.SunNum)-ChoseClassName.SunNum;
	document.getElementById('tSunNum').innerText=oGP.SunNum;
	var dOb=document.getElementById('dAll');
	if(ChoseClassName.onOtherPlant!=''){
		if(oGP.aPlant[C][R][0]!=''){
			var tmpOb;
			tmpOb=document.getElementById(oGP.aPlant[C][R][0]);
			eval(tmpOb.EName+'.Die('+tmpOb.id+')'); //如果是必须种植在其他植物上的升级植物，则调用原植物的死亡函数
		}
	}
	dOb.appendChild(plant);
	ChoseClassName.Birth(plant); //调用植物出生方法
	dOb.removeChild(document.getElementById('movePlant'));
	dOb.removeChild(document.getElementById('movePlantAlpha'));
	var n=ChoseCard.id.substr(4);
	document.getElementById('tCard'+n).innerHTML+='<img id="Card'+n+'_1" border="0" src="'+dicCardGif(ChoseClassName.EName).src+'" alt="'+ChoseClassName.CName+'" style="filter:Xray;position:absolute;left:0;top:5;">';
	var ob=document.getElementById('Card'+n);
	ob.style.cursor='';
	ob.isReady=0;
	DoCoolTimer(n,1,1000/ChoseClassName.coolTime); //调用冷却方法,在卡片上显示冷却进度
}
function PlantStatus(id){
	//判断植物的状态来更改filter或者src等，由僵尸攻击函数ZombieAttack调用
	var ob=document.getElementById(id);
	var OPlant,HP=ob.HP;
	eval('OPlant='+ob.EName);
	switch(ob.EName){
		case 'oPumpkinHead': //南瓜头
			switch(true){
				case HP<=1333:
					if(ob.src!=dicPlantsGif('PumpkinHeadHurt2').src){
						ob.src=dicPlantsGif('PumpkinHeadHurt2').src;
						ob.width=dicPlantsGif('PumpkinHeadHurt2').width;
						ob.height=dicPlantsGif('PumpkinHeadHurt2').height;
					}
					break;
				case HP<=2666:
					if(ob.src!=dicPlantsGif('PumpkinHeadHurt1').src){
						ob.style.pixelTo+=8;
						ob.src=dicPlantsGif('PumpkinHeadHurt1').src;
						ob.width=dicPlantsGif('PumpkinHeadHurt1').width;
						ob.height=dicPlantsGif('PumpkinHeadHurt1').height;
						var ob1=document.getElementById(ob.id+'_2');
						ob1.style.pixelTop+=8;
						ob1.src=dicPlantsGif('PumpkinHeadBackHurt').src;
						ob1.width=dicPlantsGif('PumpkinHeadBackHurt').width;
						ob1.height=dicPlantsGif('PumpkinHeadBackHurt').height;
					}
					break;
			}
			break;
		case 'oWallNut': //坚果墙
			switch(true){
				case HP<=1333:
					if(ob.src!=dicPlantsGif('WallNutHurt2').src){
						ob.style.pixelTop-=1;
						ob.src=dicPlantsGif('WallNutHurt2').src;
						ob.width=dicPlantsGif('WallNutHurt2').width;
						ob.height=dicPlantsGif('WallNutHurt2').height;
					}
					break;
				case HP<=2666:
					if(ob.src!=dicPlantsGif('WallNutHurt1').src){
						ob.style.pixelTo-=2;
						ob.src=dicPlantsGif('WallNutHurt1').src;
						ob.width=dicPlantsGif('WallNutHurt1').width;
						ob.height=dicPlantsGif('WallNutHurt1').height;
					}
					break;
			}
			break;
		case 'oTallNut': //高坚果
			switch(true){
				case HP<=2666:
					if(ob.src!=dicPlantsGif('TallNutHurt2').src){
						ob.src=dicPlantsGif('TallNutHurt2').src;
					}
					break;
				case HP<=5332:
					if(ob.src!=dicPlantsGif('TallNutHurt1').src){
						ob.src=dicPlantsGif('TallNutHurt1').src;
					}
					break;
			}
			break;
		case 'oGralic': //大蒜
			switch(true){
				case HP<=133:
					if(ob.src!=dicPlantsGif('GarlicHurt2').src){
						ob.src=dicPlantsGif('GarlicHurt2').src;
					}
					break;
				case HP<=266:
					if(ob.src!=dicPlantsGif('GarlicHurt1').src){
						ob.src=dicPlantsGif('GarlicHurt1').src;
					}
					break;
			}
			break;
	}
}

function getElementsByName(tag,eltname){ 
	var elts=document.getElementsByTagName(tag); 
	var count=0; 
	var elements=[]; 
	for(var i=0;i<elts.length;i++){ 
		if(elts[i].getAttribute("name")==eltname){ 
			elements[count++]=elts[i]; 
		} 
	} 
	return elements;
}

function initZombie(obName){
	var zombie=new Image();
	var ob,C=11,R;
	eval('ob='+obName);
	switch(oGP.GroundKind){
		case '水池':
			var aGr=new Array(1,2,5,6); //草地行
			if(ob.canAppear.match('[草地]')!=null){
				R=aGr[Math.floor(0+Math.random()*4)];
			}else{
				R=Math.floor(3+Math.random()*2);
			}
			break;
		case '草地':
			R=Math.floor(1+Math.random()*5);
			break;
	}
	//zombie.src=dicZombiesGif(obName).src;
	zombie.src=ob.NormalGif;
	NumZombies+=1; //僵尸实时数量
	NoZombies+=1; //僵尸已经出现过的数量
	oGP.aR[R]+=1; //每行僵尸增加1
	//var d=new Date(),s='';
	//s += d.getHours()+'_'+d.getMinutes()+'_'+d.getSeconds()+'_'+d.getMilliseconds();
	//zombie.id='Z_'+ob.EName+'_'+s;
	zombie.id='Z_'+ob.EName+'_'+NoZombies;
	//zombie.name='Zombies';
	zombie.setAttribute('name','Zombies');
	zombie.EName=ob.EName;
	zombie.C=C;
	zombie.R=R;
	zombie.HP=ob.HP;
	zombie.OrnHP=ob.OrnHP; //饰品血量
	zombie.NormalGif=ob.NormalGif;
	zombie.AttackGif=ob.AttackGif;
	zombie.beAttacked=1;
	zombie.isAttacking=0; //是否正在攻击
	zombie.Speed=ob.Speed;
	zombie.FreeSetbodyTime='' //取消定身时间
	zombie.FreeFreezeTime=''; //取消被冰冻时间
	zombie.FreeSlowTime=''; //取消被减速的时间
	zombie.againstFreeze=ob.againstFreeze; //是否免疫冰冻
	zombie.againstSlow=ob.againstSlow; //是否免疫减速
	zombie.againstSputtering=ob.againstSputtering; //是否免疫溅射
	zombie.WalkDirection=ob.WalkDirection; //0表示往左走，1表示往右走
	zombie.beAttackedPointL=ob.beAttackedPointL; //左受攻击点相对于pixelLeft右偏移的距离
	zombie.beAttackedPointR=ob.beAttackedPointR; //右受攻击点相对于pixelLeft右偏移的距离
	zombie.width=ob.width;
	zombie.height=ob.height;
	zombie.style.position='absolute';
	zombie.style.pixelLeft=GetX(C)-ob.beAttackedPointL;
	zombie.X=zombie.style.pixelLeft; //X可以取小数
	zombie.AttackedLX=zombie.X+zombie.beAttackedPointL; //实时改变的左受攻击点的X
	zombie.AttackedRX=zombie.X+zombie.beAttackedPointR; //实时改变的右受攻击点的X
	zombie.style.pixelTop=GetY(R)-parseInt(ob.height);
	zombie.style.zIndex=3*R+1;
	var dOb=document.getElementById('dAll');
	dOb.appendChild(zombie);
	var ChoseZombieClassName;
	eval('ChoseZombieClassName='+zombie.EName);
	ChoseZombieClassName.Birth(zombie);
}
function ShowLargeWave(){
	//一大波僵尸正在接近
	if(document.getElementById('LargeWave')==null){
		var img=new Image();
		img.id='LargeWave';
		img.src=dicGroundGif('LargeWave').src;
		img.style.position='absolute';
		img.style.pixelLeft=oGP.MaxWidth/2-143;
		img.style.pixelTop=oGP.MaxHeight/2-17;
		img.style.zIndex=50;
		document.getElementById('dAll').appendChild(img);
		setTimeout('document.getElementById("dAll").removeChild('+img.id+')',5000);
	}
}
function ShowFinalWave(){
	//最后一波僵尸
	if(document.getElementById('FinalWave')==null){
		var img=new Image();
		img.id='FinalWave';
		img.src=dicGroundGif('LargeWave').src;
		img.style.position='absolute';
		img.style.pixelLeft=oGP.MaxWidth/2-143;
		img.style.pixelTop=oGP.MaxHeight/2-17;
		img.style.zIndex=50;
		document.getElementById('dAll').appendChild(img);
		setTimeout('document.getElementById("FinalWave").style.display="none";document.getElementById("FinalWave").src="'+dicGroundGif('FinalWave').src+'"',6000);
		setTimeout('document.getElementById("FinalWave").style.display="block";document.getElementById("FinalWave").style.pixelLeft='+(oGP.MaxWidth/2-143)+';document.getElementById("FinalWave").style.pixelTop='+(oGP.MaxHeight/2-17),7000);
		setTimeout('document.getElementById("dAll").removeChild('+img.id+')',7500);
	}
}
function RefreshZombiesTimer(Num){
	//刷新的计时器
	Num+=1;
	if(FlagZombies==9){
		if(Num>=200&&Num<=210){ShowLargeWave();}
	}else{
		if(FlagZombies==19&&Num>=170&&Num<=180){ShowFinalWave();}
	}
	if(Num>=250){ //大于最大时间25秒
		AlreadyAddZombiesFlag=1;
		AddZombiesFlag();
		Num=0;
		return(false);
	}
	if(NumZombies==0&&AlreadyAddZombiesFlag==0){
		AlreadyAddZombiesFlag=1;
		switch(true){
			case FlagZombies==9:
				ShowLargeWave();
			case FlagZombies>=1&&FlagZombies<9:
				setTimeout('AddZombiesFlag()',5000);
				break;
			case FlagZombies==19:
				ShowFinalWave();
				setTimeout('AddZombiesFlag()',8000);
				break;
			case FlagZombies>9&&FlagZombies<20:
				setTimeout('AddZombiesFlag()',5000);
				break;
		}
		return(false);
	}
	setTimeout('RefreshZombiesTimer('+Num+')',100);
}
function SelectFlagZombie(SumNum){
	//组合每波的僵尸种类；
	var aZ=new Array();
	var aTmp=new Array();
	var n,m;
	var U,tmp=ArrayZombies.length-1; //表示僵尸的最高强度是3;
	while(true){
		if(SumNum<=0){break;}
		if(SumNum<tmp){
			U=SumNum;
		}else{
			U=tmp;
		}
		for(n=1;n<=U;n++){
			for(m=0;m<ArrayZombies[n].length;m++){
				aTmp.push([n,ArrayZombies[n][m]]);
			}
		}
		if(aTmp.length==0){
			for(n=1;n<=tmp;n++){
				if(ArrayZombies[n].length>0){
					for(m=0;m<ArrayZombies[n].length;m++){
						aTmp.push([n,ArrayZombies[n][m]]);
					}
					break;
				}
			}
		}
		n=Math.floor(Math.random()*aTmp.length);
		aZ.push(aTmp[n][1]);
		SumNum-=aTmp[n][0];
	}
	return(aZ);
}
function AddZombiesFlag(){
	//添加僵尸Flag
	var R;
	var SumNum; //僵尸强度
	var aTmp; //临时数组
	var n;
	var UboundTime;
	FlagZombies+=1;
	switch(true){
		case FlagZombies>=1&&FlagZombies<=3:
			SumNum=1;
			UboundTime=10001;
			SetTimeoutZombie(SumNum,UboundTime)
			//initZombie(Math.floor(Math.random()*ArrayZombies[1].length));
			break;
		case FlagZombies>=4&&FlagZombies<=5:
			SumNum=2;
			UboundTime=10001;
			SetTimeoutZombie(SumNum,UboundTime)
			break;
		case FlagZombies>=6&&FlagZombies<=9:
			SumNum=3;
			UboundTime=10001;
			SetTimeoutZombie(SumNum,UboundTime)
			break;			
		case FlagZombies==10:
			SumNum=9;
			UboundTime=5001;
			initZombie('oFlagZombie');
			setTimeout('SetTimeoutZombie(9,5001)',2000);
			break;
		case FlagZombies>=11&&FlagZombies<=13:
			SumNum=4;
			UboundTime=10001;
			SetTimeoutZombie(SumNum,UboundTime)
			break;
		case FlagZombies>=14&&FlagZombies<=15:
			SumNum=5;
			UboundTime=10001;
			SetTimeoutZombie(SumNum,UboundTime)
			break;
		case FlagZombies>=16&&FlagZombies<=19:
			SumNum=6;
			UboundTime=10001;
			SetTimeoutZombie(SumNum,UboundTime)
			break;
		case FlagZombies==20:
			SumNum=14;
			UboundTime=3001;
			initZombie('oFlagZombie');
			aTmp=SelectFlagZombie(SumNum);
			for(var n=0;n<aTmp.length-1;n++){
				setTimeout('initZombie("'+aTmp[n]+'")',Math.floor(2000+Math.random()*UboundTime));
			}
			setTimeout('initZombie("'+aTmp[aTmp.length-1]+'");FlagZombies=21;',Math.floor(Math.random()*UboundTime));
			return(false);
	}
	AlreadyAddZombiesFlag=0;
	RefreshZombiesTimer(0);
}
function SetTimeoutZombie(SumNum,UboundTime){
	aTmp=SelectFlagZombie(SumNum);
	initZombie(aTmp[0]);
	for(var n=1;n<aTmp.length;n++){
		setTimeout('initZombie("'+aTmp[n]+'")',Math.floor(Math.random()*UboundTime));
	}
}
function fShovel(id){
	//铲除植物
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);}
	var C=ob.C,R=ob.R;
	var OPlant;
	eval('OPlant='+ob.EName);
	if(OPlant.isGroundPlant==1){ //容器植物
		if(oGP.aPlant[C][R][0]!=''||oGP.aPlant[C][R][1]!=''){return(false);}
		OPlant.Die(ob);
	}else{ //非容器植物
		OPlant.Die(ob);
	}
	CancelShovel();
}
function SelectShovel(id){
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);}
	ob.style.filter='alpha(opacity=60)';
}
function CancelSelectShovel(id){
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);}
	ob.style.filter=(ob.style.filter).replace('alpha(opacity=60)','');
}
dAll.onmousedown=function(){
	switch(Chose){
		case 1:
			switch(event.button){
				case 1:
					GrowPlant(event.clientX,event.clientY);
					break;
				default:
					CancelPlant();
			}
			break;
		case -1:
			if(event.button!=1){CancelShovel()}
	}
}

/*
dAll.onmousedown=function(){
	switch(Chose){
		case 1:
			switch(event.button){
				case 1:
					GrowPlant(event.clientX,event.clientY);
					break;
				default:
					CancelPlant();
			}
			break;
		case -1:
			switch(event.button){
				case 1:
					var C=GetC(event.clientX);
					var R=GetR(event.clientY);
					var ob,OPlant;
					if(oGP.aPlant[C][R][0]!=''){
						ob=document.getElementById(oGP.aPlant[C][R][0]);
					}else{
						if(oGP.aPlant[C][R][1]!=''){
							ob=document.getElementById(oGP.aPlant[C][R][1]);
						}else{
							if(oGP.aGroundPlant[C][R][0]!=''){
								ob=document.getElementById(oGP.aGroundPlant[C][R][0]);
							}else{
								if(oGP.aGroundPlant[C][R][1]!=''){ob=document.getElementById(oGP.aGroundPlant[C][R][1]);}
							}
						}
					}
					if(ob=='[object]'){
						eval('OPlant='+ob.EName);
						OPlant.Die(ob);
					}
				default:
					CancelShovel();
			}
			break;
	}
}
*/
dAll.onmousemove=function(){
	if(Chose==0){return(false);}
	switch(Chose){
		case 1: //种植
			var ob=document.getElementById('movePlant');
			var obAlpha=document.getElementById('movePlantAlpha');
			var pX,pY;
			var C,R;
			var X=event.clientX;Y=event.clientY+document.body.scrollTop;
			ob.style.pixelLeft=X-ob.width/2;
			ob.style.pixelTop=Y-ob.height/2;
			rX=ChosePlantX(X);rY=ChosePlantY(Y);
			if(rY!=0){
				C=GetPlantC(rX);R=GetPlantR(rY);
				pX=rX-ChoseClassName.width/2;pY=rY-ChoseClassName.height;
				obAlpha.style.pixelLeft=pX;
				obAlpha.style.pixelTop=pY+ChoseClassName.GetDeviationY(C,R);
				if(CanGrow(C,R)){
					obAlpha.style.display='block';
				}else{
					obAlpha.style.display='none';
				}
			}else{
				obAlpha.style.display='none';
			}
			break;
		case -1:
			var ob=document.getElementById('imgShovel');
			ob.style.pixelLeft=event.clientX-30;
			ob.style.pixelTop=event.clientY-50;
			break;
	}
}

function LawnMowerKill(R){
	//剪草机
	var ob=document.getElementById('LawnMower'+R);
	var C=GetC(ob.style.pixelLeft+71);
	var zombieStr=oGP.aZombie[C][R];
	var n,atmp,obZombie,OZombie;
	atmp=zombieStr.split(',');
	for(n=0;n<atmp.length-1;n++){ //循环获得僵尸
		obZombie=document.getElementById(atmp[n]); //获得僵尸对象
		eval('OZombie='+obZombie.EName);
		OZombie.Die(obZombie);
	}
	ob.style.pixelLeft+=5;
	if(ob.style.pixelLeft>oGP.MaxWidth){
		document.getElementById('dAll').removeChild(ob);
		return(false);
	}
	setTimeout('LawnMowerKill('+R+')',10);
}

function GameOver(){
	//游戏失败
	var img=new Image();
	img.src=dicGroundGif('ZombiesWon').src;
	img.style.zIndex=100;
	img.style.position='absolute';
	img.style.pixelLeft=0;
	img.style.pixelTop=0;
	img.width=document.body.clientWidth;
	img.height=document.body.clientHeight;
	img.id='imgGameOver';
	img.onclick=function(){RestartGame();}
	document.body.appendChild(img);
}

//------------------------选择卡片------------------------
var SelectNum=0,SelectSum=10;
function SelectCard(CardID){
	//选择卡片
	var ob=document.getElementById('Card'+CardID);
	if(ob.style.filter!='gray'){
		if(SelectNum==SelectSum){return(false);}
		SelectNum+=1;
		var img=new Image();
		img.src=ob.src;
		img.id='SelectCard'+CardID;
		img.EName=ob.EName;
		img.CardID=CardID;
		img.onclick=function(){SelectCard(CardID)}
		document.getElementById('tCard'+(SelectNum-1)).appendChild(img);
		ob.style.filter='gray';
	}else{
		SelectNum-=1;
		var ob2=document.getElementById('SelectCard'+CardID);
		ob2=(ob2.offsetParent);
		ob2.removeChild(document.getElementById('SelectCard'+CardID));
		ob.style.filter='';
		SortCard();
	}
	if(SelectNum==SelectSum){
		document.getElementById('btnOK').disabled=false;
	}
}
function SortCard(){
	//重排卡片
	var n,m,ob;
	var obN,obM;
	for(n=1;n<SelectSum;n++){
		obN=document.getElementById('tCard'+(n-1));
		if(obN.childNodes.length==0){
			obM=document.getElementById('tCard'+n)
			if(obM.childNodes.length==0){return(false);}
			ob=obM.childNodes[0];
			obN.appendChild(ob);
		}
	}
	document.getElementById('btnOK').disabled=true;
}
function ResetSelectCard(){
	//全部重选
	var n,ob,CardID;
	document.getElementById('btnOK').disabled=true;
	for(n=1;n<=SelectNum;n++){
		obN=document.getElementById('tCard'+(n-1));
		if(obN.childNodes.length>0){
			ob=obN.childNodes[0];
			CardID=ob.CardID;
			document.getElementById('Card'+CardID).style.filter='';
			obN.innerHTML='';
		}
	}
	SelectNum=0;
}
function LetsGO(){
	var n,obN;
	for(n=1;n<=SelectNum;n++){
		obN=document.getElementById('tCard'+(n-1));
		ob=obN.childNodes[0];
		eval('o'+ob.EName+'=new C'+ob.EName+'();');
	}
	document.getElementById('dZombie').innerHTML='';
	document.getElementById('dSelectCard').style.display='none';
	InitInterface();
}
function DisplayZombie(){
	//X:dAll:500-750,dZombie:0-335(50-285)
	//Y:dAll:200-600,dZombie:0-513(100-513)
	//显示出场僵尸种类
	var aZ=new Array();
	var aTmp=new Array();
	var n,m,aX=new Array(),aY=new Array();
	var U=ArrayZombies.length;
	for(n=1;n<ArrayZombies.length;n++){
		for(m=0;m<ArrayZombies[n].length;m++){
			aTmp.push(ArrayZombies[n][m]);
		}
	}
	for(n=0;n<aTmp.length;n++){
		aX.push(Math.floor(50+Math.random()*236));
		aY.push(Math.floor(100+Math.random()*414));
	}
	aY=aY.sort();
	var OZombie;
	for(n=0;n<aTmp.length;n++){
		eval('OZombie='+aTmp[n]);
		var img=new Image();
		img.src=OZombie.NormalGif;
		img.style.position='absolute';
		img.style.pixelLeft=aX[n]-OZombie.width/2;
		img.style.pixelTop=aY[n]-OZombie.height;
		document.getElementById('dZombie').appendChild(img);
	}
}

function RestartGame(){
	//重新开始游戏
	window.location.reload();
	return(true);
	NumZombies=0; //僵尸数量
	NoZombies=0; //第几只僵尸，用于给僵尸取ID
	FlagZombies=0; //僵尸第几波
	ArrayZombies=new Array('',new Array(),new Array(),new Array()) //僵尸种类的数组0不用，1，2，3分别表示不同强度的僵尸
	AlreadyAddZombiesFlag=0; //标记是否已经添加了下Flag僵尸
	NumSun=0; //标记阳光，用于给阳光取ID
	Win=0; //标记是否胜利
	Chose=0; //鼠标已经选择了某个植物，1表示选择，0表示没选
	oGP.SunNum=oGP.initSunNum; //恢复阳光值
	document.getElementById('tSunNum').innerText=oGP.SunNum;
	var ob,n,m;
	var aZom=getElementsByName('img','Zombies');
	for(var n=0;n<aZom.length;n++){
		ob=aZom[n];
		document.getElementById('dAll').removeChild(ob);
	}
	var aPlant=getElementsByName('img','Plants');
	for(var n=0;n<aPlant.length;n++){
		ob=aPlant[n];
		document.getElementById('dAll').removeChild(ob);
	}
	oGP.aR=new Array(0,0,0,0,0,0); //每行的僵尸数量
	oGP.aP=new Array(); //二维数组,保存每个格子的原始属性，水池，草地，花盆，睡莲，屋顶，弹坑等
	oGP.aPAfterGrow=new Array(); //二维数组，保存每个格子种植植物以后的属性，水池，草地，花盆，睡莲，屋顶，弹坑等
	oGP.aGroundPlant=new Array(); //三维数组，保存每个格子的容器植物对象名，比如睡莲花盆地衣等，最多可以存在两种容器，比如地衣上种植花盆，目前版本暂时只有一种容器，没有地衣
	oGP.aPlant=new Array(); //三维数组，保存每个格子的植物，aPlant[C][R][0]保存普通植物比如射手等，[C][R][1]保存保护性植物，比如南瓜
	oGP.aZombie=new Array(); //二维数组,保存每个格子的僵尸
	for(n=1;n<=oGP.MaxC;n++){
		oGP.aP[n]=new Array('','[草地]','[草地]','[草地]','[草地]','[草地]');
		oGP.aPAfterGrow[n]=new Array('','[草地]','[草地]','[草地]','[草地]','[草地]');
		oGP.aGroundPlant[n]=new Array(6);
		oGP.aPlant[n]=new Array(6);
		for(m=1;m<=5;m++){
			oGP.aGroundPlant[n][m]=new Array('','');
			oGP.aPlant[n][m]=new Array('','');
		}
	}
	for(n=0;n<=oGP.MaxC+2;n++){ //僵尸列数组比植物多2，僵尸初始站在最右边的11列，无法被攻击
		oGP.aZombie[n]=new Array('','','','','','');
	}
	SelectZombie(); //初始化僵尸数组
	document.getElementById('dAll').removeChild(document.getElementById('imgGameOver'));
	for(n=0;n<=9;n++){
		document.getElementById('tCard'+n).innerHTML='';
	}
	for(n=1;n<=48;n++){
		ob=document.getElementById('Card'+n);
		if(ob=='[object]'){ob.style.filter='';}
	}
	document.getElementById('btnOK').disabled=true;
	SelectNum=0;
	GoSelectCard();
}