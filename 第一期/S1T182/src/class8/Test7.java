package class8;

import java.util.Scanner;

/**
 * ��������ά����
 * @author fun
 *
 */
public class Test7 {

	public static void main(String[] args) {
		
		//һά����ĳ�����ʽ��
		// 1 2 3 4 5
		
		//��ά����ĳ�����ʽ��
		/*
			1  2  3
			4  5  6
			7  8  9
		*/
		
		int [][] stuScores = new int[2][3];
		int i = 0 , j = 0 ;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("��������༶ѧ��������");
		
		for(i = 0 ; i < 2 ; i++){
			System.out.println("�� " + (i + 1) + " ���ࣺ");
			for(j = 0 ; j < 3 ; j++){
				System.out.println("�� " + (j + 1) + " ��ѧ����");
				stuScores[i][j] = sc.nextInt();
			}
		}
		
		
		System.out.println("=============================");
		
		System.out.println(" \t ѧ��1 \t ѧ��2 \t ѧ��3");
		
		for(i = 0 ; i < 2 ; i++){
			
			System.out.print("�� " + (i + 1) + " ���ࣺ  ");
			
			for(j = 0 ; j < 3 ; j++){
				System.out.print(stuScores[i][j] + " \t ");
			}
			
			System.out.println();
		}
		
		
	}
}
