package dvd;

import java.util.Date;

public class DVD {
	String dvdName ;	//����
	boolean dvdState ;	//����״̬ false��ʾ�ѳ��⣬true��ʾδ����				
	double dvdMoney ;	//��𣨳���������	
	String dvdOutTime ;	//���ʱ��
	String dvdBackTime;	//�黹ʱ��
	
	/**
	 * ��ʾ��Ƭ��Ϣ�ķ���
	 */
	public String toString(){
		return dvdName + " \t  " + (dvdState ? "δ����":"�ѳ���") + "      " + dvdMoney + "     " + dvdOutTime + " \t " + dvdBackTime + "\n";
	}  
}
