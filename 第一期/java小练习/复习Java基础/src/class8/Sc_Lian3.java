package class8;

import java.util.Arrays;
import java.util.Scanner;

public class Sc_Lian3 {
	public static void main(String[] args){
		String[] fu = new String[]{"a","c","u","b","e","p","f","z"};		//ԭ����
		int i = 0 ;
		int index = 0;
		String ziFu = "" ;													//������ַ�
		String[] fu1 = new String[9];										//����������	
		
		Scanner sc = new Scanner(System.in);
		
		System.out.print("ԭ�ַ����У�");
		for(i = 0 ; i < fu.length ; i++){
			System.out.print(fu[i]);
		}
		
		System.out.println();
		Arrays.sort(fu);
		System.out.print("���������");
		for(i = 0 ; i < fu.length ; i++){
			System.out.print(fu[i]);
			fu1[i] = fu[i];
		}
		
		System.out.println();
		System.out.print("�������Ϊ��");
		for(i = fu.length - 1 ; i >= 0  ; i--){
			System.out.print(fu[i]);
		}
		
		System.out.println();
		System.out.println("�����ַ���");
		ziFu = sc.next();
		
		fu1[8] = ziFu ; 
		Arrays.sort(fu1);
		System.out.println("���������Ϊ��");
		for(i = 0 ; i <= fu.length ; i++){
			
			System.out.print(fu1[i]);
			if(ziFu.equals(fu1[i])){
				index = i ;
			}
		}
		System.out.println("\n������ֵ���±꣺" + index);
	}

}
