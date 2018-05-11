import java.util.Scanner;

/*
 * 测试类，输出相关测试信息
 * */
public class BoardroomTest {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//构造会议室对象
		Boardroom one=new Boardroom();
		Boardroom two=new Boardroom();
		
		one.id="001";
		one.name="第一会议室";
		one.used=true;
		
		two.id="002";
		two.name="第二会议室";
		two.used=false;
		
		//进行会议室预定
		if(one.bespeak()==false)
			two.bespeak();
		
	}
}
