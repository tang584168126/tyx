import java.util.Scanner;

/*
 * �����࣬�����ز�����Ϣ
 * */
public class BoardroomTest {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//��������Ҷ���
		Boardroom one=new Boardroom();
		Boardroom two=new Boardroom();
		
		one.id="001";
		one.name="��һ������";
		one.used=true;
		
		two.id="002";
		two.name="�ڶ�������";
		two.used=false;
		
		//���л�����Ԥ��
		if(one.bespeak()==false)
			two.bespeak();
		
	}
}
