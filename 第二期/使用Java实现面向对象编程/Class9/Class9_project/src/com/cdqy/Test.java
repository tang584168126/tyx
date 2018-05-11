package com.cdqy;

import java.util.Scanner;

import com.cdqy.dao.MasterDao;
import com.cdqy.dao.PetDao;
import com.cdqy.dao.impl.MasterDaoImpl;
import com.cdqy.dao.impl.PetDaoImpl;
import com.cdqy.entity.Master;

/**
 * 测试类
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		MasterDao dao = new MasterDaoImpl();
		PetDao petDao = new PetDaoImpl();
		Scanner sc = new Scanner(System.in);
		
		System.out.println("---- 欢迎光临宠物乐园 ----");
		System.out.print("请输入登录名:");
		String loginid = sc.next();
		
		System.out.println("请输入密码:");
		String password = sc.next();
		
		Master master = new Master(loginid, password);
		
		int result = dao.login(master);
		
		if(result > 0){
			System.out.println("登录成功！");
		}else{
			System.out.println("用户名或密码错误，登录失败");
		}
		
		System.out.println("请选择宠物类型：");
		petDao.strain();
		
		//主人输入宠物类型
		String type = sc.next();
		
		petDao.type(type);
		
		System.out.print("请输入宠物昵称：");
		String name = sc.next();
		petDao.add(name);
		System.out.println("领养成功！");
		
	}
}
