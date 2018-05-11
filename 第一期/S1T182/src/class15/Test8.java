package class15;

public class Test8 {

	public static void main(String[] args) {
		
		String str = "我爱你中国，我爱你故乡！";
		int index = -1 ;
		String temp = "";
		
		//要获取 str 中的 中国 两个字
		//1、查找 str 中 是否有 中国 两个字
		index = str.indexOf("中国");
		
		//2、如果 index 不等于 -1 则表示 str 中有 中国 两个字
		if(index != -1){
			
			//如果有 ， 使用 substring()提取 中国 这两个字
			temp = str.substring(index,index + 2);
			
			System.out.println("temp 的值为：" + temp);
			
		}
		
	}
}
