package exam5;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import java.util.Scanner;

public class Test {
	static{
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}
	
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		Connection conn = null;
		PreparedStatement ps = null;
		
		String url = "jdbc:sqlserver://localhost:1433;DataBaseName=epet";
		String user = "sa";
		String password = "123";
		
		System.out.println("�������¼����");
		String name = input.next();
		System.out.println("���������룺");
		String pString = input.next();
		
		try {
			conn = DriverManager.getConnection(url, user, password);
			//sql���
			String sql = "select count(*) from [master] where name = ? and password = ?" ;
			ps = conn.prepareStatement(sql);
			ps.setString(1, name);
			ps.setString(2, pString);
			int result = ps.executeUpdate();
			
			if(result > 0){
				System.out.println("�û���¼�ɹ���");
			}else{
				System.out.println("�û���¼ʧ�ܣ�");
			}
			
		} catch (SQLException e) {
			System.out.println("���ݿ�����ʧ�ܣ�");
			e.printStackTrace();
		}finally{
			try {
				if(ps != null){
					ps.close();
				}
				if(conn != null){
					conn.close();
				}
			} catch (Exception e2) {
				e2.printStackTrace();
			}
		}
	}
}
