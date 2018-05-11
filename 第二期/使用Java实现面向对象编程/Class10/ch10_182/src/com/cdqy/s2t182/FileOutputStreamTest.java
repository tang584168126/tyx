package com.cdqy.s2t182;

import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

/**
 * ��ʾ�ֽ����������(д)
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-21 ����12:13:06
 * @version 1.0
 */
public class FileOutputStreamTest {

	public static void main(String[] args) {
		writeByByteArray();
	}
	/**
	 * ͨ���ֽ�����д����
	 */
	public static void writeByByteArray(){
		//�����ֽ����������
		FileOutputStream fos = null;
		try {
			fos = new FileOutputStream("c:/test.txt",true);
			String str ="�ú�ѧϰ";
			//���ַ���ת���ֽ�����
			byte[] bytes = str.getBytes();
			fos.write(bytes);
			fos.flush();
			System.out.println("д��ɹ�...");
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
