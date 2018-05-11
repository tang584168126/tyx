package com.cdqy.s2t182;

import java.io.FileWriter;
import java.io.IOException;

/**
 * FileWirter的使用
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-23 下午4:03:46
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
			System.out.println("向文件中写数据完毕...");
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
