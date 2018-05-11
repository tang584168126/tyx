package myswing;

import javax.swing.*;

public class DialogTest {

	public static void main(String[] args) {
		//创建对话框对象
		JOptionPane jp = new JOptionPane();
		
		//显示对话框
		jp.showMessageDialog(null, "退出系统！");
		
		//
		jp.showConfirmDialog(null, "确定退出？");
	}
	
}
