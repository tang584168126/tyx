package com.cdqy.s2t182;

import java.io.FileWriter;
import java.io.IOException;

/**
 * FileWirter��ʹ��
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-23 ����4:03:46
 * @version 1.0
 */
public class FileWriterTest {

	public static void main(String[] args) {
		FileWriter fw = null;
		try {
			fw  =new FileWriter("c:\\test.txt",true);
			String str = "\nhello";
			fw.write(str);
			fw.flush();
			System.out.println("���ļ���д�������...");
		} catch (IOException e) {
			e.printStackTrace();
		}finally{
			if(fw!=null){
				try {
					fw.close();
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
		}
	}

}
