package exam.entity;
/**
 * ����
 * @author Administrator
 *
 */
public class Car {
	private String cardId;		//���֤
	private String dateTime;	//����ʱ��
	private String id;			//����ʶ����
	private String strain;	//����
	private double price;		//�ٷ�ָ����
	private double money;		//��Ʊ�۸�
	private double coefficient;		//����
	private double xmoney;		//����˰
	
	public double getXmoney() {
		return xmoney;
	}
	public void setXmoney(double xmoney) {
		this.xmoney = xmoney;
	}
	public void setPrice(double price) {
		this.price = price;
	}
	public Car(String cardId, String id, 
			double price, double money, double coefficient) {
		super();
		this.cardId = cardId;
		this.id = id;
		this.price = price;
		this.money = money;
		this.coefficient = coefficient;
	}
	public double getCoefficient() {
		return coefficient;
	}
	public void setCoefficient(double coefficient) {
		this.coefficient = coefficient;
	}
	public String getCardId() {
		return cardId;
	}
	public void setCardId(String cardId) {
		this.cardId = cardId;
	}
	public String getDateTime() {
		return dateTime;
	}
	public void setDateTime(String dateTime) {
		this.dateTime = dateTime;
	}
	public String getId() {
		return id;
	}
	public void setId(String id) {
		this.id = id;
	}
	public String getStrain() {
		return strain;
	}
	public void setStrain(String strain) {
		this.strain = strain;
	}
	public double getPrice() {
		return price;
	}
	public void setPrive(double price) {
		this.price = price;
	}
	public double getMoney() {
		return money;
	}
	public void setMoney(double money) {
		this.money = money;
	}
	
}
