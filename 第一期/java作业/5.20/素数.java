
public class 素数 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//怎么求一个素数  如果该数你能整除2 3 5 7 那么该数时素数
		int a = 0;
		
		for(a = 2;a<=100;a++){
			
			if(a%2 == 0 ||a%3 == 0||a%5 == 0||a%7 == 0){//筛选非素数是则返回进行下一次循环
				continue;
			}else{
				System.out.println(a);
			}
		}

	}

}
