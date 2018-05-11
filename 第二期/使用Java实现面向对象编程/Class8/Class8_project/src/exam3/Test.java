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
		//创建连接对象
		Connection conn = null;
		//创建执行sql对象
		Statement st = null;
		
		//url
		String url = "jdbc:sqlserver://localhost:1433;DataBaseName=Class8_Example";
		//用户名
		String user = "sa";
		//密码
		String password = "123";
		
		try {
			int id = 1523;
			String name = "小麻子";
			conn = DriverManager.getConnection(url, user, password);
			
			//创建新增sql语句
			String sql1 = "insert into student (id,name) values (" +id +",'"+ name +"')";
			
			//创建查询语句
			String sql2 = "select count(*) from student";
			
			st = conn.createStatement();
			
			//获取结果
			int result = st.executeUpdate(sql2);
			
			//输出
			System.out.println("表中记录的总数为：" + result);
			
			
		} catch (SQLException e) {
			System.out.println("连接数据库失败！");
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
