package class12;

import java.util.Scanner;

public class QuessMachine {
	String[] goods = new String[5];
	int[] price = new int[5];
	int num;
	public void intn(){
		goods[0] = "�綯��";
		goods[1] = "˫�ű���";
		goods[2] = "�ʼǱ�����";
		goods[3] = "iphone�ֻ�";
		goods[4] = "ȫ�Զ�ϴ�»�";
		
		price[0] = 850;
		price[1] = 4800;
		price[2] = 3200;
		price[3] = 2999;
		price[4] = 1680;
	}
	public void guess(){
		intn();
		int money;
		int count = 0;
		String msg = "";
		Scanner sc = new Scanner(System.in);
		num = (int)(Math.random() * 5);
		System.out.println("��Ʒ��" + goods[num]);
		do{
			System.out.print("��������Ʒ�۸�");
			money = sc.nextInt();
			if(money == price[num]){
				System.out.println("��ϲ������ô󽱣�");
				break;
			}else if(money > price[num]){
				msg = "��С�㣡";
			}else if(money < price[num]){
				msg = "�ٴ�㣡";
			}
			count++;
			if(count >= 4){
				System.out.println("4�ζ�û�¶ԣ��´�Ŭ���ɣ�");
				break;
			}
			else{
				System.out.println(msg);
			}
		}while(true);

				
	}
	

}
