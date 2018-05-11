package petShop.entity;
import java.util.Date;

	/**
	 * @author ���̵�ʵ����
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
		//���
		private long id;
		//��������1--�����̵������������� 2--����������������̵� 3---��������֮�佻��
		private int dealType;
		//������
		private long petId;
		//���ұ��
		private long sellerId;
		//��ұ��
		private long buyerId;
		//�۸�
		private double price;
		//ʱ��
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
