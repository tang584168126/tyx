package com.cdqy.entity;
/**
 * ����ʵ����
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
	private String loginid;		//��¼��
	private String password;	//����
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
