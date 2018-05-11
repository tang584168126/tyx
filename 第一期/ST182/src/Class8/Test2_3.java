package Class8;


public class Test2_3 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {

		
		
		int [] points = new int[]{18,25,7,36,13,2,89,63};
		int min = points[0];
		int a = 0;
		int b = 0;//暂时储存下标的值
		for(a = 0;a<points.length;a++){
			System.out.print(points[a]);
		}
		System.out.println("");
		for(a = 0;a<points.length;a++){
			if(min>points[a]){
				min = points[a];
				b = a;
			}
			if(a == points.length-1){
				System.out.println("最小值是：" + min);
				System.out.println("下标为：" + b);
			}
			
		}

	}

}
