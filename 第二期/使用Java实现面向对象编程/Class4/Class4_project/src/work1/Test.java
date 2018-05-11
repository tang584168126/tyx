package work1;

/**
 * 测试类
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args) {
		TpDoor tpd  = new TpDoor();
		tpd.close();		//关门
		tpd.lockup();		//上锁
		tpd.takePicture();	//照相
		tpd.openLock();		//开锁
		tpd.open();			//开门
	}

}
