package work2;

public class Person {
	private String name = "";		//����
	private int age = 0;		//����
	private String sex = "��";	//�Ա�
	
	/**
	 * �����Ա�
	 */
	public void setSex(String sex) throws Exception{
		if("��".equals(sex) || "Ů".equals(sex)){
			this.sex = sex;
		}else{
			throw new Exception("�Ա������\"��\"����\"Ů\"!");
		}
	}
	
	/**
	 * �ж�����
	 */
	public void setAge(int age) throws Exception{
		if(age >= 1 && age <= 100){
			this.age = age;
		}else{
			throw new Exception("���������1��100֮�䣡");
		}
	}
	
	/**
	 * ���������Ϣ
	 */
	public void print(){
		System.out.println(this.name + "(" + this.sex + "," + this.age + "��)");
	}
}
