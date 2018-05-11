package class14;

import java.util.Scanner;

public class CustomerBizTest {
	public static void main(String[] args){
		String[] customer = new String[10000];
		String answer;
		Scanner sc = new Scanner(System.in);
		for(int i = 0 ; i < customer.length ; i++){
			System.out.println("请输入客户的姓名：");
			customer[i] = sc.next();
			System.out.println("继续输入码？（Y/N）");
			answer = sc.next();
			if(answer.equalsIgnoreCase("N")){
				break;
			}
		}
		CustomerBiz cus = new CustomerBiz();
		cus.getCustomer(customer);
	}
}
