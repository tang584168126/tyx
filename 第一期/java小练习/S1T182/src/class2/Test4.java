package class2;

public class Test4 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int i = 1 ;
		
		
		// 输出 1 - 20 ， 双排 输出
		/*
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		System.out.println(i + "         " + i++);
		*/
		
		/*
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		System.out.printf("%-3d         %-3d\n",i,i++);
		*/
		
		
		for(i = 1 ; i < 100 ; i++){
			System.out.printf("%-3d         %-3d\n",i,i);
		}
		
		// ++ 自增符号
		// i++ 如果 i 之前 为 1 ， 则 ++ 之后 为 2
	}

}
