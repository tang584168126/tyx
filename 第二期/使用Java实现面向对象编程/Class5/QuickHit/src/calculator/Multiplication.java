package calculator;
/**
 * 乘法类
 * @author Administrator
 *
 */
public class Multiplication extends Operation {

	public Multiplication(double num1, double num2) {
		super(num1, num2);
	}

	/*
	 * 乘法运算
	 */
	public double getResult(double num1, double num2) {
		return (num1 * num2);
	}

}
