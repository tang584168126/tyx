package class12;

public class B {

	public void bb(){
		
		int i = 0 ;
		
		for(i = 0 ; i < 100 ; i++){
			// 0 , 1 , 2 , 3 , 4 , 5 不再打印
			if(i == 5){
				//终止方法的执行
				return;
			}
			
			System.out.println("我是 bb() 方法");
		}
		
	}
	
	public String show(){
		
		return "123";
		
	}
	
	public static void main(String[] args) {
		
		//Object
		
		B b = new B();
		
		b.bb();
		
	}
}
