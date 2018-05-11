package work2;

/**
 * 智能手机类
 * @author Administrator
 *
 */
public class AptitudeHandset extends Handset implements SendNote,Call,NetWork,PlayWiring,TheakePicture {
	public AptitudeHandset(String brand,String type){
		super(brand,type);
	}

	@Override
	public void takePicuter() {
		System.out.println("咔嚓......拍照成功");
	}

	@Override
	public void playWiring() {
		System.out.println("开始播放视频<<小时代>>......");
	}

	@Override
	public void netPlay() {
		System.out.println("已经启动移动网络......");
	}

	@Override
	public void call() {
		System.out.println("开始视频通话......");
	}

	@Override
	public void sendNote() {
		System.out.println("发送带图片与文字的信息......");
	}

	@Override
	public void print() {
		System.out.println("这是一款型号为" + super.type + "的" + super.brand+ "手机：");
	}
}
