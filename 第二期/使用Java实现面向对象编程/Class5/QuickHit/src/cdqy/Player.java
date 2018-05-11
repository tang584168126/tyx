package cdqy;

import java.util.Scanner;

/**
 * 玩家类
 * @author Administrator
 *
 */
public class Player {
	private int levelNo;		//当前玩家等级
	private int curScore;		//玩家当前的积分
	private long startTime;		//玩家当前的开始时间
	private int costTime;		//玩家当前游戏消耗的时间
	
	public int getLevelNo() {
		return levelNo;
	}
	public void setLevelNo(int levelNo) {
		this.levelNo = levelNo;
	}
	public int getCurScore() {
		return curScore;
	}
	public void setCurScore(int curScore) {
		this.curScore = curScore;
	}
	public long getStartTime() {
		return startTime;
	}
	public void setStartTime(long startTime) {
		this.startTime = startTime;
	}
	public int getCostTime() {
		return costTime;
	}
	public void setCostTime(int costTime) {
		this.costTime = costTime;
	}
	
	/*
	 * 玩游戏方法
	 */
	public void play(){
		//创建游戏类对象
		Game game = new Game(this);
		Scanner sc = new Scanner(System.in);
		
		for(int i = 0; i <LevelParam.LEVELS.length; i++){
			//初始化
			this.startTime = System.currentTimeMillis();
			this.levelNo += 1;
			this.curScore = 0;
			this.costTime = 0;
			
			for(int j = 0; j < LevelParam.LEVELS[i].getStrTime(); j++){
				//电脑输出字符串
				String out = game.printStr();
				//玩家输入字符串
				String in = sc.next();

				//电脑判断
				game.printResult(out, in);
			}

		}
		
	}
}
