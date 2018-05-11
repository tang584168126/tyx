package com.cdqy.s2t182;

import java.io.FileNotFoundException;
import java.io.IOException;
import java.io.RandomAccessFile;
import java.util.Scanner;

/**
 * ʹ�ü�¼��λ�ý���д������,��ʾ�����д��
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-23 ����5:35:57
 * @version 1.0
 */
public class TestRandomAccessFile {
	public static void main(String[] args) {
		//�����ɶ���д�ļ�����
		RandomAccessFile rwf = null;
		//�����ɶ�����
		RandomAccessFile rf = null;
		try {
			//Ҫд����ļ�,rw����ɶ���д
			rwf = new RandomAccessFile("C:Test1.txt","rw");
			//Ҫ��ȡ���ļ�,r�����
			rf = new RandomAccessFile("C:Test.txt","r");
			//��ȡ�Ѿ�д����ֽڴ�С,�ļ����Ѿ�������ֽ���
			int pos = (int)rwf.length();
			System.out.println(pos);
			//��ȡ��Ҫ��ȡ���ļ����ֽڴ�С
			int rLen = (int)rf.length();
			if(pos >= rLen){
				//���������ļ���ȡ��λ��
				System.out.println("���ܸ�������...");
				System.exit(1);
			}
			//װ���ݵ��ֽ�����
			byte[] bytes = null;
			//�ж���Ҫ��ȡ���ļ����ֽڴ�С
			if(rLen-pos > 1024){
				bytes = new byte[1024];
			}else{
				//�ֽڴ�С,����1024
				bytes = new byte[(int)rf.length()-pos];
			}
			//���ÿ�ʼ��ȡ��λ��
			rf.seek(pos);
			//���ÿ�ʼд��λ��
			rwf.seek(pos);
			//��ȡ�Ĵ���
			int count = 0;
			while((rf.read(bytes))!= -1){
				count ++;
				//���������̨
				System.out.println(new String(bytes,0,bytes.length));
				rwf.write(bytes,0,bytes.length);
			}
			System.out.println("��ȡ�ļ��Ĵ���:"+count);
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
