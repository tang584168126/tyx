package class7___青鸟游戏平台;

public class Sc_Text3 {
	public static void main(String[] args){
		int i = 0 ;
		int j = 0 ;			//1-100不能被7整除的个数
		int sum = 0 ;
		System.out.println("1-100不能被7整除的数据为：");
		for(i = 1 ; i <= 100 ; i++){
			if(i % 7 != 0){
				System.out.print(i + "\t");
				sum += i ;
				j++;
			}
			if(j % 4 == 0){
				System.out.print("\n");
			}
		}
		System.out.println("\n数值之和为：" + sum);
	}

}
