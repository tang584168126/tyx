package calculator;
/**
 * �ӷ���
 * @author Administrator
 *
 */
public class  Add extends Operation {
	public Add(double num1, double num2) {
		super(num1, num2);
	}

	/*
	 * �ӷ�����
	 */
	public double getResult(double num1, double num2){
		
		return num1 + num2;
	}
}
