package com.cdqy.s2t182;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;

/**
 * ��ʾ�ļ���������(��)
 * 
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-21 ����11:52:39
 * @version 1.0
 */
public class FileInputStreamTest {

	public static void main(String[] args) {
		//readByByte();
		readByByteArray();
	}

	/**
	 * ��ȡ�ֽ�����
	 */
	public static void readByByteArray() {
		// ��������������
		FileInputStream fis = null;
		try {
			fis = new FileInputStream("c:/test.txt");
			// ��С
			int size = fis.available();
			System.out.println("��С:" + size);
			//�����ֽ�����,������
			byte[] chars = new byte[1024];
			// ��ȡ�ֽڷ��ص���int
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
					System.out.println("�ر����ɹ�");
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
		}
	}

	/**
	 * ��ȡ�����ֽ�
	 */
	public static void readByByte() {
		// ��������������
		FileInputStream fis = null;
		try {
			fis = new FileInputStream("c:/test.txt");
			// ��С
			int size = fis.available();
			System.out.println("��С:" + size);
			// ��ȡ�ֽڷ��ص���int
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
					System.out.println("�ر����ɹ�");
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
		}
	}

}
