package com.cdqy.s2t182;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

/**
 * 指导练习
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-23 下午4:25:43
 * @version 1.0
 */
public class BufferedWirterAndReaderTest {

	public static void main(String[] args) {
		//读
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
			String newStr = sbf.toString().replace("{name}", "小黑");
			newStr = newStr.replace("{strain}", "土狗");
			newStr= newStr.replace("{master}", "老王");
			bw = new BufferedWriter(new FileWriter("c:\\tt.txt"));
			bw.write(newStr);
			bw.flush();
			System.out.println("完毕");
			
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
		//替换
		//写
	}

}
