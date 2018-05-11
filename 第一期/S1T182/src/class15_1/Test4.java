package class15_1;

import java.util.Scanner;

/**
 * 描述：找到用户输入内容中的多个 爱 字
 * @author fun
 *
 */
public class Test4 {

	public static void main(String[] args) {
		
		int i = 0 , count = 0 ;
		String str = "";
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入内容：");
		str = sc.nextLine();
		
		//利用循环遍历 用户输入内容中的  爱  字
		for(i = 0 ; i < str.length() ; i++){
			
			if(str.indexOf("爱", i) != -1){
				
				//从找到的 字符下标 重新开始查找
				//将 找到的下标 赋值给 i
				i = str.indexOf("爱", i) ;
				
				System.out.print(i + " ");
				count++;	//统计找到多少个
			}
			
		}
		
		System.out.println("\n共计：" + count + " 个 爱 字");
	}
}





