package DVD����;

import java.util.*;

public class DvdManager {
	DVD[] dvds = new DVD[300];
	int i = 0;
	
	Calendar c = Calendar.getInstance();
	Scanner sc = new Scanner(System.in);
	
	/**
	 * ��ʼ������
	 */
	public void init(){
		for(i = 0 ; i < dvds.length; i++){
			dvds[i] = new DVD();
		}
		//�ٶ� 3��DVD��Ƭ����
				dvds[0].name = "a";
				dvds[0].dvdState = false;	
				dvds[0].price = 1 ;		
				dvds[0].dvdOutTime = "";
				dvds[0].dvdBackTime = "";
				
				dvds[1].name = "b";
				dvds[1].dvdState = true;	
				dvds[1].price = 1.5 ;		
				dvds[1].dvdOutTime = "2014.5.10";
				dvds[1].dvdBackTime = "";
				
				dvds[2].name = "c";
				dvds[2].dvdState = true;	
				dvds[2].price = 0.8 ;		
				dvds[2].dvdOutTime = "2014.6.1";
				dvds[2].dvdBackTime = "";
	}
	
	/**
	 * ����DVD�ķ���
	 */
	public void addDVD(){
		int index = -1;
		String dvdname ="";
		String isContinue;
		System.out.println("DVD���� > ����DVD");
		do{
			//�ҵ�������Ƭ�±�
			for(i = 0 ; i < dvds.length; i++){
				if(dvds[i].name == null){
					index = i;
					break;
				}
			}
			do{
				int count = 0;
				System.out.print("��������Ҫ���ӵ�DVD��");
				dvdname = sc.next();
				for(i = 0 ; i < dvds.length; i++){
					if(dvdname.equals(dvds[i].name)){
						System.out.println("������Ƭ�ظ���\n");
						break;
					}else{
						count++;
					}
				}
				if(count == dvds.length){
					break;
				}
			}while(true);
			dvds[index].name = dvdname;
			System.out.print("\n������ÿ�����");
			dvds[index].price = sc.nextDouble();
			dvds[index].dvdState = false; 		//����״̬Ϊδ����
			dvds[index].dvdOutTime = "";
			dvds[index].dvdBackTime = "";
			System.out.println("��Ƭ�ɹ���");
			System.out.println("����������(y/n)");
			isContinue = sc.next();
			if(isContinue.equalsIgnoreCase("n")){
				isContinue = sc.nextLine();
				break;
			}
		}while(true);
	}
	
	/**
	 * �鿴DVD�ķ���
	 */
	public void showDVD(){
		System.out.println("DVD���� > �鿴DVD");
		System.out.println("����\t���\t״̬\t����ʱ��");
		for(i = 0 ; i < dvds.length ; i++){
			if(dvds[i].name != null){
				System.out.println(dvds[i]);
			}
		}
	}
	
	/**
	 * ɾ��DVD�ķ���
	 */
	public void delDVD(){
		String delName;
		String isContinue;		//ȷ���Ƿ����ɾ��
		System.out.println("DVD���� > ɾ��DVD");
		do{
			int index = 0;
			System.out.println("��������Ҫɾ����DVD��");
			delName = sc.next();
			for(i = 0 ; i < dvds.length ; i++){
				if(delName.equals(dvds[i].name)){
					if(dvds[i].dvdState == false ){
						dvds[i].name = null;
						dvds[i].price = 0;
						System.out.println("ɾ���ɹ���");
						index++;
						break;
					}else{
						if(dvds[i].dvdOutTime != null){
							System.out.println("�õ�Ƭ�ѳ��⣬����ɾ����");
							index++;
							break;
						}
					}
				}
			}
			if(index != 1){
				System.out.println("û�иõ�Ƭ��");
			}
			System.out.println("����ɾ����(y/n)");
			isContinue = sc.next();
			if(isContinue.equalsIgnoreCase("n")){
				isContinue = sc.nextLine();
				break;
			}
		}while(true);
	}
	
