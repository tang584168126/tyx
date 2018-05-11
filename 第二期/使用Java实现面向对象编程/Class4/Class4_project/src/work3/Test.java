package work3;
/**
 * 测试类
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args){
		//电脑类对象
		Computer computer = new Computer();
		//CPU类
		CPUMessage cpu = new CPUMessage();
		//内存类
		EMSMessage ems = new EMSMessage();
		//硬盘类
		HardDiskMessage hardDisk = new HardDiskMessage();
		
		//组装
		computer.getBrand(cpu);
		computer.getQuency(cpu);
		computer.getems(ems);
		computer.gethardDisk(hardDisk);
		
		//输出
		computer.print();
	}
}
