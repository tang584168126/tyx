package Class3;

import java.util.Scanner;

public class Test2 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		
		int year = 0;
		String sex = "";
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("�����뺢�����䣺");
		year = sc.nextInt();
		System.out.print("�����뺢���Ա�");
		sex = sc.next();
		
		
		if(year <5){
			System.out.println("��ĺ��ӻ�̫С");
			
		}else if(sex.equals("��")){
			System.out.println("��ĺ����ܰᶯ����");
		}else{
			System.out.println("Ů���Ӳ��ʺϰ�����");
		}
	}	
}
	


