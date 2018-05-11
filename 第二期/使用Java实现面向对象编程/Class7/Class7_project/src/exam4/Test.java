package exam4;
/**
 * 测试类
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		//创建队列类对象
		Queue queue = new Queue();
		
		//添加
		queue.add("小雨");
		queue.add(123);
		queue.add('A');
		
		for(int i =0; i < queue.list.size(); i++){
			System.out.println(queue.list.get(i));
		}
		
		//移除
		queue.get();
		
		for(int i =0; i < queue.list.size(); i++){
			System.out.println(queue.list.get(i));
		}
	}
}
