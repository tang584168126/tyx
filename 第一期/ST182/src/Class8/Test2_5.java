package Class8;

public class Test2_5 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int [] sum = new int[]{1,3,-1,5,-2};
		int [] sums = new int [5];
		int a = 0;
		int b = 0;
		
		for(a = sum.length-1;a>=0;a--){
			if(sum[a] > 0){
			sums[b] = sum[a];
			}
			b++;
		}
		System.out.println("���򲢴���������Ϊ��");
		for(a = 0;a<sums.length;a++){
			System.out.print(sums[a]);
		}

	}

}
