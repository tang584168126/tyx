package cdqy;

import java.util.Scanner;

/**
 * �����
 * @author Administrator
 *
 */
public class Player {
	private int levelNo;		//��ǰ��ҵȼ�
	private int curScore;		//��ҵ�ǰ�Ļ���
	private long startTime;		//��ҵ�ǰ�Ŀ�ʼʱ��
	private int costTime;		//��ҵ�ǰ��Ϸ���ĵ�ʱ��
	
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
	 * ����Ϸ����
	 */
	public void play(){
		//������Ϸ�����
		Game game = new Game(this);
		Scanner sc = new Scanner(System.in);
		
		for(int i = 0; i <LevelParam.LEVELS.length; i++){
			//��ʼ��
			this.startTime = System.currentTimeMillis();
			this.levelNo += 1;
			this.curScore = 0;
			this.costTime = 0;
			
			for(int j = 0; j < LevelParam.LEVELS[i].getStrTime(); j++){
				//��������ַ���
				String out = game.printStr();
				//��������ַ���
				String in = sc.next();

				//�����ж�
				game.printResult(out, in);
			}

		}
		
	}
}
