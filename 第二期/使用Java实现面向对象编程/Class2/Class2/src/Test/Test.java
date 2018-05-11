package Test;

public class Test {
	public static void main(String[] args) {
		Father father = new Son();
		father.money();
		
		Son son = (Son)father;
		son.getMoney();
		son.money();
	}
}
