package fu;

import java.util.Scanner;

/*
 * 帮助类 	
 * 		完成学生类的操作
 * 	
 * 	
 * */
public class Manager {
	Scanner input = new Scanner(System.in);
	// 创建学生数组
	Student[] stu = new Student[100];

	// 查看学生信息
	public void searchStudent() {

		for (int i = 0; i < stu.length; i++) {
			// 判断数组是否为空
			if (stu[i] != null) {
				System.out.println("名字" + stu[i].name + "性别" + stu[i].sex
						+ "学号" + stu[i].number + "年龄" + stu[i].age);

			}

		}

	}

	// 修改学生信息
	public void updateStudent() {

		System.out.println("请输入修改学生的姓名");

		String name = input.next();

		for (int i = 0; i < stu.length; i++) {
			// 判断数组是否为空
			if (stu[i] != null) {
				// 先找到那个学生

				if (stu[i].name.equals(name)) {
					System.out.println("找到了" + name + "学生");
					// 找到了。。。I
					System.out.println("请输入修改名字");
					stu[i].name = input.next();
					System.out.println("请输入修改年纪");
					stu[i].age = input.nextInt();
					System.out.println("请输入修改性别");
					stu[i].sex = input.next();
					System.out.println("请输入修改学号");
					stu[i].number = input.nextInt();

					// 修改成功
					System.out.println("修改成功");
					break;
				} else {
					System.out.println("沒有此學生");
					break;
				}

			}
		}
	}

	// 添加学生信息
	public void addStudent() {

		for (int i = 0; i < stu.length; i++) {
			if (stu[i] == null) {

				// 創造一個學生
				Student student = new Student();

				System.out.println("請輸入學生姓名");
				student.name = input.next();
				System.out.println("請輸入學生性別");
				student.sex = input.next();
				System.out.println("請輸入學生學號");
				student.number = input.nextInt();
				System.out.println("請輸入學生年齡");
				student.age = input.nextInt();
				// 把學生裝入數組中
				stu[i] = student;

				System.out.println("添加成功");
				break;

			}
		}

	}

	// 删除学生信息
	public void deleteStudent() {
		System.out.println("請輸入你要刪除的學生名字");
		String name = input.next();
		for (int i = 0; i < stu.length; i++) {

			if (stu[i] != null) {
				// 找到要刪除的學生
				if (stu[i].name.equalsIgnoreCase(name)) {
					stu[i] = null;
					System.out.println("刪除成功");
					break;
				} else {
					System.out.println("沒有找到此學生");
					break;
				}
			}

		}
	}
}
