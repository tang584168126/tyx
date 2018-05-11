package class14;

public class AddUserNameTest {

	String[] useNames = new String[3];
	
	
	/**
	 * �����û����Ƶķ���
	 * @param name Ҫ������û�������
	 * @return �ɹ���true �� ʧ�ܣ�false
	 */
	public boolean addUserName(String name){
		
		int i = 0 ;
		
		boolean isSave = false;
		
		//�������������Ƿ��п�λ�����û�����		
		for(i = 0 ; i < useNames.length ; i++){
			
			//�ж� ĳ������λ���Ƿ�Ϊ��
			if(useNames[i] == null || useNames[i].equals("")){
				
				//���Ϊ�ճ��������û���������ַ���˴�
				useNames[i] = name ;
				
				isSave = true;	//����ɹ�
				
				//�ź����ֺ�����ѭ��
				break;
			}
		}
		
		return isSave;
	}

	/**
	 * �鿴�����û����Ƶķ���
	 */
	public void showUseName(){
		System.out.println("\n�û������£�");
		
		for(int i = 0 ; i < useNames.length ; i++){
			System.out.print(useNames[i] + "  ");
		}
		
		System.out.println("\n�鿴������");
	}
	
	public static void main(String[] args) {
		
		AddUserNameTest useObj = new AddUserNameTest();
		
		useObj.addUserName("��1");
		useObj.addUserName("��2");
		useObj.addUserName("��3");
		
		
		System.out.println(useObj.addUserName("��4")? "��ӳɹ�" : "���ʧ�ܣ�");
		
		useObj.showUseName();
		
	}
	
}







