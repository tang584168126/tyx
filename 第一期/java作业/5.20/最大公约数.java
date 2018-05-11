import java.util.Scanner;


public class 最大公约数 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int a = 0;//循环条件
		int b = 0;//储存第一个数
		int c = 0;//储存第二个数
		int d = 0;//
		int e = 0;//
		double f = 0;
		double h = 0;
		double i = 0;
		
		
		Scanner sc  = new Scanner(System.in);
		System.out.print("请输入第一个数：");
		b = sc.nextInt();
		h = b;
		System.out.print("请输入第二个数：");
		c = sc.nextInt();
		i = c;
		for(a = 1;a<10000000; a++){
			d = b/c;
			e = c/b;
			if(b%c == 0 || c%b == 0){
			if(b == d*c || c == e*b){
			if(a == d*c ||a == e*b){
				System.out.println("他们的最小公倍数是"+a);
			}
			}else{
				continue;
			}
			}else if(a == b*c){
				System.out.println("他们的最小公倍数是"+a);
			}
		}
		h = b;
		f = c;
		
		if (h>f){
			h = h+f;
			f =h-f;
			h = h-f;
		}
		if(f%h== 0){
			
			System.out.println("他们最小公约数是"+h);
		}else{
			
			while(h%f != 0){
			i = h%f;
			f = h;
			h = i;
			
			
			}
			
			System.out.println("他们最小公约数是"+i);
			
		}
			/*最大公约数15  9  最大公约数为3
			 * 共同因子 最大的一个
			 * 
			 */
		/*	
		for(a = 2;a<=b;a++){
			
			while(b % a ==0){
			if(b%a == 0){
				b = b/a;
				if(e<a){
					e=a;
					System.out.println(b+"的约数"+e);
				}
			}
			}
			
		}
		
		e = 0;
		
		for(a = 2;a<=c;a++){
			
			while(c % a ==0){
			if(c%a == 0){
				c = c/a;
				if(e<a){
					e=a;
				}
			}
			}
			
		}
		System.out.println(b+"的约数"+e);
		*/
		/*if(h>i){
			h = h+i;
			i = h-i;
			h = h-i;
		}
		if(h<i && i%h==0){
			f = h;
		}
		while(f!=0){
			
		}
		System.out.println("最大公约数为"+f);
		*/
			
		
			
			
			
		

	}

	}
