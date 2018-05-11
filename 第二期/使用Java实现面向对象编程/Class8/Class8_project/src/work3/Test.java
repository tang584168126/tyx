package work3;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.SQLException;

public class Test {
	static{
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}
	public static void main(String[] args) {
		Connection conn = null;
		PreparedStatement ps = null;
		
		String url = "jdbc:sqlserver://localhost:1433;DataBaseName=epet";
		String user = "ds";
		String password = "sa";
		
		try {
			conn = DriverManager.getConnection(url, user, password);
			
			String sql = "insert into [dog] (name,health,love,strain) values (?,?,?,?)"; 
			
			ps = conn.prepareStatement(sql);
			ps.setString(1, "С��");
			ps.setInt(2, 89);
			ps.setInt(3, 51);
			ps.setString(4, "����");
			int result1 = ps.executeUpdate();
			ps.setString(1, "С��");
			ps.setInt(2, 79);
			ps.setInt(3,86);
			ps.setString(4, "ʨ�ӹ�");
			int result2 = ps.executeUpdate();

			if(result1 > 0 && result2 >0){
				System.out.println("��ӳɹ���");
			}else{
				System.out.println("���ʧ�ܣ�");
			}
		} catch (SQLException e) {
			System.out.println("�������ݿ�ʧ�ܣ�");
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
