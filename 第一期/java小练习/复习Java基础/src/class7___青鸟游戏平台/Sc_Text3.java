package class7___������Ϸƽ̨;

public class Sc_Text3 {
	public static void main(String[] args){
		int i = 0 ;
		int j = 0 ;			//1-100���ܱ�7�����ĸ���
		int sum = 0 ;
		System.out.println("1-100���ܱ�7����������Ϊ��");
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
		System.out.println("\n��ֵ֮��Ϊ��" + sum);
	}

}
