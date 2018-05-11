package cdqy;


/**
 * ��Ϸ��
 * @author Administrator
 *
 */
public class Game {
	Player player = new Player();		//���
	
	public Game(Player player){
		this.player = player;
	}
	
	/*
	 * 	��Ϸ����ַ���
	 */
	public String printStr(){
		//��ȡ��ҵȼ�
		int levelNo = player.getLevelNo();
		
		//������ҵȼ���ȡ�õȼ����ַ�������
		int strLength = LevelParam.LEVELS[levelNo - 1].getStrLength();
		
		//�����ַ���
		StringBuffer buffer = new StringBuffer();

		for(int i = 0; i < strLength; i ++){
			//�����
			char rand = (char)(Math.random() * 26 + 97);
			
			buffer.append(rand);
		}
		
		System.out.println(buffer.toString());
		return buffer.toString();
	}
	
	/*
	 * �ж����������
	 */
	public void printResult(String out,String in){
		
		//�ж�����������͵����������Ƿ���ͬ
		if(out.equals(in)){
			
			//��ȡ��һ��ʱ��
			int startTime = (int)(System.currentTimeMillis() - player.getStartTime())/1000;
			
			//�ж��������ʱ���Ƿ�С�ڵ��Թ涨ʱ��
			if(startTime < LevelParam.LEVELS[player.getLevelNo() - 1].getTimeLimit()){

						//������ҵ�ǰ����
						player.setCurScore(player.getCurScore() + LevelParam.LEVELS[player.getLevelNo() - 1].getPerScore());
												
						//������ĵ�ʱ��
						player.setCostTime(startTime);
						
						System.out.println("������ȷ�����ļ���" + LevelParam.LEVELS[player.getLevelNo() -1].getLevelNo() + "�����Ļ���" + player.getCurScore() + "�����õ�ʱ��" + player.getCostTime() + "s");
			}else{
				System.out.println("������̫�����Ѿ���ʱ����Ϸ������");
				System.exit(1);
			}
		}else{
			System.out.println("���������Ϸ������");
			System.exit(1);
		}
	}
}
