package class15;

import java.util.Scanner;

public class Test9 {

	public static void main(String[] args) {
		
		String fileName = "";
		char ch = ' ';
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入 Java文件名：");
		fileName = sc.next();
		
		//判断用户输入的是否是合法的Java源文件
		if(fileName.lastIndexOf(".java") == fileName.length() - 5){
			
			//在 后缀名正确的情况下，将第一个字符提取出来，判断是否是大写字母
			//提取某个字符（不是字符串）
			ch = fileName.charAt(0);
			
			if(ch >= 'A' && ch <= 'Z'){
				System.out.println(fileName + "是一个合法的Java源程序文件！");	
			}
			else{
				System.out.println("文件是Java源文件，但命名不规范或错误！");
			}
			
			
		}
		else{
			System.out.println(fileName + "不是一个合法的Java源程序文件！");
		}
		
	}
}
