
public class 国际象棋盘8乘8 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int i,j = 0;//循环条件 并同时用作期盼规格的值
		int k = 0; //储存i*j 的积
		
		//累加规格的值以达到上限
		for(i = 1;i<9;i++){
			for(j = 1; j<9; j++){
				k = i+j;
				if(k%2 == 0){
					System.out.print("□");
				}else{
					System.out.print("■");
				}
				
			}
			System.out.println(" ");  //第二个for跳出  起到打印换行的作用
		}



	}

}
