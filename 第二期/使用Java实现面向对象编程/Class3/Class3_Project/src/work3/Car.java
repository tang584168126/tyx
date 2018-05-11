package work3;

/**
 * 轿车类
 * @author Administrator
 *
 */
public class Car extends MotoVehicle {
	private String type;		//型号

	public String getType() {
		return type;
	}

	public Car(String no, String brand, String type) {
		super(no, brand);
		this.type = type;
	}

	public void calRent(int days){
		System.out.println("顾客您好！您需要支付的费用是：");
	}
}
