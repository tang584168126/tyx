package class15;

public class Register {

	boolean isok = false;
	public boolean verify(String user , String secret , String delSecret){
		if((user.length() < 6 || user.length() > 15) && (secret.length() < 6 || secret.length() > 18)){
			System.out.println("用户名长度在6 — 15之间！用户名长度在6 — 18之间！");
			if(!secret.equals(delSecret)){
				System.out.println("2次输入的密码不正确！");
			}
			isok = false;
		}else{
			isok = true;
		}

		return isok;
	}
}
