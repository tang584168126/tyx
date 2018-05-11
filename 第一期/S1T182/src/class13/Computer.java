package class13;

public class Computer {
	String name ;	//姓名
	int result ;	//积分
	
	public int 出拳(){
		
		int num = 0 ;

		num = (int)(Math.random() * 3 + 1);
		
		switch(num){
		case 1:
			System.out.println("机器出拳：石头");
			break;
		case 2:
			System.out.println("机器出拳：剪刀");
			break;
		case 3:
			System.out.println("机器出拳： 布");
			break;
		}
		
		//返回机器出拳的结果
		return num ;
	}
}
