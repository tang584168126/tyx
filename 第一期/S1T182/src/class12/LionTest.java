package class12;

public class LionTest {

	public static void main(String[] args) {
		
		//创建一个 狮子类的对象 lion
		Lion lion = new Lion();
		
		//为狮子的颜色进行赋值
		lion.color = "黄色";
		
		//显示狮子的颜色
		System.out.println(lion.color + "的玩具狮子，");
		
		//进行玩具狮子的测试
		System.out.println("跑的测试：");
		lion.run();
		
		System.out.println("叫的测试：");
		System.out.println(lion.bark());
	}
}
