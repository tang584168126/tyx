package cdqy;


/**
 * 游戏类
 * @author Administrator
 *
 */
public class Game {
	Player player = new Player();		//玩家
	
	public Game(Player player){
		this.player = player;
	}
	
	/*
	 * 	游戏输出字符串
	 */
	public String printStr(){
		//获取玩家等级
		int levelNo = player.getLevelNo();
		
		//根据玩家等级获取该等级的字符串长度
		int strLength = LevelParam.LEVELS[levelNo - 1].getStrLength();
		
		//创建字符串
		StringBuffer buffer = new StringBuffer();

		for(int i = 0; i < strLength; i ++){
			//随机数
			char rand = (char)(Math.random() * 26 + 97);
			
			buffer.append(rand);
		}
		
		System.out.println(buffer.toString());
		return buffer.toString();
	}
	
	/*
	 * 判断玩家输出结果
	 */
	public void printResult(String out,String in){
		
		//判断玩家输入结果和电脑输出结果是否相同
		if(out.equals(in)){
			
			//获取第一次时间
			int startTime = (int)(System.currentTimeMillis() - player.getStartTime())/1000;
			
			//判断玩家输入时间是否小于电脑规定时间
			if(startTime < LevelParam.LEVELS[player.getLevelNo() - 1].getTimeLimit()){

						//计算玩家当前积分
						player.setCurScore(player.getCurScore() + LevelParam.LEVELS[player.getLevelNo() - 1].getPerScore());
												
						//玩家消耗的时间
						player.setCostTime(startTime);
						
						System.out.println("输入正确，您的级别" + LevelParam.LEVELS[player.getLevelNo() -1].getLevelNo() + "，您的积分" + player.getCurScore() + "，已用的时间" + player.getCostTime() + "s");
			}else{
				System.out.println("你输入太慢，已经超时，游戏结束！");
				System.exit(1);
			}
		}else{
			System.out.println("输入错误！游戏结束！");
			System.exit(1);
		}
	}
}
