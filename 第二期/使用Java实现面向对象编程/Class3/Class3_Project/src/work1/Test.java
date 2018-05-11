package work1;

/**
 * ²âÊÔÀà
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args){
		Master master = new Master("Ğ¡Íõ",100);
		
		Pet dog = new Dog("°×Ñ©","Ê¨×Ó¹·");
		dog.print();
		dog.eat();
		
		Pet pen = new Penguin("Ğ¡ç÷","Q×Ğ");
		pen.print();
		pen.eat();
		
		Pet cat = new Cat("ºÚÒ¹","ºÚÉ«");
		cat.print();
		cat.eat();
	}
}
