package exm6;

/**
 * ������
 * @author Administrator
 *
 */
public class Poultry {

	private String name;	//����
	private String strain;	//Ʒ��
	private String food;	//ʳ��
	private String motion;	//����
	
	//���췽��
	public Poultry(String name,String strain,String food,String motion){
		this.name = name;
		this.strain =strain;
		this.food = food;
		this.motion = motion;
	}
	
	//����
	public String getName(){
		return name;
	}
	
	//Ʒ��
	public String getStrain(){
		return strain;
	}
	
	//ʳ��
	public String getFood(){
		return food;
	}
	
	//����
	public String getMotion(){
		return motion;
	}
	
	//���
	public void print(){
		System.out.println("�ҽ�" + name + ",��һֻ" + strain + "��");
		System.out.println("��ϲ����" + food + "��");
		System.out.println("�һ�" + motion + "��");
	}
	
}
