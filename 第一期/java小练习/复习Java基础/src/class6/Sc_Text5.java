package class6;

public class Sc_Text5 {
	public static void main(String[] args){
		int man = 0 ;
		int woman = 0 ;
		int kids = 0 ;
		
		for(man = 0 ; man <=10 ; man++){
			woman = 20 - 2 * man ;
			kids = 30 - man - woman ;
			if(man * 3 + woman * 2 + kids * 1 == 50){
				System.out.println("男人：" + man + "  女人：" + woman + "  小孩：" + kids);
			}
		}
	}

}
