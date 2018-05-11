package work5;

/**
 * ΩŒ≥µ¿‡
 * @author Administrator
 *
 */
public class Car extends MotoVehicle {
	private String type;		//–Õ∫≈

	public String getType() {
		return type;
	}

	public Car(String no, String brand, String type) {
		super(no, brand);
		this.type = type;
	}

	public void calRent(int day){
		System.out.println("");
	}
}
