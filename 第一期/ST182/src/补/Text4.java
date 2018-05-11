package 补;

public class Text4 {
	public static void main(String[] args){
		int i = 0;
		int ge = 0;
		int shi = 0;
		int bai = 0;
		for(i = 100 ; i <= 999 ; i++){
			ge = i % 10 ;
			shi = i /10 % 10 ;
			bai = i / 100 ;
			if(ge * ge * ge + shi * shi * shi + bai * bai * bai == i){
				System.out.println("三位数的水仙花数为：" + i);
			}
		}
	}

}
