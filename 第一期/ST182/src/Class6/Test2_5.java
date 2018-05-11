package Class6;

public class Test2_5 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int man = 0;
		int nv = 0;
		int xiao = 0;
		
		for(man = 0; man<=10; man++){
		for( nv = 0;nv<=20;nv++){
			for(xiao = 0;xiao<=30;xiao++){
				if((man+nv+xiao) ==30 && man*3+nv*2+xiao*1 == 50){
					System.out.println("男人"+ man+"女人"+nv+"小孩"+xiao);
				}
				
			}
			
		}
		}

	}

}
