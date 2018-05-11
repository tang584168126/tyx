package work5;

/**
 * 车类
 * @author Administrator
 *
 */
public abstract class MotoVehicle {
	private String no;		//车牌号
	private String brand;	//品牌
	
	public MotoVehicle(String no, String brand) {
		super();
		this.no = no;
		this.brand = brand;
	}

	public String getNo() {
		return no;
	}

	public String getBrand() {
		return brand;
	}

	//计算租金
	public abstract void calRent(int day);
}
