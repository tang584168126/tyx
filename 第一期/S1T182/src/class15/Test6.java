package class15;

public class Test6 {

	public static void main(String[] args) {
		
		String str = "120345678920";
		
		int index = -1 ;
		
		//��һ�γ��ֵ��±�
		//index = str.indexOf("20") ;
	
		//���һ�γ��ֵ��±�
		index = str.lastIndexOf("20") ;
		
		
		if(index != -1){
			System.out.println(str + "�а��� 20 ");
			System.out.println("���±꣺" + index);
		}
		else{
			System.out.println(str + "�в����� 20 ");
		}
		
		System.out.println("====================");
		
	}
	
}
