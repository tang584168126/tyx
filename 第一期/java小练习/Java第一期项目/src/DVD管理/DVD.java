package DVD管理;

public class DVD {
	String name;		//碟片名字
	double price;		//租金
	boolean dvdState; 		//出租状态,false为未出租，true为已出租
	String dvdOutTime; 		//借出时间
	String dvdBackTime;		//归还时间
	public String toString(){
		return name + "\t" + price + "\t" + (dvdState ? "已出租" : "未出租") + "\t" + dvdOutTime + "\t" + dvdBackTime;
	} 

}
