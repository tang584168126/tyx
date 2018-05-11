package ÍòÄêÀú;

import java.util.*;

public class SystenTime {
	public static void main(String[] args){
		int year = 0;
		int month = 0;
		int day = 0;
		Calendar c = Calendar.getInstance();
		year = c.get(Calendar.YEAR);
		month = c.get(Calendar.MONTH) + 1;
		day = c.get(Calendar.DAY_OF_MONTH);
		System.out.println(year);
		System.out.println(month);
		System.out.println(day);
	}

}
