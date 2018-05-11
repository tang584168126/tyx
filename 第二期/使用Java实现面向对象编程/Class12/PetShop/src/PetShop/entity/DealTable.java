package PetShop.entity;

/**
 * 交易记录实体类
 * @author Administrator
 *
 */
public class DealTable {
	//交易记录编号
	private int id;
	//交易类型
	private int dealType;
	//宠物编号
	private int petID;
	//卖家编号
	private String sellerID;
	//买家编号
	private String buyerID;
	//交易价格
	private int price;
	//交易时间
	private String dealTime;
	
	public int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	public int getDealType() {
		return dealType;
	}
	public void setDealType(int dealType) {
		this.dealType = dealType;
	}
	public int getPetID() {
		return petID;
	}
	public void setPetID(int petID) {
		this.petID = petID;
	}
	public String getSellerID() {
		return sellerID;
	}
	public void setSellerID(String sellerID) {
		this.sellerID = sellerID;
	}
	public String getBuyerID() {
		return buyerID;
	}
	public void setBuyerID(String buyerID) {
		this.buyerID = buyerID;
	}
	public int getPrice() {
		return price;
	}
	public void setPrice(int price) {
		this.price = price;
	}
	public String getDealTime() {
		return dealTime;
	}
	public void setDealTime(String dealTime) {
		this.dealTime = dealTime;
	}
	
	public DealTable(int id, int dealType, int petID, String sellerID,
			String buyerID, int price, String dealTime) {
		super();
		this.id = id;
		this.dealType = dealType;
		this.petID = petID;
		this.sellerID = sellerID;
		this.buyerID = buyerID;
		this.price = price;
		this.dealTime = dealTime;
	}
}
