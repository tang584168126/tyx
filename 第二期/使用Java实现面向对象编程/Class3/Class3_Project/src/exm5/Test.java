package exm5;

/**
 * ≤‚ ‘¿‡
 * @author Administrator
 *
 */
public class Test {
	public static void main(String[] args){
		Printer dmp = new DotMatrixPrinter();
		dmp.print();
		
		Printer ip = new InkpetPrinter();
		ip.print();
		
		Printer lp = new LaserPrinter();
		lp.print();
	}
}
