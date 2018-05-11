package com.cdqy.s2t182;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

/**
 * 演示字节流的输出流(写)
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-21 下午12:13:06
 * @version 1.0
 */
public class FileOutputStreamTest {

	public static void main(String[] args) {
		writeByByteArray();
	}
	/**
	 * 通过字节数组写数据
	 */
	public static void writeByByteArray(){
		//创建字节输出流对象
		FileOutputStream fos = null;
		try {
			fos = new FileOutputStream("c:/test.txt",true);
			String str ="好好学习";
			//将字符串转成字节数组
			byte[] bytes = str.getBytes();
			fos.write(bytes);
			fos.flush();
			System.out.println("写入成功...");
		} catch (Exception e) {
			e.printStackTrace();
		}finally{
			if(fos!=null){
				try {
					fos.close();
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
		}
		
	}
}
