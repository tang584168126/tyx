package class15;

public class Register {

	boolean isok = false;
	public boolean verify(String user , String secret , String delSecret){
		if((user.length() < 6 || user.length() > 15) && (secret.length() < 6 || secret.length() > 18)){
			System.out.println("�û���������6 �� 15֮�䣡�û���������6 �� 18֮�䣡");
			if(!secret.equals(delSecret)){
				System.out.println("2����������벻��ȷ��");
			}
			isok = false;
		}else{
			isok = true;
		}

		return isok;
	}
}
