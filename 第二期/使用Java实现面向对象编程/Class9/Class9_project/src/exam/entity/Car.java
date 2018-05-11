package exam.entity;
/**
 * 车类
 * @author Administrator
 *
 */
public class Car {
	private String cardId;		//身份证
	private String dateTime;	//购车时间
	private String id;			//车辆识别码
	private String strain;	//车型
	private double price;		//官方指导价
	private double money;		//发票价格
	private double coefficient;		//排量
	private double xmoney;		//购置税
	
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
