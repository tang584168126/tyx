package work1;

/**
 * ������
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args){
		Master master = new Master("С��",100);
		
		Pet dog = new Dog("��ѩ","ʨ�ӹ�");
		dog.print();
		dog.eat();
		
		Pet pen = new Penguin("С��","Q��");
		pen.print();
		pen.eat();
		
		Pet cat = new Cat("��ҹ","��ɫ");
		cat.print();
		cat.eat();
	}
}
