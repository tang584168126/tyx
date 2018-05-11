package work2;

/**
 * 测试类
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args){
		//原始手机
		CommonHandset cmset = new CommonHandset("G502c","索尼爱立信");
		cmset.print();
		cmset.playWiring();		//播放
		cmset.sendNote();		//发信息
		cmset.call();			//通话
		
		System.out.println("\n");
		
		//智能手机
		AptitudeHandset adset = new AptitudeHandset("HTC","I9100");
		adset.print();
		adset.netPlay();		//上网
		adset.playWiring();		//播放
		adset.takePicuter();	//拍照
		adset.sendNote();		//发信息
		adset.call();			//通话
	}
}
