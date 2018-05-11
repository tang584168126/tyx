/**
 * 会议室类 
 * 属性：会议室编号，会议室名称，使用状态（预定，空闲）
 * 方法：预定 
 * 
 */
public class Boardroom {
	public String id;// 编号
	public String name;// 名称
	public boolean used;// 使用状态（true:预定  false:空闲）

	//预定的方法,检查会议室使用状态，如果空闲则完成预定流程
	public boolean bespeak() {
		if(this.used==false){
			System.out.println("成功申请"+this.name);
			return true;
		}else{
			System.out.println(this.name+"已经被预定！");
			return false;
		}
	}
}
