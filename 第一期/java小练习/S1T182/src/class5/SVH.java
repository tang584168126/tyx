package class5;

/**
 * 描述：输出 摄氏度和华氏度的对照表
 * 要求 摄氏度 从 0 - 250 ， 每隔 20度为一项
 * 输出条目不超过 10条
 * 转换公式为：华氏度 = 摄氏度 * 9 / 5.0 + 32
 * @author fun
 *
 */
public class SVH {

	/**
	 * @param args
	 */
	public static void main(String[] args) {

		double ss = 0 ;	//摄氏度
		double hs = 0 ;	//华氏度
		int count = 0 ;	//计数器
		
		do{			
			//根据公式计算 华氏度的温度
			hs = ss * 9 / 5.0 + 32 ;
			
			//输出对照表
			System.out.println(hs + "华氏度 VS " + ss + "摄氏度！"); 
			
			ss += 20 ;
			
			count++;
			
		}while(ss <= 250 && count < 10);

	}

}





