package Class8;

import java.util.Scanner;

public class Test2_4 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		Scanner sc = new Scanner(System.in);
		
		int [] nums = new int[10];//�����û������10��ֵ
		int [] count = new int[4];//������Ӧ���ֵġ�������
		int a = 0;

		
		System.out.println("������"+ nums.length + "����");
		for(a = 0; a < nums.length;a++){
			System.out.println("�������" + (a+1) + "����");
			nums[a] = sc.nextInt();
			switch(nums[a]){
			case 1:
				count[0] +=1;
				break;
			case 2:
				count[1] +=1;
				break;
			case 3:
				count[2] +=1;
				break;
			default:
				count[3] +=1;
				break;
			}
		}
		System.out.println("����1������" + count[0]);
		System.out.println("����2����"+count[1]);
		System.out.println("����3����"+count[2]);
		System.out.println("�Ƿ��ĸ���"+count[3]);
		

	}

}
