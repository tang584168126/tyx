package ��;

public class Test2 {
	public static void main(String[] args){
		int i = 0 ;
		int j = 0;
	
		int sum = 0;
		
		for(i = 0;i<8;i++){
			for(j = 0;j<8;j++){
				sum = i+j;
				if(sum % 2 == 0){
					System.out.print("��");
				}else{
					System.out.print("��");
				}
			}System.out.print("\n");
		}
	}

}
