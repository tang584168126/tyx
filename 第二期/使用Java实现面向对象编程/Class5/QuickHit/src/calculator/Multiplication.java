package calculator;
/**
 * �˷���
 * @author Administrator
 *
 */
public class Multiplication extends Operation {

	public Multiplication(double num1, double num2) {
		super(num1, num2);
	}

	/*
	 * �˷�����
	 */
	public double getResult(double num1, double num2) {
		return (num1 * num2);
	}

}
