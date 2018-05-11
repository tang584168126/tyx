/**
 * 以面向对象的思想，编写自定义类描述IT从业者 
 * 设定属性包括：姓名，年龄，技术方向，工作年限 
 * 方法包括：工作 
*/
public class ITWorker {
	private String name;// 姓名
	private int age;// 年龄
	private String teachic;// 技术方向
	private int year;// 工作年限

	// 工作方法通过输入参数，接收工作单位和职务，输出个人信息
	public String work(String company, String duty) {
		String content = "姓名：" + this.name + "\n年龄：" + this.age + "\n技术方向:"+ this.teachic + "\n工作年限：" + this.year + "\n目前就职于：" + company+ "\n职务是：" + duty;
		return content;
	}

	// 限定IT从业人员必须年满15岁，无效信息需提示，并设置默认年龄15
	public void setAge(int age) {
		if (age < 15) {
			System.out.println("年龄信息无效!已修改默认年龄为15");
			this.age = 15;
		} else
			this.age = age;
	}

	public String getTeachic() {
		return teachic;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}
	public void setTeachic(String teachic) {
		this.teachic = teachic;
	}
	public int getAge() {
		return age;
	}

	public int getYear() {
		return year;
	}

	public void setYear(int year) {
		this.year = year;
	}
}
