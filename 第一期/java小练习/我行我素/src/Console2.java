import java.util.Scanner;
public class Console2 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("   ��ӭʹ���������ع������ϵͳ  \n ");
		System.out.println("	1. ��½ϵͳ	\n");
		System.out.println("	2. �˳�	");
		System.out.println();
		System.out.println("**********************************");
		System.out.println();
		System.out.print("��ѡ����������:");
		int hao = sc.nextInt();
		if(hao==1)
		{	
			System.out.println("�������˺ţ�");
			String one = sc.next();
			System.out.println("���������룺");
			String two = sc.next();
			if(one.equals("admin") && two.equals("admin")){
			System.out.println("**********************************\n");
			System.out.println("   ��ӭʹ���������ع������ϵͳ  \n ");
			System.out.println("**********************************\n");
			System.out.println("	1. �ͻ���Ϣ����\n");
			System.out.println("	2. �������	\n");
			System.out.println("	3. �������	\n");
			System.out.println("	4. ע��	\n");
			System.out.println("**********************************\n");
			System.out.println("��ѡ����������:");
			}
			else{System.out.println("�˺�/�������");
				}
			}
		if(hao==2){
			System.out.println("ллʹ��");
		}
			
		
	}

}
