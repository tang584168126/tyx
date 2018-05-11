package work1;
/**
 * 防盗门类
 * @author Administrator
 *
 */
public class TpDoor extends Door implements Lock,DoorBell{

	@Override
	public void takePicture() {
		System.out.println("门铃响了，照相中...");
	}

	@Override
	public void lockup() {
		System.out.println("上锁中...");
	}

	@Override
	public void openLock() {
		System.out.println("开锁中...");
	}

	@Override
	public void open() {
		System.out.println("开门中...");
	}

	@Override
	public void close() {
		System.out.println("关门中...");
	}

}
