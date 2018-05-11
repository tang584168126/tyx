package com.cdqy.s2t182;

import com.cdqy.s2t182.dao.DogDao;
import com.cdqy.s2t182.dao.impl.DogDaoImpl;
import com.cdqy.s2t182.entity.Dog;

/**
 * 测试类
 * 
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-19 下午4:24:50
 * @version 1.0
 */
public class Test {

	public static void main(String[] args) {
		// Dog dog = new Dog(7, "老黑", 90, 10, "土狗");
		DogDao dao = new DogDaoImpl();
		/*
		 * int result = dao.update(dog); if (result > 0) {
		 * System.out.println("修改成功"); } else { System.out.println("修改失败"); }
		 */
		/*
		 * Dog dog = new Dog(0,"小花",80,80,"腊肠犬"); int result = dao.save(dog);
		 * if(result > 0){ System.out.println("增加OK"); }else{
		 * System.out.println(" add fail..."); }
		 */
		Dog dog = new Dog(7, "老老黑", 10, 10, "老土狗");
		int result = dao.update(dog);
		if (result > 0) {
			System.out.println("修改成功");
		} else {
			System.out.println("修改失败");
		}
	}

}
