package class2;

public class Test10 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int a = 5 , b = 10;
		
		/*
		//a++;
		//++a;
		
		//b = ++a ;	//前缀自增
		b = a++ ;	//后缀自增
		*/
		
		//b = ++a + ++a + ++a + ++a ;
		//=  6  +  7  +  8  +  9  = 30;
		
		//b = a++ + a++ + a++ + a++ ;
		//=  5  +  6  +  7  +  8 = 26
		
		//b = a++ + ++a + a++ + ++a + ++a + a++;
		//=  5  +  7  +  7  +  9  +  10 + 10 = 48;
		
		
		//a *= 3 + 3;
		
		//a += 5 ;
		
		
		//随机数： 0 - 9
		// 1、 大 - 小 + 1 ==> 9 - 0 + 1 ==> 10
		// 2、Math.random() * 10 + 0
		// 3、对 2 取整
		b = (int)(Math.random() * 10 + 0);
		
		
		
		//System.out.println("a = " + a);
		System.out.println("b = " + b);
		
		
	}

}
