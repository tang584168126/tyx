//僵尸

function MoveZombies(){
	//僵尸移动
	if(Win==-1){return(false);}
	var aZom=getElementsByName('img','Zombies');
	var ob,C,OZombie;
	for(var n=0;n<aZom.length;n++){
		ob=aZom[n];
		eval('OZombie='+ob.EName);
		if(ob.FreeSlowTime!=''){ //判断是否取消减速
			if(new Date()>ob.FreeSlowTime&&ob.HP>OZombie.BreakPoint){
				ob.FreeSlowTime='';
				ob.style.filter='';
				ob.Speed=OZombie.Speed;
			}
		}
		if(ob.isAttacking==0&&ob.HP>OZombie.BreakPoint){
			ZombieAttack(ob.id);
		}
		var LX,RX;
		LX=ob.AttackedLX; //实时改变的左受攻击点的X
		RX=ob.AttackedRX; //实时改变的右受攻击点的X
		if(ob.isAttacking==0){
			if(ob.WalkDirection==0){ //往左走
				ob.X-=ob.Speed;
				ob.style.pixelLeft=Math.floor(ob.X);
				LX-=ob.Speed;RX-=ob.Speed;
				C=GetC(LX);
				switch(true){
					case C==0: //走到剪草机
						var jcj=document.getElementById('LawnMower'+ob.R);
						if(jcj=='[object]'){ //剪草机还在
							LawnMowerKill(ob.R); //剪草机
						}
						break;
					case C<0: //进入房间
						Win=-1;
						GameOver();
						return(false);
						break;
				}
			}else{ //往右走
				ob.X+=ob.Speed;
				ob.style.pixelLeft=Math.ceil(ob.X);
				LX+=ob.Speed;
				RX+=ob.Speed;
				ob.style.pixelLeft+=ob.Speed;
				if(ob.style.pixelLeft>=oGP.MaxWidth){ //向右走出了屏幕
					OZombie.Die(ob);
					continue;
				}
				C=GetC(RX);
			}
			ob.AttackedLX=LX; //实时改变的左受攻击点的X
			ob.AttackedRX=RX; //实时改变的右受攻击点的X
			if(C!=ob.C&&C>0){
				oGP.aZombie[ob.C][ob.R]=oGP.aZombie[ob.C][ob.R].replace(ob.id+',','');
				oGP.aZombie[C][ob.R]+=ob.id+',';
				ob.C=C;
			}
		}
	}
	setTimeout('MoveZombies()',100);
}

