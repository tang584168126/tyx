package exam5;

/**
 * ������
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args){
		//�����������
		Dog dog = new Dog("����",95,87);
		dog.eat();					//���Է�
		dog.catchingFlyDisc();		//���ӷ���
		
		//������������
		Penguin pen = new Penguin("Сѩ",96,78);
		pen.swim();					//�����Ӿ
		pen.print();				//�����Ϣ
	}
}
