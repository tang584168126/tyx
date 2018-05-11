package com.cdqy.s2t182;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;
import java.io.OutputStream;
import java.util.ArrayList;
import java.util.List;

/**
 * ��ʾ���л�����
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-23 ����5:35:19
 * @version 1.0
 */
public class ObjectOutputStreamTest {
	public static void main(String[] args) {
		ObjectOutputStream oos =null;
		try {
			OutputStream os = new FileOutputStream("C:/obj.txt");
			oos = new ObjectOutputStream(os);
			Student stu1 = new Student("����",18);
			Student stu2 = new Student("lisi",20);
			//ʹ�÷��ͼ���
			List<Student> list = new ArrayList<Student>();
			list.add(stu1);
			list.add(stu2);
			//д�����,���л�
			oos.writeObject(list);
			oos.flush();
			System.out.println("������л�����");
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}finally{
			//�ͷ���Դ
			try {
				if(oos != null){
					oos.close();
				}
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}
}
