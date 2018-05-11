package exam.test;

import java.util.Scanner;

import exam.dao.carDao;
import exam.dao.impl.carDaoImpl;
import exam.entity.Car;

/**
 * ������
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		carDao dao = new carDaoImpl();
		System.out.println("��¼��������˰���밴��ʾ¼�������Ϣ:");
		System.out.print("�����복�����֤����(18λ)��");
		String cardId = sc.next();
		System.out.print("\n�����복��ʶ����(17λ)��");
		String id = sc.next();
		System.out.print("\n�����복��������");
		double coefficient = sc.nextDouble();
		System.out.print("\n������ٷ�ָ���ۣ�");
		double price = sc.nextDouble();
		System.out.print("\n�����뷢Ʊ�۸�");
		double money = sc.nextDouble();
		
		Car car = new Car(cardId, id, price, money, coefficient);
		int result = dao.add(car);
		if(result > 0){
			System.out.print("\n���ݱ���ɹ�����������˰Ϊ" + car.getXmoney());
		}else{
			System.out.println("\n���ݱ���ʧ�ܣ�");
		}
		
	}
}
