package review1;
/**
 * 防盗门类
 * @author Administrator
 *
 */
public class TpDoor extends Door implements Lock {

	@Override
	public void lockUp() {
		// TODO Auto-generated method stub
		System.out.println("上锁");
	}

	@Override
	public void openLock() {
		// TODO Auto-generated method stub
		System.out.println("开锁");
	}

	@Override
	public void open() {
		// TODO Auto-generated method stub
		System.out.println("开门");
	}

	@Override
	public void close() {
		// TODO Auto-generated method stub
		System.out.println("关门");
	}
	
}
