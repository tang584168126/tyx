
public class 口诀9_9 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int i,j = 1;//循环条件
		int k = 0;//保存ij  的积 由于占位符的问题
		
		//累加i  j  的值 达到满足输出表格的值
		for(i = 1;i<=9;i++){
			for(j = 1;j<=9;j++){
				 if(j>i){   			//控制不输出2*1 = 2,3*1 = 3
					 break;		/*此处用continue 效果是一样的  不过continue还要回到下面的
					 			for再判断*/
				 }
			k = i*j;
			System.out.printf("%2d*%-2d=%-2d   ",j,i,k);
			}
			System.out.println(" ");
		}
	}
}
