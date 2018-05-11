
public class 求分数序列 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		double a = 2.0;		//用来储存a的初始值  及以后储存a的累加值
		double a1 = 1;		//用来暂时储存a的累加值 之后用来赋值给B
		double b = 1.0;		//用来储存b的初始值  及以后储存b的累加值
		double c = 0;		//用来储存a/b累加值的商
		double d = 0;		//循环条件
		double sum = 0;		//储存a/b累加的和
		for(d = 0; d<20;d++){//循环推出此序列20以内的数
			c = a/b;
			sum = sum + c;
			System.out.printf("%5.0f/%-5.0f=%.5f\n",a,b,sum);//占位符控制输出
			a1 = a;			//实现a/b 到下个序列值得转换
			a = a+b;
			b = a1;				
		}
		
	}

}
