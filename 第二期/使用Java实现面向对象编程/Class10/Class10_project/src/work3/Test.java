package work3;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.io.FileWriter;

public class Test {
	public static void main(String[] args) {
		BufferedReader br = null;
		BufferedWriter bw = null;
		
		try {
			br = new BufferedReader(new FileReader("C:\\pet.template"));
			String str = null;
			StringBuffer sb = new StringBuffer();
			System.out.print("�滻ǰ��");
			while((str = br.readLine()) != null){
				System.out.println(str);
				sb.append(str);
			}
			
			//�滻
			String nextStr = sb.toString().replace("{name}", "ŷŷ");
			nextStr = sb.toString().replace("{type}", "����");
			nextStr = sb.toString().replace("{master}", "��ΰ");
			bw = new BufferedWriter(new FileWriter("D:\\myDoc\\pet.txt"));
			bw.write(nextStr);
			bw.flush();
			
			br = new BufferedReader(new FileReader("D:\\myDoc\\pet.txt"));
			String str1 = null;
			StringBuffer sb1 = new StringBuffer();
			System.out.print("�滻��");
			while((str1 = br.readLine()) != null){
				System.out.println(str1);
				sb1.append(str1);
			}
		} catch (Exception e) {
			e.printStackTrace();
		}finally{
			if(bw != null){
				try {
					bw.close();
					if(br != null){
						br.close();
					}
				} catch (Exception e2) {
					e2.printStackTrace();
				}
			}
		}
	}
}
