package class9;

public class Test3 {
	public static void main(String[] args){
		int i = 0 ; 		//����
		int j = 0 ; 		//ĸ��
		int k = 0 ; 		//����
		for(i = 0 ; i <= 20 ; i++){
			for(j = 0 ; j < 34 ; j++){
				k = 100 - i - j ;
				if(5 * i + 3 * j + 1 * k / 3 == 100){
					System.out.println("������" + i + "ĸ����" + j + "������" + k);
				}
			
			}
		}
	}

}
