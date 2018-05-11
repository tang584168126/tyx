package com.cdqy.demo3;
/**
 * 检查型异常
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-12 下午3:29:08
 * @version 1.0
 */
public class CheckExceptionTest {

	public static void main(String[] args) {
		try {
			Class.forName("");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
		/*String str = "abd";
		int num = Integer.parseInt(str);*/
	}

}
