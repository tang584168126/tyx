/**
	功能：学生信息管理系统
	作者：wanhuajun
	时间：2012-3-20
	*/
#include <stdio.h>
#include <math.h>
#include <windows.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#define LENGTH 20
#define  ROW  5 // 每页显示的人数
#define SIZE 6 //姓名长度
	int  no[LENGTH], i ,j;
	float hs[LENGTH],gs[LENGTH],cs[LENGTH],av[LENGTH];
	char name[LENGTH][SIZE];
	char name1[SIZE];
	int k; // 声明信息的计数器
	int f, g ; 
	char choice;//判断结果的标示符
	int kg;
	int isRight;
	int isRight1;
	int isRight2;
void showChoice();
void showMenu1();
void showMenu2();
void showMenu3();
void showMenu4();
void showMenu5();
void showMenu6();
void showMenu7();
void showMenu8();
void showStudent();
void showzengjia();
void showMe();
void showjiaohuan();
void showjieguo();
void showchushi(){
		no[0]=1,no[1]=2,no[2]=3,no[3]=4,no[4]=5,no[5]=6,no[6]=7,no[7]=8,
		no[8]=9,no[9]=10,
		strcpy(name[0],"qq"),strcpy(name[1],"ww"),strcpy(name[2],"ee");
		strcpy(name[3],"rr"),strcpy(name[4],"tt"),strcpy(name[5],"yy");
		strcpy(name[6],"aa"),strcpy(name[7],"ss");
		strcpy(name[8],"dd");
		strcpy(name[9],"rr");
		hs[0]=45,hs[1]=55,hs[2]=35,hs[3]=25,hs[4]=65,hs[5]=75,hs[6]=44,hs[7]=85;
		hs[8]=54,hs[9]=57;
		gs[0]=35,gs[1]=40,gs[2]=35,gs[3]=65,gs[4]=75,gs[5]=64,gs[6]=45,gs[7]=70;
		gs[8]=56,gs[9]=48;
		cs[0]=78,cs[1]=89,cs[2]=66,cs[3]=58,cs[4]=48,cs[5]=76,cs[6]=81,cs[7]=98;
		cs[8]=88,cs[9]=68;
		av[0]=(hs[0]+gs[0]+cs[0])/3,av[1]=(hs[1]+gs[1]+cs[1])/3,av[2]=(hs[2]+gs[2]+cs[2])/3;
		av[3]=(hs[3]+gs[3]+cs[3])/3,av[4]=(hs[4]+gs[4]+cs[4])/3,av[5]=(hs[5]+gs[5]+cs[5])/3;
		av[6]=(hs[6]+gs[6]+cs[06])/3,av[7]=(hs[7]+gs[7]+cs[7])/3;
		av[8]=(hs[8]+gs[8]+cs[8])/3;
		av[9]=(hs[9]+gs[9]+cs[9])/3;

}
int main()
{	
	
	for(i = 0 ; i < LENGTH; i ++){
		no[i] = -1;
		strcpy(name[i],"");
		hs[i] = -1;
		gs[i] = -1;
		cs[i] = -1;
		av[i]= -1;
	}
		showchushi();
 		 system("color 02");
		int isRight=1;
		char *pwd="111111";  
		char pwd1[6];  //声明接受输入的密码
		char name2[5];  // 声明用户名
		char *name1="admin" ;
	 	while(isRight == 1){
			system("cls");//☉★☉☉★★
			printf( "\t\t☉★☉☉★☉☉★☉☉★☉☉★☉☉★☉☉★☉☉★☉☉★☉☉★☉\n\n\n" );
			printf( "\t\t\t欢迎使用学员成绩管理系统\n\n\n" );
			printf( "\t\t\t\t\t\t作者：万华军\n\n\n" );
			printf( "\t\t☉★☉☉★☉☉★☉☉★☉☉★☉☉★☉☉★☉☉★☉☉★☉☉★☉\n\n" );
			printf( "\t\t* 请输入登录用户名<admin>:" );
		   	scanf("%s",&name2);;
		   	fflush(stdin);
			printf( "\t\t* 请输入密码<111111>:" );
			for(j = 0;j < 10; j ++){
				char ch = getch();
				if((int)ch ==13){
					pwd1[j]= '\0'; //清空
					break;
				}
				if((int)ch !=13){
						pwd1[j] = ch;
						putchar('*');
				}
				
			}
			
			if(name2 != name1 && stricmp(pwd1,pwd ) != 0){
					printf( "\n\t\t* 用户名或密码错误！按任意键继续..." );
					char ch1= getch();
					continue;
			}else{
				system("cls");
				printf( "正在初始化" );
				i = 1 ;
				while ( i ++){
					Sleep(100);
					if( i % 2 ){
						printf( "☆" );
					}else{
						printf( "★" );
					}
						if (i == 8){
						break;
					}
				}
			}
			break;
		} 

	system("cls");
	showChoice();
	return 0;
}

