import java.util.Scanner;


public class ����ѭ�����������ĳ˽� {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int a = 1;//��������˻�                 ��ô����14�˽� ���ܳ���100e  ��������21e?
		int c = 0;//ѭ������ �������
		int d = 1;//ѭ������  
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("������������˽׵�ֵ");
		d = sc.nextInt();
		while(d>9){
			System.out.println("����������");
			d= sc.nextInt();
		}
		System.out.print(d+"!=");//��ӡ ������
		
		for(c = 1;c<=d;c++){//�˽�d��ֵ �ж�ѭ������
			
			a = a*c;
			System.out.print(c);//��ӡcÿ��ѭ����ֵ ����
			
			if(c == d){
			break;	//���һ�β��ô�ӡ*
			}else{
			System.out.print("*");//��ӡ ������
			}
		}
			System.out.print("=");//��ӡ ������
			System.out.print(a);
	}

}
