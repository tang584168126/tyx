package petShop.entity;
import java.util.Date;

	/**
	 * @author 上商店实体类
	 * 
	 */
	public class Account {
		
		public Account(long id, int dealType, long petId, long sellerId,
				long buyerId, double price, Date dealTime) {
			super();
			this.id = id;
			this.dealType = dealType;
			this.petId = petId;
			this.sellerId = sellerId;
			this.buyerId = buyerId;
			this.price = price;
			this.dealTime = dealTime;
		}

		public Account() {
			super();
			// TODO Auto-generated constructor stub
		}
		//编号
		private long id;
		//交易类型1--代表商店卖给宠物主人 2--代表宠物主人卖给商店 3---宠物主人之间交易
		private int dealType;
		//宠物编号
		private long petId;
		//卖家编号
		private long sellerId;
		//买家编号
		private long buyerId;
		//价格
		private double price;
		//时间
		private Date dealTime;

		public long getBuyerId() {
			return buyerId;
		}

		public void setBuyerId(long buyerId) {
			this.buyerId = buyerId;
		}

		public Date getDealTime() {
			return dealTime;
		}

		public void setDealTime(Date dealTime) {
			this.dealTime = dealTime;
		}

		public int getDealType() {
			return dealType;
		}

		public void setDealType(int dealType) {
			this.dealType = dealType;
		}

		public long getId() {
			return id;
		}

		public void setId(long id) {
			this.id = id;
		}

		public long getPetId() {
			return petId;
		}

		public void setPetId(long petId) {
			this.petId = petId;
		}

		public double getPrice() {
			return price;
		}

		public void setPrice(double price) {
			this.price = price;
		}

		public long getSellerId() {
			return sellerId;
		}

		public void setSellerId(long sellerId) {
			this.sellerId = sellerId;
		}
	
}
