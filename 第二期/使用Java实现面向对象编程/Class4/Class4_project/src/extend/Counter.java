package extend;

/**
 * 计算器类
 * @author Administrator
 *
 */
public class Counter implements Add,Subtract,Pursue,Remove {
	double result;		//结果
	@Override
	public void remove(double digtA, double digtB) {
		if(digtB == 0){
			System.out.println("除数不能为零");
			result = digtA;
		}else{
			result = digtA/digtB;
		}
	}

	@Override
	public void pursue(double digtA, double digtB) {
		result = digtA*digtB;
	}

	@Override
	public void subtract(double digtA, double digtB) {
		result = digtA - digtB;
	}

	@Override
	public void add(double digtA, double digtB) {
		result = digtA + digtB;
	}

}
