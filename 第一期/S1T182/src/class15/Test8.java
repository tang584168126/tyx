package class15;

public class Test8 {

	public static void main(String[] args) {
		
		String str = "�Ұ����й����Ұ�����磡";
		int index = -1 ;
		String temp = "";
		
		//Ҫ��ȡ str �е� �й� ������
		//1������ str �� �Ƿ��� �й� ������
		index = str.indexOf("�й�");
		
		//2����� index ������ -1 ���ʾ str ���� �й� ������
		if(index != -1){
			
			//����� �� ʹ�� substring()��ȡ �й� ��������
			temp = str.substring(index,index + 2);
			
			System.out.println("temp ��ֵΪ��" + temp);
			
		}
		
	}
}
