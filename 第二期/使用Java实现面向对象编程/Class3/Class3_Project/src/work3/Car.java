package work3;

/**
 * �γ���
 * @author Administrator
 *
 */
public class Car extends MotoVehicle {
	private String type;		//�ͺ�

	public String getType() {
		return type;
	}

	public Car(String no, String brand, String type) {
		super(no, brand);
		this.type = type;
	}

	public void calRent(int days){
		System.out.println("�˿����ã�����Ҫ֧���ķ����ǣ�");
	}
}
