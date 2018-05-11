package com.cdqy.demo3;
/**
 * 演示抛出异常 throw的使用
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-12 下午3:04:07
 * @version 1.0
 */
public class ExceptionTest {

	public static void main(String[] args) throws Exception  {
		int age  = 150;
		if(age >=0 && age <=120){
			System.out.println("正常...");
		}else{
			throw new MyExeption("年龄不合法...");
		}
		
	}
	
}
/**
 * 自定义的异常
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-12 下午3:08:16
 * @version 1.0
 */
class MyExeption extends Exception{
	public MyExeption(String msg){
		super(msg);
	}
}
