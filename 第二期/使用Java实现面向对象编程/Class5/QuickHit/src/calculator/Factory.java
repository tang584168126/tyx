package calculator;

/**
 * 工厂类
 * @author Administrator
 *
 */
public class Factory {

	
	public Operation createOperation(double num1, double num2, char symbol){
		//创建运算类对象
		Operation operation = null;
		switch(symbol){
			case '+':
				operation = new Add(num1, num2);
				break;
			case '-':
				operation = new Subtraction(num1, num2);
				break;
			case '*':
				operation = new Multiplication(num1, num2);
				break;
			case '/':
				if(num2 == 0){
					System.out.println("除数不能为零！");
					System.exit(1);
				}else{
					operation = new Division(num1, num2);
				}
				break;
		}
		
		return operation;
	}
}
