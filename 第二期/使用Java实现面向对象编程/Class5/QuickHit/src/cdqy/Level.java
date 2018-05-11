package cdqy;
/**
 * 游戏类
 * @author Administrator
 *
 */
public class Level {
	private int levelNo;		//等级编号
	private int strLength;		//字符串长度
	private int strTime;		//输入正确的次数
	private int perScore;		//输入正确每次的得分
	private int timeLimit;		//时间限制
	
	public Level(int levelNo, int strLength, int strTime, int perScore,int timeLimit) {
		this.levelNo = levelNo;
		this.strLength = strLength;
		this.strTime = strTime;
		this.perScore = perScore;
		this.timeLimit = timeLimit;
	}
	public int getLevelNo() {
		return levelNo;
	}
	public void setLevelNo(int levelNo) {
		this.levelNo = levelNo;
	}
	public int getStrLength() {
		return strLength;
	}
	public void setStrLength(int strLength) {
		this.strLength = strLength;
	}
	public int getStrTime() {
		return strTime;
	}
	public void setStrTime(int strTime) {
		this.strTime = strTime;
	}
	public int getPerScore() {
		return perScore;
	}
	public void setPerScore(int perScore) {
		this.perScore = perScore;
	}
	public int getTimeLimit() {
		return timeLimit;
	}
	public void setTimeLimit(int timeLimit) {
		this.timeLimit = timeLimit;
	}
}
