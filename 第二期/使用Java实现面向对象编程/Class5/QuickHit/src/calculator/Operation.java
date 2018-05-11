package calculator;
/**
 * ÔËËãÀà
 * @author Administrator
 *
 */
public abstract class Operation {
	
	 double num1;
	double num2;
	
	public Operation(double num1, double num2) {
		super();
		this.num1 = num1;
		this.num2 = num2;
	}

	public abstract double getResult(double num1, double num2);
}
