package exm6;

/**
 * ��
 * @author Administrator
 *
 */
public class Person {
	private String name;	//����
	
	public String getName(){
		return name;
	}
	
	public Person(String name){
		this.name = name;
	}
	//�ݷõ�����
	public Friend getFriend(int index){
		Friend friend = null;
		
		if(index == 1){
			friend = new Chinaf("��ǿ");
		}else if(index == 2){
			friend = new Americaf("Լ��");
		}
		return friend;
	}
}
