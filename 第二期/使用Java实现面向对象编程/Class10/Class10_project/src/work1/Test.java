package work1;

import java.io.File;
import java.util.Scanner;

/**
 * ���롢���������
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		ShowFile cnf = new ShowFile();
		File file = new File("D:\\�ҵ��ഺ˭����.txt");
		File file2 = new File("C:\\myFile\\myPrime.txt");
		cnf.create(file);		//�������ļ�
		cnf.create(file2);
		cnf.show(file);
		
		System.out.println();
		System.out.println("���������ݣ�");
		String str1 = sc.next();
		cnf.Output(file,str1);		//�����ļ���д����
		cnf.show(file);
		
		System.out.println();
		String str2 = cnf.Input(file);		//�����������ַ���
		
		//���Ƶ�c��
		cnf.Output(file2, str2);
		cnf.show(file2);
	}
}
