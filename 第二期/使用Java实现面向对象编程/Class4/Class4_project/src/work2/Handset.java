package work2;

/**
 * �ֻ���
 * @author Administrator
 *
 */
public abstract class Handset {
	protected String brand;		//Ʒ��
	protected String type;		//�ͺ�
	
	public Handset(String brand,String type){
		this.brand = brand;
		this.type = type;
	}
	
	public abstract void print();
}
