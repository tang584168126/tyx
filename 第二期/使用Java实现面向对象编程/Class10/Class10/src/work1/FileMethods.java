package work1;

import java.io.File;

public class FileMethods {
	/**
	 * ��ʾ�ļ���Ϣ
	 */
	public void showFileInfo(File file){
		if(file.exists()){
			if(file.isFile()){
				System.out.println("���ƣ�" + file.getName());
				System.out.println("���·����" + file.getPath());
				System.out.println("����·����" + file.getAbsolutePath());
				System.out.println("�ļ���С��" + file.length() + "�ֽ�");
			}
			if(file.isDirectory()){
				System.out.println("���ļ���Ŀ¼");
			}
		}else{
			System.out.println("�ļ�������");
		}
	}
	
	public static void main(String[] args) {
		FileMethods fm = new FileMethods();
		File file = new File("E:\\����\\�ڶ���\\ʹ��Javaʵ�����������\\Class10\\myDoc\\hello.txt");
		fm.showFileInfo(file);
	}
}
