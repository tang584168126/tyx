package  GGG;

/*
 *抽奖类
 * 
 * */
public class Choujiang {
	int a = 0; // 随机数
	int max = 1000; // 最大值
	int min = 9999; // 最小值

	/*
	 * 随机生成一个随机数 (返回一个int类型的值)
	 */
	public int LonOne() {
		return (int) (Math.random() * ((max - min) + min));
	}

	/*
	 * 随机生成4个随机数（返回4个int类型的数组）
	 */
	public int[] LongTwo() {
		int[] a = new int[4];
		for (int i = 0; i < a.length; i++) {
			a[i] = (int) (Math.random() * ((max - min) + min));
		}
		return a;
	}
}
