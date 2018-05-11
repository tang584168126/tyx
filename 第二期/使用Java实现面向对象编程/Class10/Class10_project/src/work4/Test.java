package work4;

import java.io.DataInputStream;
import java.io.DataOutputStream;
import java.io.FileInputStream;
import java.io.FileOutputStream;

public class Test {
	public static void main(String[] args) {
		//������������
		DataInputStream dis = null;
		//�����������
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
			System.out.println("���Ƴɹ���");
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
