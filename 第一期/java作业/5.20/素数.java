
public class ���� {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//��ô��һ������  ���������������2 3 5 7 ��ô����ʱ����
		int a = 0;
		
		for(a = 2;a<=100;a++){
			
			if(a%2 == 0 ||a%3 == 0||a%5 == 0||a%7 == 0){//ɸѡ���������򷵻ؽ�����һ��ѭ��
				continue;
			}else{
				System.out.println(a);
			}
		}

	}

}
