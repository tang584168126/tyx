package  GGG;

/*
 *�齱��
 * 
 * */
public class Choujiang {
	int a = 0; // �����
	int max = 1000; // ���ֵ
	int min = 9999; // ��Сֵ

	/*
	 * �������һ������� (����һ��int���͵�ֵ)
	 */
	public int LonOne() {
		return (int) (Math.random() * ((max - min) + min));
	}

	/*
	 * �������4�������������4��int���͵����飩
	 */
	public int[] LongTwo() {
		int[] a = new int[4];
		for (int i = 0; i < a.length; i++) {
			a[i] = (int) (Math.random() * ((max - min) + min));
		}
		return a;
	}
}
