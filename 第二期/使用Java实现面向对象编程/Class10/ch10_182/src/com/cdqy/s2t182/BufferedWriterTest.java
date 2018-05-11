package com.cdqy.s2t182;

import java.io.BufferedWriter;
import java.io.FileWriter;
import java.io.IOException;

public class BufferedWriterTest {

	public static void main(String[] args) {
		BufferedWriter bw = null;
		FileWriter fw = null;
		try {
			fw = new FileWriter("c:\\test.txt",true);
			bw = new BufferedWriter(fw);
			String str = "好好学习";
			bw.write(str);
			bw.flush();
			System.out.println("写完...");
		} catch (IOException e) {
			e.printStackTrace();
		}finally{
			if(fw!=null){
				if(bw!=null){
					try {
						bw.close();
						fw.close();
					} catch (IOException e) {
						e.printStackTrace();
					}
					
				}
			}
		}
	}

}
