package class8;

import java.util.*;

public class Test6_2 {

	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int i = 0 ;
		int num = 0 ;	//�����û����������
		
		//����һ�� 5 ��Ԫ�� �� �� ��ʼֵ������
		int [] nums = {10,20,30,40,50};
		
		//����һ�����飬�� nums ����Ԫ�ظ��� + 1 ΪԪ�ظ���
		int [] newNums = new int[nums.length + 1];
		
		
		//�� nums ��ֵ ���θ�ֵ�� newNums
		for(i = 0 ; i < nums.length ; i++){
			
			newNums[i] = nums[i] ;
			
		}
		
		//��ʾ�û�
		System.out.println("������һ������:");
		num = sc.nextInt();
		
		//ֱ�ӽ� �û���������ݷ������һλ
		newNums[newNums.length - 1] = num ;
		
		//����
		Arrays.sort(newNums);
		
		for(i = 0 ; i < newNums.length ; i++){
			System.out.print(newNums[i] + "  ");
		}
		
	}
}




