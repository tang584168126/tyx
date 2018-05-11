package GGG;

/*
 * 用户类
 * */
public class User {
	// 账号 密码 幸运号
	String name = "";
	String pwd = "";
	int Sui = 0;
	// 保存 账号 密码
	String name1 = "";
	String Pwd1 = "";

	// 登陆方法 (账号密码必须和注册的账号密码一样 成功返回true 失败返回false)
	public boolean Long() {
		if (name.equalsIgnoreCase(name1) && pwd.equalsIgnoreCase(Pwd1)) {
			return true;
		} else {
			return false;
		}
	}

	// 注册方法（账号密码不能为空 成功返回true 失败返回false）
	public boolean ZeCe() {
		if (!(name1.equals("") && Pwd1.equals(""))) {
			return true;
		} else {
			return false;
		}
	}
}
