package petShop.test;

import java.sql.SQLException;

import java.util.Scanner;





import petShop.dao.*;




/**
 * @author �������� �����
 * 
 */
public class Main extends BaseDao {

	
	Scanner in=new Scanner(System.in);
	//��¼�������� �����ѯ������Ϣ��
	public String masterName="";
	//��¼����ID  �����ѯ������Ϣ��
	public int masterId;
	//��¼�̵�ID  �����ѯ������Ϣ��
	public int storeId;


	/**
	 * ϵͳ����
	 */
	public  void startPetShop() {
		System.out.println("���г���˯��������߳������ݿ�");
		System.out.println("**************************************");
		String petsql="select ID,NAMe from PET";
		try {
			pstm=getConnection().prepareStatement(petsql);
			rs=pstm.executeQuery();
			System.out.println("���\t�ǳ�");
			while (rs.next()) {
				System.out.print(rs.getInt(1)+"\t");
				System.out.println(rs.getString(2));
			}
			System.out.println("**************************************");	
			System.out.println("���г�������������");
			System.out.println("*********************************");
			String mastersql="select ID,NAME from PETOWNER";
			pstm=getConnection().prepareStatement(mastersql);
			rs=pstm.executeQuery();
			System.out.println("���\t����");
			while (rs.next()) {
				System.out.print(rs.getInt(1)+"\t");
				System.out.println(rs.getString(2));
			}
			System.out.println("*********************************");
			System.out.println("���г����̵�½������");
			System.out.println("**********************************");
			String storesql="select ID,NAME from petstore";
			pstm=getConnection().prepareStatement(storesql);
			rs=pstm.executeQuery();
			System.out.println("���\t�̵�����");
			while (rs.next()) {
				System.out.print(rs.getInt(1)+"\t");
				System.out.println(rs.getString(2));
			}
			System.out.println("**********************************");
		} catch (SQLException e) {
			e.printStackTrace();
		}finally{
			
			super.closeAll(conn, pstm, rs);
		}
		Scanner input = new Scanner(System.in);
		System.out.println("��ѡ�������¼ģʽ������1Ϊ�������˵�¼������2Ϊ�����̵��¼");
		boolean type = true;
		
		String num;
		while (type) {
			num = input.next();
			if ("1".equals(num)) {
			this.ownerLogin();  //�������˵�¼����
				type = false;
			} else if ("2".equals(num)) {
				this.storeLogin();
				type = false;
			} else {
				System.out.println("���������밴��ָ����������");
				System.out.println("��ѡ���¼ģʽ������1Ϊ�������˵�¼������2Ϊ�����̵��¼");
				type = true;
			}
		}
	}

	/**
	 * �������˵�¼����
	 */
	public  void ownerLogin() {
	
		
		System.out.println("���ȵ�¼�����������˵����֣�");
		masterName=in.next();
		System.out.println("���������˵����룺");
		String masterPwd=in.next();
		//�����ѯsql���
		String loginsql="select count(*) from petowner where name=? and password=?";
		try {
			//��֤�û���½
			pstm=getConnection().prepareStatement(loginsql);
			pstm.setString(1,masterName);
			pstm.setString(2, masterPwd);
			rs=pstm.executeQuery();
			int rows = 0;
			while (rs.next()) {
				rows=rs.getInt(1);
			}
			if (rows>0) {
				System.out.println("======��ϲ����½�ɹ�=======");
				System.out.println("--------���Ļ�����Ϣ��----------");
				//�����ݿ��ѯ�û���Ϣ����ӡ������Ϣ
				String sql="select * from PETOWNER where name=?";
				pstm=getConnection().prepareStatement(sql);
				pstm.setString(1, masterName);
				rs=pstm.executeQuery();
				while (rs.next()) {
					System.out.println("���֣�"+rs.getString("NAME"));
					System.out.println("Ԫ������"+rs.getDouble("MONEY"));
					masterId=rs.getInt(1);
				}
				System.out.println("��½�ɹ���");
				System.out.println("�����Խ������²�����");
				System.out.println("1���������");
				System.out.println("2�����۳���");
				System.out.println("����Ҫִ�еĲ�����ѡ��������룬�˳�������0");
				int num=in.nextInt();
				
				if(num == 0){
					System.out.println("�����������ӭ�´�ʹ��,,,,,,");
					System.exit(1);  //���������˳�
				}
					
					
				}else{
					
					
					System.out.println("��¼ʧ��,,,");
				}
			
		} catch (SQLException e) {
			e.printStackTrace();
		}finally{
			
			super.closeAll(conn, pstm, rs);
			
		}
	
	
	}

	/**
	 * �����̵��¼����
	 */
	public  void storeLogin() {
		
		System.out.println("���ȵ�¼������������̵����ƣ�");
		String storeName=in.next();
		System.out.println("����������̵����룺");
		String storePwd=in.next();
		//������֤�ַ���
		String storeSql="select count(*) from petstore where NAME=? and PASSWORD=?";
		try {
			pstm=getConnection().prepareStatement(storeSql);
			//��ռλ����ֵ
			pstm.setString(1, storeName);
			pstm.setString(2, storePwd);
			//ִ��sql��֤���
			rs=pstm.executeQuery();
			//�жϷ��صĽ��
			int rows=0;
			while (rs.next()) {
				rows=rs.getInt(1);
			}
			if (rows>0) {
				System.out.println("-----------��ϲ��½�ɹ�-------------");
				System.out.println("-----------�����̵�Ļ�����Ϣ--------------");
				String sql="select * from PETSTORE where name=? and password=?";
				pstm=getConnection().prepareStatement(sql);
				//��ռλ����ֵ
				pstm.setString(1, storeName);
				pstm.setString(2, storePwd);
				//ִ��sql��֤���
				rs=pstm.executeQuery();
			
				while (rs.next()) {
					System.out.println("���ƣ�"+rs.getString("NAME")+"\t");
					System.out.println("�̵��ʽ�"+rs.getDouble("BALANCE"));
					storeId=rs.getInt("ID");
				}
				System.out.println("��½�ɹ������Խ������²�����");
				System.out.println("1���������\n2����������\n3����������\n4����ѯ���۳���");
				System.out.println("5���鿴�̵����\n 6���鿴�̵���Ŀ\n7���������̵�");
				System.out.println("����Ҫִ�еĲ�����ѡ��������룬�˳�������0");
				int num=in.nextInt();
				if(num == 0){
					System.out.println("�����������ӭ�´�ʹ��,,,,,,");
					System.exit(1);  //���������˳�
				}
			}else {
				System.out.println("��¼ʧ�ܣ�");
				System.exit(0);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}finally{
			
			super.closeAll(conn, pstm, rs);
			
		}

	}
	

	
}
