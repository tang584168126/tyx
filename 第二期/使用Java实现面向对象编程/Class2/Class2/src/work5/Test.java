package work5;

import java.util.Scanner;

/**
 * ������
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args){
		int day = 0;	//����
		int money = 0;	//ÿ�����
		int count1 = 0;	//ѡ��һ��
		int count2 = 0;
		int index1 = 0;	//ѡ�����:�γ����ͳ�
		int index2 = 0;	//ѡ����Σ��𱭣�����
		int item1 = 0;	//ѡ�����Σ�����
		int item2 = 0;	//ѡ�����Σ����
		char matha = ' ';//�����ĸ
		int math1 = (int)(Math.random()*9000 + 1000);		//���������
		
		Scanner sc = new Scanner(System.in);
		
		//�����λ��д��ĸ
		for(int i = 0; i < 2; i++){
			matha += (char)(Math.random() * 26 + 'A');		
		}
		
		System.out.print("������Ҫ���޵�������");
		day = sc.nextInt();
		
		System.out.print("������Ҫ�������������ͣ�(1.�γ� 2.�ͳ�)");
		count1 = sc.nextInt();
		
		if(count1 == 1){
			System.out.print("������Ҫ����������Ʒ�ƣ�(1.���� 2.���)");
			index1 = sc.nextInt();	
			if(index1 == 1){
				System.out.print("������γ����ͺ�1.����550i��");
				item1 = sc.nextInt();
				if(item1 == 1){
					System.out.println("���������������ǣ���" + matha + math1);
				}else{
					System.out.println("û�и��ͺŵĳ���");
				}
			}else if(index1 == 2){
				System.out.print("������γ����ͺ� 2.�����GL8 3.��������");
				item2 = sc.nextInt();
				if(item2 ==2){
					System.out.println("���������������ǣ���" + matha + math1);
				}else if(item2 ==3){
					System.out.println("���������������ǣ���" + matha + math1);
				}else{
					System.out.println("û�и��ͺŵĳ���");
				}
			}else{
				System.out.println("û�и�Ʒ�ƣ�");
			}
		}else if(count2 ==2){
			System.out.print("������Ҫ���޿ͳ���Ʒ�ƣ�(1.�� 2.����)");
			index2 = sc.nextInt();
			if(index2 == 1){
				
			}
		}
	}
}
