package class2;

public class RandomTest {

	
	public static void main(String[] args) {
		
		int num = 0 ;
		int i = 0 ;
		
		//����� 98 ~ 1000
		//1���� - С + 1 ==> 1000 - 98 + 1 = 903
		//2��Math.random() * 903 + 98
		//3���� Math.random() * 903 + 98 ȡ��
		//==> (int)(Math.random() * 903 + 98)
		
		for(i = 0 ; i < 100 ; i++){
			
			//�����������
			num = (int)(Math.random() * 903 + 98);
			
			//��ӡ���
			System.out.println(num);
		}
		System.out.println("���������");
	}
}
