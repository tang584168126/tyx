package Class8;

import java.util.Scanner;

public class Test2_6 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		String [] musics = new String[]{"Island","Ocean","Pretty","Sun"};
		String [] musics1 = new String[musics.length+1];
		
		int a =0;
		int index= -1;
		String num = "";
		
		for(a = 0;a<musics.length;a++){
			musics1[a] = musics[a];
		}
		System.out.println("�������¸�����");
		 num = sc.next();
		 
		 for(a = 0;a<musics1.length;a++){
			 if(musics1[a].compareToIgnoreCase(num)>0){
				 index = a;
				 break;
			 }
		 }
		if(index == -1){
			musics1[musics1.length-1] = num;
		}else{
			for(a = musics1.length-1;a > index;a--){
				musics1[a] = musics1[a-1];
			}
		}
		musics1[index] = num;
		for(a = 0;a < musics1.length;a++){
			System.out.print(musics1[a] + "\t");
		}
		/*package class8;

import java.util.*;


public class Test6 {

	
	public static void main(String[] args) {
		
		int i = 0 ;
		int num = 0 ;		//�����û����������
		int index = -1 ;	//index��ʾ���ǲ������ �±꣬���Ϊ0 �� �п��ܱ�����Ϊ�� ��һ��Ԫ��
		
		Scanner sc = new Scanner(System.in);
		
		//����һ�� 5 ��Ԫ�� �� �� ��ʼֵ������
		int [] sz = {10,20,30,40,50};
		
		//����һ�����飬�� sz ����Ԫ�ظ��� + 1 ΪԪ�ظ���
		int [] sz1 = new int[sz.length + 1];
		

		//�� sz ��ֵ ���θ�ֵ�� sz1
		for(i = 0 ; i < sz.length ; i++){
			
			sz1[i] = sz[i] ;
			
		}
		
		//��ӡԭʼ����
		for(i = 0 ; i < sz.length ; i++){
			
			System.out.print(sz[i] + "  ");
			
		}
		
		//���û�����һ������������ sz1 �У�Ҫ��ʵ������
		System.out.println("������һ��������");
		num = sc.nextInt();
		
		//�ҵ� sz1 �� �� �û�����ֵ ����Ǹ������±�
		for(i = 0 ; i < sz1.length ; i++){

			//�ж� �ĸ�����Ԫ�� �� �û������ֵҪ��
			if(sz1[i] > num){
				//�� �û��������Ҫ������±��¼����
				index = i ;
				break;	//�ҵ���Ҫ�����λ�ú���������
			}
			
		}
		
		//��� �û������ֵ����� index �޷������ȡ�±꣬
		//��ʱ index ��Ϊ�� -1
		if(index == -1){
			sz1[sz1.length - 1] = num ;
		}
		else{
			//�� Ҫ�����û���������ݵ��±�֮�������ֵ
			//����ƶ�һλ
			for(i = sz1.length - 1; i > index; i--){
				
				//�� �±� i - 1 ��ֵ ��ֵ�� �±� i ��Ԫ��
				sz1[i] = sz1[i - 1] ;
				
			}
			
			//���һ�������û������ֵ ���� Ӧ�÷����λ��
			sz1[index] = num ;
		}
		
		//��ӡ���
		for(i = 0 ; i < sz1.length ; i++){
			
			System.out.print(sz1[i] + "  ");
			
		}
	}

}
*/



	}

}
