
public class 水仙花 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int i = 0;
		int t  = 0;//中转 t储存对i 取膜后的个位数 
		int k = 0;//中转 k储存对个位数的乘积 次方；
		int b =0;  //用来储存i的值 再循环后再还给i
		int sum = 0; //储存循环过程中i的每位数字的次方的和
		
		
		for(i = 2; i<=999;i++ ){   //i之所以不从0或1开始是应为水仙花数 是三位数
			b = i;
		
		if(i!=0){   //对	i取膜
		t = i%10;
		k = t*t*t;
		sum  = sum+k;
			}
		i = i/10; //做好对i十位数取膜的准备     取掉i的个位数
		
		if(i!=0){
			t = i%10;
			k = t*t*t;
			sum  = sum+k;
		}
		i = i/10;
		
		if(i!=0){
			t = i%10;
			k = t*t*t;
			sum  = sum+k;
		}
		i = i/10;
		
		if(sum == b){
			System.out.println(b);
		}
		sum = 0;
		i = b;
		
		}
	}

}
