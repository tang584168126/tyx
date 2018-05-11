package class12;

public class Computer {

	String name ;		//名字
	int result;			//积分
	int num = 0;
	
	public int giveResult(){

		do{
			System.out.println("请出拳：(1.石头  2.剪刀  3.布)");
			num = (int)(Math.random() * 3 + 1);
			switch(num){
			case 1:
				System.out.println("人出石头");
				break;
			case 2:
				System.out.println("人出剪刀");
				break;
			case 3:
				System.out.println("人出布");
				break;	
			}
			break;
		}while(true);
		return num;
	}
}
