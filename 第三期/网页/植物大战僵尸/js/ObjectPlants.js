//ֲ��

var aMovePea=new Array(); //�㶹�����๫���ƶ��㶹����
var aMoveStar=new Array(); //�����ӵ�����
//var oPeashooter,oSnowPea,oRepeater,oThreepeater,oSunFlower,oTwinSunflower,oPumpkinHead,oFlowerPot,oLilyPad,oPotatoMine,oGatlingPea,oTorchwood,oSpikeweed,oSpikerock,oWallNut,oTallNut,oGralic,oCherryBomb,oSquash

function PlantAttack(obPlantID,obZombieID,AttackDirection,Attack,Setbody,Freeze,Slow,AttackKind){
	//ֲ�﹥������
	//����ֲ��img���󣬴��ݽ�ʬimg���󣬹������еķ���,������,Setbody����,Freeze����,Slow����-1��ʾ����0��ʾ����1��ʾ��������,�������ͣ�ֱ�ߣ�Ͷ������͸���ش̣�����
	//�������ж��Ƿ��ܹ������Ƿ��ܹ�����ֲ���������жϡ�
	var OZombie;
	var obZombie=document.getElementById(obZombieID);
	if(obZombie!='[object]'){return(false);}
	eval('OZombie='+obZombie.EName);
	switch(OZombie.Ornaments){
		case 0: //û����Ʒ
			obZombie.HP-=Attack;
			break;
		case 1: //I����Ʒ����: ·��  ��Ͱ  �����ñ  ѩ��  ����  ��ñ;������Ʒ�ڱ��Ƴ�֮ǰ  �κ��˺�(��ը�����)���޷�ֱ�������ڱ���
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
		case 2: //II����Ʒ����: ��ֽ  ��դ��  ����;�޷����κ�������ṩ����(�ش�  ������ ��͸��  �Լ����Ա����ˮƽ���������ֱ�������ڱ���)
		
			break;
	}
	
	
	if(obZombie.HP<=OZombie.BreakPoint){ //����������������������
		OZombie.GoingDie(obZombie);
		return(false);
	}
	
	//�жϼ���״̬������obZombie�ļ���ʱ���Լ�����filter CSS
	switch(Slow){
		case -1: //����
			var d = new Date();
			d.setSeconds(d.getSeconds() + 1000);//��10��
			if(obZombie.FreeSlowTime==''){obZombie.Speed*=0.25;}
			obZombie.FreeSlowTime=d;
			obZombie.style.filter='Glow(Color=#99CCFF,Strength=5)';
			break;
		case 1: //����ȡ������
			if(obZombie.FreeSlowTime!=''){
				obZombie.FreeSlowTime='';
				if(obZombie.HP>OZombie.BreakPoint){obZombie.style.filter='';}
			}
			break;
	}
}

