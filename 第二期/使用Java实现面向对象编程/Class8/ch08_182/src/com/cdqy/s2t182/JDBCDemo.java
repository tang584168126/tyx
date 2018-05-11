package com.cdqy.s2t182;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;

public class JDBCDemo {
	//1.����,����
	//2.��������
	static{
		try {
			Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
	}
	//url
	private  static String url = "jdbc:sqlserver://localhost:1434;DataBaseName=epet";
	//�û�
	private  static String user="sa";
	//����
	private static String password="sql2008";
	public static void main(String[] args) {
		/*Connection conn = null;
		//3.�������Ӷ���
		Statement st = null;
		try {
			conn  =DriverManager.getConnection(url, user, password);
			String name = "�ڱ�";
			int health=80;
			int love = 100;
			String strain  ="����";
			//4.����sql���
			String sql ="insert into [dog] values('"+name+"',"+health+","+love+",'"+strain+"')";
			//ɾ��,�޸�
			//5.ִ��sql���Ķ���
			st = conn.createStatement();
			//6.ִ��sql���,������Ӱ�������
			int result = st.executeUpdate(sql);
			//7.������
			if(result >0){
				System.out.println("��ӳɹ�");
			}else{
				System.out.println("���ʧ��");
			}
		} catch (SQLException e) {
			e.printStackTrace();
			System.out.println("���ʧ��");
		}finally{
			try {
				//8.�ͷ���Դ,��ʹ�õĺ�ر�,��ʹ���ȹر�
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
		//���ò�ѯ�ķ���
		query();
		
	}
	/**
	 * ��ѯ���еĹ�����Ϣ
	 */
	public static void query(){
		//���Ӷ���
		Connection conn = null;
		//ִ��sql���Ķ���
		Statement st = null;
		//���صĽ����
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
			//�ͷ���Դ
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
