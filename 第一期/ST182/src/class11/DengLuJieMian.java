package class11;

import java.util.Scanner;
/**
 * ��½����
 * @author fun
 *
 */

public class DengLuJieMian {
	String name;
	String secret;
	int i = 0;
	
	public void show(){
		Scanner sc = new Scanner(System.in);
		System.out.println("�����͸���ϵͳ > ��½��");
		for(i = 0 ; i <= 4 ; i++){
			System.out.println("�������˺ţ�");
			name = sc.next();
			System.out.println("�������˺ţ�");
			secret = sc.next();
			if(name.equals("admin") && secret.equals("admin")){
				System.out.println("��½�ɹ���");
			}else{
				
				System.out.println("�����µ�½��");
				System.out.println("������ " + (4-i) + " �λ��ᣡ");
					
				if(i == 4){
					System.out.println("�������\nϵͳ�˳�");
					System.exit(1);
				}
				
			}
				
		}
		
	
	}

}
