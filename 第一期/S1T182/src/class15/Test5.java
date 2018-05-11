package class15;

import java.util.Scanner;

public class Test5 {

	public static void main(String[] args) {
		
		String fileName = "";
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入 Java文件名：");
		fileName = sc.next();
		
		if(fileName.indexOf(".java") > 0){
			System.out.println(fileName + "中包含 .java");
		}
		else{
			System.out.println(fileName + "中不包含 .java");
		}
		
	}
}
