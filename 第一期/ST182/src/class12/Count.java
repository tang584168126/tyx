package class12;

import java.util.Scanner;

public class Count {
	Ren ren = new Ren();				//��
	Computer cpu = new Computer();		//����
	int index;		//�˼�����
	int index1;		//����������
	int index2;		//ƽ�ּ�����
	
	String isOK;
	
	Scanner sc = new Scanner(System.in);
	
	//��ʾ��Ϸ����ķ���
	public void jieMian(){
		System.out.println("*********************************");
		System.out.println("******		�˻���ȭ		**********");
		System.out.println("*********************************");
		System.out.println("�������û�����");
		ren.name = sc.next();
	}
	
	//��ʼ��Ϸ�ķ���
	public void judgeGames(){
		do{
			ren.num = ren.num;
			System.out.println("������" + ren.name + "�Ľ����" + ren.num);
			cpu.num = cpu.num;
			System.out.println("����������Ľ����" + cpu.num);
			
			
			//�ж���Ӯ�ķ���
			if(ren.num == 1 && cpu.num == 2 || ren.num == 2 && cpu.num == 3 || ren.num == 3 && cpu.num == 1){
				System.out.println("��ϲ������Ӯ�ˣ���");
				index++;
			}else if(ren.num == cpu.num){
				System.out.println("ƽ�֣�");
				index2++;
			}else{
				System.out.println("���ź�������ʤ����");
				index1++;
			}
			
			System.out.println("������(Y/N)");
			isOK = sc.next();
		}while(isOK.equalsIgnoreCase("y"));
		
		//��ʾ��Ϸ���
		System.out.println("��ʤ���Ĵ�����" + index);
		System.out.println("����ʤ���Ĵ�����" + index1);
		System.out.println("ƽ�ֵĴ�����" + index2);
		
	}
	
	
	
}
