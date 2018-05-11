package work2;

/**
 * 原始手机类
 * @author Administrator
 *
 */
public class CommonHandset extends Handset implements PlayWiring,SendNote,Call {
	public CommonHandset(String brand,String type){
		super(brand,type);
	}

	@Override
	public void call() {
		System.out.println("开始语音通话......");
	}

	@Override
	public void sendNote() {
		System.out.println("发送文字信息......");
	}

	@Override
	public void playWiring() {
		System.out.println("开始播放音乐<<热雪>>......");	
	}

	@Override
	public void print() {
		System.out.println("这是一款型号为" + super.type + "的" + super.brand+ "手机：");
	}
}
