package class13;

public class Computer {
	String name ;	//����
	int result ;	//����
	
	public int ��ȭ(){
		
		int num = 0 ;

		num = (int)(Math.random() * 3 + 1);
		
		switch(num){
		case 1:
			System.out.println("������ȭ��ʯͷ");
			break;
		case 2:
			System.out.println("������ȭ������");
			break;
		case 3:
			System.out.println("������ȭ�� ��");
			break;
		}
		
		//���ػ�����ȭ�Ľ��
		return num ;
	}
}