/*-------------------普通僵尸---------------------------*/
function CZombie(){
	this.EName='oZombie';
	this.CName='普通僵尸';
	this.width=87;
	this.height=144;
	this.HP=270;
	this.BreakPoint=90;
	this.Ornaments=0; //饰品种类，123三种
	this.OrnHP=0; //饰品HP
	this.Speed=1.8; //ÐÐ½øËÙ¶È,125ºÁÃëÎªµ¥Î»,pixel
	this.WalkDirection=0; //ÐÐ½ø·½Ïò£¬0±íÊ¾×ó1±íÊ¾ÓÒ
	this.Attack=100; //¹¥»÷Á¦£¬ÃëÎªµ¥Î»
	this.canAppear='[草地][屋顶]'; //ÄÜ¹»³öÏÖµÄ³¡µØ
	this.Location='地上'; //º£°Î¶¨Î»£¬Ë®ÏÂ£¬µØÏÂ£¬µØÉÏ£¬Ìì¿Õ
	this.againstFreeze=0; //免疫冰冻
	this.againstSlow=0; //免疫减速
	this.againstSputtering=0; //免疫溅射
	this.againstRaven=0; //是否免疫食人花的吞噬
	this.againstSetbody=0; //是否免疫定身
	this.beAttackedPointL=10; //×ó±ß±»¹¥»÷µãÀëpixelLeftÆ«ÒÆ¾àÀë
	this.beAttackedPointR=77; //ÓÒ±ß±»¹¥»÷µãÀëpixelLeftÆ«ÒÆ¾àÀë
	var tmpImg1=new Image();
	tmpImg1.src='images/Zombies/Zombie/Zombie.gif';
	dicZombiesGif.add('oZombie',tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/Zombies/Zombie/ZombieAttack.gif';
	dicZombiesGif.add('oZombieAttack',tmpImg2);
	this.NormalGif=dicZombiesGif('oZombie').src;
	this.AttackGif=dicZombiesGif('oZombieAttack').src;
}
CZombie.prototype.Birth=function(ob){
	//½©Ê¬µ®Éú
	oGP.aZombie[ob.C][ob.R]+=(ob.id)+',';
}

CZombie.prototype.Die=function(ob){
	//½©Ê¬ËÀÍö
	NumZombies-=1;
	oGP.aR[ob.R]-=1;
	oGP.aZombie[ob.C][ob.R]=oGP.aZombie[ob.C][ob.R].replace(ob.id+',','');
	document.getElementById('dAll').removeChild(ob);
}
/*
CZombie.prototype.Die=function(ob){
	ob.style.pixelTop+=50;
	ob.style.pixelLeft-=70;
	ob.style.filter='progid:DXImageTransform.Microsoft.BasicImage(rotation=3)';
	ob.name='';
	window.setTimeout('oZombie.Die2('+ob.id+')',200);
}
*/
CZombie.prototype.GoingDie=function(ob){
	ob.beAttacked=0; //ÁÙËÀ,²»ÄÜ±»¹¥»÷
	ob.HP=ob.HP-60;
	ob.style.filter='gray';
	if(ob.HP<=0){
		this.Die(ob);
	}else{
		setTimeout('oZombie.GoingDie('+ob.id+')',1000);
	}
}

/*-------------------旗帜僵尸---------------------------*/
function CFlagZombie(){
	this.EName='oFlagZombie';
	this.CName='旗帜僵尸';
	this.width=111;
	this.height=143;
	this.HP=270;
	this.BreakPoint=90;
	this.Ornaments=0; //饰品种类，123三种
	this.OrnHP=0; //饰品HP
	this.Speed=2.2; //ÐÐ½øËÙ¶È,125ºÁÃëÎªµ¥Î»,pixel
	this.WalkDirection=0; //ÐÐ½ø·½Ïò£¬0±íÊ¾×ó1±íÊ¾ÓÒ
	this.Attack=100; //¹¥»÷Á¦£¬ÃëÎªµ¥Î»
	this.canAppear='[草地][屋顶]'; //ÄÜ¹»³öÏÖµÄ³¡µØ
	this.Location='地上'; //º£°Î¶¨Î»£¬Ë®ÏÂ£¬µØÏÂ£¬µØÉÏ£¬Ìì¿Õ
	this.againstFreeze=0; //免疫冰冻
	this.againstSlow=0; //免疫减速
	this.againstSputtering=0; //免疫溅射
	this.againstRaven=0; //是否免疫食人花的吞噬
	this.beAttackedPointL=10; //×ó±ß±»¹¥»÷µãÀëpixelLeftÆ«ÒÆ¾àÀë
	this.beAttackedPointR=101; //ÓÒ±ß±»¹¥»÷µãÀëpixelLeftÆ«ÒÆ¾àÀë
	var tmpImg1=new Image();
	tmpImg1.src='images/Zombies/FlagZombie/FlagZombie.gif';
	dicZombiesGif.add('oFlagZombie',tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/Zombies/FlagZombie/FlagZombieAttack.gif';
	dicZombiesGif.add('oFlagZombieAttack',tmpImg2);
	this.NormalGif=dicZombiesGif('oFlagZombie').src;
	this.AttackGif=dicZombiesGif('oFlagZombieAttack').src;
}
CFlagZombie.prototype.Birth=function(ob){
	//½©Ê¬µ®Éú
	oGP.aZombie[ob.C][ob.R]+=(ob.id)+',';
}
CFlagZombie.prototype.Die=function(ob){
	//½©Ê¬ËÀÍö
	NumZombies-=1;
	oGP.aR[ob.R]-=1;
	oGP.aZombie[ob.C][ob.R]=oGP.aZombie[ob.C][ob.R].replace(ob.id+',','');
	document.getElementById('dAll').removeChild(ob);
}
CFlagZombie.prototype.GoingDie=function(ob){
	ob.beAttacked=0; //ÁÙËÀ,²»ÄÜ±»¹¥»÷
	ob.HP=ob.HP-60;
	ob.style.filter='gray';
	if(ob.HP<=0){
		this.Die(ob);
	}else{
		setTimeout('oFlagZombie.GoingDie('+ob.id+')',1000);
	}
}

/*-------------------路障僵尸---------------------------*/
function CConeheadZombie(){
	this.EName='oConeheadZombie';
	this.CName='路障僵尸';
	this.width=87;
	this.height=144;
	this.HP=270;
	this.BreakPoint=90;
	this.Ornaments=1; //饰品种类，123三种
	this.OrnHP=370; //饰品HP
	this.Speed=1.6; //ÐÐ½øËÙ¶È,125ºÁÃëÎªµ¥Î»,pixel
	this.WalkDirection=0; //ÐÐ½ø·½Ïò£¬0±íÊ¾×ó1±íÊ¾ÓÒ
	this.Attack=100; //¹¥»÷Á¦£¬ÃëÎªµ¥Î»
	this.canAppear='[草地][屋顶]'; //ÄÜ¹»³öÏÖµÄ³¡µØ
	this.Location='地上'; //º£°Î¶¨Î»£¬Ë®ÏÂ£¬µØÏÂ£¬µØÉÏ£¬Ìì¿Õ
	this.againstFreeze=0; //免疫冰冻
	this.againstSlow=0; //免疫减速
	this.againstSputtering=0; //免疫溅射
	this.againstRaven=0; //是否免疫食人花的吞噬
	this.beAttackedPointL=10; //×ó±ß±»¹¥»÷µãÀëpixelLeftÆ«ÒÆ¾àÀë
	this.beAttackedPointR=77; //ÓÒ±ß±»¹¥»÷µãÀëpixelLeftÆ«ÒÆ¾àÀë
	var tmpImg1=new Image();
	tmpImg1.src='images/Zombies/ConeheadZombie/ConeheadZombie.gif';
	dicZombiesGif.add('oConeheadZombie',tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/Zombies/ConeheadZombie/ConeheadZombieAttack.gif';
	dicZombiesGif.add('oConeheadZombieAttack',tmpImg2);
	//使用普通僵尸的行动和攻击动画作为饰品消失后的动画
	if(!dicZombiesGif.Exists('oZombie')){
		var tmpImg3=new Image();
		tmpImg3.src='images/Zombies/Zombie/Zombie.gif';
		dicZombiesGif.add('oZombie',tmpImg3);
		var tmpImg4=new Image();
		tmpImg4.src='images/Zombies/Zombie/ZombieAttack.gif';
		dicZombiesGif.add('oZombieAttack',tmpImg4);
	}
	this.NormalGif=dicZombiesGif('oConeheadZombie').src;
	this.AttackGif=dicZombiesGif('oConeheadZombieAttack').src;
	this.OrnLostNormalGif=dicZombiesGif('oZombie').src; //失去饰品以后的行动动画
	this.OrnLostAttackGif=dicZombiesGif('oZombieAttack').src; //失去饰品以后的攻击动画
}
CConeheadZombie.prototype.Birth=function(ob){
	//½©Ê¬µ®Éú
	oGP.aZombie[ob.C][ob.R]+=(ob.id)+',';
}
CConeheadZombie.prototype.Die=function(ob){
	//½©Ê¬ËÀÍö
	NumZombies-=1;
	oGP.aR[ob.R]-=1;
	oGP.aZombie[ob.C][ob.R]=oGP.aZombie[ob.C][ob.R].replace(ob.id+',','');
	document.getElementById('dAll').removeChild(ob);
}
/*
CZombie.prototype.Die=function(ob){
	ob.style.pixelTop+=50;
	ob.style.pixelLeft-=70;
	ob.style.filter='progid:DXImageTransform.Microsoft.BasicImage(rotation=3)';
	ob.name='';
	window.setTimeout('oZombie.Die2('+ob.id+')',200);
}
*/
CConeheadZombie.prototype.GoingDie=function(ob){
	ob.beAttacked=0; //ÁÙËÀ,²»ÄÜ±»¹¥»÷
	ob.HP=ob.HP-60;
	ob.style.filter='gray';
	if(ob.HP<=0){
		this.Die(ob);
	}else{
		setTimeout('oConeheadZombie.GoingDie('+ob.id+')',1000);
	}
}

/*-------------------铁桶僵尸---------------------------*/
function CBucketheadZombie(){
	this.EName='oBucketheadZombie';
	this.CName='铁桶僵尸';
	this.width=97;
	this.height=142;
	this.HP=270;
	this.BreakPoint=90;
	this.Ornaments=1; //饰品种类，123三种
	this.OrnHP=1100; //饰品HP
	this.Speed=1.6; //ÐÐ½øËÙ¶È,125ºÁÃëÎªµ¥Î»,pixel
	this.WalkDirection=0; //ÐÐ½ø·½Ïò£¬0±íÊ¾×ó1±íÊ¾ÓÒ
	this.Attack=100; //¹¥»÷Á¦£¬ÃëÎªµ¥Î»
	this.canAppear='[草地][屋顶]'; //ÄÜ¹»³öÏÖµÄ³¡µØ
	this.Location='地上'; //º£°Î¶¨Î»£¬Ë®ÏÂ£¬µØÏÂ£¬µØÉÏ£¬Ìì¿Õ
	this.againstFreeze=0; //免疫冰冻
	this.againstSlow=0; //免疫减速
	this.againstSputtering=0; //免疫溅射
	this.againstRaven=0; //是否免疫食人花的吞噬
	this.beAttackedPointL=10; //×ó±ß±»¹¥»÷µãÀëpixelLeftÆ«ÒÆ¾àÀë
	this.beAttackedPointR=87; //ÓÒ±ß±»¹¥»÷µãÀëpixelLeftÆ«ÒÆ¾àÀë
	var tmpImg1=new Image();
	tmpImg1.src='images/Zombies/BucketheadZombie/BucketheadZombie.gif';
	dicZombiesGif.add('oBucketheadZombie',tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/Zombies/BucketheadZombie/BucketheadZombieAttack.gif';
	dicZombiesGif.add('oBucketheadZombieAttack',tmpImg2);
	//使用普通僵尸的行动和攻击动画作为饰品消失后的动画
	if(!dicZombiesGif.Exists('oZombie')){
		var tmpImg3=new Image();
		tmpImg3.src='images/Zombies/Zombie/Zombie.gif';
		dicZombiesGif.add('oZombie',tmpImg3);
		var tmpImg4=new Image();
		tmpImg4.src='images/Zombies/Zombie/ZombieAttack.gif';
		dicZombiesGif.add('oZombieAttack',tmpImg4);
	}
	this.NormalGif=dicZombiesGif('oBucketheadZombie').src;
	this.AttackGif=dicZombiesGif('oBucketheadZombieAttack').src;
	this.OrnLostNormalGif=dicZombiesGif('oZombie').src; //失去饰品以后的行动动画
	this.OrnLostAttackGif=dicZombiesGif('oZombieAttack').src; //失去饰品以后的攻击动画
}
CBucketheadZombie.prototype.Birth=function(ob){
	//½©Ê¬µ®Éú
	oGP.aZombie[ob.C][ob.R]+=(ob.id)+',';
}
CBucketheadZombie.prototype.Die=function(ob){
	//½©Ê¬ËÀÍö
	NumZombies-=1;
	oGP.aR[ob.R]-=1;
	oGP.aZombie[ob.C][ob.R]=oGP.aZombie[ob.C][ob.R].replace(ob.id+',','');
	document.getElementById('dAll').removeChild(ob);
}
CBucketheadZombie.prototype.GoingDie=function(ob){
	ob.beAttacked=0; //ÁÙËÀ,²»ÄÜ±»¹¥»÷
	ob.HP=ob.HP-60;
	ob.style.filter='gray';
	if(ob.HP<=0){
		this.Die(ob);
	}else{
		setTimeout('oBucketheadZombie.GoingDie('+ob.id+')',1000);
	}
}

/*-------------------橄榄球僵尸---------------------------*/
function CFootballZombie(){
	this.EName='oFootballZombie';
	this.CName='橄榄球僵尸';
	this.width=154;
	this.height=160;
	this.HP=270;
	this.BreakPoint=90;
	this.Ornaments=1; //饰品种类，123三种
	this.OrnHP=1400; //饰品HP
	this.Speed=3.2; //ÐÐ½øËÙ¶È,125ºÁÃëÎªµ¥Î»,pixel
	this.WalkDirection=0; //ÐÐ½ø·½Ïò£¬0±íÊ¾×ó1±íÊ¾ÓÒ
	this.Attack=100; //¹¥»÷Á¦£¬ÃëÎªµ¥Î»
	this.canAppear='[草地][屋顶]'; //ÄÜ¹»³öÏÖµÄ³¡µØ
	this.Location='地上'; //º£°Î¶¨Î»£¬Ë®ÏÂ£¬µØÏÂ£¬µØÉÏ£¬Ìì¿Õ
	this.againstFreeze=0; //免疫冰冻
	this.againstSlow=0; //免疫减速
	this.againstSputtering=0; //免疫溅射
	this.againstRaven=0; //是否免疫食人花的吞噬
	this.beAttackedPointL=20; //×ó±ß±»¹¥»÷µãÀëpixelLeftÆ«ÒÆ¾àÀë
	this.beAttackedPointR=134; //ÓÒ±ß±»¹¥»÷µãÀëpixelLeftÆ«ÒÆ¾àÀë
	var tmpImg1=new Image();
	tmpImg1.src='images/Zombies/FootballZombie/FootballZombie.gif';
	dicZombiesGif.add('oFootballZombie',tmpImg1);
	var tmpImg2=new Image();
	tmpImg2.src='images/Zombies/FootballZombie/FootballZombieAttack.gif';
	dicZombiesGif.add('oFootballZombieAttack',tmpImg2);
	var tmpImg3=new Image();
	tmpImg3.src='images/Zombies/FootballZombie/FootballZombieOrnLost.gif';
	dicZombiesGif.add('oFootballZombieOrnLost',tmpImg3);
	var tmpImg4=new Image();
	tmpImg4.src='images/Zombies/FootballZombie/FootballZombieOrnLostAttack.gif';
	dicZombiesGif.add('oFootballZombieOrnLostAttack',tmpImg4);
	this.NormalGif=dicZombiesGif('oFootballZombie').src;
	this.AttackGif=dicZombiesGif('oFootballZombieAttack').src;
	this.OrnLostNormalGif=dicZombiesGif('oFootballZombieOrnLost').src; //失去饰品以后的行动动画
	this.OrnLostAttackGif=dicZombiesGif('oFootballZombieOrnLostAttack').src; //失去饰品以后的攻击动画
}
CFootballZombie.prototype.Birth=function(ob){
	//½©Ê¬µ®Éú
	oGP.aZombie[ob.C][ob.R]+=(ob.id)+',';
}
CFootballZombie.prototype.Die=function(ob){
	//½©Ê¬ËÀÍö
	NumZombies-=1;
	oGP.aR[ob.R]-=1;
	oGP.aZombie[ob.C][ob.R]=oGP.aZombie[ob.C][ob.R].replace(ob.id+',','');
	document.getElementById('dAll').removeChild(ob);
}
CFootballZombie.prototype.GoingDie=function(ob){
	ob.beAttacked=0; //ÁÙËÀ,²»ÄÜ±»¹¥»÷
	ob.HP=ob.HP-60;
	ob.style.filter='gray';
	if(ob.HP<=0){
		this.Die(ob);
	}else{
		setTimeout('oFootballZombie.GoingDie('+ob.id+')',1000);
	}
}

function ZombieAttack(id){
	//¹¥»÷º¯Êý
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);}
	var OZombie;
	eval('OZombie='+ob.EName);
	if(ob.HP<=OZombie.BreakPoint){return(false);}
	var n,obPlant,OPlant;
	if(ob.WalkDirection==0){ //向左走的僵尸
		for(n=ob.C;n>=(ob.C-1);n--){ //´Óµ±Ç°¸ñ×Ó¿ªÊ¼ÍùÇ°µ½µÚ¶þ¸ñ
			if(n>oGP.MaxC||n<1){continue;}
			if(oGP.aPlant[n][ob.R][1]!=''){ //ÓÐ±£»¤ÐÔÖ²ÎïÄÏ¹Ï£¬ÏÈ¹¥»÷ÄÏ¹Ï
				obPlant=document.getElementById(oGP.aPlant[n][ob.R][1]); //»ñµÃÖ²Îï
				break;
			}else{
				if(oGP.aPlant[n][ob.R][0]!=''){ //Ã»ÓÐ±£»¤ÐÔÖ²Îï£¬»ñµÃÆÕÍ¨Ö²Îï
					obPlant=document.getElementById(oGP.aPlant[n][ob.R][0]);
					break;
				}else{ //Ã»ÓÐ·ÇÈÝÆ÷Ö²Îï£¬»ñÈ¡ÈÝÆ÷Ö²Îï
					if(oGP.aGroundPlant[n][ob.R][0]!=''){
						obPlant=document.getElementById(oGP.aGroundPlant[n][ob.R][0]);
						break;
					}else{
						continue; //µ±Ç°¸ñ×ÓÃ»ÓÐ»ñÈ¡µ½ÈÎºÎÖ²Îï£¬¼ÌÐø»ñÈ¡ÏÂÒ»¸ö¸ñ×ÓµÄÖ²Îï
					}
				}
			}
		}
		if(obPlant!='[object]'){ //没有植物
			if(ob.isAttacking==1){
				ob.src=ob.NormalGif;
				ob.isAttacking=0;
			}
			return(false);
		}
		eval('OPlant='+obPlant.EName);
		if(OPlant.canEat==0){ //植物不能被吃,比如地刺
			if(ob.isAttacking==1){
				ob.src=ob.NormalGif;
				ob.isAttacking=0;
			}
			return(false);
		}
		if((ob.AttackedLX<=obPlant.AttackedRX)&&(ob.AttackedRX>=obPlant.AttackedLX)){ //僵尸的左攻击点小于植物的右攻击点，并且僵尸右攻击点大于植物左攻击点
			if(ob.isAttacking==0){ob.src=ob.AttackGif;}
			if(obPlant.EName=='oGralic'){ //´óËâ
				obPlant.HP-=20;
				if(obPlant.HP<OPlant.BreakPoint){
					OPlant.Die(obPlant);
					ob.src=ob.NormalGif;
					ob.isAttacking=0;
					return(false);
				}else{
					PlantStatus(obPlant.id); //ÅÐ¶ÏÖ²ÎïµÄ×´Ì¬À´¸ü¸Äfilter»òÕßsrcµÈ
					ob.isAttacking=1;
					setTimeout('ZombieEatGralic("'+ob.id+'")',1000);
					return(false);
				}
			}else{
				ob.isAttacking=1;
				setTimeout('ZombieEatPlant("'+ob.id+'","'+obPlant.id+'")',1000);
			}
		}else{
			if(ob.isAttacking==1){
				ob.src=ob.NormalGif;
				ob.isAttacking=0;
			}
			return(false);
		}
	}else{ //ÍùÓÒ×ß

	}
}

function ZombieEatPlant(zombieid,plantid){
	//吃植物
	var ob=document.getElementById(zombieid);
	var obPlant=document.getElementById(plantid);
	if(ob!='[object]'){return(false);} //zombie die
	if(obPlant!='[object]'){ //没有植物
		ob.src=ob.NormalGif;
		ob.isAttacking=0;
		return(false);
	}
	var OZombie,OPlant;
	eval('OZombie='+ob.EName);
	eval('OPlant='+obPlant.EName);
	if(obPlant.unrivaled==0){
		if(ob.FreeSlowTime==''){
			obPlant.HP-=OZombie.Attack;
		}else{
			obPlant.HP-=OZombie.Attack*0.25;
		}
		PlantStatus(obPlant.id);
	}
	if(obPlant.HP<=OPlant.BreakPoint){
		OPlant.Die(obPlant);
		ob.src=ob.NormalGif;
		ob.isAttacking=0;
		return(false);
	}
	setTimeout('ZombieEatPlant("'+zombieid+'","'+plantid+'")',1000);
}

function ZombieEatGralic(id){
	//³Ô´óËâ»»ÐÐ
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);}
	ob.isAttacking=0;
	ob.src=dicZombiesGif(ob.EName).src;
	var tmpR,tmpC,tmpA=new Array();
	if(ob.R>1){
		tmpR=ob.R-1;
		if(oGP.aP[1][tmpR]==oGP.aP[1][ob.R]){tmpA.push(tmpR);}
	}
	if(ob.R<oGP.MaxR){
		tmpR=ob.R+1;
		if(oGP.aP[1][tmpR]==oGP.aP[1][ob.R]){tmpA.push(tmpR);}
	}
	if(tmpA.length>0){
		ob.src=dicZombiesGif(ob.EName).src;
		tmpR=tmpA[Math.floor(Math.random()*tmpA.length)];
		ob.style.pixelTop=GetY(tmpR)-parseInt(ob.height);
		ob.style.zIndex=3*tmpR+1;
		var LX,RX;
		LX=ob.AttackedLX;
		RX=ob.AttackedRX;
		if(ob.WalkDirection==0){ //向左走
			ob.style.pixelLeft-=10;
			ob.X-=10;
			LX-=10;
			RX-=10;
			tmpC=GetC(LX);
		}else{ //向右走
			ob.style.pixelLeft+=10;
			ob.X+=10;
			LX+=10;
			RX+=10;
			tmpC=GetC(RX);
		}
		ob.AttackedLX=LX; //实时改变的左受攻击点的X
		ob.AttackedRX=RX; //实时改变的右受攻击点的X
		oGP.aZombie[ob.C][ob.R]=oGP.aZombie[ob.C][ob.R].replace(ob.id+',','');
		oGP.aZombie[tmpC][tmpR]+=ob.id+',';
		oGP.aR[ob.R]-=1;
		ob.C=tmpC;
		ob.R=tmpR;
		oGP.aR[tmpR]+=1;
		
	}
}