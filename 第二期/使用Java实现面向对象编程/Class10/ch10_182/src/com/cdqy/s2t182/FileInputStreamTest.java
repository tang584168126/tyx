package com.cdqy.s2t182;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;

/**
 * 演示文件的输入流(读)
 * 
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-21 上午11:52:39
 * @version 1.0
 */
public class FileInputStreamTest {

	public static void main(String[] args) {
		//readByByte();
		readByByteArray();
	}

	/**
	 * 读取字节数组
	 */
	public static void readByByteArray() {
		// 创建输入流对象
		FileInputStream fis = null;
		try {
			fis = new FileInputStream("c:/test.txt");
			// 大小
			int size = fis.available();
			System.out.println("大小:" + size);
			//定义字节数组,缓冲区
			byte[] chars = new byte[1024];
			// 读取字节返回的是int
			int ch = fis.read(chars);
			while (ch != -1) {
				String str = new String(chars);
				System.out.println(str);
				ch = fis.read(chars);
			}

			// System.out.println((char)ch);
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			if (fis != null) {
				try {
					fis.close();
					System.out.println("关闭流成功");
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
		}
	}

	/**
	 * 读取单个字节
	 */
	public static void readByByte() {
		// 创建输入流对象
		FileInputStream fis = null;
		try {
			fis = new FileInputStream("c:/test.txt");
			// 大小
			int size = fis.available();
			System.out.println("大小:" + size);
			// 读取字节返回的是int
			int ch = fis.read();
			while (ch != -1) {
				System.out.println(ch);
				ch = fis.read();
			}

			// System.out.println((char)ch);
		} catch (Exception e) {
			e.printStackTrace();
		} finally {
			if (fis != null) {
				try {
					fis.close();
					System.out.println("关闭流成功");
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
		}
	}

}
