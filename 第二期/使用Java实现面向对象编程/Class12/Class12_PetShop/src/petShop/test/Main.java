package petShop.test;

import java.sql.SQLException;

import java.util.Scanner;





import petShop.dao.*;




/**
 * @author 北大青鸟 入口类
 * 
 */
public class Main extends BaseDao {

	
	Scanner in=new Scanner(System.in);
	//记录主人名称 （便查询宠物信息）
	public String masterName="";
	//记录主人ID  （便查询宠物信息）
	public int masterId;
	//记录商店ID  （便查询宠物信息）
	public int storeId;


	/**
	 * 系统启动
	 */
	public  void startPetShop() {
		System.out.println("所有宠物睡眼惺忪的走出了数据库");
		System.out.println("**************************************");
		String petsql="select ID,NAMe from PET";
		try {
			pstm=getConnection().prepareStatement(petsql);
			rs=pstm.executeQuery();
			System.out.println("序号\t昵称");
			while (rs.next()) {
				System.out.print(rs.getInt(1)+"\t");
				System.out.println(rs.getString(2));
			}
			System.out.println("**************************************");	
			System.out.println("所有宠物主人姗姗来迟");
			System.out.println("*********************************");
			String mastersql="select ID,NAME from PETOWNER";
			pstm=getConnection().prepareStatement(mastersql);
			rs=pstm.executeQuery();
			System.out.println("序号\t姓名");
			while (rs.next()) {
				System.out.print(rs.getInt(1)+"\t");
				System.out.println(rs.getString(2));
			}
			System.out.println("*********************************");
			System.out.println("所有宠物商店陆续开店");
			System.out.println("**********************************");
			String storesql="select ID,NAME from petstore";
			pstm=getConnection().prepareStatement(storesql);
			rs=pstm.executeQuery();
			System.out.println("序号\t商店名称");
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
		System.out.println("请选择输入登录模式，输入1为宠物主人登录，输入2为宠物商店登录");
		boolean type = true;
		
		String num;
		while (type) {
			num = input.next();
			if ("1".equals(num)) {
			this.ownerLogin();  //宠物主人登录方法
				type = false;
			} else if ("2".equals(num)) {
				this.storeLogin();
				type = false;
			} else {
				System.out.println("输入有误，请按照指定规则输入");
				System.out.println("请选择登录模式，输入1为宠物主人登录，输入2为宠物商店登录");
				type = true;
			}
		}
	}

	/**
	 * 宠物主人登录方法
	 */
	public  void ownerLogin() {
	
		
		System.out.println("请先登录，请输入主人的名字：");
		masterName=in.next();
		System.out.println("请输入主人的密码：");
		String masterPwd=in.next();
		//定义查询sql语句
		String loginsql="select count(*) from petowner where name=? and password=?";
		try {
			//验证用户登陆
			pstm=getConnection().prepareStatement(loginsql);
			pstm.setString(1,masterName);
			pstm.setString(2, masterPwd);
			rs=pstm.executeQuery();
			int rows = 0;
			while (rs.next()) {
				rows=rs.getInt(1);
			}
			if (rows>0) {
				System.out.println("======恭喜您登陆成功=======");
				System.out.println("--------您的基本信息是----------");
				//从数据库查询用户信息并打印基本信息
				String sql="select * from PETOWNER where name=?";
				pstm=getConnection().prepareStatement(sql);
				pstm.setString(1, masterName);
				rs=pstm.executeQuery();
				while (rs.next()) {
					System.out.println("名字："+rs.getString("NAME"));
					System.out.println("元宝数："+rs.getDouble("MONEY"));
					masterId=rs.getInt(1);
				}
				System.out.println("登陆成功！");
				System.out.println("您可以进行以下操作：");
				System.out.println("1、购买宠物");
				System.out.println("2、出售宠物");
				System.out.println("根据要执行的操作，选择序号输入，退出请输入0");
				int num=in.nextInt();
				
				if(num == 0){
					System.out.println("程序结束，欢迎下次使用,,,,,,");
					System.exit(1);  //结束程序并退出
				}
					
					
				}else{
					
					
					System.out.println("登录失败,,,");
				}
			
		} catch (SQLException e) {
			e.printStackTrace();
		}finally{
			
			super.closeAll(conn, pstm, rs);
			
		}
	
	
	}

	/**
	 * 宠物商店登录方法
	 */
	public  void storeLogin() {
		
		System.out.println("请先登录，请输入宠物商店名称：");
		String storeName=in.next();
		System.out.println("请输入宠物商店密码：");
		String storePwd=in.next();
		//定义验证字符串
		String storeSql="select count(*) from petstore where NAME=? and PASSWORD=?";
		try {
			pstm=getConnection().prepareStatement(storeSql);
			//给占位符赋值
			pstm.setString(1, storeName);
			pstm.setString(2, storePwd);
			//执行sql验证语句
			rs=pstm.executeQuery();
			//判断返回的结果
			int rows=0;
			while (rs.next()) {
				rows=rs.getInt(1);
			}
			if (rows>0) {
				System.out.println("-----------恭喜登陆成功-------------");
				System.out.println("-----------宠物商店的基本信息--------------");
				String sql="select * from PETSTORE where name=? and password=?";
				pstm=getConnection().prepareStatement(sql);
				//给占位符赋值
				pstm.setString(1, storeName);
				pstm.setString(2, storePwd);
				//执行sql验证语句
				rs=pstm.executeQuery();
			
				while (rs.next()) {
					System.out.println("名称："+rs.getString("NAME")+"\t");
					System.out.println("商店资金："+rs.getDouble("BALANCE"));
					storeId=rs.getInt("ID");
				}
				System.out.println("登陆成功，可以进行以下操作：");
				System.out.println("1、购买宠物\n2、卖出宠物\n3、培育宠物\n4、查询待售宠物");
				System.out.println("5、查看商店结余\n 6、查看商店账目\n7、开宠物商店");
				System.out.println("根据要执行的操作，选择序号输入，退出请输入0");
				int num=in.nextInt();
				if(num == 0){
					System.out.println("程序结束，欢迎下次使用,,,,,,");
					System.exit(1);  //结束程序并退出
				}
			}else {
				System.out.println("登录失败！");
				System.exit(0);
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}finally{
			
			super.closeAll(conn, pstm, rs);
			
		}

	}
	

	
}
