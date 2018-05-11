package review;
/**
 * 测试类
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		Master master = new Master("小张", 100); 
		Pet dog = new Dog("小雪",87,90,"土狗");
		Pet penguin = new Penguin("小白",76,56,"Q仔");
		master.play(dog);
		master.feed(penguin);
	}
}
