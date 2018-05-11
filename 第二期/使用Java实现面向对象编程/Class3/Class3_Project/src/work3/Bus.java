package work3;

/**
 * 客车类
 * @author Administrator
 *
 */
public class Bus extends MotoVehicle {
	private String seatCount;		//座位数

	public Bus(String no, String brand, String seatCount) {
		super(no, brand);
		this.seatCount = seatCount;
	}

	public String getSeatCount() {
		return seatCount;
	}

	public void calRent(int days){
		System.out.println("顾客您好！您需要支付的费用是：");
	}
	
}
