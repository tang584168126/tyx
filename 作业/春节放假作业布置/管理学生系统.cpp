/**
	���ܣ�ѧ����Ϣ����ϵͳ
	���ߣ�wanhuajun
	ʱ�䣺2012-3-20
	*/
#include <stdio.h>
#include <math.h>
#include <windows.h>
#include <stdlib.h>
#include <conio.h>
#include <string.h>
#define LENGTH 20
#define  ROW  5 // ÿҳ��ʾ������
#define SIZE 6 //��������
	int  no[LENGTH], i ,j;
	float hs[LENGTH],gs[LENGTH],cs[LENGTH],av[LENGTH];
	char name[LENGTH][SIZE];
	char name1[SIZE];
	int k; // ������Ϣ�ļ�����
	int f, g ; 
	char choice;//�жϽ���ı�ʾ��
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
		char pwd1[6];  //�����������������
		char name2[5];  // �����û���
		char *name1="admin" ;
	 	while(isRight == 1){
			system("cls");//���﨑�����
			printf( "\t\t���﨑���﨑���﨑���﨑���﨑���﨑���﨑���﨑���﨑���﨑\n\n\n" );
			printf( "\t\t\t��ӭʹ��ѧԱ�ɼ�����ϵͳ\n\n\n" );
			printf( "\t\t\t\t\t\t���ߣ��򻪾�\n\n\n" );
			printf( "\t\t���﨑���﨑���﨑���﨑���﨑���﨑���﨑���﨑���﨑���﨑\n\n" );
			printf( "\t\t* �������¼�û���<admin>:" );
		   	scanf("%s",&name2);;
		   	fflush(stdin);
			printf( "\t\t* ����������<111111>:" );
			for(j = 0;j < 10; j ++){
				char ch = getch();
				if((int)ch ==13){
					pwd1[j]= '\0'; //���
					break;
				}
				if((int)ch !=13){
						pwd1[j] = ch;
						putchar('*');
				}
				
			}
			
			if(name2 != name1 && stricmp(pwd1,pwd ) != 0){
					printf( "\n\t\t* �û�����������󣡰����������..." );
					char ch1= getch();
					continue;
			}else{
				system("cls");
				printf( "���ڳ�ʼ��" );
				i = 1 ;
				while ( i ++){
					Sleep(100);
					if( i % 2 ){
						printf( "��" );
					}else{
						printf( "��" );
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
	printf( "�򨒨��򨒨��򨒨��򨒨��򨒨��򨒨��򨒨��򨒨��򨒨��򨒨��򨒨��򨒨��򨒨���" );
	printf( "�򨒨��򨒨��򨒨��򨒡�\t\t\t\t�򨒨��򨒨��򨒨��򨒡�" );
	printf( "�򨒨���\t\t\t������ѡ��\t\t\t\t�򨒨���\n\n" );
	printf( "\t\t��1����ʾѧԱ��Ϣ\t\t��2����ѯѧԱ��Ϣ\n" );
	printf( "\t\t��3���޸�ѧԱ��Ϣ\t\t��4��ͳ��ѧԱ��Ϣ\n" );
	printf( "\t\t��5������ѧԱ��Ϣ\t\t��6��ɾ��ѧԱ��Ϣ\n" );
	printf( "\t\t��7���Գ�ʼ����Ϣ��\t\t��8��ѧԱ��Ϣ����\n\n" );
	printf( "�򨒨���\t\t\t��0:�˳�ϵͳ\t\t\t\t�򨒨���" );
	printf( "�򨒨��򨒨��򨒨��򨒡�\t\t\t\t�򨒨��򨒨��򨒨��򨒡�" );
	printf( "�򨒨��򨒨��򨒨��򨒨��򨒨��򨒨��򨒨��򨒨��򨒨��򨒨��򨒨��򨒨��򨒨���" );
	printf( "��ѡ���ܣ�" );
	choice = getch();
	int isRight;
	do{
		switch(choice){
			case '1':       //�˵�1  ��ʾ
				showMenu1();  
				break;
			case '2':       //�˵�2   ��ѯ
				showMenu2();
				break;
			case '3':        //�˵�3   �޸�
				showMenu3();
				break;
			case '4':    //�˵�4   ͳ��
				showMenu4();
				break;
			case '5':     //�˵�5   ����
				showMenu5();
				break;
			case '6':        //�˵�6  ɾ��
				showMenu6();
				break;
			case '7':    //�˵�7
				showMenu7();
				break;
			case '8':   //�˵�8  ����
				showMenu8();
				break; 
			case '0':     //�˳�
			 i = 1;
			system("cls");
			printf( "�˳�ϵͳ...\n�����ͷ���Դ" );
			while(i ++){
				Sleep(200);
				if (i % 2){
					printf( "��" );
				}else{
					printf( "��" );
				}
				if (i ==10){
				system("cls");
				printf( "�˳�ϵͳ\n�ͷ���Դ��ɣ��밴���������..." );
				char ch1= getch();
				fflush(stdin);
				exit(0);
				}
			}                       
				break; 
			default:
				printf( "\n\n�������ѡ�����󣬰������������" );
				choice = getch();
				showChoice();
				break;
		}
	}while(isRight);
}
void showMenu1(){   // ��ʾѧԱ��Ϣ
	system("cls");
	showStudent();
	printf("\n\n��ǰѧԱ��Ϣϵͳ�ڵ���Ϣ����Ϊ��%d\n\n\n",k);
	printf( "�밴���������..." );
	char ch1= getch();
	system("cls");
	showChoice();
	

}
void showMenu2(){  // ��ѯѧԱ��Ϣ
	system("cls");
	printf("��ѡ���˨���ѯѧԱ��Ϣ��������\n\n");
	printf("��1.ѧ��\t��2.����\t��3.��ʷ�ɼ�\n");
	printf("��4.����ɼ�\t��5.������ɼ�\t��6.ƽ���ɼ�\t��0.�������˵�\n\n");
	printf("ѡ����Ҫ��ѯ�Ĳ�����Ŀ:");
	int y=0;
	kg = 0;
	do{
		isRight2= 0;
		int ch ;
		scanf("%d",&ch);
		fflush(stdin);
		switch(ch){
			case 1:
				printf("��ѡ���ˡ�ѧ�š���Ϊ��Ĳ�ѯ����.\n");
				do{
					isRight1= 0;
					printf("\n��������Ҫ��ѯ��ѧ�ţ�");
					int no1;
					scanf("%d",&no1);
					fflush(stdin);
					system("cls");
				for(i =0; i < LENGTH; i ++){
					if( no[i]== no1){
						printf("����ѯ������£�\n\n\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
						printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
						kg = 1;
						y ++;
						printf("������Ĳ�ѯ��������Ϣ����:%d��\n",y);
						isRight1= 0;
					//	isRight2= 0;
					}
				}
				showjieguo();

			}while(isRight1);
				printf("�밴���������...");
				char c1 = getch();
				showMenu2();
				break;
			case 2:
				printf("��ѡ���ˡ���������Ϊ��Ĳ�ѯ����.\n");
				do{
					isRight1= 0;
					printf("\n��������Ҫ��ѯ��������");
					char name1[SIZE];
					scanf("%s",&name1);
					fflush(stdin);
					system("cls");
					do{
						isRight = 0;
						printf("����ѯ������£�\n\n\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
						
				for(i =0; i < LENGTH; i ++){
					if(stricmp(name[i],name1)== 0){

						printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
						kg = 1;
						y ++ ;
					}
				}
					isRight1 = 0;
					isRight= 0;
					printf("������Ĳ�ѯ��������Ϣ����:%d��\n",y);
				}while(isRight);
				showjieguo();

				}while (isRight1);
					printf("�����������...\n");
					 getch();
					showMenu2();
				break;
			case  3:
				printf("��ѡ���ˡ���ʷ�ɼ�����Ϊ��Ĳ�ѯ����.\n");
				do{
					isRight1=0;
					printf("\n��������Ҫ��ѯ����ʷ�ɼ���");
					float hs1;
					scanf("%f",&hs1);
					fflush(stdin);
					system("cls");
					do{
						isRight=0;
					printf("����ѯ������£�\n\n\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
				for(i =0; i < LENGTH; i ++){
				if(hs[i] == hs1){
					
					printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
					kg =1;
					y ++;
			}
			}
					isRight1 = 0;
					isRight= 0;
					printf("������Ĳ�ѯ��������Ϣ����:%d��\n",y);
				}while(isRight);
				showjieguo();

		}while(isRight1);
				printf("�����������...\n");
				getch();
				showMenu2();
				break;
			case  4:
				printf("��ѡ���ˡ����ɼ�����Ϊ��Ĳ�ѯ����.\n");
				do{
					isRight1=0;
					printf("\n��������Ҫ��ѯ�ĵ���ɼ���");
					float gs1;
					scanf("%f",&gs1);
					fflush(stdin);
					system("cls");
					do{
						isRight = 0;
						printf("����ѯ������£�\n\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
					for(i =0; i < LENGTH; i ++){
						if(gs[i]== gs1){
							printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
							kg=1;
							y ++ ;
						}
					}
					isRight1 = 0;
					isRight= 0;
					printf("������Ĳ�ѯ��������Ϣ����:%d��\n",y);
				}while(isRight);
				showjieguo();

				}while (isRight1);
					printf("\n\n�����������...\n");
					char h3  = getch();
					showMenu2();
				break;
			case  5:
				printf("��ѡ���ˡ������ɼ�����Ϊ��Ĳ�ѯ����.\n");
				do{
					isRight1=0;
					printf("\n��������Ҫ��ѯ�ļ�����ɼ���");
					float cs1;
					scanf("%f",&cs1);
					fflush(stdin);
					do{
						isRight = 0;
					system("cls");	
					printf("����ѯ������£�\n\n\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");			
				for(i =0; i < LENGTH; i ++){
					if(cs[i] == cs1){
					printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
					kg = 1;
					y  ++ ;
					}
				}
					isRight1 = 0;
					isRight= 0;
					printf("������Ĳ�ѯ��������Ϣ����:%d��\n",y);
				}while(isRight);
				showjieguo();

				}while (isRight1);
				printf("�����������...\n");
				char ch2  = getch();
				 showMenu2();
				break;
			case  6:
				printf("��ѡ���ˡ�ƽ���ɼ�����Ϊ��Ĳ�ѯ����.\n");

			do{
					isRight1=0;
					printf("\n��������Ҫ��ѯ��ƽ���ɼ���");
					float av1;
				char  str1[6];
				char  str2[6];
					scanf("%f",&av1);
					fflush(stdin);  
					int sig ;
					if( av1 < 10){ // �ж������ƽ���ɼ�С��10��ϵͳ�е�ƽ���ɼ���ȡ��λ��
						 sig  =  2;
				}else{
						 sig  =  3;//�ж������ƽ���ɼ�����10��ϵͳ�е�ƽ���ɼ���ȡ��λ��
				}
					
					system("cls");
					do{
						isRight = 0;
				printf("����ѯ������£�\n\n\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
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
					printf("������Ĳ�ѯ��������Ϣ����:%d��\n",y);
				}while(isRight);
				showjieguo();

		}while (isRight1);
			printf("�����������...\n");
			 char h8  = getch();
			showMenu2();
			break;
			case 0:
					showChoice();
				break;
	default:
	printf("������Ĳ����������������룺\n");	
	isRight2= 1;
	break;
		}
		}while(isRight2);
	
		
}

void showMenu3(){   //�޸�
	system("cls");
	showStudent();
	int isRight;
	int n;  //�����޸�ѧԱ��ѧ��
	int t = 0; 
	int p;// ������ʶ��
	int q ;
	printf("\n\n�������޸�ѧԱ��ѧ�ţ�");
	scanf("%d",&n);
	fflush(stdin);
	do{
		isRight= 0;
		for( i = 0; i < LENGTH ; i ++){
			if( no[i] == n  ){	
			t = 1;
			p = i;
			printf("\n\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
			printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
			isRight= 0;	
			break;
			}
			}
		if(t == 0){
		printf("�������ѧ�Ų����ڣ����������루��0�������˵�����\n");
		scanf("%d",&n);
		if( n ==0 ){
			showChoice();
		}
		
			isRight= 1;
		}
		
	}while(isRight);
	printf("��1.ѧ��\t��2.����\t��3.��ʷ�ɼ�\n");
	printf("��4.����ɼ�\t��5.������ɼ�\t��0.�������˵�\n\n");
	printf("ѡ����Ҫ�޸ĵĲ�����Ŀ:");
	int num, no3 ;
	scanf("%d",&num);  //����Ҫ�޸ĵ���Ŀ
	fflush(stdin);
	switch(num){
		case 1:
				printf("\n������Ҫ�޸ĵ�ѧ�ţ�");
				scanf("%d",&no3);
			do{ 
					isRight = 0;
					for( i = 0; i< k;  i ++){      //�ж�ѧ���Ƿ����
					if(no3 == no[i]){
						printf("�������ѧ���Ѵ��ڣ�\n����������");
						scanf("%d",&no3);
						isRight = 1;
					}
				}
			
				}while(isRight);
			
				printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
				printf("�޸�ǰ��%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name[p],hs[p],gs[p],cs[p], av[p]);
				printf("�޸ĺ�%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no3,name[p],hs[p],gs[p],cs[p],av[p]);
  			
  				printf("�Ƿ�ȷ���޸�?��yȷ�ϣ��������������޸�...");
  				char ch2 = getch();
	  			if(ch2 =='y'){
	  				no[p]=no3;
	  				printf("\n�޸ĳɹ��������������...\n");
	  				getch();
	
	  				showMenu3();
		
		  		}else{
		  			printf("\n�����޸ģ������������...\n");
		  			int  ch1 = getch();
		 			showMenu3();
		  		}  
  			break;
  		case 2:
  			printf("������Ҫ�޸ĵ�������");
  			char name2[SIZE];
  			scanf("%s",&name2);
				printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
				printf("�޸�ǰ��%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name[p],hs[p],gs[p],cs[p],av[p]);
				printf("�޸ĺ�%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name2,hs[p],gs[p],cs[p],av[p]);
  				printf("�Ƿ�ȷ���޸�?��yȷ�ϣ��������������޸�...");
  				char ch = getch();
	  			if(ch =='y'){
	  				strcpy(name[p],name2);
	  				printf("\n�޸ĳɹ��������������...\n");
	  				int ch1 = getch();
	  				 showMenu3();
		  		}else{
		  			printf("\n�����޸ģ������������...\n");
		  			int ch1 = getch();
					showMenu3();
		  		}
		  		break;
		case 3 :
  			float hs2;
  		do{
  			
  			isRight=0;
  			printf("\n\n������Ҫ�޸ĵ���ʷ�ɼ���");
  			scanf("%f",&hs2);
  			fflush(stdin);
  			if( hs2 >= 0 && hs2 <= 100){
  				printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
				printf("�޸�ǰ��%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name[p],hs[p],gs[p],cs[p],av[p]);
				printf("�޸ĺ�%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name[p],hs2,gs[p],cs[p],(hs2+gs[p]+cs[p])/3);
		  		isRight=0;
		  	}else{
		  		printf("����ɼ����󣡣�0-100��\n");
		  		isRight=1;
		  	}
  		}while(isRight);
  	
  				printf("�Ƿ�ȷ���޸�?��yȷ�ϣ��������������޸�...");
  				char ch3 = getch();
	  			if(ch3 =='y'){
	  				hs[p]=hs2;
	  				printf("\n�޸ĳɹ��������������...\n");
	  				char  ch1 = getch();
	  				showMenu3();
		  		}else{
		  			printf("\n�����޸ģ������������...\n");
		  			char ch1 = getch();
						showMenu3();
		  		}  
		  		break;
		case 4:
  			float gs2;
			do{
				isRight = 0;
			printf("������Ҫ�޸ĵĵ���ɼ���");	
			scanf("%f",&gs2);
			if( gs2 >= 0 && gs2 <= 100){
				printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
				printf("�޸�ǰ��%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name[p],hs[p],gs[p],cs[p],av[p]);
				printf("�޸ĺ�%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name[p],hs[p],gs2,cs[p],(hs[p]+gs2+cs[p])/3);
				isRight = 0;
			}else {
				printf("������ĵ���ɼ�����0-100��\n");	
				isRight = 1;
			}			
			}while(isRight);
  				printf("�Ƿ�ȷ���޸�?��yȷ�ϣ��������������޸�...");
  				char ch4 = getch();
	  			if(ch4 =='y'){
	  				gs[p]=gs2;
	  				printf("\n�޸ĳɹ��������������...\n");
	  				int ch1 = getch();
	  				showMenu3();
		  		}else{
		  			printf("\n�����޸ģ������������...\n");
		  			char ch1 = getch();
		  			showMenu3();
		  		}
		  		break;
		case 5:
		  	float cs2;
		do{
			isRight = 0;
		  	printf("������Ҫ�޸ĵļ�����ɼ���");
		  	scanf("%f",&cs2);
			if(cs2 >= 0 && cs2 <= 100){
				printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
				printf("�޸�ǰ��%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name[p],hs[p],gs[p],cs[p],av[p]);
				printf("�޸ĺ�%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[p],name[p],hs[p],gs[p],cs2,(hs[p]+gs[p]+cs2)/3);
				isRight = 0;
			}else{
				printf("������ļ�����ɼ�����0-100��\n");
				isRight = 1;
			}
		}while(isRight);
  				printf("�Ƿ�ȷ���޸�?��yȷ�ϣ��������������޸�...");
  				char ch5 = getch();
	  			if(ch5 =='y'){
	  				cs[p]=cs2;
	  				printf("\n�޸ĳɹ��������������...\n");
	  				int ch1 = getch();
	  				showMenu3();
		  		}else{
		  			printf("\n�����޸ģ������������...\n");
		  			char ch1 = getch();
		  			showMenu3();
		  		}
		  		break;
		case 0:
		showChoice();
		break;
		default:
		printf("\n������Ŀ���󣬰����������...\n");
		char ch6 = getch();
		showMenu3();
		break;
}
}
void showMenu4(){   
	system("cls");
	printf("��ѡ���˨�ͳ��ѧԱ��Ϣ��������\n\n");
	printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
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
		printf("ƽ���ɼ�\t\t");
		printf("%3.1f\t%3.1f\t%3.1f\t%3.1f\n\n",sum1/j,sum2/j,sum3/j,(sum1+sum2+sum3)/j/3);
		printf("����������\t\t%d\t%d\t%d\t%d",j - hsjige,j -gsjige, j - csjige,j -avjige );
		printf("\n������������\t\t%3.1f%%\t%3.1f%%\t%3.1f%%\t%3.1f%%\n\n",(((float)(j - hsjige)/j) * 100),(((float)(j - gsjige)/j) * 100),(((float)(j - csjige)/j) * 100),(float)(j-avjige)/j*100);
		printf("��������\t\t%d\t%d\t%d\t%d",hsjige,gsjige,csjige,avjige);
		fflush(stdin);
		printf("\n����������\t\t%3.1f%%\t%3.1f%%\t%3.1f%%\t%3.1f%%\n",((float)hsjige/j) *100,((float)gsjige/j) *100,((float)csjige/j) *100 ,((float)avjige/(float)j)*100);
		printf("\n�밴���������...");
	    char ch1 = getch();
	   system("cls");
	   		//��ʷ,����,�����,ƽ���ֳɼ���������
	int his,geo,com,avg;
	his = hsjige;
	geo = gsjige;
	com = csjige;
	avg = avjige;
	//������
	int totalCount = j;
	
	char str[3];
	/*�жϵ�ǰ���Ƶ������i��ֵ�Ƿ�����˸��Ƽ���/��������*/
	for(int i = 100 ; i > 0 ; i -= 5){
		//��һ������ٷֺ�
		if(i == 100){
			printf(" %%");
		}else{
			//����+100����ȡ����λ,�Ӷ��õ���������ʾΪ0x,����5����ʾ��05
			itoa(i + 100 , str , 10);
			str[0] = str[1];
			str[1] = str[2];
			str[2] = '\0';
			printf("%s" , str);
		}
		printf("��\t");

		//��ʷ������
		if((100 - his / (float)totalCount * 100) >= i ){
			printf("��  ");
		}else{
			printf("    ");
		}
		//��ʷ����
		if(his / (float)totalCount * 100 >= i ){
			printf("��  ");
		}else{
			printf("    ");
		}
		printf("\t");
		//��������
		if((100 - geo / (float)totalCount * 100) >= i ){
			printf("��  ");
		}else{
			printf("    ");
		}
		//������
		if(geo / (float)totalCount * 100 >= i ){
			printf("��  ");
		}else{
			printf("    ");
		}
		printf("\t");
		//�����������
		if((100 - com / (float)totalCount * 100) >= i ){
			printf("��  ");
		}else{
			printf("    ");
		}
		//���������
		if(com / (float)totalCount * 100 >= i ){
			printf("��  ");
		}else{
			printf("    ");
		}
		printf("\t");
		//ƽ���ֲ�����
		if((100 - avg / (float)totalCount * 100) >= i ){
			printf("��  ");
		}else{
			printf("    ");
		}
		//ƽ���ּ���
		if(avg / (float)totalCount * 100 >= i ){
			printf("��  ");
		}else{
			printf("    ");
		}
		puts("");
	}

	puts("����������������������������������������������������������������");
	puts("\t��ʷ\t\t����\t\t�����\t\tƽ����");
	puts("\n\t\t��:������\t��:����");
	printf("\n�밴���������...");
	   	char ch3 = getch();
	   	showChoice();
	   	
}
void showMenu5(){    //����ѧԱ
	system("cls");
	showStudent();
	showzengjia();
}
void showMenu6(){    //ɾ��ѧԱ
	system("cls");
	showStudent();
	int no5 ;
	int v= 0;
	int h;
	int isRight;
		printf("\n��������Ҫɾ��ѧԱ��ѧ�ţ�");
		scanf("%d",&no5);
		fflush(stdin);
		do{
			isRight = 0;
		for(i = 0; i < LENGTH ; i ++){
			if(no5 == no[i] ){
				printf("\n\n\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
				printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
				v =1;
				h = i;
				isRight = 0;
			}
		}if( v == 0){
				printf("�������ѧ�Ų�����, ��0�������˵�������������...\n");
				char ch6 = getch();
				if(ch6 == '0'){
					showChoice();
			}else{
				showMenu6();
			}
			}
	}while(	isRight);
	printf("\n\n���Ƿ�ɾ����ѧԱ��Ϣ����y/n��:");
	char ch7= getch();
	if(ch7 =='y'){
		no[h] = -1;
		strcpy(name[h] , "");
		hs[h] = gs[h] = cs[ h] = -1;
		printf("\n\nɾ���ɹ�����0�������˵���������������...");
		char ch8 = getch();
		if(ch8 == '0'){
			showChoice();
		}else{
			showMenu6();
		}
		}else if(ch7 =='n'){
			printf("\n\n����ɾ������0�������˵���������������...");
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




void showMenu7(){   //�Ż�
	showchushi();
	system("cls");
	printf("���ڳ�ʼ��ϵͳ��");
	int i = 1;
	while( i ++){
		Sleep(200);
		if(i % 2){
			printf("��");
		}else{
			printf("��");
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
		printf("\n��ǰѧԱ��Ϣϵͳ�ڵ���Ϣ����Ϊ��%d\n",k);
		printf("\n\n�밴���������...");
	    char ch1 = getch();
	   	showMenu8();
}  
void swap(char *a, char *b){  //���ֽ���
	char tempName[6];
	strcpy(tempName,a);
	strcpy(a,b);
	strcpy(b,tempName);
	
}

void swap(int *a, int *b){ //  ѧ��
	int temp = *a;
	*a = *b;
	*b = temp;
}
void swap(float *a, float *b){ // �ɼ�����
	float temp = *a;
	*a = *b;
	*b = temp;
}
void swapBy1(int arr[]){            // ѧ�Ž���
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
void swapBy2(int arr[]){            //ѧ��sheng��
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
void swapBy3(float arr[]){         // �ɼ�����
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

void swapBy4(float arr[]){            //�ɼ�����
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
void swapBy5(char arr[]){            //��������
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
void swapBy6(char arr[]){            //���ֽ���
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
void showMenu8(){     //����
	system("cls");
	printf("��ѡ���ˡ�ѧԱ��Ϣ��������!\n\n");
	showStudent();
	printf("\n\n��1.ѧ��\t��2.����\t��3.��ʷ�ɼ�\n");
	printf("��4.����ɼ�\t��5.������ɼ�\t��6.ƽ���ɼ�\t��0.�������˵�\n\n");
	printf("\nѡ����Ҫ���е��ֶ�:");
	int isRight;
	char ch3 = getch();
	do{
		isRight = 0;
		if(ch3 != '1'&& ch3 != '2' && ch3 != '3' && ch3 != '4' && ch3 != '5' && ch3 !='6' && ch3 != '0'){
		printf("�������ѡ���������������룡\n");
		printf("ѡ����Ҫ���е��ֶ�:");
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
		printf("\n��ѡ���������u�����ǽ���d��:");
		 ch4 = getch();
		fflush(stdin);
		if(  ch4 != 'u' && ch4 != 'd'){
			printf("�������ѡ���������������룡");
			isRight =1 ;
	}else{
		isRight = 0;
	}
	}while(isRight);
	if(ch3== '1' && ch4 =='d' ){ //ѧ�Ž���
		system("cls");
		swapBy1(no);
		printf("����á���ѧ�Ž������С��������:\n\n");
		printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
		showjiaohuan();
}
	if(ch3== '1' && ch4 =='u' ){ //  ѧ������
		system("cls");
		swapBy2(no);
		printf("����á�ѧ���������С�������:\n\n");
		printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
		showjiaohuan();
}
	if(ch3== '2' && ch4 == 'u'){  // ��������
		system("cls");
		swapBy5(name[SIZE]);
		printf("����á�ѧ���������С�������:\n\n");
		printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
		showjiaohuan();
	}
	if(ch3== '2' && ch4 == 'd'){  // ���ֽ���
		system("cls");
		swapBy6(name[SIZE]);
		printf("����á�ѧ���������С�������:\n\n");
		printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
		showjiaohuan();
	}
		if(ch3== '3' && ch4 == 'u' ){    //����ʷ�ɼ�����
			system("cls");
			swapBy3(hs);
			printf("����á�����ʷ�ɼ����������������£�\n\n");
			printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
			showjiaohuan();
}
	if(ch3== '3' && ch4 =='d' ){    //����ʷ�ɼ�����
		system("cls");
		swapBy4(hs);
		printf("����á�����ʷ�ɼ����������������£�\n\n");
		printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
		showjiaohuan();
}
if(ch3== '4' && ch4 =='u' ){    //�ŵ���ɼ�����
		system("cls");
		swapBy3(gs);
		printf("����á�������ɼ����������������£�\n\n");
		printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
		showjiaohuan();
	}
	if(ch3== '4' && ch4 =='d' ){    //�ŵ���ɼ�����
		system("cls");
		swapBy4(gs);
		printf("����á�������ɼ����������������£�\n\n");
		printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
		showjiaohuan();
}
	if(ch3== '5' && ch4 =='u' ){    //�ż�����ɼ�����
		system("cls");
		swapBy3(cs);
		printf("����á���������ɼ����������������£�\n\n");
		printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
		showjiaohuan();
}
	if(ch3== '5' && ch4 =='d' ){    //�ż�����ɼ�����
		system("cls");
		swapBy4(cs);
		printf("����á�����������������������£�\n\n");
		printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
		showjiaohuan();
}

if(ch3== '6' && ch4 =='d' ){    //��ƽ���ɼ�����
		system("cls");
		swapBy4(av);
		printf("����á���ƽ���ɼ����������������£�\n\n");
		printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
		showjiaohuan();
}
	if(ch3== '6' && ch4 =='u' ){    //��ƽ���ɼ�����
		system("cls");
		swapBy3(av);
		printf("����á���ƽ���ɼ����������������£�\n\n");
		printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
		showjiaohuan();

}
		
}
void xianshi(){
	
}

void showStudent(){       // ��ʾѧ��         
 	int isRight1;
 	int isRight2;
 	int isRight3;
 	int  f = 0;
 	for(i= 0 ; i < LENGTH;i ++){
	 	if(no[i] != -1){
	 		f ++; // ��Ϣ����
	 	}
 	} 
 	int g =1;  //��ʾ��ǰҳ
 	k=0;
	 		system("cls");
		 	showMe();
			printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
		for(  i=0 ; i < LENGTH ; i ++){
			av[i] = (hs[i] +gs[i] +cs[i])/3 ;
			if(no[i] != -1){
				k++;  // �����ж�����ѧԱ��Ϣ
				printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f\n",no[i],name[i],hs[i],gs[i],cs[i],av[i]);
				if( k%ROW == 0 ||k ==f ){  //ֻ��ÿҳ��ʾROW��ѧԱ��Ϣ
					printf("-----------------------------------------------------------\n");
					if(f>ROW){
						printf("\t\t��һҳ(w)  ��ǰ��%d/%dҳ  ��һҳ��d��",g,(int)ceil((double)f/ROW));
						}else{
						printf("\t\t\t��ǰֻ��һҳ");
					
						}
					do{
						isRight2= 0;
						char wd = getch();
						if(wd=='d'&& g !=  (int)ceil((double)f/ROW) ){
							g ++;
							isRight2= 0;
							system("cls");
			 				showMe();
							printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
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
								printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
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


void showzengjia(){   //����ѧԱ
	int index = -1;
	for(i = 0;i < LENGTH; i ++){
		if(no[i] < 0){
			//�ҵ���
			index = i;
			break;
		}
	}
	if(no[i] > 0){   //���û��,��ʾ
	printf("û�п�λ��\n");
	}
	//����п�λ,׷��
	int no1 ;
	while(index >= 0){
	int kk;
		printf("\n\n���������ѧԱ��ѧ�ţ�");
		scanf("%d",&no1);
		fflush(stdin);
	do{	
			kk =0;
		for(i= 0; i <LENGTH; i ++){
			if(no[i]==no1 ){
				printf("�����ѧ���Ѵ��ڣ����������루����0�������˵���:");
				scanf("%d",&no1);
				fflush(stdin);
				if( no1 == 0){
					showChoice();
				}
					kk = 1;
			}
		}
		if(no1 == 0){
			printf("��������ѧ��Ϊ0��ѧ�ţ����������루����0�������˵���:");
			scanf("%d",&no1);
			fflush(stdin);
			if( no1 == 0){
				showChoice();
			}
			kk = 1;
		}
	}while(kk);
	
		
		
			no[index]= no1;
			printf("���������ѧԱ��������");
			scanf("%s",&name1);
			fflush(stdin);
			strcpy(name[index],name1);
			printf("���������ѧԱ����ʷ�ɼ���");
			float hs1;
			scanf("%f",&hs1);
			fflush(stdin);
		
		do{ 
			kk =0;
			if(hs1 >= 0 && hs1 <= 100){
				hs[index]= hs1; // ��ʷ
				kk = 0;
			}else{
				printf("���������ʷ�ɼ�����0-100�������������룺");
				scanf("%f",&hs1);
				fflush(stdin);
				kk = 1;
			}
			}while(kk);
			printf("���������ѧԱ�ĵ���ɼ���");
			float gs1;  // ����
			scanf("%f",&gs1);
			fflush(stdin);
		do{
			kk = 0;
			if(gs1 <= 100 && gs1 >= 0){
				gs[index]=gs1;
				kk = 0 ;
				}else {
				printf("������ĵ���ɼ�����0-100�������������룺");
				scanf("%f",&gs1);
				fflush(stdin);
				kk = 1;
				}
				}while(kk);
			printf("���������ѧԱ�ļ�����ɼ���");
			float cs1;
			scanf("%f",&cs1);
			fflush(stdin);
		do{
			kk = 0;
			if(cs1 <= 100 && cs1 >= 0){
				cs[index]=cs1;
				kk =0;
				}else {
					printf("������ļ�����ɼ�����0-100�������������룺");
					scanf("%f",&cs1);
					fflush(stdin);	
					kk = 1;		
				}
			}while(kk);
			float av1 = (hs1 + gs1 + cs1)/3;
			av[index]=av1;
			printf("\n���ѧԱ����ϢΪ��\n");
			printf("\tѧ��\t����\t��ʷ\t����\t�����\tƽ���ɼ�\n");
			printf("\t%d\t%s\t%3.1f\t%3.1f\t%3.1f\t%3.1f",no[index],name[index],hs[index],gs[index],cs[index],av[index]);
			printf("\n\n��ӳɹ���������Ӱ�y,�����������أ�\n");
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
 			printf("��ѡ���� ����ʾѧԱ��Ϣ��������\n\n");
 			break;
 		case '2':
 			printf("��ѡ���� ����ѯѧԱ��Ϣ��������\n\n");
 			break;
 		case '3':
 			printf("��ѡ���� ���޸�ѧԱ��Ϣ��������\n\n");
 			break;
 		case '4':
 			printf("��ѡ���� ��ͳ��ѧԱ��Ϣ��������\n\n");
 			break;
 		case '5':
 			printf("��ѡ���� ������ѧԱ��Ϣ��������\n\n");
 			break;
 		case '6':
 			printf("��ѡ���� ��ɾ��ѧԱ��Ϣ��������\n\n");
 			break;
 		case '8':
 			printf("��ѡ���� ��ѧԱ��Ϣ���򨐲�����\n\n");
 			break;
 	}
}   

void showjieguo(){
		if( kg == 0){
				system("cls");
					printf("����ѯ������£�\n\nû���ҵ���Ҫ��ѯ����Ϣ������������������������0�������˵�:");
					char c = getch();
					fflush(stdin);
					if(c  == '0'){
						showChoice();
				}else{
					isRight1 = 1;
				}
			}
}

