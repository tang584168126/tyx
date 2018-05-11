package exam4;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class Test {
	static{
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}
	public static void main(String[] args) {
		//�������Ӷ���
		Connection conn = null;
		//����ִ��sql����
		Statement st = null;
		//���������
		ResultSet rs = null;
				
		//url
		String url = "jdbc:sqlserver://localhost:1433;DataBaseName=Class8_Example";
		//�û���
		String user = "sa";
		//����
		String password = "123";
		
		try {
			conn = DriverManager.getConnection(url, user, password);
			//����sql���
			String sql = "select * from student";
			
			st = conn.createStatement();
			
			rs = st.executeQuery(sql);
			while(rs.next()){
				int id = rs.getInt("id");
				String name = rs.getString("name");
				System.out.println(id + "\t" + name);
			}
		} catch (SQLException e) {
			System.out.println("�������ݿ�ʧ�ܣ�");
			e.printStackTrace();
		}finally{
			try {
				if(rs != null){
					rs.close();
				}
				if(st != null){
					st.close();
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
