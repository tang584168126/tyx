package com.cdqy.s2t182;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;
import java.io.ObjectOutputStream;
import java.io.OutputStream;
import java.util.ArrayList;
import java.util.List;

/**
 * 演示序列化操作
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-23 下午5:35:19
 * @version 1.0
 */
public class ObjectOutputStreamTest {
	public static void main(String[] args) {
		ObjectOutputStream oos =null;
		try {
			OutputStream os = new FileOutputStream("C:/obj.txt");
			oos = new ObjectOutputStream(os);
			Student stu1 = new Student("张三",18);
			Student stu2 = new Student("lisi",20);
			//使用泛型集合
			List<Student> list = new ArrayList<Student>();
			list.add(stu1);
			list.add(stu2);
			//写入对象,序列化
			oos.writeObject(list);
			oos.flush();
			System.out.println("完成序列化操作");
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}finally{
			//释放资源
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
