package class12;

public class CellTest {

	public static void main(String[] args) {
		
		Cell cell = new Cell();
		
		cell.i = 100 ;
		
		System.out.println("�µ���ѹ���ã�����Ϊ��100 ��");
		
		System.out.println("���һ������ 2 ��λ�ĵ磡��");
		
		for(int i = 0 ; i < cell.i ; i++){

			System.out.println("��" + (i + 1) + "�γ�磬���ĵ�����" + cell.����() + "�����ʣ�������" + cell.i);
			
		}
		
	}
}
