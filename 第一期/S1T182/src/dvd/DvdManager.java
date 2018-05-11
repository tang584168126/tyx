package dvd;

import java.util.Date;
import java.util.Scanner;

public class DvdManager {

	//要被管理的 DVD 碟片 300 个
	DVD[] Dvds = new DVD[300];
	
	/*
	 * 数据初始化的方法（加入测试数据）
	 */
	public void init(){
		
		int i = 0 ;
		
		//实例化每一张碟片
		for(i = 0 ; i < Dvds.length ; i++){
			Dvds[i] = new DVD();
		}
		
		//假定 3个DVD碟片数据
		Dvds[0].dvdName = "碟片1";
		Dvds[0].dvdState = true;	// false表示已出租，true表示未出租
		Dvds[0].dvdMoney = 5 ;		//租金：5元/天
		Dvds[0].dvdOutTime = "";
		Dvds[0].dvdBackTime = "";
		
		Dvds[1].dvdName = "碟片2";
		Dvds[1].dvdState = false;	// false表示已出租，true表示未出租
		Dvds[1].dvdMoney = 3 ;		//租金：5元/天
		Dvds[1].dvdOutTime = "2014-5-10";
		Dvds[1].dvdBackTime = "";
		
		Dvds[2].dvdName = "碟片3";
		Dvds[2].dvdState = false;	// false表示已出租，true表示未出租
		Dvds[2].dvdMoney = 4 ;		//租金：5元/天
		Dvds[2].dvdOutTime = "2014-6-1";
		Dvds[2].dvdBackTime = "";
		
		
	}
	
	/**
	 * 新增DVD的方法
	 */	
	public void addDVD(){
		Scanner sc = new Scanner(System.in);
		int i = 0 ;
		int index = -1 ;	//新增碟片要放入的位置
		
		System.out.println("DVD碟片管理系统 > 新增碟片 : ");
		
		//要新增碟片，首先检查新碟片可放入的位置
		for(i = 0 ; i < Dvds.length ; i++){
			//判断碟片是否为空碟片
			if(Dvds[i].dvdName == null){
				//如果某碟片名称为空，则新增碟片要放入该位置
				index = i;
			}
		}
		
		System.out.println("请输入 DVD碟片名称：");
		Dvds[index].dvdName = sc.next();
		
		System.out.println("请输入 DVD碟片每日租金额度：");
		Dvds[index].dvdMoney = sc.nextDouble();
		
		//碟片借出状态为：true
		Dvds[index].dvdState = true;
		
		//重置新碟片的出租和归还日期
		Dvds[index].dvdOutTime = "";
		Dvds[index].dvdBackTime = "";
		
		System.out.println("碟片新增完毕！");
		
		sc.nextLine();
		sc.nextLine();
	}
	
	/**
	 * 查看DVD的方法
	 */	
	public void showDVD(){
		System.out.println("DVD碟片管理系统 > 查看碟片 : ");
		
		int i = 0 ;
		
		System.out.println("碟片名称  出租状态  每日租金  出租时间");
		
		for(i = 0 ; i < Dvds.length ; i++){
			//判断碟片是否为空碟片
			if(Dvds[i].dvdName != null){
				//如果某碟片名称不为空，则打印该碟片数据
				System.out.println(Dvds[i]);
			}
		}
	}
	
	/**
	 * 删除DVD的方法
	 */		
	public void delDVD(){
		System.out.println("DVD碟片管理系统 > 删除碟片 : ");
	}
	
	/**
	 * 借出DVD的方法
	 */	
	public void outDVD(){
		
		String name ;
		Scanner sc = new Scanner(System.in);
		int i = 0 ; 
		
		System.out.println("DVD碟片管理系统 > 借出碟片 : ");
		System.out.println("请输入借出碟片的名称：");
		
		name = sc.next();
		
		for(i = 0 ; i < Dvds.length ; i++){
			//判断碟片是否为空碟片
			if(Dvds[i].dvdName != null){
				
				//如果某碟片名称不为空，则判断该碟片名称是否与用户要借出的碟片名称一致
				if(Dvds[i].dvdName.equalsIgnoreCase(name)){
					
					//如果该碟片跟用户要借出的碟片名称一致
					//判断该碟片是否可出租
					if(Dvds[i].dvdState){
						Dvds[i].dvdState = false;
						Dvds[i].dvdOutTime = new Date().toLocaleString().substring(0,new Date().toLocaleString().indexOf(" "));
						System.out.println("恭喜：该碟成功借出！");
						break;
					}
					else{
						System.out.println("该碟片已出租，无法借出！");
						break;
					}
					
				}
			}
		}
		
	}
	
	/**
	 *	归还DVD的方法
	 */	
	public void backDVD(){
		System.out.println("DVD碟片管理系统 > 归还碟片 : ");
	}
	
	public void menu(){
		System.out.println("欢迎进入 DVD碟片管理系统");
		System.out.println("\t\t 1、新增DVD碟片");
		System.out.println("\t\t 2、查看DVD碟片");
		System.out.println("\t\t 3、删除DVD碟片");
		System.out.println("\t\t 4、借出DVD碟片");
		System.out.println("\t\t 5、归还DVD碟片");
		System.out.println("\t\t 0、退出");
	}
	
	/**
	 * 管理流程控制的方法
	 */
	public void start(){
		
		int num = 0 ;	//接收用户输入的选项的值
		Scanner sc = new Scanner(System.in);
		
		//初始化程序数据
		init();
		
		do{
			//调用 系统 菜单
			menu();
			
			System.out.println("请输入选项编号：");
			num = sc.nextInt();
			
			switch(num){
			case 0:
				//调用退出的方法
				System.out.println("欢迎下次继续使用本系统！");
				System.exit(0);
				break;
			case 1:
				//调用新增碟片的方法
				addDVD();
				break;
			case 2:
				//查看DVD碟片
				showDVD();
				break;
			case 3:
				//删除DVD碟片
				delDVD();
				break;
			case 4:
				//借出DVD碟片
				outDVD();
				break;
			case 5:
				//归还DVD碟片
				backDVD();
				break;
			}
		
			sc.nextLine();
			sc.nextLine();
			
		}while(true);
		
	}
}
