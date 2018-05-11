import java.util.Scanner;


public class 分解质因数 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		 int a = 0;//用来储存用户输入的数
		 int b = 2;//循环条件 储存最小质因数 初始值为2  因为任何数最小质因数为2
		 
		 
		 Scanner sc = new Scanner(System.in);
		 
		 System.out.println("请输入一个正整数");
		  a = sc.nextInt();
		  
		  System.out.print(a + "=");
		  
		  //判断当除数小雨被除数时跳出循环  用b++ 分解的时候能依次从小到大分解质因数出来
		  for(b = 2;a>b;b++){
			 do{
			  if(a%b == 0){			//判断用户输入的值对质因数取膜为0时说明该数能被b整除
				  System.out.print(b);
				  if(a == b){
					  
				  }else{
					  System.out.print("*");
				  }
				  a=a/b;  //对于分解了第一次的整数要执行分解
			  }else{
			  break;
			  }
			  } while(a%b == 0);
			  
		  }
		  if(a == 1){//当A等于1的时候则不用打印a
			 
		  }
		  else{
		  System.out.println(a);//当a大于b的时候说明不能分解了
		  }
		 
			 
		 

	}

}
