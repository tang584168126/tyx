package DVD����;

public class DVD {
	String name;		//��Ƭ����
	double price;		//���
	boolean dvdState; 		//����״̬,falseΪδ���⣬trueΪ�ѳ���
	String dvdOutTime; 		//���ʱ��
	String dvdBackTime;		//�黹ʱ��
	public String toString(){
		return name + "\t" + price + "\t" + (dvdState ? "�ѳ���" : "δ����") + "\t" + dvdOutTime + "\t" + dvdBackTime;
	} 

}
