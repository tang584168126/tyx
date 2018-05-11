package work1;

import java.io.File;

public class FileMethods {
	/**
	 * 显示文件信息
	 */
	public void showFileInfo(File file){
		if(file.exists()){
			if(file.isFile()){
				System.out.println("名称：" + file.getName());
				System.out.println("相对路径：" + file.getPath());
				System.out.println("绝对路径：" + file.getAbsolutePath());
				System.out.println("文件大小：" + file.length() + "字节");
			}
			if(file.isDirectory()){
				System.out.println("此文件是目录");
			}
		}else{
			System.out.println("文件不存在");
		}
	}
	
	public static void main(String[] args) {
		FileMethods fm = new FileMethods();
		File file = new File("E:\\代码\\第二期\\使用Java实现面向对象编程\\Class10\\myDoc\\hello.txt");
		fm.showFileInfo(file);
	}
}
