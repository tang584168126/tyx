package fu;

import java.util.Scanner;

/*
 * ������ 	
 * 		���ѧ����Ĳ���
 * 	
 * 	
 * */
public class Manager {
	Scanner input = new Scanner(System.in);
	// ����ѧ������
	Student[] stu = new Student[100];

	// �鿴ѧ����Ϣ
	public void searchStudent() {

		for (int i = 0; i < stu.length; i++) {
			// �ж������Ƿ�Ϊ��
			if (stu[i] != null) {
				System.out.println("����" + stu[i].name + "�Ա�" + stu[i].sex
						+ "ѧ��" + stu[i].number + "����" + stu[i].age);

			}

		}

	}

	// �޸�ѧ����Ϣ
	public void updateStudent() {

		System.out.println("�������޸�ѧ��������");

		String name = input.next();

		for (int i = 0; i < stu.length; i++) {
			// �ж������Ƿ�Ϊ��
			if (stu[i] != null) {
				// ���ҵ��Ǹ�ѧ��

				if (stu[i].name.equals(name)) {
					System.out.println("�ҵ���" + name + "ѧ��");
					// �ҵ��ˡ�����I
					System.out.println("�������޸�����");
					stu[i].name = input.next();
					System.out.println("�������޸����");
					stu[i].age = input.nextInt();
					System.out.println("�������޸��Ա�");
					stu[i].sex = input.next();
					System.out.println("�������޸�ѧ��");
					stu[i].number = input.nextInt();

					// �޸ĳɹ�
					System.out.println("�޸ĳɹ�");
					break;
				} else {
					System.out.println("�]�дˌW��");
					break;
				}

			}
		}
	}

	// ���ѧ����Ϣ
	public void addStudent() {

		for (int i = 0; i < stu.length; i++) {
			if (stu[i] == null) {

				// ����һ���W��
				Student student = new Student();

				System.out.println("Ոݔ��W������");
				student.name = input.next();
				System.out.println("Ոݔ��W���Ԅe");
				student.sex = input.next();
				System.out.println("Ոݔ��W���W̖");
				student.number = input.nextInt();
				System.out.println("Ոݔ��W�����g");
				student.age = input.nextInt();
				// �ьW���b�딵�M��
				stu[i] = student;

				System.out.println("��ӳɹ�");
				break;

			}
		}

	}

	// ɾ��ѧ����Ϣ
	public void deleteStudent() {
		System.out.println("Ոݔ����Ҫ�h���ČW������");
		String name = input.next();
		for (int i = 0; i < stu.length; i++) {

			if (stu[i] != null) {
				// �ҵ�Ҫ�h���ČW��
				if (stu[i].name.equalsIgnoreCase(name)) {
					stu[i] = null;
					System.out.println("�h���ɹ�");
					break;
				} else {
					System.out.println("�]���ҵ��ˌW��");
					break;
				}
			}

		}
	}
}
