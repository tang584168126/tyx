package exam4;

import java.util.LinkedList;

/**
 * ������
 * @author Administrator
 *
 */
public class Queue {

	//����LinkedList����
	LinkedList list = new LinkedList();
	
	public void add(Object obj){
		list.addFirst(obj);
	}
	
	public void get(){
		list.removeLast();
	}

}
