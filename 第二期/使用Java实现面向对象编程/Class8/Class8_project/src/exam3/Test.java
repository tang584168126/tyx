package exam3;

import java.sql.Statement;
import java.sql.Connection;
import java.sql.DriverManager;
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
		//�������Ӷ���
		Connection conn = null;
		//����ִ��sql����
		Statement st = null;
		
		//url
		String url = "jdbc:sqlserver://localhost:1433;DataBaseName=Class8_Example";
		//�û���
		String user = "sa";
		//����
		String password = "123";
		
		try {
			int id = 1523;
			String name = "С����";
			conn = DriverManager.getConnection(url, user, password);
			
			//��������sql���
			String sql1 = "insert into student (id,name) values (" +id +",'"+ name +"')";
			
			//������ѯ���
			String sql2 = "select count(*) from student";
			
			st = conn.createStatement();
			
			//��ȡ���
			int result = st.executeUpdate(sql2);
			
			//���
			System.out.println("���м�¼������Ϊ��" + result);
			
			
		} catch (SQLException e) {
			System.out.println("�������ݿ�ʧ�ܣ�");
			e.printStackTrace();
		}finally{
			try {
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
