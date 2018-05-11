package calculator;
/**
 * 加法类
 * @author Administrator
 *
 */
public class  Add extends Operation {
	public Add(double num1, double num2) {
		super(num1, num2);
	}

	/*
	 * 加法运算
	 */
	public double getResult(double num1, double num2){
		
		return num1 + num2;
	}
}
