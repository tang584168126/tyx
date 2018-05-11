package Class7;

public class Test2_3 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int i = 0;
		int sum = 0;
		int a = 0;
		
		System.out.println("1~100之间不能被7整除的数据为：");
		for(i = 1;i<=100;i++){
			
			if(i%7 != 0){
				System.out.print(i + "\t");
				sum = sum+i;
				a++;
				if(a%4==0){
					System.out.println();
				}
			}else{
				continue;
			}
			
		}System.out.println();
		System.out.println("数据只和为"+sum);

	}

}
