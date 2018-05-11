package class15_1;

public class Test2 {

	public static void main(String[] args) {
		
		//trim()
		//去掉 字符串 左右 / 前后 的空格，中间的空格不管
		String str = "  1 2 3  ";
		
		//去掉空格前的原始结果
		System.out.println("去掉空格前的原始结果: ");
		System.out.println("**" + str + "**");
		
		System.out.println("===========================");
		
		str = str.trim();
		
		System.out.println("使用 trim() 去掉空格后的最新结果: ");
		System.out.println("**" + str + "**");
		
		System.out.println("===========================");
		
		//重新赋为初值 :空格空格123空格空格  
		str = "  1 2 3  ";
		
		//要将所有空格全部去除，可使用 replace()替换
		str = str.replace(" ", "");
		
		System.out.println("使用  replace()替换 去掉空格后的最新结果: ");
		System.out.println("**" + str + "**");
		
	}
}
