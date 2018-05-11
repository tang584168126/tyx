package class11;

public class InitialSchool {

	public static void main(String[] args){
		School center = new School();
		System.out.println("变量前：");
		center.showCenter();
		center.SchoolName = "北京远航";
		center.classNumber = 10;
		center.labNumber = 10;
		System.out.println("\n变量后：");
		center.showCenter();
	}
	
}
