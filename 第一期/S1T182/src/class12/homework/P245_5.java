package class12.homework;

import java.util.Scanner;

public class P245_5 {

	String[] goodsNames = new String[3];//��Ʒ����
	int [] goodsprices = new int[3];	//��Ʒ�۸�
	int num = 0 ;						//������Ʒ���±�
	
	/**
	 * ��Ʒ��Ϣ��ʼ���ķ���
	 */
	public void init(){
		goodsNames[0] = "˫�ű���";
		goodsNames[1] = "ƽ��ʵ�";
		goodsNames[2] = "��Ͳϴ�»�";
		
		goodsprices[0] = 5100;
		goodsprices[1] = 2999;
		goodsprices[2] = 1890;
		
	}
	

	/**
	 * ȷ��Ҫ���µ���Ʒ
	 */
	public void showGoods(){
		
		num = (int)(Math.random() * 3);
		
		System.out.println("���ξ��µ���ƷΪ��" + goodsNames[num]);
	}
	
	/**
	 * ��ʼ������Ϸ�ķ���
	 */
	public void startGame(){
		
		int money = 0 ;	//�����û�����ľ��¼۸�
		int count = 0 ;	//ͳ���û����뾺�¼۸�Ĵ���
		String msg = "";//�����û�����ʾ
		
		//���ȳ�ʼ����Ŀ����
		init();
		
		//���Ҫ���µ���Ʒ
		showGoods();
		
		Scanner sc = new Scanner(System.in);
		
		do{
			//��ʾ�û�����Ҫ���µ���Ʒ�ļ۸�
			System.out.println("��������Ʒ�۸�");
			money = sc.nextInt();
			
			//�ж��û�����ļ۸��� Ҫ������Ʒ�ļ۸�Ĺ�ϵ
			if(money == goodsprices[num]){
				//������
				System.out.println("��ϲ�������ˣ���ã�" + goodsNames[num]);
				break;
			}
			else if(money > goodsprices[num]){
				//�������
				msg = "���ٵ㣡��";
			}
			else{
				//���С��
				msg = "�ٶ�㣡��";
			}
			
			count++;
			
			if(count >= 4){
				System.out.println("���Ѳ´� 4 �Σ���Ϸ������");
				break;
			}
			else{
				System.out.println(msg);
			}
			
		}while(true);
	}
}








