
public class 用星号打印三角形 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//硬思路    求调试 
		int a = 0;//循环条件 
		int b = 0;//循环条件

		//第一部分打印一次增多的*
		for(a = 1;a<=7;a+=2){
			for(b = 1;b<=7;b++){
				if(a<b){
					break;   //b的值大于a时 跳出循环
				}
			
			System.out.print("*");
			
			
		}
			System.out.println("");//打印换行
		}
		//第二部分打印依次减少的*
			for(a = 5;a>=1;a-=2){
				for(b = 5;b>=1;b--){
					if(a == 3){ //用于判断a的值减小导致发生的bug
						if(a>b){
							break;//由于b是减小的 所以可以从此跳出打印换行
		}
		}else{				//如果跳到第二部分第一循环A的值减小导致bug
					if(a<5){ 
						System.out.print("*");
					} if(a<b){
						break;
					}
					}
			System.out.print("*");	
					}
			System.out.println("");
		}

	}

}
