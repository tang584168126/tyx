package com.cdqy.s2t182;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

/**
 * 演示JDBC连接数据库
 * 
 * @author Justin
 * @deparment 学术部
 * @time 2015-1-16 下午3:53:51
 * @version 1.0
 */
public class JDBCTest {
	// 1.导入jar包,并且正确部署
	// 2.加载驱动
	static {
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}

	public static void main(String[] args) {
		// 访问数据库的url
		String url = "jdbc:sqlserver://localhost:1434";
		String user = "sa";
		String password = "sql2008";
		// 3.创建连接对象
		Connection conn = null;
		try {
			conn = DriverManager.getConnection(url, user, password);
			System.out.println("连接数据库成功");
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			try {
				if (conn != null) {
					conn.close();
					System.out.println("关闭成功");
				}
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}

	}

}
