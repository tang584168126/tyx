package class8;

import java.util.Scanner;

/**
 * ������
 * @author fun
 *
 */
public class Test5 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int i = 0 ;
		int [] nums = new int[5] ;
		int max = 0 ;
		
		Scanner sc = new Scanner(System.in);
		
		for(i = 0 ; i < nums.length ; i++){
			//�����û����������Ԫ��
			System.out.println("�������" + (i + 1) + "������");
			nums[i] = sc.nextInt();
		}

		System.out.println("\n==============================\n");
		
		//�ҵ����ֵ��
		//1������ �����е�һ��Ԫ�����
		max = nums[0] ;
		
		//2���� max ������������Ԫ�����αȽ�
		for(i = 0 ; i < nums.length ; i++){
			
			//�ж� ��� ĳ��Ԫ�� ���� ���ֵ
			if(max > nums[i]){
				//�������� ����������� max ��Ҫ���ֵ 
				//��ֵ�� max
				max = nums[i] ;
			}
			
		}
		
		System.out.println("���ֵΪ��" + max);
	}

}





