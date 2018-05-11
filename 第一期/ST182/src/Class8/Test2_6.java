package Class8;

import java.util.Scanner;

public class Test2_6 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		String [] musics = new String[]{"Island","Ocean","Pretty","Sun"};
		String [] musics1 = new String[musics.length+1];
		
		int a =0;
		int index= -1;
		String num = "";
		
		for(a = 0;a<musics.length;a++){
			musics1[a] = musics[a];
		}
		System.out.println("请输入新歌曲：");
		 num = sc.next();
		 
		 for(a = 0;a<musics1.length;a++){
			 if(musics1[a].compareToIgnoreCase(num)>0){
				 index = a;
				 break;
			 }
		 }
		if(index == -1){
			musics1[musics1.length-1] = num;
		}else{
			for(a = musics1.length-1;a > index;a--){
				musics1[a] = musics1[a-1];
			}
		}
		musics1[index] = num;
		for(a = 0;a < musics1.length;a++){
			System.out.print(musics1[a] + "\t");
		}
		/*package class8;

import java.util.*;


public class Test6 {

	
	public static void main(String[] args) {
		
		int i = 0 ;
		int num = 0 ;		//接收用户输入的整数
		int index = -1 ;	//index表示的是查出来的 下标，如果为0 ， 有可能被误认为是 第一个元素
		
		Scanner sc = new Scanner(System.in);
		
		//声明一个 5 个元素 ， 带 初始值的数组
		int [] sz = {10,20,30,40,50};
		
		//声明一个数组，以 sz 数组元素个数 + 1 为元素个数
		int [] sz1 = new int[sz.length + 1];
		

		//将 sz 的值 依次赋值给 sz1
		for(i = 0 ; i < sz.length ; i++){
			
			sz1[i] = sz[i] ;
			
		}
		
		//打印原始数据
		for(i = 0 ; i < sz.length ; i++){
			
			System.out.print(sz[i] + "  ");
			
		}
		
		//由用户输入一个整数，放入 sz1 中，要求实现有序
		System.out.println("请输入一个整数：");
		num = sc.nextInt();
		
		//找到 sz1 中 比 用户输入值 大的那个数的下标
		for(i = 0 ; i < sz1.length ; i++){

			//判断 哪个数组元素 比 用户输入的值要大
			if(sz1[i] > num){
				//将 用户输入的数要放入的下标记录下来
				index = i ;
				break;	//找到了要放入的位置后，跳出查找
			}
			
		}
		
		//如果 用户输入的值最大，则 index 无法额外获取下标，
		//此时 index 将为： -1
		if(index == -1){
			sz1[sz1.length - 1] = num ;
		}
		else{
			//将 要放入用户输入的数据的下标之后的所有值
			//向后移动一位
			for(i = sz1.length - 1; i > index; i--){
				
				//将 下标 i - 1 的值 赋值给 下标 i 的元素
				sz1[i] = sz1[i - 1] ;
				
			}
			
			//最后一步，将用户输入的值 放入 应该放入的位置
			sz1[index] = num ;
		}
		
		//打印结果
		for(i = 0 ; i < sz1.length ; i++){
			
			System.out.print(sz1[i] + "  ");
			
		}
	}

}
*/



	}

}
