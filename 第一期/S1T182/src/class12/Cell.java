package class12;

public class Cell {

	String logo ; //品牌
	int i ;		  //电量
	
	//续电的方法
	public int 续电(){
		
		i -= 2 ;
		
		return 1 ;
	}
}
