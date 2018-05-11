/**
 * 以面向对象的思想，编写自定义类描述图书信息 
 * 设定属性包括：书名，作者，出版社名，价格 
 * 方法包括：信息介绍 
 */
public class Book {
	public String bookName;// 书名
	public String author;// 作者
	public String publisher;// 出版社
	public double price;// 价格

	// 信息介绍方法描述图书所有信息
	public void info() {
		String content = "书名：" + this.bookName + "\n作者：" + this.author + "\n出版社:"
				+ this.publisher + "\n价格：" + this.price+"元";
		System.out.println(content);
	}
}
