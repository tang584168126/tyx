package class2;

public class Test4 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int i = 1 ;
		
		
		// ��� 1 - 20 �� ˫�� ���
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
		
		// ++ ��������
		// i++ ��� i ֮ǰ Ϊ 1 �� �� ++ ֮�� Ϊ 2
	}

}
