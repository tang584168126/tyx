package class12;

public class ScoreCalc{
//属性：
	//三门功课的成绩
	double [] scores = new double[3];
		
	//总成绩
	double sum = 0 ;
	
	//平均分
	double avg = 0 ;
	
//方法：
	/**
	 * 计算平均分
	 */
	public void getAvg(){
		
		avg = sum / scores.length;
		
	}
	
	
	
	/**
	 *	计算总成绩 
	 */
	public void getSum(){
		
		sum = scores[0] + scores[1] + scores[2];   
		
	}
	
	/**
	 * 显示总分的方法
	 */
	public void showSum(){
		System.out.println("三门功课总分为：" + sum);
	}
	
	/**
	 * 显示平均分的方法
	 */
	public void showAvg(){
		System.out.println("三门功课平均分为：" + avg);
	}
}



