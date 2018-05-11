package dvd;

import java.util.Date;

public class DVD {
	String dvdName ;	//名字
	boolean dvdState ;	//出租状态 false表示已出租，true表示未出租				
	double dvdMoney ;	//租金（出租的日租金）	
	String dvdOutTime ;	//借出时间
	String dvdBackTime;	//归还时间
	
	/**
	 * 显示碟片信息的方法
	 */
	public String toString(){
		return dvdName + " \t  " + (dvdState ? "未出租":"已出租") + "      " + dvdMoney + "     " + dvdOutTime + " \t " + dvdBackTime + "\n";
	}  
}
