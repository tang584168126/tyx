package com.cdqy.s2t182;

import java.io.BufferedReader;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.IOException;

/**
 * 高效字符输入流
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-23 下午3:55:04
 * @version 1.0
 */
public class BufferedReaderTest {

	public static void main(String[] args) {
		BufferedReader br = null;
		FileReader fr = null;
		try {
			fr = new FileReader("c:\\test.txt");
			br = new BufferedReader(fr);
			String str = br.readLine();
			while(str!=null){
				System.out.println(str);
				str = br.readLine();
			}
			System.out.println("读取完毕...");
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}finally{
			if(fr!=null){
				if(br!=null){
					try {
						br.close();
						fr.close();
					} catch (IOException e) {
						e.printStackTrace();
					}
					
				}
			}
		}
	}

}
