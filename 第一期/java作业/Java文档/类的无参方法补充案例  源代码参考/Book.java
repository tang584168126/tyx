/**
 * ����������˼�룬��д�Զ���������ͼ����Ϣ 
 * �趨���԰��������������ߣ������������۸� 
 * ������������Ϣ���� 
 */
public class Book {
	public String bookName;// ����
	public String author;// ����
	public String publisher;// ������
	public double price;// �۸�

	// ��Ϣ���ܷ�������ͼ��������Ϣ
	public void info() {
		String content = "������" + this.bookName + "\n���ߣ�" + this.author + "\n������:"
				+ this.publisher + "\n�۸�" + this.price+"Ԫ";
		System.out.println(content);
	}
}
