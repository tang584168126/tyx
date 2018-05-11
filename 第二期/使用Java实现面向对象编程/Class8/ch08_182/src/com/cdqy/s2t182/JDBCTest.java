package com.cdqy.s2t182;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.sql.Statement;

/**
 * ��ʾJDBC�������ݿ�
 * 
 * @author Justin
 * @deparment ѧ����
 * @time 2015-1-16 ����3:53:51
 * @version 1.0
 */
public class JDBCTest {
	// 1.����jar��,������ȷ����
	// 2.��������
	static {
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}

	public static void main(String[] args) {
		// �������ݿ��url
		String url = "jdbc:sqlserver://localhost:1434";
		String user = "sa";
		String password = "sql2008";
		// 3.�������Ӷ���
		Connection conn = null;
		try {
			conn = DriverManager.getConnection(url, user, password);
			System.out.println("�������ݿ�ɹ�");
		} catch (SQLException e) {
			e.printStackTrace();
		} finally {
			try {
				if (conn != null) {
					conn.close();
					System.out.println("�رճɹ�");
				}
			} catch (SQLException e) {
				e.printStackTrace();
			}
		}

	}

}
