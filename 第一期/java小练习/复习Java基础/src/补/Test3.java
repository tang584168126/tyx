package 补;

public class Test3 {
	public static void main(String[] args){
		int num = 100;
		int ge  = 0;
		int shi = 0;
		int bai = 0 ;
		while( num <= 999){
			ge = num % 10;
			shi = num /10 % 10;
			bai = num / 100;
			
			if(ge * ge * ge + shi * shi *shi + bai * bai * bai == num){
				System.out.println("水仙花数为：" + num);
			}
			num++;
		}
	}

}