void showChoice(){
	
	system("cls");
	printf( "◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎" );
	printf( "◎⊕⊕◎⊕⊕◎⊕⊕◎⊕◎\t\t\t\t◎⊕⊕◎⊕⊕◎⊕⊕◎⊕◎" );
	printf( "◎⊕⊕◎\t\t\t▉功能选择▉\t\t\t\t◎⊕⊕◎\n\n" );
	printf( "\t\t¤1：显示学员信息\t\t¤2：查询学员信息\n" );
	printf( "\t\t¤3：修改学员信息\t\t¤4：统计学员信息\n" );
	printf( "\t\t¤5：增加学员信息\t\t¤6：删除学员信息\n" );
	printf( "\t\t¤7：显初始化信息库\t\t¤8：学员信息排序\n\n" );
	printf( "◎⊕⊕◎\t\t\t¤0:退出系统\t\t\t\t◎⊕⊕◎" );
	printf( "◎⊕⊕◎⊕⊕◎⊕⊕◎⊕◎\t\t\t\t◎⊕⊕◎⊕⊕◎⊕⊕◎⊕◎" );
	printf( "◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎⊕⊕◎" );
	printf( "请选择功能：" );
	choice = getch();
	int isRight;
	do{
		switch(choice){
			case '1':       //菜单1  显示
				showMenu1();  
				break;
			case '2':       //菜单2   查询
				showMenu2();
				break;
			case '3':        //菜单3   修改
				showMenu3();
				break;
			case '4':    //菜单4   统计
				showMenu4();
				break;
			case '5':     //菜单5   增加
				showMenu5();
				break;
			case '6':        //菜单6  删除
				showMenu6();
				break;
			case '7':    //菜单7
				showMenu7();
				break;
			case '8':   //菜单8  排序
				showMenu8();
				break; 
			case '0':     //退出
			 i = 1;
			system("cls");
			printf( "退出系统...\n正在释放资源" );
			while(i ++){
				Sleep(200);
				if (i % 2){
					printf( "◆" );
				}else{
					printf( "■" );
				}
				if (i ==10){
				system("cls");
				printf( "退出系统\n释放资源完成！请按任意键结束..." );
				char ch1= getch();
				fflush(stdin);
				exit(0);
				}
			}                       
				break; 
			default:
				printf( "\n\n你输入的选项有误，按任意键继续！" );
				choice = getch();
				showChoice();
				break;
		}
	}while(isRight);
}
void showMenu1(){   // 显示学员信息
	system("cls");
	showStudent();
	printf("\n\n当前学员信息系统内的信息条数为：%d\n\n\n",k);
	printf( "请按任意键结束..." );
	char ch1= getch();
	system("cls");
	showChoice();
	

}
void showMenu2(){  // 查询学员信息
	system("cls");
	printf("你选择了◤查询学员信息◥操作！\n\n");
	printf("◆1.学号\t◆2.姓名\t◆3.历史成绩\n");
	printf("◆4.地理成绩\t◆5.计算机成绩\t◆6.平均成绩\t◆0.返回主菜单\n\n");
	printf("选择你要查询的参数项目:");
	int y=0;
	kg = 0;
	do{
		isRight2= 0;
		int ch ;
		scanf("%d",&ch);
		fflush(stdin);
		switch(ch){
			case 1:
				printf("你选择了¤学号¤作为你的查询参数.\n");
				do{
					isRight1= 0;
					printf("\n请输入你要查询的学号：");
					int no1;
					scanf("%d",&no1);
					fflush(stdin);
					system("cls");
				for(i =0; i < LENGTH; i ++){
					if( no[i]== no1){
						printf("▼查询结果如下：\n\n\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
						printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
						kg = 1;
						y ++;
						printf("符合你的查询条件的信息共有:%d条\n",y);
						isRight1= 0;
					//	isRight2= 0;
					}
				}
				showjieguo();

			}while(isRight1);
				printf("请按任意键继续...");
				char c1 = getch();
				showMenu2();
				break;
			case 2:
				printf("你选择了¤姓名¤作为你的查询参数.\n");
				do{
					isRight1= 0;
					printf("\n请输入你要查询的姓名：");
					char name1[SIZE];
					scanf("%s",&name1);
					fflush(stdin);
					system("cls");
					do{
						isRight = 0;
						printf("▼查询结果如下：\n\n\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
						
				for(i =0; i < LENGTH; i ++){
					if(stricmp(name[i],name1)== 0){

						printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
						kg = 1;
						y ++ ;
					}
				}
					isRight1 = 0;
					isRight= 0;
					printf("符合你的查询条件的信息共有:%d条\n",y);
				}while(isRight);
				showjieguo();

				}while (isRight1);
					printf("按任意键继续...\n");
					 getch();
					showMenu2();
				break;
			case  3:
				printf("你选择了¤历史成绩¤作为你的查询参数.\n");
				do{
					isRight1=0;
					printf("\n请输入你要查询的历史成绩：");
					float hs1;
					scanf("%f",&hs1);
					fflush(stdin);
					system("cls");
					do{
						isRight=0;
					printf("▼查询结果如下：\n\n\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
				for(i =0; i < LENGTH; i ++){
				if(hs[i] == hs1){
					
					printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
					kg =1;
					y ++;
			}
			}
					isRight1 = 0;
					isRight= 0;
					printf("符合你的查询条件的信息共有:%d条\n",y);
				}while(isRight);
				showjieguo();

		}while(isRight1);
				printf("按任意键继续...\n");
				getch();
				showMenu2();
				break;
			case  4:
				printf("你选择了¤地理成绩¤作为你的查询参数.\n");
				do{
					isRight1=0;
					printf("\n请输入你要查询的地理成绩：");
					float gs1;
					scanf("%f",&gs1);
					fflush(stdin);
					system("cls");
					do{
						isRight = 0;
						printf("▼查询结果如下：\n\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
					for(i =0; i < LENGTH; i ++){
						if(gs[i]== gs1){
							printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
							kg=1;
							y ++ ;
						}
					}
					isRight1 = 0;
					isRight= 0;
					printf("符合你的查询条件的信息共有:%d条\n",y);
				}while(isRight);
				showjieguo();

				}while (isRight1);
					printf("\n\n按任意键继续...\n");
					char h3  = getch();
					showMenu2();
				break;
			case  5:
				printf("你选择了¤计算机成绩¤作为你的查询参数.\n");
				do{
					isRight1=0;
					printf("\n请输入你要查询的计算机成绩：");
					float cs1;
					scanf("%f",&cs1);
					fflush(stdin);
					do{
						isRight = 0;
					system("cls");	
					printf("▼查询结果如下：\n\n\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");			
				for(i =0; i < LENGTH; i ++){
					if(cs[i] == cs1){
					printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
					kg = 1;
					y  ++ ;
					}
				}
					isRight1 = 0;
					isRight= 0;
					printf("符合你的查询条件的信息共有:%d条\n",y);
				}while(isRight);
				showjieguo();

				}while (isRight1);
				printf("按任意键继续...\n");
				char ch2  = getch();
				 showMenu2();
				break;
			case  6:
				printf("你选择了¤平均成绩¤作为你的查询参数.\n");

			do{
					isRight1=0;
					printf("\n请输入你要查询的平均成绩：");
					float av1;
				char  str1[6];
				char  str2[6];
					scanf("%f",&av1);
					fflush(stdin);  
					int sig ;
					if( av1 < 10){ // 判断输入的平均成绩小于10，系统中的平均成绩就取两位数
						 sig  =  2;
				}else{
						 sig  =  3;//判断输入的平均成绩大于10，系统中的平均成绩就取三位数
				}
					
					system("cls");
					do{
						isRight = 0;
				printf("▼查询结果如下：\n\n\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
			for(i =0; i < LENGTH; i ++){
				gcvt(av1,sig,str1);
				gcvt(av[i],sig,str2);
				if(stricmp(str1 , str2) == 0){
				
					printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
					kg = 1;
				    y ++ ;
				}
			}
					isRight1 = 0;
					isRight= 0;
					printf("符合你的查询条件的信息共有:%d条\n",y);
				}while(isRight);
				showjieguo();

		}while (isRight1);
			printf("按任意键继续...\n");
			 char h8  = getch();
			showMenu2();
			break;
			case 0:
					showChoice();
				break;
	default:
	printf("你输入的参数有误，请重新输入：\n");	
	isRight2= 1;
	break;
		}
		}while(isRight2);
	
		
}

void showMenu3(){   //修改
	system("cls");
	showStudent();
	int isRight;
	int n;  //输入修改学员的学号
	int t = 0; 
	int p;// 声明标识符
	int q ;
	printf("\n\n请输入修改学员的学号：");
	scanf("%d",&n);
	fflush(stdin);
	do{
		isRight= 0;
		for( i = 0; i < LENGTH ; i ++){
			if( no[i] == n  ){	
			t = 1;
			p = i;
			printf("\n\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
			printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
			isRight= 0;	
			break;
			}
			}
		if(t == 0){
		printf("你输入的学号不存在，请重新输入（按0返回主菜单）：\n");
		scanf("%d",&n);
		if( n ==0 ){
			showChoice();
		}
		
			isRight= 1;
		}
		
	}while(isRight);
	printf("◆1.学号\t◆2.姓名\t◆3.历史成绩\n");
	printf("◆4.地理成绩\t◆5.计算机成绩\t◆0.返回主菜单\n\n");
	printf("选择你要修改的参数项目:");
	int num, no3 ;
	scanf("%d",&num);  //接受要修改的项目
	fflush(stdin);
	switch(num){
		case 1:
				printf("\n请输入要修改的学号：");
				scanf("%d",&no3);
			do{ 
					isRight = 0;
					for( i = 0; i< k;  i ++){      //判断学号是否存在
					if(no3 == no[i]){
						printf("你输入的学号已存在！\n请重新输入");
						scanf("%d",&no3);
						isRight = 1;
					}
				}
			
				}while(isRight);
			
				printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
				printf("修改前：%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name[p],hs[p],gs[p],cs[p], av[p]);
				printf("修改后：%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no3,name[p],hs[p],gs[p],cs[p],av[p]);
  			
  				printf("是否确认修改?按y确认，按其他键放弃修改...");
  				char ch2 = getch();
	  			if(ch2 =='y'){
	  				no[p]=no3;
	  				printf("\n修改成功！按任意键继续...\n");
	  				getch();
	
	  				showMenu3();
		
		  		}else{
		  			printf("\n放弃修改！按任意键继续...\n");
		  			int  ch1 = getch();
		 			showMenu3();
		  		}  
  			break;
  		case 2:
  			printf("请输入要修改的姓名：");
  			char name2[SIZE];
  			scanf("%s",&name2);
				printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
				printf("修改前：%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name[p],hs[p],gs[p],cs[p],av[p]);
				printf("修改后：%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name2,hs[p],gs[p],cs[p],av[p]);
  				printf("是否确认修改?按y确认，按其他键放弃修改...");
  				char ch = getch();
	  			if(ch =='y'){
	  				strcpy(name[p],name2);
	  				printf("\n修改成功！按任意键继续...\n");
	  				int ch1 = getch();
	  				 showMenu3();
		  		}else{
		  			printf("\n放弃修改！按任意键继续...\n");
		  			int ch1 = getch();
					showMenu3();
		  		}
		  		break;
		case 3 :
  			float hs2;
  		do{
  			
  			isRight=0;
  			printf("\n\n请输入要修改的历史成绩：");
  			scanf("%f",&hs2);
  			fflush(stdin);
  			if( hs2 >= 0 && hs2 <= 100){
  				printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
				printf("修改前：%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name[p],hs[p],gs[p],cs[p],av[p]);
				printf("修改后：%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name[p],hs2,gs[p],cs[p],(hs2+gs[p]+cs[p])/3);
		  		isRight=0;
		  	}else{
		  		printf("输入成绩有误！（0-100）\n");
		  		isRight=1;
		  	}
  		}while(isRight);
  	
  				printf("是否确认修改?按y确认，按其他键放弃修改...");
  				char ch3 = getch();
	  			if(ch3 =='y'){
	  				hs[p]=hs2;
	  				printf("\n修改成功！按任意键继续...\n");
	  				char  ch1 = getch();
	  				showMenu3();
		  		}else{
		  			printf("\n放弃修改！按任意键继续...\n");
		  			char ch1 = getch();
						showMenu3();
		  		}  
		  		break;
		case 4:
  			float gs2;
			do{
				isRight = 0;
			printf("请输入要修改的地理成绩：");	
			scanf("%f",&gs2);
			if( gs2 >= 0 && gs2 <= 100){
				printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
				printf("修改前：%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name[p],hs[p],gs[p],cs[p],av[p]);
				printf("修改后：%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name[p],hs[p],gs2,cs[p],(hs[p]+gs2+cs[p])/3);
				isRight = 0;
			}else {
				printf("你输入的地理成绩有误（0-100）\n");	
				isRight = 1;
			}			
			}while(isRight);
  				printf("是否确认修改?按y确认，按其他键放弃修改...");
  				char ch4 = getch();
	  			if(ch4 =='y'){
	  				gs[p]=gs2;
	  				printf("\n修改成功！按任意键继续...\n");
	  				int ch1 = getch();
	  				showMenu3();
		  		}else{
		  			printf("\n放弃修改！按任意键继续...\n");
		  			char ch1 = getch();
		  			showMenu3();
		  		}
		  		break;
		case 5:
		  	float cs2;
		do{
			isRight = 0;
		  	printf("请输入要修改的计算机成绩：");
		  	scanf("%f",&cs2);
			if(cs2 >= 0 && cs2 <= 100){
				printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
				printf("修改前：%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name[p],hs[p],gs[p],cs[p],av[p]);
				printf("修改后：%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name[p],hs[p],gs[p],cs2,(hs[p]+gs[p]+cs2)/3);
				isRight = 0;
			}else{
				printf("你输入的计算机成绩有误（0-100）\n");
				isRight = 1;
			}
		}while(isRight);
  				printf("是否确认修改?按y确认，按其他键放弃修改...");
  				char ch5 = getch();
	  			if(ch5 =='y'){
	  				cs[p]=cs2;
	  				printf("\n修改成功！按任意键继续...\n");
	  				int ch1 = getch();
	  				showMenu3();
		  		}else{
		  			printf("\n放弃修改！按任意键继续...\n");
		  			char ch1 = getch();
		  			showMenu3();
		  		}
		  		break;
		case 0:
		showChoice();
		break;
		default:
		printf("\n输入项目有误，按任意键继续...\n");
		char ch6 = getch();
		showMenu3();
		break;
}
}
void showMenu4(){   
	system("cls");
	printf("你选择了◤统计学员信息◥操作！\n\n");
	printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
	float sum1=0,sum2= 0,sum3 = 0 ;
	 j = 0;
	int hsjige = 0;
	int gsjige = 0;
	int csjige = 0;
	int avjige = 0;
	for( i = 0; i < LENGTH;i ++){
				if (av[i] >= 60){
			 	avjige ++ ;
			} 
			if (hs[i] >= 60){
			 	hsjige ++ ;
			} 
			if (gs[i] >= 60){
		 		gsjige ++ ;
			} 
			if (cs[i] >= 60){
		 		csjige ++ ;
			} 
			if(no[i] != -1){
			
				sum1 += hs[i];
				sum2 += gs[i];
				sum3 += cs[i];
				j ++;
			}
			if(no[i] != -1){
				printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[i],name[i],hs[i],gs[i],cs[i],(hs[i]+gs[i]+cs[i])/3);
			}
		}
		printf("----------------------------------------------------------\n");
		printf("平均成绩\t\t");
		printf("%3.1f\t%3.1f\t%3.1f\t%3.1f\n\n",sum1/j,sum2/j,sum3/j,(sum1+sum2+sum3)/j/3);
		printf("不及格人数\t\t%d\t%d\t%d\t%d",j - hsjige,j -gsjige, j - csjige,j -avjige );
		printf("\n不及格人数率\t\t%3.1f%%\t%3.1f%%\t%3.1f%%\t%3.1f%%\n\n",(((float)(j - hsjige)/j) * 100),(((float)(j - gsjige)/j) * 100),(((float)(j - csjige)/j) * 100),(float)(j-avjige)/j*100);
		printf("及格人数\t\t%d\t%d\t%d\t%d",hsjige,gsjige,csjige,avjige);
		fflush(stdin);
		printf("\n及格人数率\t\t%3.1f%%\t%3.1f%%\t%3.1f%%\t%3.1f%%\n",((float)hsjige/j) *100,((float)gsjige/j) *100,((float)csjige/j) *100 ,((float)avjige/(float)j)*100);
		printf("\n请按任意键继续...");
	    char ch1 = getch();
	   system("cls");
	   		//历史,地理,计算机,平均分成绩及格人数
	int his,geo,com,avg;
	his = hsjige;
	geo = gsjige;
	com = csjige;
	avg = avjige;
	//总人数
	int totalCount = j;
	
	char str[3];
	/*判断当前绘制的坐标点i的值是否包含了各科及格/不及格率*/
	for(int i = 100 ; i > 0 ; i -= 5){
		//第一行输入百分号
		if(i == 100){
			printf(" %%");
		}else{
			//数字+100，再取后两位,从而让单个数字显示为0x,比如5会显示成05
			itoa(i + 100 , str , 10);
			str[0] = str[1];
			str[1] = str[2];
			str[2] = '\0';
			printf("%s" , str);
		}
		printf("┃\t");

		//历史不及格
		if((100 - his / (float)totalCount * 100) >= i ){
			printf("■  ");
		}else{
			printf("    ");
		}
		//历史及格
		if(his / (float)totalCount * 100 >= i ){
			printf("□  ");
		}else{
			printf("    ");
		}
		printf("\t");
		//地理不及格
		if((100 - geo / (float)totalCount * 100) >= i ){
			printf("■  ");
		}else{
			printf("    ");
		}
		//地理及格
		if(geo / (float)totalCount * 100 >= i ){
			printf("□  ");
		}else{
			printf("    ");
		}
		printf("\t");
		//计算机不及格
		if((100 - com / (float)totalCount * 100) >= i ){
			printf("■  ");
		}else{
			printf("    ");
		}
		//计算机及格
		if(com / (float)totalCount * 100 >= i ){
			printf("□  ");
		}else{
			printf("    ");
		}
		printf("\t");
		//平均分不及格
		if((100 - avg / (float)totalCount * 100) >= i ){
			printf("■  ");
		}else{
			printf("    ");
		}
		//平均分及格
		if(avg / (float)totalCount * 100 >= i ){
			printf("□  ");
		}else{
			printf("    ");
		}
		puts("");
	}

	puts("━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━");
	puts("\t历史\t\t地理\t\t计算机\t\t平均分");
	puts("\n\t\t■:不及格\t□:及格");
	printf("\n请按任意键继续...");
	   	char ch3 = getch();
	   	showChoice();
	   	
}
void showMenu5(){    //增加学员
	system("cls");
	showStudent();
	showzengjia();
}
void showMenu6(){    //删除学员
	system("cls");
	showStudent();
	int no5 ;
	int v= 0;
	int h;
	int isRight;
		printf("\n请输入你要删除学员的学号：");
		scanf("%d",&no5);
		fflush(stdin);
		do{
			isRight = 0;
		for(i = 0; i < LENGTH ; i ++){
			if(no5 == no[i] ){
				printf("\n\n\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
				printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
				v =1;
				h = i;
				isRight = 0;
			}
		}if( v == 0){
				printf("你输入的学号不存在, 按0返回主菜单，其他键继续...\n");
				char ch6 = getch();
				if(ch6 == '0'){
					showChoice();
			}else{
				showMenu6();
			}
			}
	}while(	isRight);
	printf("\n\n你是否删除该学员信息？（y/n）:");
	char ch7= getch();
	if(ch7 =='y'){
		no[h] = -1;
		strcpy(name[h] , "");
		hs[h] = gs[h] = cs[ h] = -1;
		printf("\n\n删除成功！按0返回主菜单，按其它键继续...");
		char ch8 = getch();
		if(ch8 == '0'){
			showChoice();
		}else{
			showMenu6();
		}
		}else if(ch7 =='n'){
			printf("\n\n放弃删除！按0返回主菜单，按其它键继续...");
			char ch8 = getch();
			if(ch8== '0'){
				showChoice();
			}else{
			showMenu6();
		}
		}else{
		showChoice();
		}
}




void showMenu7(){   //优化
	showchushi();
	system("cls");
	printf("正在初始化系统：");
	int i = 1;
	while( i ++){
		Sleep(200);
		if(i % 2){
			printf("★");
		}else{
			printf("☆");
		}
		if( i == 10){
			system("cls");
			 showChoice();
		}
}
}

void showjiaohuan(){
	
		for(i = 0; i < LENGTH ;i ++){
		if( no[i] != -1){
			printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
		}
	}
		printf("------------------------------------------------------------------\n");
		printf("\n当前学员信息系统内的信息条数为：%d\n",k);
		printf("\n\n请按任意键继续...");
	    char ch1 = getch();
	   	showMenu8();
}  
void swap(char *a, char *b){  //名字交换
	char tempName[6];
	strcpy(tempName,a);
	strcpy(a,b);
	strcpy(b,tempName);
	
}

void swap(int *a, int *b){ //  学号
	int temp = *a;
	*a = *b;
	*b = temp;
}
void swap(float *a, float *b){ // 成绩交换
	float temp = *a;
	*a = *b;
	*b = temp;
}
void swapBy1(int arr[]){            // 学号降序
	for(int i = 0 ; i < LENGTH - 1; i ++){
		for(int j = 0 ; j < LENGTH - 1 - i; j ++){
			if(arr[j] < arr[j + 1]){
				swap(&no[j], &no[j+1]);
				swap(&hs[j], &hs[j+1]);
				swap(name[j],name[j+1]);
				swap(&gs[j], &gs[j+1]);
				swap(&cs[j], &cs[j+1]);
				swap(&av[j], &av[j+1]);
			}
		}
	}
}
void swapBy2(int arr[]){            //学号sheng序
	for(int i = 0 ; i < LENGTH - 1; i ++){
		for(int j = 0 ; j < LENGTH - 1 - i; j ++){
			if(arr[j] > arr[j + 1]){
				swap(&no[j], &no[j+1]);
				swap(&hs[j], &hs[j+1]);
				swap(name[j],name[j+1]);
				swap(&gs[j], &gs[j+1]);
				swap(&cs[j], &cs[j+1]);
				swap(&av[j], &av[j+1]);
			}
		}
	}
}
void swapBy3(float arr[]){         // 成绩升序
	for(int i = 0 ; i < LENGTH - 1; i ++){
		for(int j = 0 ; j < LENGTH - 1 - i; j ++){
			if(arr[j] > arr[j + 1]){
				swap(&no[j], &no[j+1]);
				swap(&hs[j], &hs[j+1]);
				swap(name[j],name[j+1]);
				swap(&gs[j], &gs[j+1]);
				swap(&cs[j], &cs[j+1]);
				swap(&av[j], &av[j+1]);
			}
		}
	}
}

void swapBy4(float arr[]){            //成绩降序
	for(int i = 0 ; i < LENGTH - 1; i ++){
		for(int j = 0 ; j < LENGTH - 1 - i; j ++){
			if(arr[j] < arr[j + 1]){
				swap(&no[j], &no[j+1]);
				swap(&hs[j], &hs[j+1]);
				swap(name[j],name[j+1]);
				swap(&gs[j], &gs[j+1]);
				swap(&cs[j], &cs[j+1]);
				swap(&av[j], &av[j+1]);
			}
		}
	}
}
void swapBy5(char arr[]){            //名字升序
	for(int i = 0 ; i < LENGTH - 1; i ++){
		for(int j = 0 ; j < LENGTH - 1 - i; j ++){
			if((stricmp(name[j], name[j + 1])) > 0){
				swap(&no[j], &no[j+1]);
				swap(&hs[j], &hs[j+1]);
				swap(name[j],name[j+1]);
				swap(&gs[j], &gs[j+1]);
				swap(&cs[j], &cs[j+1]);
				swap(&av[j], &av[j+1]);
			}
		}
	}
}
void swapBy6(char arr[]){            //名字降序
	for(int i = 0 ; i < LENGTH - 1; i ++){
		for(int j = 0 ; j < LENGTH - 1 - i; j ++){
			if((stricmp(name[j], name[j + 1])) < 0){
				swap(&no[j], &no[j+1]);
				swap(&hs[j], &hs[j+1]);
				swap(name[j],name[j+1]);
				swap(&gs[j], &gs[j+1]);
				swap(&cs[j], &cs[j+1]);
				swap(&av[j], &av[j+1]);
			}
		}
	}
}
void showMenu8(){     //排序
	system("cls");
	printf("你选择了¤学员信息排序¤操作!\n\n");
	showStudent();
	printf("\n\n◆1.学号\t◆2.姓名\t◆3.历史成绩\n");
	printf("◆4.地理成绩\t◆5.计算机成绩\t◆6.平均成绩\t◆0.返回主菜单\n\n");
	printf("\n选择你要排列的字段:");
	int isRight;
	char ch3 = getch();
	do{
		isRight = 0;
		if(ch3 != '1'&& ch3 != '2' && ch3 != '3' && ch3 != '4' && ch3 != '5' && ch3 !='6' && ch3 != '0'){
		printf("你输入的选项有误，请重新输入！\n");
		printf("选择你要排列的字段:");
		isRight= 1;
		 ch3 = getch();
		
	}else{
		isRight= 0;
	}
	}while (isRight);

	if(ch3== '0'){	
		 showChoice();
		}
	char ch4;
	do{
			isRight = 0;
		printf("\n请选择采用升序（u）还是降序（d）:");
		 ch4 = getch();
		fflush(stdin);
		if(  ch4 != 'u' && ch4 != 'd'){
			printf("你输入的选项有误，请重新输入！");
			isRight =1 ;
	}else{
		isRight = 0;
	}
	}while(isRight);
	if(ch3== '1' && ch4 =='d' ){ //学号降序
		system("cls");
		swapBy1(no);
		printf("你采用◆按学号降序排列◆结果如下:\n\n");
		printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
		showjiaohuan();
}
	if(ch3== '1' && ch4 =='u' ){ //  学号升序
		system("cls");
		swapBy2(no);
		printf("你采用◇按学号升序排列◇结果如下:\n\n");
		printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
		showjiaohuan();
}
	if(ch3== '2' && ch4 == 'u'){  // 名字升序
		system("cls");
		swapBy5(name[SIZE]);
		printf("你采用◇按学号升序排列◇结果如下:\n\n");
		printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
		showjiaohuan();
	}
	if(ch3== '2' && ch4 == 'd'){  // 名字降序
		system("cls");
		swapBy6(name[SIZE]);
		printf("你采用◇按学号升序排列◇结果如下:\n\n");
		printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
		showjiaohuan();
	}
		if(ch3== '3' && ch4 == 'u' ){    //排历史成绩升序
			system("cls");
			swapBy3(hs);
			printf("你采用◆按历史成绩升序排序◆结果如下：\n\n");
			printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
			showjiaohuan();
}
	if(ch3== '3' && ch4 =='d' ){    //排历史成绩降序
		system("cls");
		swapBy4(hs);
		printf("你采用◆按历史成绩降序排序◆结果如下：\n\n");
		printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
		showjiaohuan();
}
if(ch3== '4' && ch4 =='u' ){    //排地理成绩升序
		system("cls");
		swapBy3(gs);
		printf("你采用◆按地理成绩升序排序◆结果如下：\n\n");
		printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
		showjiaohuan();
	}
	if(ch3== '4' && ch4 =='d' ){    //排地理成绩降序
		system("cls");
		swapBy4(gs);
		printf("你采用◆按地理成绩升序排序◆结果如下：\n\n");
		printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
		showjiaohuan();
}
	if(ch3== '5' && ch4 =='u' ){    //排计算机成绩升序
		system("cls");
		swapBy3(cs);
		printf("你采用◆按计算机成绩升序排序◆结果如下：\n\n");
		printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
		showjiaohuan();
}
	if(ch3== '5' && ch4 =='d' ){    //排计算机成绩降序
		system("cls");
		swapBy4(cs);
		printf("你采用◆按计算机降序排序◆结果如下：\n\n");
		printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
		showjiaohuan();
}

if(ch3== '6' && ch4 =='d' ){    //排平均成绩降序
		system("cls");
		swapBy4(av);
		printf("你采用◆按平均成绩降序排序◆结果如下：\n\n");
		printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
		showjiaohuan();
}
	if(ch3== '6' && ch4 =='u' ){    //排平均成绩升序
		system("cls");
		swapBy3(av);
		printf("你采用◆按平均成绩升序排序◆结果如下：\n\n");
		printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
		showjiaohuan();

}
		
}
void xianshi(){
	
}

void showStudent(){       // 显示学生         
 	int isRight1;
 	int isRight2;
 	int isRight3;
 	int  f = 0;
 	for(i= 0 ; i < LENGTH;i ++){
	 	if(no[i] != -1){
	 		f ++; // 信息条数
	 	}
 	} 
 	int g =1;  //显示当前页
 	k=0;
	 		system("cls");
		 	showMe();
			printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
		for(  i=0 ; i < LENGTH ; i ++){
			av[i] = (hs[i] +gs[i] +cs[i])/3 ;
			if(no[i] != -1){
				k++;  // 计数有多少条学员信息
				printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
				if( k%ROW == 0 ||k ==f ){  //只让每页显示ROW个学员信息
					printf("-----------------------------------------------------------\n");
					if(f>ROW){
						printf("\t\t上一页(w)  当前第%d/%d页  下一页（d）",g,(int)ceil((double)f/ROW));
						}else{
						printf("\t\t\t当前只有一页");
					
						}
					do{
						isRight2= 0;
						char wd = getch();
						if(wd=='d'&& g !=  (int)ceil((double)f/ROW) ){
							g ++;
							isRight2= 0;
							system("cls");
			 				showMe();
							printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
						}
						 if(wd=='d' && g == (int)ceil((double)f/ROW)){
							isRight2= 0;
						
						}
						if(wd=='w'){
							if(g > 1){
								g --;  // g =2
								k =(g-1)*ROW;
								i =k-1;
								system("cls");
				 				showMe();
								printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
								isRight2=0;
							}else{
								isRight2= 1;
							}
						}
							if(wd !='w' && wd !='d'){
								isRight2= 1;
							}
					}while(isRight2);
				}
			}
		}



}


void showzengjia(){   //增加学员
	int index = -1;
	for(i = 0;i < LENGTH; i ++){
		if(no[i] < 0){
			//找到了
			index = i;
			break;
		}
	}
	if(no[i] > 0){   //如果没有,提示
	printf("没有空位！\n");
	}
	//如果有空位,追加
	int no1 ;
	while(index >= 0){
	int kk;
		printf("\n\n请输入添加学员的学号：");
		scanf("%d",&no1);
		fflush(stdin);
	do{	
			kk =0;
		for(i= 0; i <LENGTH; i ++){
			if(no[i]==no1 ){
				printf("输入的学号已存在，请重新输入（输入0返回主菜单）:");
				scanf("%d",&no1);
				fflush(stdin);
				if( no1 == 0){
					showChoice();
				}
					kk = 1;
			}
		}
		if(no1 == 0){
			printf("不能输入学号为0的学号，请重新输入（输入0返回主菜单）:");
			scanf("%d",&no1);
			fflush(stdin);
			if( no1 == 0){
				showChoice();
			}
			kk = 1;
		}
	}while(kk);
	
		
		
			no[index]= no1;
			printf("请输入添加学员的姓名：");
			scanf("%s",&name1);
			fflush(stdin);
			strcpy(name[index],name1);
			printf("请输入添加学员的历史成绩：");
			float hs1;
			scanf("%f",&hs1);
			fflush(stdin);
		
		do{ 
			kk =0;
			if(hs1 >= 0 && hs1 <= 100){
				hs[index]= hs1; // 历史
				kk = 0;
			}else{
				printf("你输入的历史成绩有误（0-100），请重新输入：");
				scanf("%f",&hs1);
				fflush(stdin);
				kk = 1;
			}
			}while(kk);
			printf("请输入添加学员的地理成绩：");
			float gs1;  // 地理
			scanf("%f",&gs1);
			fflush(stdin);
		do{
			kk = 0;
			if(gs1 <= 100 && gs1 >= 0){
				gs[index]=gs1;
				kk = 0 ;
				}else {
				printf("你输入的地理成绩有误（0-100），请重新输入：");
				scanf("%f",&gs1);
				fflush(stdin);
				kk = 1;
				}
				}while(kk);
			printf("请输入添加学员的计算机成绩：");
			float cs1;
			scanf("%f",&cs1);
			fflush(stdin);
		do{
			kk = 0;
			if(cs1 <= 100 && cs1 >= 0){
				cs[index]=cs1;
				kk =0;
				}else {
					printf("你输入的计算机成绩有误（0-100），请重新输入：");
					scanf("%f",&cs1);
					fflush(stdin);	
					kk = 1;		
				}
			}while(kk);
			float av1 = (hs1 + gs1 + cs1)/3;
			av[index]=av1;
			printf("\n添加学员的信息为：\n");
			printf("\t学号\t姓名\t历史\t地理\t计算机\t平均成绩\n");
			printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f",no[index],name[index],hs[index],gs[index],cs[index],av[index]);
			printf("\n\n添加成功，继续添加按y,按其他键返回：\n");
		 char ch = getch();
		 if(ch == 'y'){
		 		 system("cls");
		 		 showStudent();
    			showzengjia();
			}else{
				showChoice();
			}
	}
}
void showMe(){
	switch(choice){
 		case '1':
 			printf("你选择了 ◤显示学员信息◥操作：\n\n");
 			break;
 		case '2':
 			printf("你选择了 ◤查询学员信息◥操作：\n\n");
 			break;
 		case '3':
 			printf("你选择了 ◤修改学员信息◥操作：\n\n");
 			break;
 		case '4':
 			printf("你选择了 ◤统计学员信息◥操作：\n\n");
 			break;
 		case '5':
 			printf("你选择了 ◤增加学员信息◥操作：\n\n");
 			break;
 		case '6':
 			printf("你选择了 ◤删除学员信息◥操作：\n\n");
 			break;
 		case '8':
 			printf("你选择了 ◤学员信息排序◥操作：\n\n");
 			break;
 	}
}   

void showjieguo(){
		if( kg == 0){
				system("cls");
					printf("▼查询结果如下：\n\n没有找到你要查询的信息，重新输入参数按任意键，按0返回主菜单:");
					char c = getch();
					fflush(stdin);
					if(c  == '0'){
						showChoice();
				}else{
					isRight1 = 1;
				}
			}
}

