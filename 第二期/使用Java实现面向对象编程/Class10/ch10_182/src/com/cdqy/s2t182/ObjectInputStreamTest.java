package com.cdqy.s2t182;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.util.ArrayList;
import java.util.List;

/**
 * ��ʾ�����л�����
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-23 ����5:35:02
 * @version 1.0
 */
public class ObjectInputStreamTest {
	@SuppressWarnings("unchecked")
	public static void main(String[] args) {
		//���������л�����
		ObjectInputStream ois = null;
		try {
			//�����ֽ�����������
			FileInputStream fis = new FileInputStream("C:\\obj.txt");
			ois = new ObjectInputStream(fis);
			//��ȡ����,�����л�
			Object obj=ois.readObject();
			if(obj instanceof List){
				List<Student> list = (ArrayList<Student>)obj;
				//�������
				for(Student stu : list){
					System.out.println(stu.getName()+"\t"+stu.getAge());
				}
			}
			System.out.println("�����л����...");
		}catch (FileNotFoundException e) {
			e.printStackTrace();
		}catch (IOException e) {
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}finally{
			//�ͷ���Դ
			try {
				if(ois !=null){
					ois.close();
				}
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}
}
