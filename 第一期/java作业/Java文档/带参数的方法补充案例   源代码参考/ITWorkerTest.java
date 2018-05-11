
public class ITWorkerTest {

	
	//测试方法
	public static void main(String[] args){
		//通过构造实例化对象，对所有属性赋值
		ITWorker zhangSan=new ITWorker();
		zhangSan.setName("马未龙");
		zhangSan.setAge(35);
		zhangSan.setYear(10);
		zhangSan.setTeachic("数据库维护");
		//调用工作的方法
		System.out.println(zhangSan.work("腾讯实业", "数据库维护工程师"));
		System.out.println("=============================");
		//实例化对象，并对相关属性赋值
		ITWorker meiMei=new ITWorker();
		meiMei.setName("张凯");
		meiMei.setAge(10);
		meiMei.setYear(1);
		meiMei.setTeachic("Java开发");
		//调用工作的方法
		System.out.println(meiMei.work("鼎盛科技", "Java开发工程师"));
	}

}
