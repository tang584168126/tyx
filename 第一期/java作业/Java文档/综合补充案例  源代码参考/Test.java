
package test;

import info.Student;
import info.Subject;

/*
 * 测试类，输出相关测试信息
 * */
public class Test {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//构造专业对象
		Subject one=new Subject();
		one.setSubjectId("001");
		one.setSubjectName("计算机科学与应用");
		
		//构造学生对象
		Student liuXin=new Student();
		liuXin.setStuName("刘新雨");
		liuXin.setStuAge(16);		
		//设置专业属性，学号属性
		liuXin.setMySubject(one);
		liuXin.setStuId("00101");
		//调用学习方法
		liuXin.study();
		System.out.println("===================================");
		
		//构造学生对象
		Student tianMeng=new Student();
		tianMeng.setStuId("00102");
		tianMeng.setStuName("田宝强");
		tianMeng.setStuAge(21);
		tianMeng.setMySubject(one);
		
		//调用学习方法
		tianMeng.study();
		System.out.println("===================================");
		//调用专业的介绍方法*/
		one.info();
		
	}

}
