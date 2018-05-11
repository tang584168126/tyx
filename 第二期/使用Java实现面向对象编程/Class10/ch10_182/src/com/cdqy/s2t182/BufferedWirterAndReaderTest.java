package com.cdqy.s2t182;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

/**
 * ָ����ϰ
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-23 ����4:25:43
 * @version 1.0
 */
public class BufferedWirterAndReaderTest {

	public static void main(String[] args) {
		//��
		BufferedReader br = null;
		BufferedWriter bw = null;
		try {
			br = new BufferedReader(new FileReader("c:/test.txt"));
			//String str = br.readLine();
			String str=null;
			StringBuffer sbf = new StringBuffer();
			while((str =br.readLine())!=null){
				sbf.append(str);
			}
			String newStr = sbf.toString().replace("{name}", "С��");
			newStr = newStr.replace("{strain}", "����");
			newStr= newStr.replace("{master}", "����");
			bw = new BufferedWriter(new FileWriter("c:\\tt.txt"));
			bw.write(newStr);
			bw.flush();
			System.out.println("���");
			
		} catch (Exception e) {
			e.printStackTrace();
		}finally{
			if(bw!=null){
				try {
					bw.close();
					if(br!=null){
						br.close();
					}
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
		}
		//�滻
		//д
	}

}
