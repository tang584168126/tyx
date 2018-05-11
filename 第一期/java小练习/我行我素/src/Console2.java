import java.util.Scanner;
public class Console2 {
	public static void main(String[] args) {
		Scanner sc = new Scanner(System.in);
		System.out.println("   欢迎使用我行我素购物管理系统  \n ");
		System.out.println("	1. 登陆系统	\n");
		System.out.println("	2. 退出	");
		System.out.println();
		System.out.println("**********************************");
		System.out.println();
		System.out.print("请选择，输入数字:");
		int hao = sc.nextInt();
		if(hao==1)
		{	
			System.out.println("请输入账号：");
			String one = sc.next();
			System.out.println("请输入密码：");
			String two = sc.next();
			if(one.equals("admin") && two.equals("admin")){
			System.out.println("**********************************\n");
			System.out.println("   欢迎使用我行我素购物管理系统  \n ");
			System.out.println("**********************************\n");
			System.out.println("	1. 客户信息管理\n");
			System.out.println("	2. 购物结算	\n");
			System.out.println("	3. 真情回馈	\n");
			System.out.println("	4. 注销	\n");
			System.out.println("**********************************\n");
			System.out.println("请选择，输入数字:");
			}
			else{System.out.println("账号/密码错误");
				}
			}
		if(hao==2){
			System.out.println("谢谢使用");
		}
			
		
	}

}
