
package test;

import info.Student;
import info.Subject;

/*
 * �����࣬�����ز�����Ϣ
 * */
public class Test {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//����רҵ����
		Subject one=new Subject();
		one.setSubjectId("001");
		one.setSubjectName("�������ѧ��Ӧ��");
		
		//����ѧ������
		Student liuXin=new Student();
		liuXin.setStuName("������");
		liuXin.setStuAge(16);		
		//����רҵ���ԣ�ѧ������
		liuXin.setMySubject(one);
		liuXin.setStuId("00101");
		//����ѧϰ����
		liuXin.study();
		System.out.println("===================================");
		
		//����ѧ������
		Student tianMeng=new Student();
		tianMeng.setStuId("00102");
		tianMeng.setStuName("�ﱦǿ");
		tianMeng.setStuAge(21);
		tianMeng.setMySubject(one);
		
		//����ѧϰ����
		tianMeng.study();
		System.out.println("===================================");
		//����רҵ�Ľ��ܷ���*/
		one.info();
		
	}

}
