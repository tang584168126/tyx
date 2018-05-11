package work3;
/**
 * 电脑类
 * @author Administrator
 *
 */
public class Computer {
	private CPU brand;	//CPU品牌
	private CPU quency;	//CPU主频
	private EMS ems;	//内存
	private HardDisk hardDisk;		//硬盘
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
	
	//CPU品牌
	public void getBrand(CPU brand){
		this.brand = brand;
	}
	
	//CPU主频
	public void getQuency(CPU quency){
		this.quency = quency;
	}
	
	//硬盘容量
	public void gethardDisk(HardDisk hardDisk){
		this.hardDisk = hardDisk;
	}
	
	//内存容量
	public void getems(EMS ems){
		this.ems = ems;
	}
	
	//输出信息
	public void print(){
		System.out.println("计算机的信息如下：");
		System.out.println("CPU的品牌是" + brand.getCPUBrand() + ",主频是：" + quency.getFrequency() + "\n硬盘容量是：" + hardDisk.getCapacity() + "GB\n内存容量是：" + ems.getSize() + "GB");
	}
}
