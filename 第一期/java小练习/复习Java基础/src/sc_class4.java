import java.util.Scanner;


public class sc_class4 {
	public static void main(String[] args){
		double num1 = 0 ; 		//��һ����
		double num2 = 0 ; 		//�ڶ�����
		String fh = "" ;		//�����
		String isok = "" ;		//�ж��Ƿ����
		
		Scanner sc = new Scanner(System.in);
		
		do{
			System.out.print("�������һ����������");
			if(!sc.hasNextDouble()){
				System.out.println("�������");
			}else{
				num1 = sc.nextDouble();
			}
			
			System.out.print("�������һ����������");
			if(!sc.hasNextDouble()){
				System.out.println("�������");
			}else{
				num2 = sc.nextDouble();
			}
			System.out.print("��������ţ�");
			if(!sc.hasNext()){
				System.out.println("�������");
			}else{
				fh = sc.next();
			}
			switch(fh){
			case "+":
				System.out.println("��������" + num1 + "+" + num2 + "=" + (num1 + num2));
				break;
				
			case "-":
				System.out.println("��������" + num1 + "-" + num2 + "=" + (num1 - num2));
				break;
				
			case "*":
				System.out.println("��������" + num1 + "*" + num2 + "=" + (num1 * num2));
				break;
				
			case "/":
				System.out.println("��������" + num1 + "/" + num2 + "=" + (num1 / num2));
				break;
			default:
				System.out.println("�������");
				break;
			}
			System.out.print("������(Y/N)");
			isok = sc.next();
			if(isok.equalsIgnoreCase("N")){
				System.out.println("ллʹ�ã�");
				System.exit(1);
			}
			
			
		}while(true);	
		
	}

}
