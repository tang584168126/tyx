package com.cdqy.s2t182;

import java.io.File;
import java.io.IOException;

/**
 * ��ʾFile���ʹ��
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-21 ����11:15:08
 * @version 1.0
 */
public class FileTest {

	public static void main(String[] args) {
		//�����ļ�����
		File file = new File("c:\\test.txt");
		//�ж��Ƿ����
		if(file.exists()){
			//����
			//��ȡ����
			String name = file.getName();
			//��ȡ��С
			long size = file.length();
			System.out.println("�ļ�������:"+name);
			System.out.println("�ļ���С:"+size);
		}else{
			//�½�һ���ļ�
			try {
				file.createNewFile();
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}

}
