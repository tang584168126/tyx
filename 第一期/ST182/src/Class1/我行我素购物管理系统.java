package Class1;

import java.util.Scanner;

public class �������ع������ϵͳ {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//�����һ������0��0һ�µ����� ���Ѵ��� С��
		
		int option1,option2= 0; //ѡ�����1��/2��
		int number = 0;       	//��Ʒ���
		int amount = 0;			//��Ʒ����
		int id1 = 0;			//��Ա����1
		int baiwei = 0;			//ȡĤ��λ
		
		double discount = 0;		//�ۿ�
		double money1 = 0;			//���
		double money2 = 0;			//Ӧ�����
		double money3 = 0;			//ʵ�����
		double money4 = 0;			//�ҵĽ��
		double price = 0;		//��Ʒ�۸�
		String proceed = "0";	//����
		String name = "0";  	//��Ʒ����
		String id,password = "0";//�û���/����
		
		Scanner sc = new Scanner(System.in);
		
		//��һ�����
		System.out.println("��������������������������������������������������������������������������������");
		System.out.println("                                        ");
		System.out.println("\t\t\t1.��¼ϵͳ                                       ");
		System.out.println("\t\t\t2.�˳�                                                ");
		System.out.println("                                        ");
		System.out.println("                                        ");
		System.out.println("��������������������������������������������������������������������������������");
		do{
		System.out.print("���������֣�");
		
		
		//�ж�ѡ��Ϸ�
		
		if(!sc.hasNextInt()){
			sc = new Scanner(System.in);
		}else{
			break;
			}
		}while(true);
		
		option1 = sc.nextInt();
		
		
		
		
		while(option1 > 2){
			do{
			System.out.println("������3���µ�����");
			System.out.println("���������֣�");
			if(!sc.hasNextInt()){
				sc = new Scanner(System.in);
			}else{
				break;
				}
			}while(true);
			option1 = sc.nextInt();
		}
		
		
		//��һ�㹦��ѡ��
		switch(option1){
		case 1:
			System.out.println("�������û���");
			id = sc.next();
			System.out.println("����������");
			password = sc.next();
			
			//�ж��û���������
			if(id.equals("admin") && password.equals("admin")){
				System.out.println("��������������������������������������������������������������������������������");
				System.out.println("\t\t\t1.�ͻ���Ϣ����                           ");
				System.out.println("\t\t\t2.��������                                ");
				System.out.println("\t\t\t3.�������                                       ");
				System.out.println("\t\t\t4.ע��                                                ");
				System.out.println("                                        ");
				System.out.println("��������������������������������������������������������������������������������");
				System.out.println("����������ѡ��");
				//�ж������Ƿ�Ϸ�
			if(!sc.hasNext()){
				System.out.println("������ �� �� ");
				System.out.println("�������");
				System.exit(1);
			}
			option2 = sc.nextInt();
			//�ڶ��㹦��ѡ��
			switch(option2){
			case 1:
				System.out.println("��������������������������������������������������������������������������������");
				System.out.println("                                        ");
				System.out.println("                                        ");
				System.out.println("\t\t\t�Բ�����ʱû�пͻ���Ϣ               ");
				System.out.println("                                        ");
				System.out.println("                                        ");
				System.out.println("��������������������������������������������������������������������������������");
				System.out.println("��������1¼���»�Ա");//������				
				break;
			case 2:
				
				System.out.println("��������������������������������������������������������������������������������");
				System.out.println("�����빺����Ʒ�ı��                          ");
				System.out.println("1.T��\t2.����Ь\t3.������                               ");
				System.out.println("��������������������������������������������������������������������������������");
				System.out.println("��������Ʒ�ı��                                                                  ");
				number = sc.nextInt();
				System.out.println("��������Ʒ������                                                                   ");
				amount = sc.nextInt();
				switch(number){
				case 1:
					name = "T��";
					price = 245.0;
					break;
				case 2:
					name = "����Ь";
					price = 570;
					break;
				case 3:
					name = "������";
					price = 320.0;
					break;
				default:
					System.out.println("û�д���Ʒ������1 2 3");
					break;//����ѭ��
				}
				money1 = price*amount;
				System.out.println(name + "��" + price + "\t����" + amount + "\t�ϼƣ�" + money1);
				System.out.println("�Ƿ����y/n");//������ͬʱ��������Ʒ�Լ�n��ѭ��
				proceed = sc.next();
				
				if(proceed.equals("y")){
					
					System.out.print("�������ۿۣ�");
					discount = sc.nextDouble();
					
					money2 = money1*discount;
					System.out.println("Ӧ����" + money2);
					System.out.print("������ʵ����");
					money3 = sc.nextDouble();
					
					money4 = money3-money2;
					System.out.println("��Ǯ" + money4);//��������
					
				}
				break;
			case 3:
				System.out.println("���ڵĻֻ�в鿴�Ƿ��������û�");
				System.out.println("������4λ��Ա���ţ�");
				id1 = sc.nextInt();
				baiwei = id1/100%10;
				
				int random = (int)(Math.random()*10);
				
				if(baiwei == random){
					System.out.println("��ϲ���������˿ͻ����MP3һ��");
				}else{
					System.out.println("���ź��㲻�����˿ͻ�");
				}
				
				break;
			case 4:
				//ע�� ������
				break;
			default:
				System.out.println("û�����ѡ������������");//��ѭ��
				break;
			}
			}else{
				System.out.println("������û�������������������ϵͳ");
			}
			break;
		case 2:
			System.out.println("��ӭ�´�ʹ�ñ�ϵͳ");
			break;
		
		}
		System.out.println("�������");

	}

}
