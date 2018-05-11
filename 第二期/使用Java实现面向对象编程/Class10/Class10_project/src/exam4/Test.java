package exam4;

import java.io.DataInputStream;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;

public class Test {
	public static void main(String[] args) {
		//二进制输入流
		DataInputStream dis = null;
		
		try {
			dis = new DataInputStream(new FileInputStream("C:\\Windows\\win.ini"));
			byte[] bytes = new byte[1024];
			int len = dis.read(bytes);
			while(len != -1){
				System.out.println(bytes);
				len = dis.read(bytes);
			}
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}
		
	}
}
