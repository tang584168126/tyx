package com.cdqy.demo3;
/**
 * ��ʾ�׳��쳣 throw��ʹ��
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-12 ����3:04:07
 * @version 1.0
 */
public class ExceptionTest {

	public static void main(String[] args) throws Exception  {
		int age  = 150;
		if(age >=0 && age <=120){
			System.out.println("����...");
		}else{
			throw new MyExeption("���䲻�Ϸ�...");
		}
		
	}
	
}
/**
 * �Զ�����쳣
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-12 ����3:08:16
 * @version 1.0
 */
class MyExeption extends Exception{
	public MyExeption(String msg){
		super(msg);
	}
}
