package com.cdqy.entity;
/**
 * 主人实体类
 * @author Administrator
 *
 */
public class Master {
	private static int id;

	public static int getId() {
		return id;
	}
	public void setId(int id) {
		this.id = id;
	}
	private String loginid;		//登录号
	private String password;	//密码
	public Master(String loginid, String password) {
		super();
		this.loginid = loginid;
		this.password = password;
	}
	public String getLoginid() {
		return loginid;
	}
	public void setLoginid(String loginid) {
		this.loginid = loginid;
	}
	public String getPassword() {
		return password;
	}
	public void setPassword(String password) {
		this.password = password;
	}
	
}
