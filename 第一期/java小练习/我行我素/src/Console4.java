

import java.util.Scanner;

public class Console4 {
	public static void main(String[] args) {
		int numShirt = 0;
		int numShoe = 0;
		int numPad = 0;
		Scanner sc = new Scanner(System.in);
		System.out.println("T��������");
		numShirt = sc.nextInt();
		System.out.println("��Ь������");
		numShoe = sc.nextInt();
		System.out.println("���ĸ�����");
		numPad = sc.nextInt();
		int buyShirt = numShirt * 245;
		int buyShoe = numShoe * 570;
		int buyPad = numPad * 320;
		System.out.println("*************���ѵ�***********");
		System.out.println("������Ʒ \t ���� \t ���� \t ���");
		System.out.println("T�� \t ��245 \t" + numShirt + "\t ��" + buyShirt);
		System.out.println("��Ь \t ��570 \t" + numShoe + "\t ��" + buyShoe);
		System.out.println("���� \t ��320\t" + numPad+ "\t ��" + buyPad);
		System.out.println("�ۿۣ�");
		double zheKo = sc.nextDouble();
		double shoudJiao = (numShirt * 245 + numShoe * 570 + numPad * 320) * (1 - zheKo);
		System.out.println("Ӧ�ɷѣ�" + shoudJiao);
		System.out.println("ʵ�ʽ��ѣ�");
		int jiaoFei = sc.nextInt();
		double yu = jiaoFei - shoudJiao;
		System.out.println("���㣺" + yu);
		int fen = (int)shoudJiao * 3 /100;
		System.out.println("���ι�������õĻ��֣�" + fen);
	}

}
