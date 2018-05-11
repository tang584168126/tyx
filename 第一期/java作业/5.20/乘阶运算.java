
public class 乘阶运算 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int i = 0;//循环条件
		int j = 10;//10以内的乘阶运算
		int cheng = 1;//保存每次积的值
		int sum = 0;//保存累加的总和
		
		//累加1到10 sum的值
		for(i = 1;i<=j;i++){
			cheng = cheng*i;
			sum = sum+cheng;
		}
		System.out.println("1!+2!+...10!="+sum);
		/*
		 *1! = 1*1
		 *2! = 1*2= 2
		 *3! = 1*2*3=6
		 *4! = 1*2*3*4=24  乘阶运算
		 */

	}

}
