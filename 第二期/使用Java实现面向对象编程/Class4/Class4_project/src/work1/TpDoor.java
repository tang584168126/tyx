package work1;
/**
 * ��������
 * @author Administrator
 *
 */
public class TpDoor extends Door implements Lock,DoorBell{

	@Override
	public void takePicture() {
		System.out.println("�������ˣ�������...");
	}

	@Override
	public void lockup() {
		System.out.println("������...");
	}

	@Override
	public void openLock() {
		System.out.println("������...");
	}

	@Override
	public void open() {
		System.out.println("������...");
	}

	@Override
	public void close() {
		System.out.println("������...");
	}

}
