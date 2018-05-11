package com.cdqy.s2t182;

import java.io.File;
import java.io.IOException;

/**
 * 演示File类的使用
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-21 上午11:15:08
 * @version 1.0
 */
public class FileTest {

	public static void main(String[] args) {
		//创建文件对象
		File file = new File("c:\\test.txt");
		//判断是否存在
		if(file.exists()){
			//存在
			//获取名称
			String name = file.getName();
			//获取大小
			long size = file.length();
			System.out.println("文件的名称:"+name);
			System.out.println("文件大小:"+size);
		}else{
			//新建一个文件
			try {
				file.createNewFile();
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}

}
