package work1;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileOutputStream;
import java.io.IOException;

/**
 *对文件的增加，输入、输出
 * @author Administrator
 *
 */
public class ShowFile {
	/**
	 * 创建新文件的方法
	 */
	public void create(File file){
		if(!file.exists()){
			try {
				file.createNewFile();
				System.out.println("创建成功！");
			} catch (IOException e) {
				e.printStackTrace();
			}
		}else{
			System.out.println("已存在该文件！");
		}
	}
	
	/**
	 * 显示文件信息
	 */
	public void show(File file){
		if(file.exists()){
			if(file.isFile()){
				System.out.println("名称：" + file.getName());
				System.out.println("路径：" + file.getPath());
				System.out.println("文件大小：" + file.length() + "字节");
			}
		}
	}
	
	/**
	 * 通过字节数组写数据
	 */
	 public void Output(File file,String str){
		 FileOutputStream fos = null;
		 
		 try {
			fos = new FileOutputStream(file);
			
			//将字符串转换为字节数组
			byte[] bytes = str.getBytes();
			fos.write(bytes);
			fos.flush();
			System.out.println("写入成功！");
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
	  * 读取字节数组返回字符串
	  */
	 public String Input(File file){
		 FileInputStream fis = null;
		 
		 try {
			fis = new FileInputStream(file);
			
			//定义字节数组
			byte[] bytes = new byte[1024];
			String str = null;
			//读取字节返回int
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
