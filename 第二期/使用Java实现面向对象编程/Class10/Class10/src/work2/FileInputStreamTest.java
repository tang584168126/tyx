package work2;

import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;

public class FileInputStreamTest {
	public static void main(String[] args) throws IOException {
		FileInputStream fis = null;
		
		try {
			fis = new FileInputStream("E:\\����\\�ڶ���\\ʹ��Javaʵ�����������\\Class10\\myDoc\\hello.txt");
			int data;
			System.out.println("�ɶ�ȡ���ֽ�����" + fis.available());
			System.out.print ("�ļ�����Ϊ��");
			while((data=fis.read()) != -1){
				System.out.print(data + " ");
			}
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}catch(IOException e){
			e.printStackTrace();
		}finally{
			try {
				if(fis != null){
					fis.close();
				}
			} catch (IOException e2) {
				// TODO: handle exception
				e2.printStackTrace();
			}
		}
	}
	
}
