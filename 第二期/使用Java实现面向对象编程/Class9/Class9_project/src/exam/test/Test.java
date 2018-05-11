package exam.test;

import java.util.Scanner;

import exam.dao.carDao;
import exam.dao.impl.carDaoImpl;
import exam.entity.Car;

/**
 * 测试类
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		carDao dao = new carDaoImpl();
		System.out.println("记录车辆购置税，请按提示录入相关信息:");
		System.out.print("请输入车主身份证号码(18位)：");
		String cardId = sc.next();
		System.out.print("\n请输入车辆识别码(17位)：");
		String id = sc.next();
		System.out.print("\n请输入车辆排量：");
		double coefficient = sc.nextDouble();
		System.out.print("\n请输入官方指导价：");
		double price = sc.nextDouble();
		System.out.print("\n请输入发票价格：");
		double money = sc.nextDouble();
		
		Car car = new Car(cardId, id, price, money, coefficient);
		int result = dao.add(car);
		if(result > 0){
			System.out.print("\n数据保存成功，车辆购置税为" + car.getXmoney());
		}else{
			System.out.println("\n数据保存失败！");
		}
		
	}
}
