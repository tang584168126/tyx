package com.cdqy;

import java.util.Scanner;

import com.cdqy.dao.MasterDao;
import com.cdqy.dao.PetDao;
import com.cdqy.dao.impl.MasterDaoImpl;
import com.cdqy.dao.impl.PetDaoImpl;
import com.cdqy.entity.Master;

/**
 * ������
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		MasterDao dao = new MasterDaoImpl();
		PetDao petDao = new PetDaoImpl();
		Scanner sc = new Scanner(System.in);
		
		System.out.println("---- ��ӭ���ٳ�����԰ ----");
		System.out.print("�������¼��:");
		String loginid = sc.next();
		
		System.out.println("����������:");
		String password = sc.next();
		
		Master master = new Master(loginid, password);
		
		int result = dao.login(master);
		
		if(result > 0){
			System.out.println("��¼�ɹ���");
		}else{
			System.out.println("�û�����������󣬵�¼ʧ��");
		}
		
		System.out.println("��ѡ��������ͣ�");
		petDao.strain();
		
		//���������������
		String type = sc.next();
		
		petDao.type(type);
		
		System.out.print("����������ǳƣ�");
		String name = sc.next();
		petDao.add(name);
		System.out.println("�����ɹ���");
		
	}
}
