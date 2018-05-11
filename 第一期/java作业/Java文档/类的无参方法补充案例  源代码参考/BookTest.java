
public class BookTest {	
	//测试方法
	public static void main(String[] args){
		Book one=new Book();
				one.bookName="鹿鼎记";
				one.author="金庸";
				one.publisher="人民文学出版社";
				one.price=120;
				//调用介绍的方法
				one.info();
				System.out.println("=============================");
				
				//实例化对象，并对相关属性赋值
				Book two=new Book();
				two.bookName="绝代双骄";
				two.author="古龙";
				two.publisher="中国长安出版社";
				two.price=55.5;
				//调用介绍的方法
				two.info();
	}
}
