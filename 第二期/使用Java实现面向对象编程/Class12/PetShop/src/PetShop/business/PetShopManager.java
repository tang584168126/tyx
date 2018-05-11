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
 * �����̵�ҵ����
 * 
 * @author Administrator
 * 
 */
public class PetShopManager {
	Scanner input = new Scanner(System.in);

	/**
	 * ��������
	 */
	public void list() {
		// �������Ｏ��
		List<Pet> lp = new ArrayList<Pet>();
		// ���ó���ʵ�������
		PetDao pd = new PetDaoImpl();
		System.out.println("Wonderland���ѣ����г����SQLserver������");
		System.out.println("******************************************");
		// �������г���
		lp = pd.select();
		System.out.println("���\t\t��������");
		// ѭ����ȡ������Ϣ
		for (int i = 0; i < lp.size(); i++) {
			System.out
					.println(lp.get(i).getId() + "\t\t" + lp.get(i).getName());
		}
		System.out.println("*******************************************\n");

		// �������˼���
		List<Master> lp1 = new ArrayList<Master>();
		// ����ʵ�������
		MasterDao pd1 = new PetMasterDaoImpl();
		System.out.println("���г������˴�SQLserver������");
		System.out.println("******************************************");
		// ���ü��Ͻ�������������Ϣ
		lp1 = pd1.getPetOwner();
		System.out.println("���\t\t��������");
		// ѭ����ȡ������Ϣ
		for (int j = 0; j < lp1.size(); j++) {
			System.out.println(lp1.get(j).getId() + "\t\t"
					+ lp1.get(j).getName());
		}
		System.out.println("*******************************************\n");

		// �����̵꼯��
		List<Shop> lp2 = new ArrayList<Shop>();
		// ����ʵ�������
		ShopDao pd2 = new ShopDaoImpl();
		System.out.println("���г����̵��SQLserver������");
		System.out.println("******************************************");
		// ���ü��Ͻ�������������Ϣ
		lp2 = pd2.getShop();
		System.out.println("���\t\t��������");
		// ѭ����ȡ������Ϣ
		for (int j = 0; j < lp2.size(); j++) {
			System.out.println(lp2.get(j).getId() + "\t\t"
					+ lp2.get(j).getName());
		}
		System.out.println("*******************************************\n");
	}

	/**
	 * ��¼
	 */
	public void login() {
		
		//���ݼ���
		list();
		
		System.out.println("******************��ӭ���ٳ�����԰******************\n");
		try {
			System.out.println("��ѡ���½��ʽ��1.���˵�½��2.�̵��½��3.ע�᣻4.�˳�");
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
				System.out.println("�˳��ɹ�!ллʹ�ã���ӭ�´�������");
				System.exit(1);
				break;
			default:
				System.out.println("����������������룡");
				break;
			}
		} catch (Exception e) {
			System.out.println("��������ȷ�����֣�");
		}
	}

	/**
	 * ���˵�½
	 */
	public void masterLogin() {
		MasterDao dao = new PetMasterDaoImpl();
		System.out.print("������ID��");
		String id = input.next();
		System.out.print("���������룺");
		String password = input.next();

		Master master = new Master(id, password, null, 0);
		if (dao.MasterQuery(master) != null) {
			System.out.println("******************��¼�ɹ�******************");
			System.out.println("���Ļ�����Ϣ��");
			System.out.println("����\t\t���");
			System.out.println(dao.MasterQuery(master).getName() + "\t\t"
					+ dao.MasterQuery(master).getMoney());
		} else {
			System.out.println("��¼ʧ�ܡ�����������");
		}
	}

	/**
	 * �̵��½
	 */
	public void shopLogin() {
		ShopDao dao1 = new ShopDaoImpl();
		System.out.print("������ID��");
		String id1 = input.next();
		System.out.print("���������룺");
		String password1 = input.next();

		Shop shop = new Shop(id1, password1, null, 0);
		if (dao1.ShopQuery(shop) != null) {
			System.out.println("******************��¼�ɹ�******************");
			System.out.println("���Ļ�����Ϣ��");
			System.out.println("����\t\t����");
			System.out.println(dao1.ShopQuery(shop).getName() + "\t\t"
					+ dao1.ShopQuery(shop).getBalance());
			petAdd(id1);
		} else {
			System.out.println("��¼ʧ�ܡ�����������");
		}
	}

	/**
	 * �����³���
	 * 
	 * @param str
	 */
	public void petAdd(String str) {
		System.out.print("�������������ƣ�");
		String name = input.next();
		System.out.print("�������������ͣ�");
		String type = input.next();
		System.out.print("���������ļ۸�");
		int price = input.nextInt();

		PetDao dao = new PetDaoImpl();

		Pet pet = new Pet(0, name, type, 0, 0, price, str, 0);
		int result = dao.PetAdd(pet);
		if (result > 0) {
			System.out.println("�ɹ�");
		} else {
			System.out.println("ʧ��");
		}
	}
}
