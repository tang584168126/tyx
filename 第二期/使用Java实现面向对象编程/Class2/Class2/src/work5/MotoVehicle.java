package work5;

/**
 * ����
 * @author Administrator
 *
 */
public abstract class MotoVehicle {
	private String no;		//���ƺ�
	private String brand;	//Ʒ��
	
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

	//�������
	public abstract void calRent(int day);
}
