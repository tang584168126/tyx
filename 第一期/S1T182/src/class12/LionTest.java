package class12;

public class LionTest {

	public static void main(String[] args) {
		
		//����һ�� ʨ����Ķ��� lion
		Lion lion = new Lion();
		
		//Ϊʨ�ӵ���ɫ���и�ֵ
		lion.color = "��ɫ";
		
		//��ʾʨ�ӵ���ɫ
		System.out.println(lion.color + "�����ʨ�ӣ�");
		
		//�������ʨ�ӵĲ���
		System.out.println("�ܵĲ��ԣ�");
		lion.run();
		
		System.out.println("�еĲ��ԣ�");
		System.out.println(lion.bark());
	}
}
