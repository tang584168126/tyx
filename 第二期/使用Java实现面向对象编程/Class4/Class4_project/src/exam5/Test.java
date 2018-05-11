package exam5;

/**
 * 测试类
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args){
		//创建狗类对象
		Dog dog = new Dog("旺财",95,87);
		dog.eat();					//狗吃饭
		dog.catchingFlyDisc();		//狗接飞盘
		
		//创建企鹅类对象
		Penguin pen = new Penguin("小雪",96,78);
		pen.swim();					//企鹅游泳
		pen.print();				//企鹅信息
	}
}
