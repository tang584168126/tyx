/*用户类：
属性:  用户昵称，密码，性别，年龄，注册时间，等级
方法：个人信息展示
*/
public class User {
	public String name;//昵称
	public String pass;//密码
	public String gender;//性别
	public int age;//年龄
	public String date;//注册日期
	public String state;//等级

	//个人信息展示方法
	public void info(){
		System.out.println("大家好！我是"+this.name+"，今年"+this.age+"岁\n我是"+this.date+"注册的，目前的等级是："+this.state);
	}
	/**
	 * 测试方法
	 */
	public static void main(String[] args) {
		//构造对象
		User lucy=new User();
		//设置属性值
		lucy.name="Lucy";
		lucy.date="2011-01-08";
		lucy.state="无敌小菜鸟";
		lucy.age=21;
		//调用方法
		lucy.info();
		
		//构造对象
		User mary=new User();
		//设置属性值
		lucy.name="Mary";
		lucy.date="2000-01-01";
		lucy.state="超级智多星";
		lucy.age=28;
		//调用方法
		mary.info();	
	}
}
