package com.cdqy.s2t182;

import com.cdqy.s2t182.dao.DogDao;
import com.cdqy.s2t182.dao.impl.DogDaoImpl;
import com.cdqy.s2t182.entity.Dog;

/**
 * ������
 * 
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-19 ����4:24:50
 * @version 1.0
 */
public class Test {

	public static void main(String[] args) {
		// Dog dog = new Dog(7, "�Ϻ�", 90, 10, "����");
		DogDao dao = new DogDaoImpl();
		/*
		 * int result = dao.update(dog); if (result > 0) {
		 * System.out.println("�޸ĳɹ�"); } else { System.out.println("�޸�ʧ��"); }
		 */
		/*
		 * Dog dog = new Dog(0,"С��",80,80,"����Ȯ"); int result = dao.save(dog);
		 * if(result > 0){ System.out.println("����OK"); }else{
		 * System.out.println(" add fail..."); }
		 */
		Dog dog = new Dog(7, "���Ϻ�", 10, 10, "������");
		int result = dao.update(dog);
		if (result > 0) {
			System.out.println("�޸ĳɹ�");
		} else {
			System.out.println("�޸�ʧ��");
		}
	}

}
