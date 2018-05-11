package com.cdqy.s2t182;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.util.Scanner;

/**
 * 使用记录的位置进行写入数据,演示任意读写流
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-23 下午5:35:57
 * @version 1.0
 */
public class TestRandomAccessFile {
	public static void main(String[] args) {
		//创建可读可写文件对象
		RandomAccessFile rwf = null;
		//创建可读对象
		RandomAccessFile rf = null;
		try {
			//要写入的文件,rw代表可读可写
			rwf = new RandomAccessFile("C:Test1.txt","rw");
			//要读取的文件,r代表读
			rf = new RandomAccessFile("C:Test.txt","r");
			//获取已经写入的字节大小,文件中已经保存的字节数
			int pos = (int)rwf.length();
			System.out.println(pos);
			//获取需要读取的文件的字节大小
			int rLen = (int)rf.length();
			if(pos >= rLen){
				//不能设置文件读取的位置
				System.out.println("不能复制数据...");
				System.exit(1);
			}
			//装数据的字节数组
			byte[] bytes = null;
			//判断需要读取的文件的字节大小
			if(rLen-pos > 1024){
				bytes = new byte[1024];
			}else{
				//字节大小,不够1024
				bytes = new byte[(int)rf.length()-pos];
			}
			//设置开始读取的位置
			rf.seek(pos);
			//设置开始写的位置
			rwf.seek(pos);
			//读取的次数
			int count = 0;
			while((rf.read(bytes))!= -1){
				count ++;
				//输出到控制台
				System.out.println(new String(bytes,0,bytes.length));
				rwf.write(bytes,0,bytes.length);
			}
			System.out.println("读取文件的次数:"+count);
		} catch (FileNotFoundException e) {
			e.printStackTrace();
		} catch (IOException e) {
			e.printStackTrace();
		}finally{
			try {
				if(rwf != null){
					rwf.close();
				}
				if(rf !=null){
					rf.close();
				}
			} catch (IOException e) {
				e.printStackTrace();
			}
		}
	}
}
