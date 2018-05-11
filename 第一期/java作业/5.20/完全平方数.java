
public class 完全平方数 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//完全平方数：3*3 =9   那么9是3的完全平方数待做
		int a ;
		int b ;
		int c;
		int d;
		int e;
		
		for(a = 1;a<10000;a++){
			for(b = 1;b<10000;b++){
				for(e = 0; e<10000;e++){
			c = a*a;
			d = b*b;
			if(e+100 == c && e+100+168 == d){
				System.out.println("这个数是:"+e);
				
			}
		}
		}
		}

	}

}
