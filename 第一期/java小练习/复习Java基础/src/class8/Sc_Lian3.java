package class8;

import java.util.Arrays;
import java.util.Scanner;

public class Sc_Lian3 {
	public static void main(String[] args){
		String[] fu = new String[]{"a","c","u","b","e","p","f","z"};		//原数组
		int i = 0 ;
		int index = 0;
		String ziFu = "" ;													//插入的字符
		String[] fu1 = new String[9];										//插入后的数组	
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("原字符序列：");
		for(i = 0 ; i < fu.length ; i++){
			System.out.print(fu[i]);
		}
		
		System.out.println();
		Arrays.sort(fu);
		System.out.print("升序排序后：");
		for(i = 0 ; i < fu.length ; i++){
			System.out.print(fu[i]);
			fu1[i] = fu[i];
		}
		
		System.out.println();
		System.out.print("逆序输出为：");
		for(i = fu.length - 1 ; i >= 0  ; i--){
			System.out.print(fu[i]);
		}
		
		System.out.println();
		System.out.println("插入字符：");
		ziFu = sc.next();
		
		fu1[8] = ziFu ; 
		Arrays.sort(fu1);
		System.out.println("插入后并排序为：");
		for(i = 0 ; i <= fu.length ; i++){
			
			System.out.print(fu1[i]);
			if(ziFu.equals(fu1[i])){
				index = i ;
			}
		}
		System.out.println("\n插入数值的下标：" + index);
	}

}
