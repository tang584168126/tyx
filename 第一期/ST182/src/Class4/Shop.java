package Class4;

import java.util.Scanner;

public class Shop {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		double money = 0;
		int option = 0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("���������ѽ�");
		money = sc.nextDouble();
		System.out.println("�Ƿ�μ��Żݻ������");
		System.out.println("1:��50Ԫ����2Ԫ�������¿���һƿ");
		System.out.println("2:��100Ԫ����3Ԫ����500ml����һƿ");
		System.out.println("3:��100Ԫ����10Ԫ����5�������һ��");
		System.out.println("4:��200Ԫ����10Ԫ����1���ղ�������");
		System.out.println("5:��200Ԫ����20Ԫ����ŷ����ˬ��ˮһƿ");
		System.out.println("0��������");
		System.out.println("��ѡ��");
		option = sc.nextInt();
		
		switch(option){
		case 1:
			if(money<50){
				System.out.println("�Բ����㲻��������");
				System.out.println("���������ܶ" + money);
			}else{
				System.out.println("���������ܶ" + (money+2));
				System.out.println("��ϲ�㣡�������¿���һƿ");
			}
			break;
		case 2:
			if(money<100){
				System.out.println("�Բ����㲻��������");
				System.out.println("���������ܶ" + money);
			}else{
				System.out.println("���������ܶ" + (money+3));
				System.out.println("��ϲ�㣡����500ml����һƿ");
			}
			break;
		case 3:
			if(money<100){
				System.out.println("�Բ����㲻��������");
				System.out.println("���������ܶ" + money);
			}else{
				System.out.println("���������ܶ" + (money+10));
				System.out.println("��ϲ�㣡�������5����");
			}
			break;
		case 4:
			if(money<200){
				System.out.println("�Բ����㲻��������");
				System.out.println("���������ܶ" + money);
			}else{
				System.out.println("���������ܶ" + (money+10));
				System.out.println("��ϲ�㣡�����ղ����糴��һ��");
			}
			break;
		case 5:
			if(money<200){
				System.out.println("�Բ����㲻��������");
				System.out.println("���������ܶ" + money);
			}else{
				System.out.println("���������ܶ" + (money+20));
				System.out.println("��ϲ�㣡����ŷ����ˬ��ˮһƿ");
			}
			break;
		case 0:
			System.out.println("���������ܶ" + money);
			break;
			default:
				System.out.println("��������Ч��ѡ��");
			break;
		}
		System.out.println("�������");

	}

}
