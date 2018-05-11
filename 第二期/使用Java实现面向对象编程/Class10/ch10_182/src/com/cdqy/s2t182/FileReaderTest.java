package com.cdqy.s2t182;

import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

/**
 * ��ʾ�ַ�������
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-23 ����3:43:39
 * @version 1.0
 */
public class FileReaderTest {

	public static void main(String[] args) {
		FileReader fr = null;
		try {
			fr = new FileReader("C:\\test.txt");
			char[] chars = new char[1024];
			int len = fr.read(chars);
			StringBuffer  sbf = new StringBuffer(); 
			while(len != -1){
				sbf.append(chars);
				len = fr.read(chars);
			}
			System.out.println(sbf.toString());
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}finally{
			if(fr!=null){
				try {
					fr.close();
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
		}
	}

}
