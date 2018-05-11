package work1;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

/**
 *���ļ������ӣ����롢���
 * @author Administrator
 *
 */
public class ShowFile {
	/**
	 * �������ļ��ķ���
	 */
	public void create(File file){
		if(!file.exists()){
			try {
				file.createNewFile();
				System.out.println("�����ɹ���");
			} catch (IOException e) {
				e.printStackTrace();
			}
		}else{
			System.out.println("�Ѵ��ڸ��ļ���");
		}
	}
	
	/**
	 * ��ʾ�ļ���Ϣ
	 */
	public void show(File file){
		if(file.exists()){
			if(file.isFile()){
				System.out.println("���ƣ�" + file.getName());
				System.out.println("·����" + file.getPath());
				System.out.println("�ļ���С��" + file.length() + "�ֽ�");
			}
		}
	}
	
	/**
	 * ͨ���ֽ�����д����
	 */
	 public void Output(File file,String str){
		 FileOutputStream fos = null;
		 
		 try {
			fos = new FileOutputStream(file);
			
			//���ַ���ת��Ϊ�ֽ�����
			byte[] bytes = str.getBytes();
			fos.write(bytes);
			fos.flush();
			System.out.println("д��ɹ���");
		} catch (Exception e) {
			e.printStackTrace();
		}finally{
			if(fos != null){
				try {
					fos.close();
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
		}
	 }
	 
	 /**
	  * ��ȡ�ֽ����鷵���ַ���
	  */
	 public String Input(File file){
		 FileInputStream fis = null;
		 
		 try {
			fis = new FileInputStream(file);
			
			//�����ֽ�����
			byte[] bytes = new byte[1024];
			String str = null;
			//��ȡ�ֽڷ���int
			while(fis.read() != -1){
				str = new String(bytes);
				System.out.println(str);
				fis.read(bytes);
			}
			return str;
		} catch (Exception e) {
			e.printStackTrace();
		}finally{
			if(fis != null){
				try {
					fis.close();
				} catch (IOException e) {
					e.printStackTrace();
				}
			}
		}
		return null;
		 
	 }
}
