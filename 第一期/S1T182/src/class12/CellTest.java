package class12;

public class CellTest {

	public static void main(String[] args) {
		
		Cell cell = new Cell();
		
		cell.i = 100 ;
		
		System.out.println("新电池已购买好！电量为：100 。");
		
		System.out.println("充电一次消耗 2 单位的电！！");
		
		for(int i = 0 ; i < cell.i ; i++){

			System.out.println("第" + (i + 1) + "次充电，消耗电量：" + cell.续电() + "，电池剩余电量：" + cell.i);
			
		}
		
	}
}
