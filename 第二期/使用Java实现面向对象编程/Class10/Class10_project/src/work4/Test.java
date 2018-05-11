package work4;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.FileInputStream;
import java.io.FileOutputStream;

public class Test {
	public static void main(String[] args) {
		//二进制输入流
		DataInputStream dis = null;
		//二进制输出流
		DataOutputStream dos = null;
		
		try {
			dis = new DataInputStream(new FileInputStream("C:\\top.bmp"));
			dos = new DataOutputStream(new FileOutputStream("D:\\myDoc\\myPicture.bmp"));
			byte[] bytes = new byte[1024];
			int len = dis.read(bytes);
			while(len != -1){
				dos.write(bytes);
				len = dis.read(bytes);
			}
			System.out.println("复制成功！");
		} catch (Exception e) {
			e.printStackTrace();
		}finally{
			try {
				if(dos != null){
					dos.close();
				}
				if(dis != null){
					dis.close();
				}
			} catch (Exception e2) {
				e2.printStackTrace();
			}
		}

	}
}
