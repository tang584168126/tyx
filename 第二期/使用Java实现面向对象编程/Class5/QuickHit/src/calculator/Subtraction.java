package calculator;
/**
 * 减法类
 * @author Administrator
 *
 */
public class Subtraction extends Operation {

	public Subtraction(double num1, double num2) {
		super(num1, num2);
	}

	/*
	 * 减法运算
	 */
	public double getResult(double num1, double num2) {
		return (num1 - num2);
	}

}	
