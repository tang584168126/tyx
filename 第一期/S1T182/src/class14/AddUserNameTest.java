package class14;

public class AddUserNameTest {

	String[] useNames = new String[3];
	
	
	/**
	 * 增加用户名称的方法
	 * @param name 要保存的用户的名字
	 * @return 成功：true ， 失败：false
	 */
	public boolean addUserName(String name){
		
		int i = 0 ;
		
		boolean isSave = false;
		
		//遍历名字数组是否有空位放入用户名称		
		for(i = 0 ; i < useNames.length ; i++){
			
			//判断 某个名字位置是否为空
			if(useNames[i] == null || useNames[i].equals("")){
				
				//如果为空成立，则将用户传入的名字放入此处
				useNames[i] = name ;
				
				isSave = true;	//保存成功
				
				//放好名字后，跳出循环
				break;
			}
		}
		
		return isSave;
	}

	/**
	 * 查看所有用户名称的方法
	 */
	public void showUseName(){
		System.out.println("\n用户名如下：");
		
		for(int i = 0 ; i < useNames.length ; i++){
			System.out.print(useNames[i] + "  ");
		}
		
		System.out.println("\n查看结束！");
	}
	
	public static void main(String[] args) {
		
		AddUserNameTest useObj = new AddUserNameTest();
		
		useObj.addUserName("张1");
		useObj.addUserName("张2");
		useObj.addUserName("张3");
		
		
		System.out.println(useObj.addUserName("张4")? "添加成功" : "添加失败！");
		
		useObj.showUseName();
		
	}
	
}







