package work3;
/**
 * ������
 * @author Administrator
 *
 */
public class Computer {
	private CPU brand;	//CPUƷ��
	private CPU quency;	//CPU��Ƶ
	private EMS ems;	//�ڴ�
	private HardDisk hardDisk;		//Ӳ��
	public CPU getBrand() {
		return brand;
	}
	public void setBrand(CPU brand) {
		this.brand = brand;
	}
	public CPU getQuency() {
		return quency;
	}
	public void setQuency(CPU quency) {
		this.quency = quency;
	}
	public EMS getEms() {
		return ems;
	}
	public void setEms(EMS ems) {
		this.ems = ems;
	}
	public HardDisk getHardDisk() {
		return hardDisk;
	}
	public void setHardDisk(HardDisk hardDisk) {
		this.hardDisk = hardDisk;
	}
	
	//CPUƷ��
	public void getBrand(CPU brand){
		this.brand = brand;
	}
	
	//CPU��Ƶ
	public void getQuency(CPU quency){
		this.quency = quency;
	}
	
	//Ӳ������
	public void gethardDisk(HardDisk hardDisk){
		this.hardDisk = hardDisk;
	}
	
	//�ڴ�����
	public void getems(EMS ems){
		this.ems = ems;
	}
	
	//�����Ϣ
	public void print(){
		System.out.println("���������Ϣ���£�");
		System.out.println("CPU��Ʒ����" + brand.getCPUBrand() + ",��Ƶ�ǣ�" + quency.getFrequency() + "\nӲ�������ǣ�" + hardDisk.getCapacity() + "GB\n�ڴ������ǣ�" + ems.getSize() + "GB");
	}
}
