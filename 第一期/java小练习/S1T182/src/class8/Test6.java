package class8;

import java.util.*;

/**
 * �����㷨
 * @author fun
 *
 */
public class Test6 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int i = 0 ;
		int num = 0 ;		//�����û����������
		int index = -1 ;	//index��ʾ���ǲ������ �±꣬���Ϊ0 �� �п��ܱ�����Ϊ�� ��һ��Ԫ��
		
		Scanner sc = new Scanner(System.in);
		
		//����һ�� 5 ��Ԫ�� �� �� ��ʼֵ������
		int [] nums = {10,20,30,40,50};
		
		//����һ�����飬�� nums ����Ԫ�ظ��� + 1 ΪԪ�ظ���
		int [] newNums = new int[nums.length + 1];
		

		//�� nums ��ֵ ���θ�ֵ�� newNums
		for(i = 0 ; i < nums.length ; i++){
			
			newNums[i] = nums[i] ;
			
		}
		
		//��ӡԭʼ����
		for(i = 0 ; i < nums.length ; i++){
			
			System.out.print(nums[i] + "  ");
			
		}
		
		//���û�����һ������������ newNums �У�Ҫ��ʵ������
		System.out.println("������һ��������");
		num = sc.nextInt();
		
		//�ҵ� newNums �� �� �û�����ֵ ����Ǹ������±�
		for(i = 0 ; i < newNums.length ; i++){

			//�ж� �ĸ�����Ԫ�� �� �û������ֵҪ��
			if(newNums[i] > num){
				//�� �û��������Ҫ������±��¼����
				index = i ;
				break;	//�ҵ���Ҫ�����λ�ú���������
			}
			
		}
		
		//��� �û������ֵ����� index �޷������ȡ�±꣬
		//��ʱ index ��Ϊ�� -1
		if(index == -1){
			newNums[newNums.length - 1] = num ;
		}
		else{
			//�� Ҫ�����û���������ݵ��±�֮�������ֵ
			//����ƶ�һλ
			for(i = newNums.length - 1; i > index; i--){
				
				//�� �±� i - 1 ��ֵ ��ֵ�� �±� i ��Ԫ��
				newNums[i] = newNums[i - 1] ;
				
			}
			
			//���һ�������û������ֵ ���� Ӧ�÷����λ��
			newNums[index] = num ;
		}
		
		//��ӡ���
		for(i = 0 ; i < newNums.length ; i++){
			
			System.out.print(newNums[i] + "  ");
			
		}
	}

}



