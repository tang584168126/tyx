package exam4;
/**
 * ������
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		//�������������
		Queue queue = new Queue();
		
		//���
		queue.add("С��");
		queue.add(123);
		queue.add('A');
		
		for(int i =0; i < queue.list.size(); i++){
			System.out.println(queue.list.get(i));
		}
		
		//�Ƴ�
		queue.get();
		
		for(int i =0; i < queue.list.size(); i++){
			System.out.println(queue.list.get(i));
		}
	}
}