	/**
	 * ���DVD�ķ���
	 */
	public void outDVD(){
		System.out.println("DVD���� > ���DVD");
		String isContinue;
		String outname;
		int year = 0;
		int month = 0;
		int day = 0;
		do{
			int count = 0;
			System.out.println("��������Ҫ�����DVD��");
			outname = sc.next();
			for(i = 0 ; i < dvds.length ; i++){
				if(outname.equals(dvds[i].name)){
					if(dvds[i].dvdState == false){
						System.out.println("����ɹ���");
						year = c.get(Calendar.YEAR);
						month = c.get(Calendar.MONTH) + 1;
						day = c.get(Calendar.DAY_OF_MONTH);
						dvds[i].dvdState = true;
						dvds[i].dvdOutTime = year + "." + month + "." + day;
						count++;
						break;
					}else{
						if(dvds[i].dvdOutTime != null){
							System.out.println("�õ�Ƭ�ѳ��⣬�����ٴγ��⣡");
							count++;
							break;
						}
					}
				}
			}if(count != 1){
				System.out.println("û�иõ�Ƭ��");
			}
			System.out.println("����������(y/n)");
			isContinue = sc.next();
			if(isContinue.equalsIgnoreCase("n")){
				isContinue = sc.nextLine();
				break;
			}
		}while(true);
		
	}
	
	/**
	 * �黹DVD�ķ���
	 */
	public void backDVD(){
		System.out.println("DVD���� > �黹DVD");
		String isContinue;
		String backname;
		do{
			int count = 0;
			System.out.println("��������Ҫ�黹��DVD��");
			backname = sc.next();
			for(i = 0 ; i < dvds.length ; i++){
				if(backname.equals(dvds[i].name)){
					if(dvds[i].dvdState == true){
						System.out.println("�黹�ɹ���");
						dvds[i].dvdState = false;
						count++;
						break;
					}else{
						if(dvds[i].dvdOutTime != null){
							System.out.println("�õ�Ƭ�ѹ黹������Ҫ�ٴι黹��");
							count++;
							break;
						}
					}
				}
			}if(count != 1){
				System.out.println("û�иõ�Ƭ��");
			}
			System.out.println("�����黹��(y/n)");
			isContinue = sc.next();
			if(isContinue.equalsIgnoreCase("n")){
				isContinue = sc.nextLine();
				break;
			}
		}while(true);
		
	}
	
	/**
	 * �޸ĵķ���
	 */
	public void recompose(){
		System.out.println("DVD���� > �޸�");
		String recomposename;
		String isContinue;
		int money = 0;
		do{
			int count = 0;
			System.out.println("��������Ҫ�޸ĵ�DVD��");
			recomposename = sc.next();
			for(i = 0 ; i < dvds.length ; i++){
				if(recomposename.equals(dvds[i].name)){
					System.out.println("�������޸ĵļ۸�");
					dvds[i].price = sc.nextInt();
					System.out.println("�޸ĳɹ���");
					count++;
					break;
				}
			}
			if(count != 1){
				System.out.println("û�иõ�Ƭ��");
			}
			System.out.println("�����޸���(y/n)");
			isContinue = sc.next();
			if(isContinue.equalsIgnoreCase("n")){
				isContinue = sc.nextLine();
				break;
			}
		}while(true);
	}
	
	/**
	 * �˵�
	 */
	public void menu(){
		System.out.println("*****************************************\n");
		System.out.println("��ӭʹ������DVD������\n");
		System.out.println("*****************************************\n");
		System.out.println("1.����DVD");
		System.out.println("2.�鿴DVD");
		System.out.println("3.ɾ��DVD");
		System.out.println("4.���DVD");
		System.out.println("5.�黹DVD");
		System.out.println("6.�޸�DVD");
		System.out.println("0.�˳�");
	}

}
