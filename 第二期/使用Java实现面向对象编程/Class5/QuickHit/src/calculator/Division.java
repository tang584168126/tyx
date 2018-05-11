package calculator;
/**
 * 除法类
 * @author Administrator
 *
 */
public class Division extends Operation {

	public Division(double num1, double num2) {
		super(num1, num2);
	}

	/*
	 * 除法运算
	 */
	public double getResult(double num1, double num2) {
			return (num1 / num2);
	}
}
