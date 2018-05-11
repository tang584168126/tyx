package com.cdqy.s2t182;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class JDBCDemo {
	//1.导包,部署
	//2.加载驱动
	static{
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}
	//url
	private  static String url = "jdbc:sqlserver://localhost:1434;DataBaseName=epet";
	//用户
	private  static String user="sa";
	//密码
	private static String password="sql2008";
	public static void main(String[] args) {
		/*Connection conn = null;
		//3.创建连接对象
		Statement st = null;
		try {
			conn  =DriverManager.getConnection(url, user, password);
			String name = "黑豹";
			int health=80;
			int love = 100;
			String strain  ="藏獒";
			//4.创建sql语句
			String sql ="insert into [dog] values('"+name+"',"+health+","+love+",'"+strain+"')";
			//删除,修改
			//5.执行sql语句的对象
			st = conn.createStatement();
			//6.执行sql语句,返回受影响的行数
			int result = st.executeUpdate(sql);
			//7.处理结果
			if(result >0){
				System.out.println("添加成功");
			}else{
				System.out.println("添加失败");
			}
		} catch (SQLException e) {
			e.printStackTrace();
			System.out.println("添加失败");
		}finally{
			try {
				//8.释放资源,先使用的后关闭,后使用先关闭
				if(st!=null){
					st.close();
				}
				if(conn!=null){
					conn.close();
				}
			} catch (Exception e2) {
				e2.printStackTrace();
			}
		}*/
		//调用查询的方法
		query();
		
	}
	/**
	 * 查询所有的狗狗信息
	 */
	public static void query(){
		//连接对象
		Connection conn = null;
		//执行sql语句的对象
		Statement st = null;
		//返回的结果集
		ResultSet rs = null;
		try {
			conn  =DriverManager.getConnection(url, user, password);
			String sql ="select * from [dog]";
			st = conn.createStatement();
			rs = st.executeQuery(sql);
			while(rs.next()){
				String name = rs.getString("name");
				int health = rs.getInt("health");
				String strain = rs.getString("strain");
				System.out.println(name+"\t"+health+"\t"+strain);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}finally{
			//释放资源
			try {
				if(rs!=null){rs.close();}
				if(st!=null){st.close();}
				if(conn!=null){conn.close();}
			} catch (Exception e2) {
				e2.printStackTrace();
			}
		}
	}

}
