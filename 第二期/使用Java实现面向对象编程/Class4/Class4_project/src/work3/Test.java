package work3;
/**
 * ������
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args){
		//���������
		Computer computer = new Computer();
		//CPU��
		CPUMessage cpu = new CPUMessage();
		//�ڴ���
		EMSMessage ems = new EMSMessage();
		//Ӳ����
		HardDiskMessage hardDisk = new HardDiskMessage();
		
		//��װ
		computer.getBrand(cpu);
		computer.getQuency(cpu);
		computer.getems(ems);
		computer.gethardDisk(hardDisk);
		
		//���
		computer.print();
	}
}
