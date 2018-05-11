package PetShop.business;

import java.util.*;

import PetShop.dao.MasterDao;
import PetShop.dao.PetDao;
import PetShop.dao.ShopDao;
import PetShop.dao.impl.PetDaoImpl;
import PetShop.dao.impl.PetMasterDaoImpl;
import PetShop.dao.impl.ShopDaoImpl;
import PetShop.entity.Master;
import PetShop.entity.Pet;
import PetShop.entity.Shop;

/**
 * 宠物商店业务类
 * 
 * @author Administrator
 * 
 */
public class PetShopManager {
	Scanner input = new Scanner(System.in);

	/**
	 * 加载数据
	 */
	public void list() {
		// 创建宠物集合
		List<Pet> lp = new ArrayList<Pet>();
		// 设置宠物实现类对象
		PetDao pd = new PetDaoImpl();
		System.out.println("Wonderland苏醒，所有宠物从SQLserver中醒来");
		System.out.println("******************************************");
		// 接受所有宠物
		lp = pd.select();
		System.out.println("序号\t\t宠物名称");
		// 循环读取宠物信息
		for (int i = 0; i < lp.size(); i++) {
			System.out
					.println(lp.get(i).getId() + "\t\t" + lp.get(i).getName());
		}
		System.out.println("*******************************************\n");

		// 创建主人集合
		List<Master> lp1 = new ArrayList<Master>();
		// 设置实现类对象
		MasterDao pd1 = new PetMasterDaoImpl();
		System.out.println("所有宠物主人从SQLserver中醒来");
		System.out.println("******************************************");
		// 利用集合接受所有主人信息
		lp1 = pd1.getPetOwner();
		System.out.println("序号\t\t主人姓名");
		// 循环读取主人信息
		for (int j = 0; j < lp1.size(); j++) {
			System.out.println(lp1.get(j).getId() + "\t\t"
					+ lp1.get(j).getName());
		}
		System.out.println("*******************************************\n");

		// 创建商店集合
		List<Shop> lp2 = new ArrayList<Shop>();
		// 设置实现类对象
		ShopDao pd2 = new ShopDaoImpl();
		System.out.println("所有宠物商店从SQLserver中醒来");
		System.out.println("******************************************");
		// 利用集合接受所有主人信息
		lp2 = pd2.getShop();
		System.out.println("序号\t\t主人姓名");
		// 循环读取主人信息
		for (int j = 0; j < lp2.size(); j++) {
			System.out.println(lp2.get(j).getId() + "\t\t"
					+ lp2.get(j).getName());
		}
		System.out.println("*******************************************\n");
	}

	/**
	 * 登录
	 */
	public void login() {
		
		//数据加载
		list();
		
		System.out.println("******************欢迎光临宠物乐园******************\n");
		try {
			System.out.println("请选择登陆方式：1.主人登陆；2.商店登陆；3.注册；4.退出");
			int num = input.nextInt();
			switch (num) {
			case 1:
				masterLogin();
				break;
			case 2:
				shopLogin();
				break;
			case 3:
				
				break;
			case 4:
				System.out.println("退出成功!谢谢使用，欢迎下次再来！");
				System.exit(1);
				break;
			default:
				System.out.println("输入错误，请重新输入！");
				break;
			}
		} catch (Exception e) {
			System.out.println("请输入正确的数字！");
		}
	}

	/**
	 * 主人登陆
	 */
	public void masterLogin() {
		MasterDao dao = new PetMasterDaoImpl();
		System.out.print("请输入ID：");
		String id = input.next();
		System.out.print("请输入密码：");
		String password = input.next();

		Master master = new Master(id, password, null, 0);
		if (dao.MasterQuery(master) != null) {
			System.out.println("******************登录成功******************");
			System.out.println("您的基本信息：");
			System.out.println("姓名\t\t余额");
			System.out.println(dao.MasterQuery(master).getName() + "\t\t"
					+ dao.MasterQuery(master).getMoney());
		} else {
			System.out.println("登录失败。。。。。。");
		}
	}

	/**
	 * 商店登陆
	 */
	public void shopLogin() {
		ShopDao dao1 = new ShopDaoImpl();
		System.out.print("请输入ID：");
		String id1 = input.next();
		System.out.print("请输入密码：");
		String password1 = input.next();

		Shop shop = new Shop(id1, password1, null, 0);
		if (dao1.ShopQuery(shop) != null) {
			System.out.println("******************登录成功******************");
			System.out.println("您的基本信息：");
			System.out.println("名称\t\t结余");
			System.out.println(dao1.ShopQuery(shop).getName() + "\t\t"
					+ dao1.ShopQuery(shop).getBalance());
			petAdd(id1);
		} else {
			System.out.println("登录失败。。。。。。");
		}
	}

	/**
	 * 培育新宠物
	 * 
	 * @param str
	 */
	public void petAdd(String str) {
		System.out.print("请输入宠物的名称：");
		String name = input.next();
		System.out.print("请输入宠物的类型：");
		String type = input.next();
		System.out.print("请输入宠物的价格：");
		int price = input.nextInt();

		PetDao dao = new PetDaoImpl();

		Pet pet = new Pet(0, name, type, 0, 0, price, str, 0);
		int result = dao.PetAdd(pet);
		if (result > 0) {
			System.out.println("成功");
		} else {
			System.out.println("失败");
		}
	}
}
