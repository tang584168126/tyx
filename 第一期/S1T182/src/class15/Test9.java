package class15;

import java.util.Scanner;

public class Test9 {

	public static void main(String[] args) {
		
		String fileName = "";
		char ch = ' ';
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("������ Java�ļ�����");
		fileName = sc.next();
		
		//�ж��û�������Ƿ��ǺϷ���JavaԴ�ļ�
		if(fileName.lastIndexOf(".java") == fileName.length() - 5){
			
			//�� ��׺����ȷ������£�����һ���ַ���ȡ�������ж��Ƿ��Ǵ�д��ĸ
			//��ȡĳ���ַ��������ַ�����
			ch = fileName.charAt(0);
			
			if(ch >= 'A' && ch <= 'Z'){
				System.out.println(fileName + "��һ���Ϸ���JavaԴ�����ļ���");	
			}
			else{
				System.out.println("�ļ���JavaԴ�ļ������������淶�����");
			}
			
			
		}
		else{
			System.out.println(fileName + "����һ���Ϸ���JavaԴ�����ļ���");
		}
		
	}
}
