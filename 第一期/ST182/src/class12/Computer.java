package class12;

public class Computer {

	String name ;		//����
	int result;			//����
	int num = 0;
	
	public int giveResult(){

		do{
			System.out.println("���ȭ��(1.ʯͷ  2.����  3.��)");
			num = (int)(Math.random() * 3 + 1);
			switch(num){
			case 1:
				System.out.println("�˳�ʯͷ");
				break;
			case 2:
				System.out.println("�˳�����");
				break;
			case 3:
				System.out.println("�˳���");
				break;	
			}
			break;
		}while(true);
		return num;
	}
}
