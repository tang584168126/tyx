package class10;

import java.util.Scanner;

public class XiaoSystem {
	public static void main(String[] args){
		int num1  ;			//����
		int random = 0  ;			//�����
		String name = "" , pw = "" ;			//ע���û���������
		String name1 = "" , pw1 = "";			//������û���������
		String isOK ;
		int id = 0;
		int i = 0 , j = 0;
		int[] num2 = new int[5];
		boolean isPoint = false ;
		
		Scanner sc = new Scanner(System.in);
		
		do{
			System.out.println("*****************************************\n");
			System.out.println("***********��ӭ���뽱�͸���ϵͳ********\n");
			System.out.println("\t\t1.ע��\n");
			System.out.println("\t\t2.��½\n");
			System.out.println("\t\t3.�齱\n");
			System.out.println("*****************************************\n");
			do{
			System.out.print("��ѡ��˵���");
			
			
			
			if(!sc.hasNextInt()){
				System.out.println("����������������룺");
				sc = new Scanner(System.in);
			}else{
				break;
			}
			}while(true);
			num1 = sc.nextInt();
			switch(num1){
			case 1:
				System.out.println("[���͸���ϵͳ > ע��]");
				System.out.println("����д����ע����Ϣ��");
				System.out.print("�û�����");
				name = sc.next();		
				System.out.print("���룺");
				pw = sc.next();
				random = (int)(Math.random() * 9000 + 1000);
				System.out.println("ע��ɹ������ס���Ļ�Ա����");	
				System.out.println("�û���\t����\t��Ա����");
				
				System.out.println( name + "\t" + pw + "\t" + random);
				System.out.print("�����𣿣�Y/N����");
				isOK = sc.next();
				if(isOK.equalsIgnoreCase("n")){
					System.out.println("ллʹ�ã�");
					System.exit(1);
				}
				System.out.println();
				break;
				
			case 2:
				System.out.println("[���͸���ϵͳ > ��½]");
				for(i = 0 ; i< 3 ; i ++){
					System.out.print("�������û�����");
					name1 = sc.next();
					System.out.print("���������룺");
					pw1 = sc.next();
					if(name1.equals(name)  && pw1.equals(pw)  ){
						System.out.println("��½�ɹ���");
						isPoint = true;
						break;
						}else{
							System.out.println("�û���/�������");
							System.out.println("����" + (2 - i) + "�дλ���");
						}
					if(i == 2){
						System.out.println("�������ϵͳ�˳�");
						System.exit(1);
					}
				}
				break;
				
			case 3:
				if(!isPoint){
					System.out.println("����û��½�����½");
					continue;
				}
				System.out.println("[���͸���ϵͳ > �齱]");
				do{
					System.out.print("���������Ŀ���");
					id = sc.nextInt();
					if(id == random){
						System.out.print("������������Ϊ��");
						for(j = 0 ; j < 5 ; j++){
							num2[j] = (int)(Math.random() * 9000 + 1000);
							System.out.print(num2[j] + "  ");		
							
							
							
							
							if(id == num2[j]){
								System.out.println("��ϲ�����������˻�Ա��");
								System.out.print("�����𣿣�Y/N����");
								isOK = sc.next();
								
								if(isOK.equalsIgnoreCase("n")){
									System.out.println("ллʹ�ã�");
									System.exit(1);
								
								}
								break;
							}
						}
						System.out.println();
						}	
						break;
					
				
				}while(true);
				break;
				
			default:
				System.out.println("�����������������");
				break;
			}
		}while(true);
	}

}
