package work3;

/**
 * �ͳ���
 * @author Administrator
 *
 */
public class Bus extends MotoVehicle {
	private String seatCount;		//��λ��

	public Bus(String no, String brand, String seatCount) {
		super(no, brand);
		this.seatCount = seatCount;
	}

	public String getSeatCount() {
		return seatCount;
	}

	public void calRent(int days){
		System.out.println("�˿����ã�����Ҫ֧���ķ����ǣ�");
	}
	
}
