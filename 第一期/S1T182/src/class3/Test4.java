package class3;

import java.util.Scanner;

public class Test4 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		double score = 0 ;
		
		System.out.println("�����������");
		
		
		//����IF�ṹ
		/*
		if(score >= 90){
			System.out.println("��");
		}
		else if(score >= 80){
			System.out.println("��");
		}
		else if(score >= 70){
			System.out.println("��");
		}
		else if(score >= 60){
			System.out.println("����");
		}
		else{
			System.out.println("����Ҫ���ͣ���");
		}
		*/
		
		
		if(sc.hasNextDouble()){
			score = sc.nextDouble();
		}
		else{
			System.out.println("��������ȷ�ķ�����");
			System.out.println("���������");
			System.exit(1);
		}
		
		
		
		if(score < 60){
			System.out.println("����Ҫ���ͣ���");
		}
		else if(score < 70){
			System.out.println("����");
		}
		else if(score < 80){
			System.out.println("��");
		}
		else if(score < 90){
			System.out.println("��");
		}
		else{
			System.out.println("��");
		}
		

	}

}
