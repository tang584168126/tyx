package com.cdqy.demo3;
/**
 * ������쳣
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-12 ����3:29:08
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
