package class15_1;


/**
 * 描述：关于 substring()
 * @author fun
 *
 */
public class Test1 {

	public static void main(String[] args) {
		
		//1、substring(int index)
		//含义：从 index 开始获取后面所有字符
		String str = "abcdefg123";
		
		//从下标 3 开始获取后面所有字符
		str = str.substring(3);
		
		System.out.println(str);
		
		System.out.println("================");
		
		//2、substring(int beginIndex , int endIndex)
		//含义：从 beginIndex 开始 
		//获取到 endIndex 前一个 之间的所有字符
		str = "abcdefg";
		
		str = str.substring(2,6);
		
		System.out.println(str);
		
	}
	
}






