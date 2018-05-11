package com.cdqy.s2t182;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

public class DataInputAndOutputTest {

	/**
	 *
	 */
	public static void main(String[] args) {
		//二进制输入流
		DataInputStream dis = null;
		//二进制输出流
		DataOutputStream dos = null;
		try {
			dis = new DataInputStream(new FileInputStream("c:/dd_scroll_6.jpg"));
			dos = new DataOutputStream(new FileOutputStream("c:/demo.png"));
			byte[] bytes = new byte[1024];
			int len = dis.read(bytes);
			while(len!=-1){
				dos.write(bytes);
				len = dis.read(bytes);
			}
			System.out.println("复制完成...");
		} catch (Exception e) {
			e.printStackTrace();
		}finally{
			try {
				if(dos!=null){dos.close();}
				if(dis!=null){dis.close();}
			} catch (IOException e) {
				e.printStackTrace();
			}
			
		}
	}

}
