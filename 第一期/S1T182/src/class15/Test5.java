package class15;

import java.util.Scanner;

public class Test5 {

	public static void main(String[] args) {
		
		String fileName = "";
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("������ Java�ļ�����");
		fileName = sc.next();
		
		if(fileName.indexOf(".java") > 0){
			System.out.println(fileName + "�а��� .java");
		}
		else{
			System.out.println(fileName + "�в����� .java");
		}
		
	}
}
