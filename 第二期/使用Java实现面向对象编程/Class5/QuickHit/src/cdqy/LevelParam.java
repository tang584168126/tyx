package cdqy;
/**
 * 等级管理类
 * @author Administrator
 *
 */
public class LevelParam {
	public final static Level[] LEVELS = new Level[6];		//等级
	
	//游戏参数初始化
	static{
		LEVELS[0] = new Level(1,2,10,1,30);
		LEVELS[1] = new Level(2,3,12,2,26);
		LEVELS[2] = new Level(3,4,14,3,22);
		LEVELS[3] = new Level(4,5,16,4,18);
		LEVELS[4] = new Level(5,6,18,6,14);
		LEVELS[5] = new Level(6,7,20,10,8);
	}
}
