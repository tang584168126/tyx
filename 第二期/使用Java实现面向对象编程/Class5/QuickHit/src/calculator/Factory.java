package calculator;

/**
 * ������
 * @author Administrator
 *
 */
public class Factory {

	
	public Operation createOperation(double num1, double num2, char symbol){
		//�������������
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
					System.out.println("��������Ϊ�㣡");
					System.exit(1);
				}else{
					operation = new Division(num1, num2);
				}
				break;
		}
		
		return operation;
	}
}
