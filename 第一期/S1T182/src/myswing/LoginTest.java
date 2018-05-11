package myswing;

import javax.swing.*;
import javax.swing.JLabel;
import javax.swing.JTextField;
import javax.swing.JButton;

public class LoginTest extends JFrame{
	JLabel lblName = new JLabel("�û�����");
	JLabel lblPwd = new JLabel("���룺");
	
	JTextField txtName = new JTextField();
	JPasswordField txtPwd = new JPasswordField();
	
	JButton btnOk = new JButton("��¼");
	JButton btnExit = new JButton("�˳�");
	
	public LoginTest(){
		this.setTitle("��¼����");
		this.setSize(400, 200);
		
		this.setLayout(null);
		
		
		lblName.setBounds(50, 20, 100, 20);
		lblPwd.setBounds(50, 60, 100, 20);
		this.add(lblName);
		this.add(lblPwd);
		
		txtName.setBounds(150, 20, 150, 20);
		txtPwd.setBounds(150, 60, 150, 20);
		this.add(txtName);
		this.add(txtPwd);
		
		btnOk.setBounds(100, 100, 80, 20);
		btnExit.setBounds(200, 100, 80, 20);
		this.add(btnOk);
		this.add(btnExit);
		
		this.setResizable(false);
	}
	
	
	public static void main(String[] args) {
		
		new LoginTest().show(true);
		
	}
	
}
