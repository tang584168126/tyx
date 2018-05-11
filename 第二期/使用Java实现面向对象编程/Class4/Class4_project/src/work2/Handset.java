package work2;

/**
 * 手机类
 * @author Administrator
 *
 */
public abstract class Handset {
	protected String brand;		//品牌
	protected String type;		//型号
	
	public Handset(String brand,String type){
		this.brand = brand;
		this.type = type;
	}
	
	public abstract void print();
}
