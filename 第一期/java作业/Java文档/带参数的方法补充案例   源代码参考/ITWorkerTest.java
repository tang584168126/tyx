
public class ITWorkerTest {

	
	//���Է���
	public static void main(String[] args){
		//ͨ������ʵ�������󣬶��������Ը�ֵ
		ITWorker zhangSan=new ITWorker();
		zhangSan.setName("��δ��");
		zhangSan.setAge(35);
		zhangSan.setYear(10);
		zhangSan.setTeachic("���ݿ�ά��");
		//���ù����ķ���
		System.out.println(zhangSan.work("��Ѷʵҵ", "���ݿ�ά������ʦ"));
		System.out.println("=============================");
		//ʵ�������󣬲���������Ը�ֵ
		ITWorker meiMei=new ITWorker();
		meiMei.setName("�ſ�");
		meiMei.setAge(10);
		meiMei.setYear(1);
		meiMei.setTeachic("Java����");
		//���ù����ķ���
		System.out.println(meiMei.work("��ʢ�Ƽ�", "Java��������ʦ"));
	}

}
