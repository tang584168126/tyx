package class15_1;

import java.util.Scanner;

/**
 * 描述：用户输入歌词，每段使用 空格 分割
 * 我们将用户输入的歌词使用 split()进行拆分
 * @author fun
 *
 */
public class Test3 {

	public static void main(String[] args) {
		//长亭外 古道边 芳草碧连天 晚风扶柳笛声残 夕阳山外山
		String gc = "";
		String[] gcs ;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("请输入歌词：（ 每段以空格隔开）");
		
		//next() 认为：空格 和 回车都表示输入完毕
		//gc = sc.next(); 
		
		//nextLine() 认为：回车 才表示输入完毕
		gc = sc.nextLine();
		
		System.out.println("===============================");
		
		System.out.println("原歌词为：" + gc);
		
		System.out.println("===============================");		
		
		//对歌词进行拆分，将歌词拆分为一个字符串数组
		gcs = gc.split(" ");
		
		//打印拆分后的结果
		System.out.println("拆分后，歌词为：");
		
		for(int i = 0 ; i < gcs.length ; i++){
			System.out.println(gcs[i]);
		}
		
		System.out.println("===========================");
		
		System.out.println("将 split()切割后的字符串数组拼接回 String : ");
		
		gc = "";
		
		//将字符串数组中的每一个元素重新 拼接成一个 字符串
		for(int i = 0 ; i < gcs.length ; i++){
			
			gc += gcs[i] + "_";
			
		}
		
		//去掉最后一个多余的字符 _
		gc = gc.substring(0,gc.length() - 1);
		
		
		System.out.println(gc);
	}
}





