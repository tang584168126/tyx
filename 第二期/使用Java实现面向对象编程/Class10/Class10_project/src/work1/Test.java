package work1;

import java.io.File;
import java.util.Scanner;

/**
 * 输入、输出流测试
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		ShowFile cnf = new ShowFile();
		File file = new File("D:\\我的青春谁做主.txt");
		File file2 = new File("C:\\myFile\\myPrime.txt");
		cnf.create(file);		//创建新文件
		cnf.create(file2);
		cnf.show(file);
		
		System.out.println();
		System.out.println("请输入内容：");
		String str1 = sc.next();
		cnf.Output(file,str1);		//在新文件中写内容
		cnf.show(file);
		
		System.out.println();
		String str2 = cnf.Input(file);		//输入流返回字符串
		
		//复制到c盘
		cnf.Output(file2, str2);
		cnf.show(file2);
	}
}
