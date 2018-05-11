package com.cdqy.s2t182;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.ObjectInputStream;
import java.util.ArrayList;
import java.util.List;

/**
 * 演示反序列化操作
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-23 下午5:35:02
 * @version 1.0
 */
public class ObjectInputStreamTest {
	@SuppressWarnings("unchecked")
	public static void main(String[] args) {
		//创建反序列化对象
		ObjectInputStream ois = null;
		try {
			//创建字节输入流对象
			FileInputStream fis = new FileInputStream("C:\\obj.txt");
			ois = new ObjectInputStream(fis);
			//读取对象,反序列化
			Object obj=ois.readObject();
			if(obj instanceof List){
				List<Student> list = (ArrayList<Student>)obj;
				//遍历输出
				for(Student stu : list){
					System.out.println(stu.getName()+"\t"+stu.getAge());
				}
			}
			System.out.println("反序列化完毕...");
		}catch (FileNotFoundException e) {
			e.printStackTrace();
		}catch (IOException e) {
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}finally{
			//释放资源
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
