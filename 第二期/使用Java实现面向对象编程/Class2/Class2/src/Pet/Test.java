package Pet;

/**
 * ������
 * @author Administrator
 *
 */
public class Test {

	public static void main(String[] args){
		
		Pet pet = new Pet("����");
		pet.print();
		
		Dog dog = new Dog("����","С��Ȯ");
		dog.print();
		
		Penguin pen = new Penguin("����","��");
		pen.print();
	}
}
