package class6;

/**
 * 歌曲循环播放 案例 continue 
 * @author fun
 *
 */

public class Test7 {

	public static void main(String[] args) {
		
		int i = 0 ; 
		
		/*
		for(i = 1 ; i < 10 ; i++){
			
			//我跳过 第 5 首 歌
			if(i == 5){
				continue;
			}
			
			System.out.println("正在播放第 " + i + "首歌");
			
		}
		*/
		
		for(i = 1 ; i < 10 ; i++){
			
			//我跳过 第 5 首 歌
			if(i != 5){
				System.out.println("正在播放第 " + i + "首歌");	
			}
			
		}
	}
	
	
	
}





