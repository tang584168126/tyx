package post_class4;

import java.util.Scanner;
/**
 * ѧԱ��
 * @author Administrator
 *
 */
public class Student1 {

	String name = "����";	//����
	int age;		//����
	
	Scanner sc = new Scanner(System.in);
	
	//������֤
	public void setAge()
	{
		System.out.println("�������ѧԱ���䣺");
		age = sc.nextInt();
	}
	
	//���
	public void print()
	{
		System.out.println("������" + name + "\t���䣺" + age);
	}
}
