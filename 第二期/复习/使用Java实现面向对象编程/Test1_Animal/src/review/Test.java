package review;
/**
 * ������
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		Master master = new Master("С��", 100); 
		Pet dog = new Dog("Сѩ",87,90,"����");
		Pet penguin = new Penguin("С��",76,56,"Q��");
		master.play(dog);
		master.feed(penguin);
	}
}