/*-------------------�㶹����---------------------------*/
function CPeashooter(){
	//�㶹���ֶ���
	//����ֲ�ﶼ�е�����
	this.EName='oPeashooter'; //Ӣ������
	this.CName='�㶹����'; //��������
	this.width=71; //��
	this.height=71; //��
	this.HP=300; //�;�
	this.SunNum=100;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/Peashooter.png'; //��ƬͼƬ
	this.normalGif='images/Plants/Peashooter/Peashooter.gif'; //��ͨ����
	this.canGrow='[�ݵ�][����][˯��]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=7500; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
	this.beAttackedPointL=20; //�����������pixelLeftƫ��
	this.beAttackedPointR=51; //�ҵ�ƫ��

	//��������ֲ�ﶼ�е�����
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
	//GroundStr��ʾ�������ԣ�����'[�ݵ�]'
	//����������ĳ�����Գ������������ƫ����
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		case '[˯��]':
			return(-20);
			break;
		default:
			return(0);
	}
}
CPeashooter.prototype.Birth=function(ob){
	//��ֲ����ֲ���ʹ�������Ա�Ϊ���������ԣ�����˯����ֲ��ʹ"ˮ��"���"˯��"
	//����ı��ֲ��÷���Ϊ��
	ob.src=dicPlantsGif('oPeashooter').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	//this.DoTimer(ob);
	this.fAttack(ob.id);
}
CPeashooter.prototype.Die=function(ob){
	//ֲ������
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CPeashooter.prototype.fAttack=function(id){
	//ÿ��������ȴʱ��ͼ���Ƿ��е��ˣ��Ǿͼ�������������й���
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //�����Ѿ�����
	if(!this.HaveEnemy(ob)){
		setTimeout('oPeashooter.fAttack("'+id+'")',this.AttackCoolTime);
		return(false); //�ж�û�е���
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
	PeashooterBullet.AttackDirection=0; //�����н�����,0��ʾ�ң�˳ʱ��һֱ��7
	PeashooterBullet.Attack=20; //��ʼ����������ɻ��㶹�Ժ󷭱�
	PeashooterBullet.BulletKind=0; //-1��ʾ���٣�0��ʾ��ͨ�㶹��1��ʾ���㶹
	PeashooterBullet.ChangeBulletC=0; //�㶹����BulletKind��C,Ҳ�����Ƿ񾭹��˻����׮
	document.getElementById('dAll').appendChild(PeashooterBullet);
	setTimeout('var tmpOb=document.getElementById("'+PeashooterBullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',150);
	aMovePea.push(PeashooterBullet);
	setTimeout('oPeashooter.fAttack("'+id+'")',this.AttackCoolTime);
}
CPeashooter.prototype.HaveEnemy=function(ob){
	var C=parseInt(ob.C),R=parseInt(ob.R);
	if(oGP.aR[R]==0){return(false);}
	var m,n,zombieStr,atmp,obZombie,obZombieX;
	for(m=C;m<=oGP.MaxC+1;m++){ //�㶹��������ж�
		zombieStr=oGP.aZombie[m][R];
		if(zombieStr!=''){
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //ѭ�������ӽ�������ֲ��ǰ��Ľ�ʬ
				obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
				if(obZombie.WalkDirection==0){ //��ý�ʬ�ı�����������
					obZombieX=obZombie.AttackedLX; //��ʬ�����ߣ���ȡ�󱻹�����
				}else{
					obZombieX=obZombie.AttackedRX; //��ʬ�����ߣ���ȡ�ұ�������
				}
				if(obZombieX>=ob.AttackedLX){ //��ʬ�ı������������������ֲ�ﱻ�����������
					return(true);
				}
			}
		}
	}
	return(false);
}
/*-------------------��������---------------------------*/
function CSnowPea(){
	//����ֲ�ﶼ�е�����
	this.EName='oSnowPea'; //Ӣ������
	this.CName='��������'; //��������
	this.width=71; //��
	this.height=71; //��
	this.HP=300; //�;�
	this.SunNum=175;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/SnowPea.png'; //��ƬͼƬ
	this.normalGif='images/Plants/SnowPea/SnowPea.gif'; //��ͨ����
	this.canGrow='[�ݵ�][����][˯��]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=7500; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
	this.beAttackedPointL=20; //�����������pixelLeftƫ��
	this.beAttackedPointR=51; //�ҵ�ƫ��

	//��������ֲ�ﶼ�е�����
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
	//GroundStr��ʾ�������ԣ�����'[�ݵ�]'
	//����������ĳ�����Գ������������ƫ����
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		case '[˯��]':
			return(-20);
			break;
		default:
			return(0);
	}
}
CSnowPea.prototype.Birth=function(ob){
	//��ֲ����ֲ���ʹ�������Ա�Ϊ���������ԣ�����˯����ֲ��ʹ"ˮ��"���"˯��"
	//����ı��ֲ��÷���Ϊ��
	ob.src=dicPlantsGif('oSnowPea').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	//this.DoTimer(ob);
	this.fAttack(ob.id);
}
CSnowPea.prototype.Die=function(ob){
	//ֲ������
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CSnowPea.prototype.fAttack=function(id){
	//ÿ��������ȴʱ��ͼ���Ƿ��е��ˣ��Ǿͼ�������������й���
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //�����Ѿ�����
	if(!this.HaveEnemy(ob)){
		setTimeout('oSnowPea.fAttack("'+id+'")',this.AttackCoolTime);
		return(false); //�ж�û�е���
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
	PeashooterBullet.AttackDirection=0; //�����н�����,0��ʾ�ң�˳ʱ��һֱ��7
	PeashooterBullet.Attack=20; //��ʼ������
	PeashooterBullet.BulletKind=-1; //-1��ʾ���٣�0��ʾ��ͨ�㶹��1��ʾ���㶹
	PeashooterBullet.ChangeBulletC=0; //�㶹����BulletKind��C,Ҳ�����Ƿ񾭹��˻����׮
	document.getElementById('dAll').appendChild(PeashooterBullet);
	setTimeout('var tmpOb=document.getElementById("'+PeashooterBullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',100);
	aMovePea.push(PeashooterBullet);
	setTimeout('oSnowPea.fAttack("'+id+'")',this.AttackCoolTime);
}
CSnowPea.prototype.HaveEnemy=function(ob){
	var C=parseInt(ob.C),R=parseInt(ob.R);
	if(oGP.aR[R]==0){return(false);}
	var m,n,zombieStr,atmp,obZombie,obZombieX;
	for(m=C;m<=oGP.MaxC+1;m++){ //�㶹��������ж�
		zombieStr=oGP.aZombie[m][R];
		if(zombieStr!=''){
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //ѭ�������ӽ�������ֲ��ǰ��Ľ�ʬ
				obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
				if(obZombie.WalkDirection==0){ //��ý�ʬ�ı�����������
					obZombieX=obZombie.AttackedLX; //��ʬ�����ߣ���ȡ�󱻹�����
				}else{
					obZombieX=obZombie.AttackedRX; //��ʬ�����ߣ���ȡ�ұ�������
				}
				if(obZombieX>=ob.AttackedLX){ //��ʬ�ı������������������ֲ�ﱻ�����������
					return(true);
				}
			}
		}
	}
	return(false);
}
/*-------------------˫������---------------------------*/
function CRepeater(){
	//˫�����ֶ���
	this.EName='oRepeater'; //Ӣ������
	this.CName='˫������'; //��������
	this.width=73; //��
	this.height=71; //��
	this.HP=300; //�;�
	this.SunNum=200;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/Repeater.png'; //��ƬͼƬ
	this.normalGif='images/Plants/Repeater/Repeater.gif'; //��ͨ����
	this.canGrow='[�ݵ�][����][˯��]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=7500; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	//��ֲ����ֲ���ʹ�������Ա�Ϊ���������ԣ�����˯����ֲ��ʹ"ˮ��"���"˯��"
	//����ı��ֲ��÷���Ϊ��
	ob.src=dicPlantsGif('oRepeater').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	this.fAttack(ob.id,1);
}
CRepeater.prototype.Die=function(ob){
	//ֲ������
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CRepeater.prototype.fAttack=function(id,NoPeashooterBullet){
	//ÿ��������ȴʱ��ͼ���Ƿ��е��ˣ��Ǿͼ�������������й���
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //�����Ѿ�����
	if(!this.HaveEnemy(ob)){
		NoPeashooterBullet=1;
		setTimeout('oRepeater.fAttack("'+id+'",'+NoPeashooterBullet+')',this.AttackCoolTime);
		return(false); //�ж�û�е���
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
	PeashooterBullet.AttackDirection=0; //�����н�����,0��ʾ�ң�˳ʱ��һֱ��7
	PeashooterBullet.Attack=20; //��ʼ����������ɻ��㶹�Ժ󷭱�
	PeashooterBullet.BulletKind=0; //-1��ʾ���٣�0��ʾ��ͨ�㶹��1��ʾ���㶹
	PeashooterBullet.ChangeBulletC=0; //�㶹����BulletKind��C,Ҳ�����Ƿ񾭹��˻����׮
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
	for(m=C;m<=oGP.MaxC+1;m++){ //�㶹��������ж�
		zombieStr=oGP.aZombie[m][R];
		if(zombieStr!=''){
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //ѭ�������ӽ�������ֲ��ǰ��Ľ�ʬ
				obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
				if(obZombie.WalkDirection==0){ //��ý�ʬ�ı�����������
					obZombieX=obZombie.AttackedLX; //��ʬ�����ߣ���ȡ�󱻹�����
				}else{
					obZombieX=obZombie.AttackedRX; //��ʬ�����ߣ���ȡ�ұ�������
				}
				if(obZombieX>=ob.AttackedLX){ //��ʬ�ı������������������ֲ�ﱻ�����������
					return(true);
				}
			}
		}
	}
	return(false);
}
CRepeater.prototype.GetDeviationY=function(C,R){
	//GroundStr��ʾ�������ԣ�����'[�ݵ�]'
	//����������ĳ�����Գ������������ƫ����
	var GroundStr=oGP.aPAfterGrow[C][R];

	switch(GroundStr){
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		case '[˯��]':
			return(-20);
			break;
		default:
			return(0);
	}
}
/*-------------------��������---------------------------*/
function CThreepeater(){
	//˫�����ֶ���
	this.EName='oThreepeater'; //Ӣ������
	this.CName='��������'; //��������
	this.width=73; //��
	this.height=80; //��
	this.HP=300; //�;�
	this.SunNum=325;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/Threepeater.png'; //��ƬͼƬ
	this.normalGif='images/Plants/Threepeater/Threepeater.gif'; //��ͨ����
	this.canGrow='[�ݵ�][����][˯��]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=7500; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	//��ֲ����ֲ���ʹ�������Ա�Ϊ���������ԣ�����˯����ֲ��ʹ"ˮ��"���"˯��"
	//����ı��ֲ��÷���Ϊ��
	ob.src=dicPlantsGif('oThreepeater').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	this.fAttack(ob.id,1);
}
CThreepeater.prototype.Die=function(ob){
	//ֲ������
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CThreepeater.prototype.fAttack=function(id){
	//ÿ��������ȴʱ��ͼ���Ƿ��е��ˣ��Ǿͼ�������������й���
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //�����Ѿ�����
	if(!this.HaveEnemy(ob)){
		setTimeout('oThreepeater.fAttack("'+id+'")',this.AttackCoolTime);
		return(false); //�ж�û�е���
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
	PeashooterBullet.AttackDirection=0; //�����н�����,0��ʾ�ң�˳ʱ��һֱ��7
	PeashooterBullet.Attack=20; //��ʼ����������ɻ��㶹�Ժ󷭱�
	PeashooterBullet.BulletKind=0; //-1��ʾ���٣�0��ʾ��ͨ�㶹��1��ʾ���㶹
	PeashooterBullet.ChangeBulletC=0; //�㶹����BulletKind��C,Ҳ�����Ƿ񾭹��˻����׮
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
		for(mC=C;mC<=oGP.MaxC+1;mC++){ //�㶹��������ж�
			zombieStr=oGP.aZombie[mC][mR];
			if(zombieStr!=''){
				atmp=zombieStr.split(',');
				for(n=0;n<atmp.length-1;n++){ //ѭ�������ӽ�������ֲ��ǰ��Ľ�ʬ
					obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
					if(obZombie.WalkDirection==0){ //��ý�ʬ�ı�����������
						obZombieX=obZombie.AttackedLX; //��ʬ�����ߣ���ȡ�󱻹�����
					}else{
						obZombieX=obZombie.AttackedRX; //��ʬ�����ߣ���ȡ�ұ�������
					}
					if(obZombieX>=ob.AttackedLX){ //��ʬ�ı������������������ֲ�ﱻ�����������
						return(true);
					}
				}
			}
		}
	}
	return(false);
}
CThreepeater.prototype.GetDeviationY=function(C,R){
	//GroundStr��ʾ�������ԣ�����'[�ݵ�]'
	//����������ĳ�����Գ������������ƫ����
	var GroundStr=oGP.aPAfterGrow[C][R];

	switch(GroundStr){
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		case '[˯��]':
			return(-20);
			break;
		default:
			return(0);
	}
}
/*-------------------���տ�---------------------------*/
function CSunFlower(){
	//���տ�
	this.EName='oSunFlower'; //Ӣ������
	this.CName='���տ�'; //��������
	this.width=73; //��
	this.height=74; //��
	this.HP=300; //�;�
	this.SunNum=50;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/SunFlower.png'; //��ƬͼƬ
	this.normalGif='images/Plants/SunFlower/SunFlower.gif'; //��ͨ����
	this.canGrow='[�ݵ�][����][˯��]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=7500; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	setTimeout('oSunFlower.ProduceSun("'+ob.id+'")',6000); //6���������������
}
CSunFlower.prototype.ProduceSun=function(id){
	//��������
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //�����Ѿ�����
	var X,Y;
	X=GetX(ob.C);
	Y=GetY(ob.R);
	AppearSun(X,Y,25,0); //��������
	if(Win==0){setTimeout('oSunFlower.ProduceSun("'+id+'")',24000);}
}
CSunFlower.prototype.Die=function(ob){
	//ֲ������
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CSunFlower.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	
	switch(GroundStr){
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		case '[˯��]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------˫�����տ�---------------------------*/
function CTwinSunflower(){
	//���տ�
	this.EName='oTwinSunflower'; //Ӣ������
	this.CName='˫�����տ�'; //��������
	this.width=83; //��
	this.height=84; //��
	this.HP=300; //�;�
	this.SunNum=150;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/TwinSunflower.png'; //��ƬͼƬ
	this.normalGif='images/Plants/TwinSunflower/TwinSunflower.gif'; //��ͨ����
	this.canGrow='[�ݵ�][����][˯��]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=50000; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant='oSunFlower'; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	setTimeout('oTwinSunflower.ProduceSun("'+ob.id+'")',6000); //6���������������
}
CTwinSunflower.prototype.ProduceSun=function(id){
	//��������
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //�����Ѿ�����
	var X,Y;
	X=GetX(ob.C);
	Y=GetY(ob.R);
	AppearSun(X-10,Y,25,0); //��������
	AppearSun(X+10,Y,25,0);
	if(Win==0){setTimeout('oTwinSunflower.ProduceSun("'+id+'")',24000);}
}
CTwinSunflower.prototype.Die=function(ob){
	//ֲ������
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CTwinSunflower.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		case '[˯��]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------�Ϲ�ͷ---------------------------*/
function CPumpkinHead(){
	//�Ϲ�ͷ
	this.EName='oPumpkinHead'; //Ӣ������
	this.CName='�Ϲ�ͷ'; //��������
	this.width=97; //��
	this.height=67; //��
	this.HP=4000; //�;�
	this.SunNum=125;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=1; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/PumpkinHead.png'; //��ƬͼƬ
	this.normalGif='images/Plants/PumpkinHead/PumpkinHead.gif'; //��ͨ����
	this.canGrow='[�ݵ�][����][˯��]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=30000; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	//ֲ������
	document.getElementById('dAll').removeChild(ob);
	document.getElementById('dAll').removeChild(document.getElementById(ob.id+'_2'));
	oGP.aPlant[ob.C][ob.R][1]='';
}
CPumpkinHead.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	
	switch(GroundStr){
		case '[�ݵ�]':
			return(-5);
			break;
		case '[����]':
			return(-13);
			break;
		case '[˯��]':
			return(-10);
			break;
		default:
			return(0);
	}
}

/*-------------------����---------------------------*/
function CFlowerPot(){
	//����
	this.EName='oFlowerPot'; //Ӣ������
	this.CName='����'; //��������
	this.width=72; //��
	this.height=68; //��
	this.HP=300; //�;�
	this.SunNum=25;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=1; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/FlowerPot.png'; //��ƬͼƬ
	this.normalGif='images/Plants/FlowerPot/FlowerPot.gif'; //��ͨ����
	this.canGrow='[�ݵ�][�ݶ�]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=7500; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	oGP.aPAfterGrow[C][R]='[����]';
	if(oGP.aGroundPlant[C][R][0]==''){
		oGP.aGroundPlant[C][R][0]=ob.id;
	}else{
		oGP.aGroundPlant[C][R][1]=ob.id;
	}
}
CFlowerPot.prototype.Die=function(ob){
	//ֲ������
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
		case '[�ݵ�]':
			return(3);
			break;
		case '[�ݶ�]':
			return(3);
			break;
		default:
			return(0);
	}
}

/*-------------------˯��---------------------------*/
function CLilyPad(){
	//˯��
	this.EName='oLilyPad'; //Ӣ������
	this.CName='˯��'; //��������
	this.width=81; //��
	this.height=61; //��
	this.HP=300; //�;�
	this.SunNum=25;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=1; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/LilyPad.png'; //��ƬͼƬ
	this.normalGif='images/Plants/LilyPad/LilyPad.gif'; //��ͨ����
	this.canGrow='[ˮ��]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=7500; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	oGP.aPAfterGrow[C][R]='[˯��]';
	if(oGP.aGroundPlant[C][R][0]==''){
		oGP.aGroundPlant[C][R][0]=ob.id;
	}else{
		oGP.aGroundPlant[C][R][1]=ob.id;
	}
}
CLilyPad.prototype.Die=function(ob){
	//ֲ������
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
		case '[ˮ��]':
			return(0);
	}
}

/*-------------------������---------------------------*/
function CPotatoMine(){
	//������
	this.EName='oPotatoMine'; //Ӣ������
	this.CName='������'; //��������
	this.width=75; //��
	this.height=55; //��
	this.HP=300; //�;�
	this.SunNum=25;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/PotatoMine.png'; //��ƬͼƬ
	this.normalGif='images/Plants/PotatoMine/PotatoMine.gif'; //��ͨ����
	this.canGrow='[�ݵ�][����]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=30000; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=0; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	tmpImg2.src='images/Plants/PotatoMine/PotatoMineNotReady.gif'; //����
	dicPlantsGif.add('PotatoMineNotReady',tmpImg2);
	var tmpImg3=new Image();
	tmpImg3.src='images/Plants/PotatoMine/PotatoMine_mashed.gif'; //��ը������
	dicPlantsGif.add('PotatoMine_mashed',tmpImg3);
	var tmpImg4=new Image();
	tmpImg4.src='images/Plants/PotatoMine/ExplosionSpudow.gif'; //��ը������
	dicPlantsGif.add('ExplosionSpudow',tmpImg4);
}
CPotatoMine.prototype.Birth=function(ob){
	ob.src=dicPlantsGif('PotatoMineNotReady').src;
	ob.isBoom=0; //�Ƿ�ը״̬
	var C=ob.C,R=ob.R;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	setTimeout('oPotatoMine.fBreakout("'+ob.id+'")',15000); //15�������
}
CPotatoMine.prototype.fBreakout=function(id){
	//����
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //�����Ѿ�����
	ob.src=dicPlantsGif('oPotatoMine').src; //����gif
	 this.fAttack(ob.id)//�Ѿ����������ù����ж�
}
CPotatoMine.prototype.Die=function(ob){
	//ֲ������
	if(ob.isBoom==0){document.getElementById('dAll').removeChild(ob);} //����Ǳ�ը״̬���Ƴ�ͼƬ�ɹ�����ʱ��ִ��
	oGP.aPlant[ob.C][ob.R][0]='';
}
CPotatoMine.prototype.fAttack=function(id){
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //�����Ѿ�����
	var C=ob.C,R=ob.R;
	if(oGP.aPlant[C][R][1].substr(0,14)=='P_oPumpkinHead'){setTimeout('oPotatoMine.fAttack("'+ob.id+'")',100);return(false);}
	var zombieStr=oGP.aZombie[C-1][R]+oGP.aZombie[C][R]+oGP.aZombie[C+1][R];
	if(zombieStr!=''){ //�𱬾����ǵ�ǰ����,��ը��Χ�ǵ�ǰ���ӵ����н�ʬ�ͺ������
		var smallX='',smallZombie='',n,atmp,obZombie,LX,RX;
		atmp=zombieStr.split(',');
		LX=ob.style.pixelLeft;RX=ob.style.pixelLeft+ob.width; //��õ������ߵ�X,�Խ�ʬ�����ҹ��������X��Χ���ж��Ƿ���
		for(n=0;n<atmp.length-1;n++){ //ѭ����ý�ʬ
			obZombie=document.getElementById(atmp[n]); //ѭ���������Ľ�ʬ����
			switch(true){
				case obZombie.AttackedLX>=LX&&obZombie.AttackedLX<=RX: //��ʬ�󹥻�����X��Χ��
				case obZombie.AttackedRX>=LX&&obZombie.AttackedRX<=RX: //��ʬ�ҹ�������X��Χ��
				case obZombie.AttackedLX<=LX&&obZombie.AttackedRX>=RX: //��ʬ�����X1���ҵ���X2��
					if(obZombie.beAttacked==1){ob.unrivaled=1;this.fBoom(ob,atmp,LX,RX);return(false);}
					break;
			}
		}
	}
	setTimeout('oPotatoMine.fAttack("'+ob.id+'")',100);
}
CPotatoMine.prototype.fBoom=function(ob,atmp,LX,RX){
	//��ը
	var C=ob.C,R=ob.R;
	var n,obZombie,MiddleX=(RX-LX)/2;
	for(n=0;n<atmp.length-1;n++){ //ѭ����ý�ʬ
		obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
		switch(true){
			case obZombie.AttackedLX>=LX&&obZombie.AttackedLX<=RX: //��ʬ�󹥻�����X��Χ��
			case obZombie.AttackedRX>=LX&&obZombie.AttackedRX<=RX: //��ʬ�ҹ�������X��Χ��
			case obZombie.AttackedLX<=LX&&obZombie.AttackedRX>=RX: //��ʬ�����X1���ҵ���X2��
				if(obZombie.beAttacked==1){PlantAttack(ob.id,obZombie.id,0,this.Attack,0,'��͸');}
				break;
			case obZombie.AttackedRX<LX: //��ʬ�ҵ�С��X1
				if(obZombie.beAttacked==1&&MiddleX-obZombie.AttackedRX<=50){PlantAttack(ob.id,obZombie.id,0,this.Attack,0,'��͸');}
				break;
			case obZombie.AttackedLX>RX: //��ʬ������X2
				if(obZombie.beAttacked==1&&obZombie.AttackedLX-MiddleX<=50){PlantAttack(ob.id,obZombie.id,0,this.Attack,0,'��͸');}
				break;
		}
	}
	ob.src=dicPlantsGif('PotatoMine_mashed').src; //���ĳɱ�ը���GIF,���ұ���һ��ʱ�䣬Ȼ�����Ƴ�ͼƬ����
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
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		default:
			return(0);
	}
}

/*-------------------��ǹ����---------------------------*/
function CGatlingPea(){
	//��ǹ���ֶ���
	this.EName='oGatlingPea'; //Ӣ������
	this.CName='��ǹ����'; //��������
	this.width=88; //��
	this.height=84; //��
	this.HP=300; //�;�
	this.SunNum=250;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/GatlingPea.png'; //��ƬͼƬ
	this.normalGif='images/Plants/GatlingPea/GatlingPea.gif'; //��ͨ����
	this.canGrow='[�ݵ�][����][˯��]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=50000; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant='oRepeater'; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=1; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	//��ֲ����ֲ���ʹ�������Ա�Ϊ���������ԣ�����˯����ֲ��ʹ"ˮ��"���"˯��"
	//����ı��ֲ��÷���Ϊ��
	ob.src=dicPlantsGif('oGatlingPea').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	this.fAttack(ob.id,1);
}
CGatlingPea.prototype.Die=function(ob){
	//ֲ������
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CGatlingPea.prototype.fAttack=function(id,NoPeashooterBullet){
	//ÿ��������ȴʱ��ͼ���Ƿ��е��ˣ��Ǿͼ�������������й���
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //�����Ѿ�����
	if(!this.HaveEnemy(ob)){
		NoPeashooterBullet=1;
		setTimeout('oGatlingPea.fAttack("'+id+'",'+NoPeashooterBullet+')',this.AttackCoolTime);
		return(false); //�ж�û�е���
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
	PeashooterBullet.AttackDirection=0; //�����н�����,0��ʾ�ң�˳ʱ��һֱ��7
	PeashooterBullet.Attack=20; //��ʼ����������ɻ��㶹�Ժ󷭱�
	PeashooterBullet.BulletKind=0; //-1��ʾ���٣�0��ʾ��ͨ�㶹��1��ʾ���㶹
	PeashooterBullet.ChangeBulletC=0; //�㶹����BulletKind��C,Ҳ�����Ƿ񾭹��˻����׮
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
	for(m=C;m<=oGP.MaxC+1;m++){ //�㶹��������ж�
		zombieStr=oGP.aZombie[m][R];
		if(zombieStr!=''){
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //ѭ�������ӽ�������ֲ��ǰ��Ľ�ʬ
				obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
				if(obZombie.WalkDirection==0){ //��ý�ʬ�ı�����������
					obZombieX=obZombie.AttackedLX; //��ʬ�����ߣ���ȡ�󱻹�����
				}else{
					obZombieX=obZombie.AttackedRX; //��ʬ�����ߣ���ȡ�ұ�������
				}
				if(obZombieX>=ob.AttackedLX){ //��ʬ�ı������������������ֲ�ﱻ�����������
					return(true);
				}
			}
		}
	}
	return(false);
}
CGatlingPea.prototype.GetDeviationY=function(C,R){
	//GroundStr��ʾ�������ԣ�����'[�ݵ�]'
	//����������ĳ�����Գ������������ƫ����
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		case '[˯��]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------�����׮---------------------------*/
function CTorchwood(){
	this.EName='oTorchwood'; //Ӣ������
	this.CName='�����׮'; //��������
	this.width=73; //��
	this.height=83; //��
	this.HP=300; //�;�
	this.SunNum=175;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/Torchwood.png'; //��ƬͼƬ
	this.normalGif='images/Plants/Torchwood/Torchwood.gif'; //��ͨ����
	this.canGrow='[�ݵ�][����][˯��]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=7500; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	//ֲ������
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CTorchwood.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		case '[˯��]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------�ش�---------------------------*/
function CSpikeweed(){
	this.EName='oSpikeweed'; //Ӣ������
	this.CName='�ش�'; //��������
	this.width=85; //��
	this.height=35; //��
	this.HP=300; //�;�
	this.SunNum=100;
	this.canEat=0; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/Spikeweed.png'; //��ƬͼƬ
	this.normalGif='images/Plants/Spikeweed/Spikeweed.gif'; //��ͨ����
	this.canGrow='[�ݵ�]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=7500; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=0; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	//ֲ������
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CSpikeweed.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[�ݵ�]':
			return(-10);
			break;
	}
}
CSpikeweed.prototype.fAttack=function(id){
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);}
	var obC=ob.C,obR=ob.R;
	if(oGP.aPlant[obC][obR][1].substr(0,14)=='P_oPumpkinHead'){setTimeout('oSpikeweed.fAttack("'+ob.id+'")',1000);return(false);}
	var	zombieStr=oGP.aZombie[obC-1][obR]+oGP.aZombie[obC][obR]+oGP.aZombie[obC+1][obR]; //����ӵ����ڸ��ӵĽ�ʬ�ַ���
	if(zombieStr!=''){ //�ֽ⽩ʬ�ַ����ɽ�ʬ����
		var atmp=zombieStr.split(',');
		var LX=ob.style.pixelLeft,RX=ob.style.pixelLeft+ob.width,MX=ob.style.pixelLeft+ob.width/2;
		for(n=0;n<atmp.length-1;n++){ //ѭ�������ӽ�������ֲ��ǰ��Ľ�ʬ
			obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
			if(obZombie.beAttacked==1){ //��ʬ��������״̬,���Ա�����
				if(obZombie.WalkDirection==0){ //��ý�ʬ�ı�����������
					switch(true){
						case obZombie.AttackedLX>=LX&&obZombie.AttackedLX<=MX:
						case obZombie.AttackedLX<=LX&&obZombie.AttackedRX>=RX:
						case obZombie.AttackedRX>=LX&&obZombie.AttackedRX<=MX:
							PlantAttack(ob.id,obZombie.id,0,20,0,0,0,'�ش�');
					}
					//if(obZombie.FreeSlowTime==''){
					//	obZombie.style.filter='alpha(opacity=60)'; //��������
					//	setTimeout('if('+obZombie.id+'.beAttacked==1){'+obZombie.id+'.style.filter="";}else{'+obZombie.id+'.style.filter="gray";}',100);
					//}
				}else{
					switch(true){
						case obZombie.AttackedLX>=MX&&obZombie.AttackedLX<=RX:
						case obZombie.AttackedLX<=LX&&obZombie.AttackedRX>=RX:
						case obZombie.AttackedRX>=MX&&obZombie.AttackedRX<=RX:
							PlantAttack(ob.id,obZombie.id,0,20,0,0,0,'�ش�');
					}
					//if(obZombie.FreeSlowTime==''){
					//	obZombie.style.filter='alpha(opacity=60)'; //��������
					//	setTimeout('if('+obZombie.id+'.beAttacked==1){'+obZombie.id+'.style.filter="";}else{'+obZombie.id+'.style.filter="gray";}',100);
					//}
				}
			}
		}
	}
	setTimeout('oSpikeweed.fAttack("'+id+'")',1000);
}

/*-------------------�ش���---------------------------*/
function CSpikerock(){
	this.EName='oSpikerock'; //Ӣ������
	this.CName='�ش���'; //��������
	this.width=84; //��
	this.height=43; //��
	this.HP=450; //�;�
	this.SunNum=125;
	this.canEat=0; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/Spikerock.png'; //��ƬͼƬ
	this.normalGif='images/Plants/Spikerock/Spikerock.gif'; //��ͨ����
	this.canGrow='[�ݵ�]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=50000; //��ȴʱ��
	this.BreakPoint=1; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant='oSpikeweed'; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=0; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	//ֲ������
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CSpikerock.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[�ݵ�]':
			return(-10);
			break;
	}
}
CSpikerock.prototype.fAttack=function(id){
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);}
	var obC=ob.C,obR=ob.R;
	if(oGP.aPlant[obC][obR][1].substr(0,14)=='P_oPumpkinHead'){setTimeout('oSpikerock.fAttack("'+ob.id+'")',1000);return(false);}
	var	zombieStr=oGP.aZombie[obC-1][obR]+oGP.aZombie[obC][obR]+oGP.aZombie[obC+1][obR]; //����ӵ����ڸ��ӵĽ�ʬ�ַ���
	if(zombieStr!=''){ //�ֽ⽩ʬ�ַ����ɽ�ʬ����
		var atmp=zombieStr.split(',');
		var LX=ob.style.pixelLeft,RX=ob.style.pixelLeft+ob.width,MX=ob.style.pixelLeft+ob.width/2;
		for(n=0;n<atmp.length-1;n++){ //ѭ�������ӽ�������ֲ��ǰ��Ľ�ʬ
			obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
			if(obZombie.beAttacked==1){ //��ʬ��������״̬,���Ա�����
				if(obZombie.WalkDirection==0){ //��ý�ʬ�ı�����������
					switch(true){
						case obZombie.AttackedLX>=LX&&obZombie.AttackedLX<=MX:
						case obZombie.AttackedLX<=LX&&obZombie.AttackedRX>=RX:
						case obZombie.AttackedRX>=LX&&obZombie.AttackedRX<=MX:
							PlantAttack(ob.id,obZombie.id,0,40,0,0,0,'�ش�');
					}
					//if(obZombie.FreeSlowTime==''){
					//	obZombie.style.filter='alpha(opacity=60)'; //��������
					//	setTimeout('if('+obZombie.id+'.beAttacked==1){'+obZombie.id+'.style.filter="";}else{'+obZombie.id+'.style.filter="gray";}',100);
					//}
				}else{
					switch(true){
						case obZombie.AttackedLX>=MX&&obZombie.AttackedLX<=RX:
						case obZombie.AttackedLX<=LX&&obZombie.AttackedRX>=RX:
						case obZombie.AttackedRX>=MX&&obZombie.AttackedRX<=RX:
							PlantAttack(ob.id,obZombie.id,0,40,0,0,0,'�ش�');
					}
					//if(obZombie.FreeSlowTime==''){
					//	obZombie.style.filter='alpha(opacity=60)'; //��������
					//	setTimeout('if('+obZombie.id+'.beAttacked==1){'+obZombie.id+'.style.filter="";}else{'+obZombie.id+'.style.filter="gray";}',100);
					//}
				}
			}
		}
	}
	setTimeout('oSpikerock.fAttack("'+id+'")',1000);
}

/*-------------------���ǽ---------------------------*/
function CWallNut(){
	this.EName='oWallNut'; //Ӣ������
	this.CName='���ǽ'; //��������
	this.width=65; //��
	this.height=73; //��
	this.HP=4000; //�;�
	this.SunNum=50;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/WallNut.png'; //��ƬͼƬ
	this.normalGif='images/Plants/WallNut/WallNut.gif'; //��ͨ����
	this.canGrow='[�ݵ�][˯��][����]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=30000; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	//ֲ������
	var C=ob.C;
	var R=ob.R;
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[C][R][0]='';
}
CWallNut.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	
	switch(GroundStr){
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		case '[˯��]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------�߼��---------------------------*/
function CTallNut(){
	this.EName='oTallNut'; //Ӣ������
	this.CName='�߼��'; //��������
	this.width=83; //��
	this.height=119; //��
	this.HP=8000; //�;�
	this.SunNum=125;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/TallNut.png'; //��ƬͼƬ
	this.normalGif='images/Plants/TallNut/TallNut.gif'; //��ͨ����
	this.canGrow='[�ݵ�][˯��][����]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=30000; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=2; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	//ֲ������
	var C=ob.C;
	var R=ob.R;
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[C][R][0]='';
}
CTallNut.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	
	switch(GroundStr){
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		case '[˯��]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------����---------------------------*/
function CGralic(){
	this.EName='oGralic'; //Ӣ������
	this.CName='����'; //��������
	this.width=60; //��
	this.height=59; //��
	this.HP=400; //�;�
	this.SunNum=50;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/Gralic.png'; //��ƬͼƬ
	this.normalGif='images/Plants/Gralic/Gralic.gif'; //��ͨ����
	this.canGrow='[�ݵ�][˯��][����]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=7500; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	//ֲ������
	var C=ob.C;
	var R=ob.R;
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[C][R][0]='';
}
CGralic.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	
	switch(GroundStr){
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		case '[˯��]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------�ѹ�---------------------------*/
function CSquash(){
	this.EName='oSquash'; //Ӣ������
	this.CName='�ѹ�'; //��������
	this.width=73; //��
	this.height=85; //��
	this.HP=300; //�;�
	this.SunNum=50;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/Squash.png'; //��ƬͼƬ
	this.normalGif='images/Plants/Squash/Squash.gif'; //��ͨ����
	this.canGrow='[�ݵ�][˯��][����]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=30000; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	//ֲ������
	if(ob.isBoom==0){document.getElementById('dAll').removeChild(ob);} //����Ǳ�ը״̬���Ƴ�ͼƬ�ɹ�����ʱ��ִ��
	oGP.aPlant[ob.C][ob.R][0]='';
}
CSquash.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		case '[˯��]':
			return(-20);
			break;
		default:
			return(0);
	}
}
CSquash.prototype.fAttack=function(id){
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //�����Ѿ�����
	var C=ob.C,R=ob.R;
	var zombieStr=oGP.aZombie[C-1][R]+oGP.aZombie[C][R]+oGP.aZombie[C+1][R];
	if(C<oGP.MaxC){zombieStr+=oGP.aZombie[C+2][R];}
	if(zombieStr!=''){
		var smallX='',smallZombie='',n,atmp,obZombie,LX,RX,obZombieX,MiddleX;
		atmp=zombieStr.split(',');
		LX=ob.style.pixelLeft-40;RX=ob.style.pixelLeft+ob.width+120; //����ѹϹ���X��Χ����40��120,�Խ�ʬ�����ҹ��������X��Χ���ж��Ƿ�����
		MiddleX=ob.style.pixelLeft+ob.width/2; //�ѹϵ��е�X
		for(n=0;n<atmp.length-1;n++){ //ѭ����ý�ʬ
			obZombie=document.getElementById(atmp[n]); //ѭ���������Ľ�ʬ����
			switch(true){
				case obZombie.AttackedLX>=LX&&obZombie.AttackedLX<=RX: //��ʬ�󹥻�����X��Χ��
				case obZombie.AttackedRX>=LX&&obZombie.AttackedRX<=RX: //��ʬ�ҹ�������X��Χ��
				case obZombie.AttackedLX<=LX&&obZombie.AttackedRX>=RX: //��ʬ�����X1���ҵ���X2��
					if(obZombie.beAttacked==1){
						if(smallX==''){
							switch(obZombie.WalkDirection){
								case 0: //��ʬ�����ߣ�ȡ�󹥻�����Ϊ�����ж�
									smallX=obZombie.AttackedLX;
									break;
								default: //������ȡ�ҹ�����
									smallX=obZombie.AttackedRX;
							}
							smallZombie=obZombie;
						}else{
							switch(obZombie.WalkDirection){
								case 0: //��ʬ�����ߣ�ȡ�󹥻�����Ϊ�����ж�
									obZombieX=obZombie.AttackedLX;
									break;
								default: //������ȡ�ҹ�����
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
			setTimeout('oSquash.fBoom('+ob.id+','+obZombie.C+')',600); //���ҳ���
			return(false);
		}
	}
	setTimeout('oSquash.fAttack("'+ob.id+'")',100);
}
CSquash.prototype.fBoom=function(ob,C){
	//��
	var obZombie;
	var R=ob.R;
	var zombieStr=oGP.aZombie[C][R];
	if(C>0){zombieStr+=oGP.aZombie[C-1][R];}
	if(C<=oGP.MaxC){zombieStr+=oGP.aZombie[C+1][R];}
	var n,atmp,LX,RX;
	LX=ob.style.pixelLeft;
	RX=ob.style.pixelLeft+ob.width;
	atmp=zombieStr.split(',');
	for(n=0;n<atmp.length-1;n++){ //ѭ����ý�ʬ
		obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
		switch(true){
			case obZombie.AttackedLX>=LX&&obZombie.AttackedLX<=RX: //��ʬ�󹥻�����X��Χ��
			case obZombie.AttackedRX>=LX&&obZombie.AttackedRX<=RX: //��ʬ�ҹ�������X��Χ��
			case obZombie.AttackedLX<=LX&&obZombie.AttackedRX>=RX: //��ʬ�����X1���ҵ���X2��
				if(obZombie.beAttacked==1){
					PlantAttack(ob.id,obZombie.id,0,this.Attack,0,'��͸');
				}
				break;
		}
	}
	ob.isBoom=1;
	this.Die(ob);
	setTimeout('document.getElementById("dAll").removeChild('+ob.id+');',1000);
}

/*-------------------ӣ��ը��---------------------------*/
function CCherryBomb(){
	this.EName='oCherryBomb'; //Ӣ������
	this.CName='ӣ��ը��'; //��������
	this.width=112; //��
	this.height=81; //��
	this.HP=300; //�;�
	this.SunNum=150;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/CherryBomb.png'; //��ƬͼƬ
	this.normalGif='images/Plants/CherryBomb/CherryBomb.gif'; //��ͨ����
	this.canGrow='[�ݵ�][����][˯��]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=50000; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	tmpImg2.src='images/Plants/CherryBomb/Boom.gif'; //��ը������
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
	//ֲ������
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CCherryBomb.prototype.fBoom=function(ob){
	//��ը
	var C=ob.C,R=ob.R;
	var R1;
	var zombieStr=oGP.aZombie[C-1][R]+oGP.aZombie[C][R]+oGP.aZombie[C+1][R];
	if(R>1){R1=R-1;zombieStr+=oGP.aZombie[C-1][R1]+oGP.aZombie[C][R1]+oGP.aZombie[C+1][R1];}
	if(R<oGP.MaxR){R1=R+1;zombieStr+=oGP.aZombie[C-1][R1]+oGP.aZombie[C][R1]+oGP.aZombie[C+1][R1];}
	var n,atmp,obZombie;
	atmp=zombieStr.split(',');
	for(n=0;n<atmp.length-1;n++){ //ѭ����ý�ʬ
		obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
		PlantAttack(ob.id,obZombie.id,0,this.Attack,0,'��͸')
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
	//GroundStr��ʾ�������ԣ�����'[�ݵ�]'
	//����������ĳ�����Գ������������ƫ����
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		case '[˯��]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------������---------------------------*/
function CJalapeno(){
	this.EName='oJalapeno'; //Ӣ������
	this.CName='������'; //��������
	this.width=68; //��
	this.height=89; //��
	this.HP=300; //�;�
	this.SunNum=150;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/Jalapeno.png'; //��ƬͼƬ
	this.normalGif='images/Plants/Jalapeno/Jalapeno.gif'; //��ͨ����
	this.canGrow='[�ݵ�][����][˯��]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=50000; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	tmpImg2.src='images/Plants/Jalapeno/JalapenoAttack.gif'; //��ը��
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
	//ֲ������
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CJalapeno.prototype.fBoom=function(ob){
	//��ը
	var C=ob.C,R=ob.R;
	var R1,n;
	var zombieStr='';
	for(n=0;n<=oGP.MaxC+1;n++){
		zombieStr+=oGP.aZombie[n][R];
	}
	var n,atmp,obZombie;
	atmp=zombieStr.split(',');
	for(n=0;n<atmp.length-1;n++){ //ѭ����ý�ʬ
		obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
		PlantAttack(ob.id,obZombie.id,0,this.Attack,0,'��͸')
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
	//GroundStr��ʾ�������ԣ�����'[�ݵ�]'
	//����������ĳ�����Գ������������ƫ����
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		case '[˯��]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------���컨---------------------------*/
function CChomper(){
	this.EName='oChomper'; //Ӣ������
	this.CName='���컨'; //��������
	this.width=101; //��
	this.height=98; //��
	this.HP=300; //�;�
	this.SunNum=150;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/Chomper.png'; //��ƬͼƬ
	this.normalGif='images/Plants/Chomper/Chomper.gif'; //��ͨ����
	this.canGrow='[�ݵ�][˯��][����]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=7500; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	//ֲ������
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CChomper.prototype.GetDeviationY=function(C,R){
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		case '[˯��]':
			return(-20);
			break;
		default:
			return(0);
	}
}
CChomper.prototype.fAttack=function(id){
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //�����Ѿ�����
	var C=ob.C,R=ob.R;
	var zombieStr=oGP.aZombie[C][R]+oGP.aZombie[C+1][R];
	if(C<oGP.MaxC){zombieStr+=oGP.aZombie[C+2][R];}
	if(zombieStr!=''){
		var smallX='',smallZombie='',n,atmp;
		atmp=zombieStr.split(',');
		var obZombie=document.getElementById(atmp[0]);
		for(n=0;n<atmp.length-1;n++){ //ѭ����ý�ʬ
			obZombie=document.getElementById(atmp[n]); //ѭ���������Ľ�ʬ����
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
	if(ob!='[object]'){return(false);} //��������
	var obZombie=document.getElementById(zombieid);
	if(obZombie!='[object]'||obZombie.beAttacked!=1){ //�����Ľ�ʬ�Ѿ�������
		setTimeout('oChomper.fNormal("'+id+'")',400);
	}else{
		var OZombie;
		eval('OZombie='+obZombie.EName);
		if(OZombie.againstRaven==0){ //��������ʳ,�����Ժ�
			OZombie.Die(obZombie);
			setTimeout('oChomper.fDigest("'+id+'")',400);
		}else{ //������ʳ,�൱�ڹ���40��,�����Ժ�ظ���������̬
			PlantAttack(id,zombieid,0,this.Attack,0,0,0,'ֱ��');
			setTimeout('oChomper.fNormal("'+id+'")',400);
		}
	}
}
CChomper.prototype.fDigest=function(id){
	//�׽���̬
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);}
	ob.style.pixelTop+=30;
	ob.width=dicPlantsGif('ChomperDigest').width;
	ob.height=dicPlantsGif('ChomperDigest').height;
	ob.src=dicPlantsGif('ChomperDigest').src;
	setTimeout('oChomper.fNormal("'+id+'")',42000);
}

CChomper.prototype.fNormal=function(id){
	//�ָ���ƽ����̬
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

/*-------------------��������---------------------------*/
function CSplitPea(){
	this.EName='oSplitPea'; //Ӣ������
	this.CName='��������'; //��������
	this.width=92; //��
	this.height=72; //��
	this.HP=300; //�;�
	this.SunNum=125;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/SplitPea.png'; //��ƬͼƬ
	this.normalGif='images/Plants/SplitPea/SplitPea.gif'; //��ͨ����
	this.canGrow='[�ݵ�][����][˯��]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=7500; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
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
	//��ֲ����ֲ���ʹ�������Ա�Ϊ���������ԣ�����˯����ֲ��ʹ"ˮ��"���"˯��"
	//����ı��ֲ��÷���Ϊ��
	ob.src=dicPlantsGif('oSplitPea').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	this.fAttack(ob.id,1);
}
CSplitPea.prototype.Die=function(ob){
	//ֲ������
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CSplitPea.prototype.fAttack=function(id,NoPeashooterBullet){
	//ÿ��������ȴʱ��ͼ���Ƿ��е��ˣ��Ǿͼ�������������й���
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //�����Ѿ�����
	
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
		PeashooterBullet.AttackDirection=4; //�����н�����,0��ʾ�ң�˳ʱ��һֱ��7
		PeashooterBullet.Attack=20; //��ʼ����������ɻ��㶹�Ժ󷭱�
		PeashooterBullet.BulletKind=0; //-1��ʾ���٣�0��ʾ��ͨ�㶹��1��ʾ���㶹
		PeashooterBullet.ChangeBulletC=0; //�㶹����BulletKind��C,Ҳ�����Ƿ񾭹��˻����׮
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
		PeashooterBullet2.AttackDirection=0; //�����н�����,0��ʾ�ң�˳ʱ��һֱ��7
		PeashooterBullet2.Attack=20; //��ʼ����������ɻ��㶹�Ժ󷭱�
		PeashooterBullet2.BulletKind=0; //-1��ʾ���٣�0��ʾ��ͨ�㶹��1��ʾ���㶹
		PeashooterBullet2.ChangeBulletC=0; //�㶹����BulletKind��C,Ҳ�����Ƿ񾭹��˻����׮
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
	//�ж��ұ��Ƿ��н�ʬ
	var C=parseInt(ob.C),R=parseInt(ob.R);
	if(oGP.aR[R]==0){return(false);}
	var m,n,zombieStr,atmp,obZombie,obZombieX;
	for(m=C;m<=oGP.MaxC+1;m++){ //�㶹��������ж�
		zombieStr=oGP.aZombie[m][R];
		if(zombieStr!=''){
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //ѭ�������ӽ�������ֲ��ǰ��Ľ�ʬ
				obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
				if(obZombie.WalkDirection==0){ //��ý�ʬ�ı�����������
					obZombieX=obZombie.AttackedLX; //��ʬ�����ߣ���ȡ�󱻹�����
				}else{
					obZombieX=obZombie.AttackedRX; //��ʬ�����ߣ���ȡ�ұ�������
				}
				if(obZombieX>=ob.AttackedLX){ //��ʬ�ı������������������ֲ�ﱻ�����������
					return(true);
				}
			}
		}
	}
	return(false);
}
CSplitPea.prototype.HaveEnemyL=function(ob){
	//�ж�����Ƿ��н�ʬ
	var C=parseInt(ob.C),R=parseInt(ob.R);
	if(oGP.aR[R]==0){return(false);}
	var m,n,zombieStr,atmp,obZombie,obZombieX;
	for(m=0;m<=C;m++){ //�㶹��������ж�
		zombieStr=oGP.aZombie[m][R];
		if(zombieStr!=''){
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //ѭ�������ӽ�������ֲ��ǰ��Ľ�ʬ
				obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
				if(obZombie.WalkDirection==0){ //��ý�ʬ�ı�����������
					obZombieX=obZombie.AttackedLX; //��ʬ�����ߣ���ȡ�󱻹�����
				}else{
					obZombieX=obZombie.AttackedRX; //��ʬ�����ߣ���ȡ�ұ�������
				}
				if(obZombieX<=ob.AttackedRX){ //��ʬ�ı������������������ֲ�ﱻ�����������
					return(true);
				}
			}
		}
	}
	return(false);
}

CSplitPea.prototype.GetDeviationY=function(C,R){
	//GroundStr��ʾ�������ԣ�����'[�ݵ�]'
	//����������ĳ�����Գ������������ƫ����
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[�ݵ�]':
			return(-15);
			break;
		case '[����]':
			return(-23);
			break;
		case '[˯��]':
			return(-20);
			break;
		default:
			return(0);
	}
}

/*-------------------����---------------------------*/
function CStarfruit(){
	//����ֲ�ﶼ�е�����
	this.EName='oStarfruit'; //Ӣ������
	this.CName='����'; //��������
	this.width=77; //��
	this.height=70; //��
	this.HP=300; //�;�
	this.SunNum=125;
	this.canEat=1; //�ܱ���ʬ�Ե�
	this.isGroundPlant=0; //�Ƿ�����ֲ��
	this.isProtectPlant=0; //�Ƿ񱣻���ֲ������Ϲ�
	this.cardImage='images/Card/Plants/Starfruit.png'; //��ƬͼƬ
	this.normalGif='images/Plants/Starfruit/Starfruit.gif'; //��ͨ����
	this.canGrow='[�ݵ�][����][˯��]'; //������ֲ��ʲô���Եĳ���,�������Ա�����CGroundPool.aP[n]������
	this.coolTime=7500; //��ȴʱ��
	this.BreakPoint=0; //�ٽ��,�;õ��ڴ˼�����
	this.onOtherPlant=''; //������ֲ������ֲ���ϣ�""��ʾ���ܣ���ֲ��EName����ʾ������ֲ�ڸ���ֲ����
	this.onOtherPlantNum=0; //�������ڼ���ֲ���ϣ�ֵΪ1��ʾ�ø�Ϊ2��ʾ����Ҫ������������Χ8�����������������������ڣ�
	this.Stature=1; //�������0��ʾ��С�ͣ�С�繽���⹽�ش̣�1��ʾ��ͨ��2��ʾ�ߴ��ͣ��߼��
	this.againstSecKill=0; //�Ƿ�������ɱ
	this.beAttackedPointL=20; //�����������pixelLeftƫ��
	this.beAttackedPointR=57; //�ҵ�ƫ��

	//��������ֲ�ﶼ�е�����
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
	//GroundStr��ʾ�������ԣ�����'[�ݵ�]'
	//����������ĳ�����Գ������������ƫ����
	var GroundStr=oGP.aPAfterGrow[C][R];
	switch(GroundStr){
		case '[�ݵ�]':
			return(-10);
			break;
		case '[����]':
			return(-18);
			break;
		case '[˯��]':
			return(-15);
			break;
	}
}
CStarfruit.prototype.Birth=function(ob){
	//��ֲ����ֲ���ʹ�������Ա�Ϊ���������ԣ�����˯����ֲ��ʹ"ˮ��"���"˯��"
	//����ı��ֲ��÷���Ϊ��
	ob.src=dicPlantsGif('oStarfruit').src;
	oGP.aPlant[ob.C][ob.R][0]=ob.id;
	this.fAttack(ob.id);
}
CStarfruit.prototype.Die=function(ob){
	//ֲ������
	document.getElementById('dAll').removeChild(ob);
	oGP.aPlant[ob.C][ob.R][0]='';
}
CStarfruit.prototype.fAttack=function(id){
	//ÿ��������ȴʱ��ͼ���Ƿ��е��ˣ��Ǿͼ�������������й���
	var ob=document.getElementById(id);
	if(ob!='[object]'){return(false);} //�����Ѿ�����
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
	//�ж����±��Ƿ��н�ʬ
	var C=parseInt(ob.C),R=parseInt(ob.R);
	var m,l,n,tmpl,zombieStr,atmp,obZombie,obZombieX,obZombieC;
	var StarMY=ob.style.pixelTop+15; //�����ӵ����е�Y����
	var FlyTime,SS; //�ӵ�������дﵽ��ʬ��������Ҫ��ʱ�䣬�ӵ�������дﵽ��ʬ������ʱ��ʬ�Ѿ��н��ľ���
	for(m=R+1;m<=oGP.MaxR;m++){
		if(oGP.aR[m]==0){continue;}
		tmpl=C-1+2*(m-R);
		if(tmpl>oGP.MaxC){break;}
		zombieStr='';
		for(l=tmpl;l<=tmpl+3;l++){ //ÿ����������C+1+(m-1-R)*2,��������C+1+(m-1-R)*2+3
			if(l>oGP.MaxC+1){break;}
			zombieStr+=oGP.aZombie[l][m];
		}
		if(zombieStr!=''){
			FlyTime=(GetY(m)-StarMY)*4; //����������ٶ���ÿ����0.25,(StarMY-GetY(m))/0.25=����ʱ��
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //ѭ����ý�ʬ
				obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
				if(obZombie.WalkDirection==0){ //��ý�ʬ�ı�����������
					obZombieX=obZombie.AttackedLX; //��ʬ�����ߣ���ȡ�󱻹�����
					SS=-obZombie.Speed*Math.floor(FlyTime*0.008);
				}else{
					obZombieX=obZombie.AttackedRX; //��ʬ�����ߣ���ȡ�ұ�������
					SS=obZombie.Speed*Math.floor(FlyTime*0.008);
				}
				obZombieX+=SS;
				obZombieC=GetC(obZombieX);
				if(obZombieC<tmpl+3&&obZombieC>tmpl){ //��ʬԤ���н������е����ӵ����е�����
					return(true);
				}
			}
		}
	}
	return(false);
}
CStarfruit.prototype.AttackRD=function(ob){
	//��������·ɵ��ӵ�
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
	Bullet.AttackDirection=1; //�����н�����,0��ʾ�ң�˳ʱ��һֱ��7
	document.getElementById('dAll').appendChild(Bullet);
	setTimeout('var tmpOb=document.getElementById("'+Bullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',100);
	aMoveStar.push(Bullet);
}

CStarfruit.prototype.HaveEnemyRU=function(ob){
	//�ж����ϱ��Ƿ��н�ʬ
	var C=parseInt(ob.C),R=parseInt(ob.R);
	var m,l,n,tmpl,zombieStr,atmp,obZombie,obZombieX,obZombieC;
	var StarMY=ob.style.pixelTop+15; //�����ӵ����е�Y����
	var FlyTime,SS; //�ӵ�������дﵽ��ʬ��������Ҫ��ʱ�䣬�ӵ�������дﵽ��ʬ������ʱ��ʬ�Ѿ��н��ľ���
	for(m=R-1;m>=1;m--){
		if(oGP.aR[m]==0){continue;}
		tmpl=C-1+2*(R-m);
		if(tmpl>oGP.MaxC){break;}
		zombieStr='';
		for(l=tmpl;l<=tmpl+3;l++){ //ÿ����������C+1+(R-m-1)*2,��������C+1+(R-m-1)*2+3
			if(l>oGP.MaxC+1){break;}
			zombieStr+=oGP.aZombie[l][m];
		}
		if(zombieStr!=''){
			FlyTime=(StarMY-GetY(m))*4; //����������ٶ���ÿ����0.25,(StarMY-GetY(m))/0.25=����ʱ��
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //ѭ����ý�ʬ
				obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
				if(obZombie.WalkDirection==0){ //��ý�ʬ�ı�����������
					obZombieX=obZombie.AttackedLX; //��ʬ�����ߣ���ȡ�󱻹�����
					SS=-obZombie.Speed*Math.floor(FlyTime*0.008);
				}else{
					obZombieX=obZombie.AttackedRX; //��ʬ�����ߣ���ȡ�ұ�������
					SS=obZombie.Speed*Math.floor(FlyTime*0.008);
				}
				obZombieX+=SS;
				obZombieC=GetC(obZombieX);
				if(obZombieC<tmpl+3&&obZombieC>tmpl){ //��ʬԤ���н������е����ӵ����е�����
					return(true);
				}
			}
		}
	}
	return(false);
}
CStarfruit.prototype.AttackRU=function(ob){
	//��������Ϸɵ��ӵ�
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
	Bullet.AttackDirection=7; //�����н�����,0��ʾ�ң�˳ʱ��һֱ��7
	document.getElementById('dAll').appendChild(Bullet);
	setTimeout('var tmpOb=document.getElementById("'+Bullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',100);
	aMoveStar.push(Bullet);
}

CStarfruit.prototype.HaveEnemyL=function(ob){
	//�ж�����Ƿ��н�ʬ
	var C=parseInt(ob.C),R=parseInt(ob.R);
	if(oGP.aR[R]==0){return(false);}
	var m,n,zombieStr,atmp,obZombie,obZombieX;
	for(m=C;m>=0;m--){
		zombieStr=oGP.aZombie[m][R];
		if(zombieStr!=''){
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //ѭ�������ӽ�������ֲ��ǰ��Ľ�ʬ
				obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
				if(obZombie.WalkDirection==0){ //��ý�ʬ�ı�����������
					obZombieX=obZombie.AttackedLX; //��ʬ�����ߣ���ȡ�󱻹�����
				}else{
					obZombieX=obZombie.AttackedRX; //��ʬ�����ߣ���ȡ�ұ�������
				}
				if(obZombieX<=ob.AttackedRX){ //��ʬ�ı���������������С��ֲ�ﱻ�����������
					return(true);
				}
			}
		}
	}
	return(false);
}
CStarfruit.prototype.AttackL=function(ob){
	//�������ɵ��ӵ�
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
	Bullet.AttackDirection=4; //�����н�����,0��ʾ�ң�˳ʱ��һֱ��7
	document.getElementById('dAll').appendChild(Bullet);
	setTimeout('var tmpOb=document.getElementById("'+Bullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',150);
	aMoveStar.push(Bullet);
}
CStarfruit.prototype.HaveEnemyU=function(ob){
	//�ж��ϱ��Ƿ��н�ʬ
	var C=parseInt(ob.C),R=parseInt(ob.R);
	var m,n,zombieStr,atmp,obZombie,obZombieX;
	var StarMY=ob.style.pixelTop+15; //�����ӵ����е�Y����
	var FlyTime,SS; //�ӵ�������дﵽ��ʬ��������Ҫ��ʱ�䣬�ӵ�������дﵽ��ʬ������ʱ��ʬ�Ѿ��н��ľ���
	for(m=R;m>=1;m--){
		if(oGP.aR[m]==0){continue;}
		zombieStr=oGP.aZombie[C-1][m]+oGP.aZombie[C][m]+oGP.aZombie[C+1][m];
		if(zombieStr!=''){
			FlyTime=(StarMY-GetY(m))*2;
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //ѭ����ý�ʬ
				obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
				if(obZombie.WalkDirection==0){ //��ý�ʬ�ı�����������
					obZombieX=obZombie.AttackedLX; //��ʬ�����ߣ���ȡ�󱻹�����
					SS=-obZombie.Speed*Math.floor(FlyTime*0.008);
				}else{
					obZombieX=obZombie.AttackedRX; //��ʬ�����ߣ���ȡ�ұ�������
					SS=obZombie.Speed*Math.floor(FlyTime*0.008);
				}
				obZombieX+=SS;
				if(GetC(obZombieX)==C){ //��ʬԤ���н������е����ӵ����е�����
					return(true);
				}
			}
		}
	}
	return(false);
}
CStarfruit.prototype.AttackU=function(ob){
	//������Ϸɵ��ӵ�
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
	Bullet.AttackDirection=6; //�����н�����,0��ʾ�ң�˳ʱ��һֱ��7
	document.getElementById('dAll').appendChild(Bullet);
	setTimeout('var tmpOb=document.getElementById("'+Bullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',100);
	aMoveStar.push(Bullet);
}
CStarfruit.prototype.HaveEnemyD=function(ob){
	//�ж��±��Ƿ��н�ʬ
	var C=parseInt(ob.C),R=parseInt(ob.R);
	var m,n,zombieStr,atmp,obZombie,obZombieX;
	var StarMY=ob.style.pixelTop+15; //�����ӵ����е�Y����
	var FlyTime,SS; //�ӵ�������дﵽ��ʬ��������Ҫ��ʱ�䣬�ӵ�������дﵽ��ʬ������ʱ��ʬ�Ѿ��н��ľ���
	for(m=R;m<=oGP.MaxR;m++){
		if(oGP.aR[m]==0){continue;}
		zombieStr=oGP.aZombie[C-1][m]+oGP.aZombie[C][m]+oGP.aZombie[C+1][m];
		if(zombieStr!=''){
			FlyTime=(StarMY-GetY(m))*2;
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //ѭ����ý�ʬ
				obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
				if(obZombie.WalkDirection==0){ //��ý�ʬ�ı�����������
					obZombieX=obZombie.AttackedLX; //��ʬ�����ߣ���ȡ�󱻹�����
					SS=-obZombie.Speed*Math.floor(FlyTime*0.008);
				}else{
					obZombieX=obZombie.AttackedRX; //��ʬ�����ߣ���ȡ�ұ�������
					SS=obZombie.Speed*Math.floor(FlyTime*0.008);
				}
				obZombieX+=SS;
				if(GetC(obZombieX)==C){ //��ʬԤ���н������е����ӵ����е�����
					return(true);
				}
			}
		}
	}
	return(false);
}
CStarfruit.prototype.AttackD=function(ob){
	//������·ɵ��ӵ�
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
	Bullet.AttackDirection=2; //�����н�����,0��ʾ�ң�˳ʱ��һֱ��7
	document.getElementById('dAll').appendChild(Bullet);
	setTimeout('var tmpOb=document.getElementById("'+Bullet.id+'");if(tmpOb=="[object]"){tmpOb.style.display="block"}',100);
	aMoveStar.push(Bullet);
}
function MovePeashooterBullet(){
	//�ƶ��㶹�ӵ��Ĺ��ú������㶹���֣�˫�����֣��������֣���ǹ���֣������㶹���֣����㶹����
	var m=0;
	if(aMovePea.length==0){setTimeout('MovePeashooterBullet()',20);return(false);}
	while(true){
		if(m>aMovePea.length-1){break;}
		var ob=aMovePea[m];
		var zombieStr;
		var atmp,tmpX='',obZombie,tmpOb='';
		var obC=GetC(ob.X); //�ӵ��ĸ���C
		var obR=ob.R; //�ӵ��ĸ���R
		var MX=ob.style.pixelLeft+ob.width/2; //�ӵ����е�X����
		var side=(ob.AttackDirection==0)?10:-10; //��������+10��ʾ�ң�-10��ʾ��
		if(obC>1){
			zombieStr=oGP.aZombie[obC-1][obR]+oGP.aZombie[obC][obR]; //����ӵ����ڸ��ӵĽ�ʬ�ַ���
		}else{
			zombieStr=oGP.aZombie[obC][obR];
		}
		if(zombieStr!=''){ //�ֽ⽩ʬ�ַ����ɽ�ʬ����
			atmp=zombieStr.split(',');
			for(n=0;n<atmp.length-1;n++){ //ѭ�������ӽ��Ľ�ʬ
				obZombie=document.getElementById(atmp[n]); //��ý�ʬ����
				switch(ob.AttackDirection){
					case 0: //���ҹ������㶹
						if(ob.X>=obZombie.AttackedLX&&ob.X<=obZombie.AttackedRX){ //�ӵ����е������ڽ�ʬ�����ܹ�����֮���ʾ���Թ���
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
					case 4: //���󹥻����㶹
						if(ob.X>=obZombie.AttackedLX&&ob.X<=obZombie.AttackedRX){ //�ӵ����е������ڽ�ʬ�����ܹ�����֮���ʾ���Թ���
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
				if(tmpOb.beAttacked==1){ //��ʬ��������״̬,���Ա�����
					PlantAttack(ob.id,tmpOb.id,0,ob.Attack,0,0,ob.BulletKind,'ֱ��');
					//if(tmpOb.FreeSlowTime==''){
						//tmpOb.style.filter='alpha(opacity=60)'; //��������
						//setTimeout('if('+tmpOb.id+'.beAttacked==1){'+tmpOb.id+'.style.filter="";}else{'+tmpOb.id+'.style.filter="gray";}',100);
					//}
				}
				//��ʬ������״̬�����չ�������ʬ�������ټ��٣��ɽ�ʬ����functionִ��
				document.getElementById('dAll').removeChild(ob);
				aMovePea.splice(m,1);
				continue;
			}
		}
		//��������׮
		if(obC<=oGP.MaxC&&obC>=1&&ob.ChangeBulletC!=obC){
			if(oGP.aPlant[obC][obR][0].substr(0,12)=='P_oTorchwood'){
				switch(ob.BulletKind){
					case -1: //���㶹�����ͨ�㶹
						ob.src=dicPlantsGif('PeashooterBullet').src;
						ob.width=dicPlantsGif('PeashooterBullet').width;
						ob.height=dicPlantsGif('PeashooterBullet').height;
						ob.BulletKind=0;
						ob.ChangeBulletC=obC;
						ob.X=ob.style.pixelLeft+12;
						break;
					case 0: //��ͨ�㶹��ɻ��㶹
						ob.src=dicPlantsGif('FirePeashooterBullet').src;
						if(ob.AttackDirection==0){ //���ҷ�
							ob.X=ob.style.pixelLeft+40;
						}else{
							ob.X=ob.style.pixelLeft+16;
							ob.style.filter='FlipH'; //����ɵĻ��㶹��תGIFͼƬ
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
		//�߽�
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
	//�ƶ������ӵ�
	var m=0;
	if(aMoveStar.length==0){setTimeout('MoveStarBullet()',20);return(false);}
	while(true){
		if(m>aMoveStar.length-1){break;}
		var ob=aMoveStar[m];
		var zombieStr;
		var atmp,tmpX='',obZombie,tmpOb='',obZombieX;
		var obC=GetC(ob.X); //�ӵ��ĸ���C
		var obR=GetR(ob.style.pixelTop+15); //�ӵ��ĸ���R
		var MX=ob.style.pixelLeft+ob.width/2; //�ӵ����е�X����
		switch(ob.AttackDirection){
			case 1: //�����¹���
				if(obC>0){zombieStr=oGP.aZombie[obC-1][obR];}
				zombieStr+=oGP.aZombie[obC][obR];
				if(obC<=oGP.MaxC){zombieStr+=oGP.aZombie[obC+1][obR];}
				if(zombieStr!=''){
					atmp=zombieStr.split(',');
					for(n=0;n<atmp.length-1;n++){
						obZombie=document.getElementById(atmp[n]);
						switch(obZombie.WalkDirection){
							case 0: //�����ߵĽ�ʬ
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
						if(tmpOb.beAttacked==1){ //��ʬ��������״̬,���Ա�����
							PlantAttack(ob.id,tmpOb.id,0,20,0,0,0,'ֱ��');
							//if(tmpOb.FreeSlowTime==''){
							//	tmpOb.style.filter='alpha(opacity=60)'; //��������
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
			case 7: //�����Ϲ���
				if(obC>0){zombieStr=oGP.aZombie[obC-1][obR];}
				zombieStr+=oGP.aZombie[obC][obR];
				if(obC<=oGP.MaxC){zombieStr+=oGP.aZombie[obC+1][obR];}
				if(zombieStr!=''){
					atmp=zombieStr.split(',');
					for(n=0;n<atmp.length-1;n++){
						obZombie=document.getElementById(atmp[n]);
						switch(obZombie.WalkDirection){
							case 0: //�����ߵĽ�ʬ
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
						if(tmpOb.beAttacked==1){ //��ʬ��������״̬,���Ա�����
							PlantAttack(ob.id,tmpOb.id,0,20,0,0,0,'ֱ��');
							//if(tmpOb.FreeSlowTime==''){
							//	tmpOb.style.filter='alpha(opacity=60)'; //��������
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
			case 2: //���¹���
				zombieStr=oGP.aZombie[obC][obR];
				if(zombieStr!=''){
					atmp=zombieStr.split(',');
					for(n=0;n<atmp.length-1;n++){
						obZombie=document.getElementById(atmp[n]);
						switch(obZombie.WalkDirection){
							case 0: //�����ߵĽ�ʬ
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
					if(tmpOb.beAttacked==1){ //��ʬ��������״̬,���Ա�����
						PlantAttack(ob.id,tmpOb.id,0,20,0,0,0,'ֱ��');
						//if(tmpOb.FreeSlowTime==''){
						//	tmpOb.style.filter='alpha(opacity=60)'; //��������
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
			case 6: //���Ϲ���
				zombieStr=oGP.aZombie[obC][obR];
				if(zombieStr!=''){
					atmp=zombieStr.split(',');
					for(n=0;n<atmp.length-1;n++){
						obZombie=document.getElementById(atmp[n]);
						switch(obZombie.WalkDirection){
							case 0: //�����ߵĽ�ʬ
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
					if(tmpOb.beAttacked==1){ //��ʬ��������״̬,���Ա�����
						PlantAttack(ob.id,tmpOb.id,0,20,0,0,0,'ֱ��');
						//if(tmpOb.FreeSlowTime==''){
						//	tmpOb.style.filter='alpha(opacity=60)'; //��������
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
			case 4: //���󹥻�
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
						if(tmpOb.beAttacked==1){ //��ʬ��������״̬,���Ա�����
							PlantAttack(ob.id,tmpOb.id,0,20,0,0,0,'ֱ��');
							//if(tmpOb.FreeSlowTime==''){
							//	tmpOb.style.filter='alpha(opacity=60)'; //��������
							//	setTimeout('if('+tmpOb.id+'.beAttacked==1){'+tmpOb.id+'.style.filter="";}else{'+tmpOb.id+'.style.filter="gray";}',50);
							//}
						}
						//��ʬ������״̬�����չ�������ʬ�������ټ��٣��ɽ�ʬ����functionִ��
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