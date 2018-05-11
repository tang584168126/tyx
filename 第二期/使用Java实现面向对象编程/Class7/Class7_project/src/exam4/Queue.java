package exam4;

import java.util.LinkedList;

/**
 * 队列类
 * @author Administrator
 *
 */
public class Queue {

	//创建LinkedList对象
	LinkedList list = new LinkedList();
	
	public void add(Object obj){
		list.addFirst(obj);
	}
	
	public void get(){
		list.removeLast();
	}

}
