package class12;

public class Test {
		public static void main(String[] args) {
			Count count = new Count();
			Ren ren = new Ren();
			Computer cpu = new Computer();
			count.jieMian();
			ren.giveResult();
			cpu.giveResult();
			count.judgeGames();
		}
}
