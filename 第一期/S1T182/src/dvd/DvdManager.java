package dvd;

import java.util.Date;
import java.util.Scanner;

public class DvdManager {

	//Ҫ������� DVD ��Ƭ 300 ��
	DVD[] Dvds = new DVD[300];
	
	/*
	 * ���ݳ�ʼ���ķ���������������ݣ�
	 */
	public void init(){
		
		int i = 0 ;
		
		//ʵ����ÿһ�ŵ�Ƭ
		for(i = 0 ; i < Dvds.length ; i++){
			Dvds[i] = new DVD();
		}
		
		//�ٶ� 3��DVD��Ƭ����
		Dvds[0].dvdName = "��Ƭ1";
		Dvds[0].dvdState = true;	// false��ʾ�ѳ��⣬true��ʾδ����
		Dvds[0].dvdMoney = 5 ;		//���5Ԫ/��
		Dvds[0].dvdOutTime = "";
		Dvds[0].dvdBackTime = "";
		
		Dvds[1].dvdName = "��Ƭ2";
		Dvds[1].dvdState = false;	// false��ʾ�ѳ��⣬true��ʾδ����
		Dvds[1].dvdMoney = 3 ;		//���5Ԫ/��
		Dvds[1].dvdOutTime = "2014-5-10";
		Dvds[1].dvdBackTime = "";
		
		Dvds[2].dvdName = "��Ƭ3";
		Dvds[2].dvdState = false;	// false��ʾ�ѳ��⣬true��ʾδ����
		Dvds[2].dvdMoney = 4 ;		//���5Ԫ/��
		Dvds[2].dvdOutTime = "2014-6-1";
		Dvds[2].dvdBackTime = "";
		
		
	}
	
	/**
	 * ����DVD�ķ���
	 */	
	public void addDVD(){
		Scanner sc = new Scanner(System.in);
		int i = 0 ;
		int index = -1 ;	//������ƬҪ�����λ��
		
		System.out.println("DVD��Ƭ����ϵͳ > ������Ƭ : ");
		
		//Ҫ������Ƭ�����ȼ���µ�Ƭ�ɷ����λ��
		for(i = 0 ; i < Dvds.length ; i++){
			//�жϵ�Ƭ�Ƿ�Ϊ�յ�Ƭ
			if(Dvds[i].dvdName == null){
				//���ĳ��Ƭ����Ϊ�գ���������ƬҪ�����λ��
				index = i;
			}
		}
		
		System.out.println("������ DVD��Ƭ���ƣ�");
		Dvds[index].dvdName = sc.next();
		
		System.out.println("������ DVD��Ƭÿ������ȣ�");
		Dvds[index].dvdMoney = sc.nextDouble();
		
		//��Ƭ���״̬Ϊ��true
		Dvds[index].dvdState = true;
		
		//�����µ�Ƭ�ĳ���͹黹����
		Dvds[index].dvdOutTime = "";
		Dvds[index].dvdBackTime = "";
		
		System.out.println("��Ƭ������ϣ�");
		
		sc.nextLine();
		sc.nextLine();
	}
	
	/**
	 * �鿴DVD�ķ���
	 */	
	public void showDVD(){
		System.out.println("DVD��Ƭ����ϵͳ > �鿴��Ƭ : ");
		
		int i = 0 ;
		
		System.out.println("��Ƭ����  ����״̬  ÿ�����  ����ʱ��");
		
		for(i = 0 ; i < Dvds.length ; i++){
			//�жϵ�Ƭ�Ƿ�Ϊ�յ�Ƭ
			if(Dvds[i].dvdName != null){
				//���ĳ��Ƭ���Ʋ�Ϊ�գ����ӡ�õ�Ƭ����
				System.out.println(Dvds[i]);
			}
		}
	}
	
	/**
	 * ɾ��DVD�ķ���
	 */		
	public void delDVD(){
		System.out.println("DVD��Ƭ����ϵͳ > ɾ����Ƭ : ");
	}
	
	/**
	 * ���DVD�ķ���
	 */	
	public void outDVD(){
		
		String name ;
		Scanner sc = new Scanner(System.in);
		int i = 0 ; 
		
		System.out.println("DVD��Ƭ����ϵͳ > �����Ƭ : ");
		System.out.println("����������Ƭ�����ƣ�");
		
		name = sc.next();
		
		for(i = 0 ; i < Dvds.length ; i++){
			//�жϵ�Ƭ�Ƿ�Ϊ�յ�Ƭ
			if(Dvds[i].dvdName != null){
				
				//���ĳ��Ƭ���Ʋ�Ϊ�գ����жϸõ�Ƭ�����Ƿ����û�Ҫ����ĵ�Ƭ����һ��
				if(Dvds[i].dvdName.equalsIgnoreCase(name)){
					
					//����õ�Ƭ���û�Ҫ����ĵ�Ƭ����һ��
					//�жϸõ�Ƭ�Ƿ�ɳ���
					if(Dvds[i].dvdState){
						Dvds[i].dvdState = false;
						Dvds[i].dvdOutTime = new Date().toLocaleString().substring(0,new Date().toLocaleString().indexOf(" "));
						System.out.println("��ϲ���õ��ɹ������");
						break;
					}
					else{
						System.out.println("�õ�Ƭ�ѳ��⣬�޷������");
						break;
					}
					
				}
			}
		}
		
	}
	
	/**
	 *	�黹DVD�ķ���
	 */	
	public void backDVD(){
		System.out.println("DVD��Ƭ����ϵͳ > �黹��Ƭ : ");
	}
	
	public void menu(){
		System.out.println("��ӭ���� DVD��Ƭ����ϵͳ");
		System.out.println("\t\t 1������DVD��Ƭ");
		System.out.println("\t\t 2���鿴DVD��Ƭ");
		System.out.println("\t\t 3��ɾ��DVD��Ƭ");
		System.out.println("\t\t 4�����DVD��Ƭ");
		System.out.println("\t\t 5���黹DVD��Ƭ");
		System.out.println("\t\t 0���˳�");
	}
	
	/**
	 * �������̿��Ƶķ���
	 */
	public void start(){
		
		int num = 0 ;	//�����û������ѡ���ֵ
		Scanner sc = new Scanner(System.in);
		
		//��ʼ����������
		init();
		
		do{
			//���� ϵͳ �˵�
			menu();
			
			System.out.println("������ѡ���ţ�");
			num = sc.nextInt();
			
			switch(num){
			case 0:
				//�����˳��ķ���
				System.out.println("��ӭ�´μ���ʹ�ñ�ϵͳ��");
				System.exit(0);
				break;
			case 1:
				//����������Ƭ�ķ���
				addDVD();
				break;
			case 2:
				//�鿴DVD��Ƭ
				showDVD();
				break;
			case 3:
				//ɾ��DVD��Ƭ
				delDVD();
				break;
			case 4:
				//���DVD��Ƭ
				outDVD();
				break;
			case 5:
				//�黹DVD��Ƭ
				backDVD();
				break;
			}
		
			sc.nextLine();
			sc.nextLine();
			
		}while(true);
		
	}
}
