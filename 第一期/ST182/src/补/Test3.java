package ��;

public class Test3 {

	public static void main(String[] args){
		int i = 0 ;
		int j = 0 ;
		int sum = 0;			//�׳�֮��
		int ji = 1 ; 			//�׳�ֵ֮
		for(i = 1 ; i <= 10 ; i++){
			for(j = 1 ; j <= i ; j++){
				ji *= j ;
			}
			sum += ji ;
		}
		System.out.println("1-10�Ľ׳�֮��Ϊ��" + sum);
	}
}
