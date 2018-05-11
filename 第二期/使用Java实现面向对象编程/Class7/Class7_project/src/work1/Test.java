package work1;

import java.util.*;

/**
 * 测试类
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		//创建企鹅对象
		Penguin xueBing = new Penguin("雪饼","Q仔");
		Penguin xiaoBai = new Penguin("小白", "Q妹");
		Penguin wangCai = new Penguin("旺财", "Q仔");
		
		//创建ArrayList对象
		List<Penguin> list = new ArrayList<Penguin>(); 
		
		list.add(xueBing);
		list.add(xiaoBai);
		list.add(1,wangCai);
		
		//输出企鹅数目
		System.out.println("企鹅有" + list.size() + "只");
		
		//循环输出企鹅
		for(int i = 0; i < list.size(); i++){
			Penguin pen = list.get(i);
			System.out.println(pen.getName() + "\t" + pen.getSex());
		}
		
		//删除下标为1的企鹅
		Penguin pen1 = list.get(1);
		System.out.println("下标为1的企鹅为：" + pen1.getName());
		list.remove(1);
		
		//判断是否还有该企鹅
		if(list.contains(1)){
			System.out.println("还有该企鹅！");
		}else{
			System.out.println("没有该企鹅！");
		}
	}

}
