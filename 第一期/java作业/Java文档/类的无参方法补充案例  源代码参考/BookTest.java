
public class BookTest {	
	//���Է���
	public static void main(String[] args){
		Book one=new Book();
				one.bookName="¹����";
				one.author="��ӹ";
				one.publisher="������ѧ������";
				one.price=120;
				//���ý��ܵķ���
				one.info();
				System.out.println("=============================");
				
				//ʵ�������󣬲���������Ը�ֵ
				Book two=new Book();
				two.bookName="����˫��";
				two.author="����";
				two.publisher="�й�����������";
				two.price=55.5;
				//���ý��ܵķ���
				two.info();
	}
}
