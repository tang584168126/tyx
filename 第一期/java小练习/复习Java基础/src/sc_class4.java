import java.util.Scanner;


public class sc_class4 {
	public static void main(String[] args){
		double num1 = 0 ; 		//第一个数
		double num2 = 0 ; 		//第二个数
		String fh = "" ;		//运算符
		String isok = "" ;		//判断是否继续
		
		Scanner sc = new Scanner(System.in);
		
		do{
			System.out.print("请输入第一个操作数：");
			if(!sc.hasNextDouble()){
				System.out.println("输入错误！");
			}else{
				num1 = sc.nextDouble();
			}
			
			System.out.print("请输入第一个操作数：");
			if(!sc.hasNextDouble()){
				System.out.println("输入错误！");
			}else{
				num2 = sc.nextDouble();
			}
			System.out.print("请输入符号：");
			if(!sc.hasNext()){
				System.out.println("输入错误！");
			}else{
				fh = sc.next();
			}
			switch(fh){
			case "+":
				System.out.println("计算结果：" + num1 + "+" + num2 + "=" + (num1 + num2));
				break;
				
			case "-":
				System.out.println("计算结果：" + num1 + "-" + num2 + "=" + (num1 - num2));
				break;
				
			case "*":
				System.out.println("计算结果：" + num1 + "*" + num2 + "=" + (num1 * num2));
				break;
				
			case "/":
				System.out.println("计算结果：" + num1 + "/" + num2 + "=" + (num1 / num2));
				break;
			default:
				System.out.println("输入错误！");
				break;
			}
			System.out.print("继续吗？(Y/N)");
			isok = sc.next();
			if(isok.equalsIgnoreCase("N")){
				System.out.println("谢谢使用！");
				System.exit(1);
			}
			
			
		}while(true);	
		
	}

}
