package DVD管理;

import java.util.*;

public class DvdManager {
	DVD[] dvds = new DVD[300];
	int i = 0;
	
	Calendar c = Calendar.getInstance();
	Scanner sc = new Scanner(System.in);
	
	/**
	 * 初始化数据
	 */
	public void init(){
		for(i = 0 ; i < dvds.length; i++){
			dvds[i] = new DVD();
		}
		//假定 3个DVD碟片数据
				dvds[0].name = "a";
				dvds[0].dvdState = false;	
				dvds[0].price = 1 ;		
				dvds[0].dvdOutTime = "";
				dvds[0].dvdBackTime = "";
				
				dvds[1].name = "b";
				dvds[1].dvdState = true;	
				dvds[1].price = 1.5 ;		
				dvds[1].dvdOutTime = "2014.5.10";
				dvds[1].dvdBackTime = "";
				
				dvds[2].name = "c";
				dvds[2].dvdState = true;	
				dvds[2].price = 0.8 ;		
				dvds[2].dvdOutTime = "2014.6.1";
				dvds[2].dvdBackTime = "";
	}
	
	/**
	 * 新增DVD的方法
	 */
	public void addDVD(){
		int index = -1;
		String dvdname ="";
		String isContinue;
		System.out.println("DVD管理 > 新增DVD");
		do{
			//找到新增碟片下标
			for(i = 0 ; i < dvds.length; i++){
				if(dvds[i].name == null){
					index = i;
					break;
				}
			}
			do{
				int count = 0;
				System.out.print("请输入需要增加的DVD：");
				dvdname = sc.next();
				for(i = 0 ; i < dvds.length; i++){
					if(dvdname.equals(dvds[i].name)){
						System.out.println("新增碟片重复！\n");
						break;
					}else{
						count++;
					}
				}
				if(count == dvds.length){
					break;
				}
			}while(true);
			dvds[index].name = dvdname;
			System.out.print("\n请输入每日租金：");
			dvds[index].price = sc.nextDouble();
			dvds[index].dvdState = false; 		//出租状态为未出租
			dvds[index].dvdOutTime = "";
			dvds[index].dvdBackTime = "";
			System.out.println("碟片成功！");
			System.out.println("继续增加吗？(y/n)");
			isContinue = sc.next();
			if(isContinue.equalsIgnoreCase("n")){
				isContinue = sc.nextLine();
				break;
			}
		}while(true);
	}
	
	/**
	 * 查看DVD的方法
	 */
	public void showDVD(){
		System.out.println("DVD管理 > 查看DVD");
		System.out.println("名称\t租金\t状态\t出租时间");
		for(i = 0 ; i < dvds.length ; i++){
			if(dvds[i].name != null){
				System.out.println(dvds[i]);
			}
		}
	}
	
	/**
	 * 删除DVD的方法
	 */
	public void delDVD(){
		String delName;
		String isContinue;		//确认是否继续删除
		System.out.println("DVD管理 > 删除DVD");
		do{
			int index = 0;
			System.out.println("请输入需要删除的DVD：");
			delName = sc.next();
			for(i = 0 ; i < dvds.length ; i++){
				if(delName.equals(dvds[i].name)){
					if(dvds[i].dvdState == false ){
						dvds[i].name = null;
						dvds[i].price = 0;
						System.out.println("删除成功！");
						index++;
						break;
					}else{
						if(dvds[i].dvdOutTime != null){
							System.out.println("该碟片已出租，不能删除！");
							index++;
							break;
						}
					}
				}
			}
			if(index != 1){
				System.out.println("没有该碟片！");
			}
			System.out.println("继续删除吗？(y/n)");
			isContinue = sc.next();
			if(isContinue.equalsIgnoreCase("n")){
				isContinue = sc.nextLine();
				break;
			}
		}while(true);
	}
	
	/**
	 * 借出DVD的方法
	 */
	public void outDVD(){
		System.out.println("DVD管理 > 借出DVD");
		String isContinue;
		String outname;
		int year = 0;
		int month = 0;
		int day = 0;
		do{
			int count = 0;
			System.out.println("请输入需要出租的DVD：");
			outname = sc.next();
			for(i = 0 ; i < dvds.length ; i++){
				if(outname.equals(dvds[i].name)){
					if(dvds[i].dvdState == false){
						System.out.println("出租成功！");
						year = c.get(Calendar.YEAR);
						month = c.get(Calendar.MONTH) + 1;
						day = c.get(Calendar.DAY_OF_MONTH);
						dvds[i].dvdState = true;
						dvds[i].dvdOutTime = year + "." + month + "." + day;
						count++;
						break;
					}else{
						if(dvds[i].dvdOutTime != null){
							System.out.println("该碟片已出租，不能再次出租！");
							count++;
							break;
						}
					}
				}
			}if(count != 1){
				System.out.println("没有该碟片！");
			}
			System.out.println("继续出租吗？(y/n)");
			isContinue = sc.next();
			if(isContinue.equalsIgnoreCase("n")){
				isContinue = sc.nextLine();
				break;
			}
		}while(true);
		
	}
	
	/**
	 * 归还DVD的方法
	 */
	public void backDVD(){
		System.out.println("DVD管理 > 归还DVD");
		String isContinue;
		String backname;
		do{
			int count = 0;
			System.out.println("请输入需要归还的DVD：");
			backname = sc.next();
			for(i = 0 ; i < dvds.length ; i++){
				if(backname.equals(dvds[i].name)){
					if(dvds[i].dvdState == true){
						System.out.println("归还成功！");
						dvds[i].dvdState = false;
						count++;
						break;
					}else{
						if(dvds[i].dvdOutTime != null){
							System.out.println("该碟片已归还，不需要再次归还！");
							count++;
							break;
						}
					}
				}
			}if(count != 1){
				System.out.println("没有该碟片！");
			}
			System.out.println("继续归还吗？(y/n)");
			isContinue = sc.next();
			if(isContinue.equalsIgnoreCase("n")){
				isContinue = sc.nextLine();
				break;
			}
		}while(true);
		
	}
	
	/**
	 * 修改的方法
	 */
	public void recompose(){
		System.out.println("DVD管理 > 修改");
		String recomposename;
		String isContinue;
		int money = 0;
		do{
			int count = 0;
			System.out.println("请输入需要修改的DVD：");
			recomposename = sc.next();
			for(i = 0 ; i < dvds.length ; i++){
				if(recomposename.equals(dvds[i].name)){
					System.out.println("请输入修改的价格：");
					dvds[i].price = sc.nextInt();
					System.out.println("修改成功！");
					count++;
					break;
				}
			}
			if(count != 1){
				System.out.println("没有该碟片！");
			}
			System.out.println("继续修改吗？(y/n)");
			isContinue = sc.next();
			if(isContinue.equalsIgnoreCase("n")){
				isContinue = sc.nextLine();
				break;
			}
		}while(true);
	}
	
	/**
	 * 菜单
	 */
	public void menu(){
		System.out.println("*****************************************\n");
		System.out.println("欢迎使用迷你DVD管理器\n");
		System.out.println("*****************************************\n");
		System.out.println("1.新增DVD");
		System.out.println("2.查看DVD");
		System.out.println("3.删除DVD");
		System.out.println("4.借出DVD");
		System.out.println("5.归还DVD");
		System.out.println("6.修改DVD");
		System.out.println("0.退出");
	}

}
