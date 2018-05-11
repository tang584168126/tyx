package exam3;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.File;
import java.io.FileReader;
import java.io.FileWriter;

public class Test {
	public static void main(String[] args) {
		File file = new File("C:\\source.txt");
		System.out.println("C�����ļ���С��" + file.length());
		file = new File("D:\\target.txt");
		//��
		BufferedReader br = null;
		//д
		BufferedWriter bw = null;
		
		try {
			br = new BufferedReader(new FileReader("C:\\source.txt"));
			bw = new BufferedWriter(new FileWriter("D:\\target.txt"));
			String str = null;
			StringBuffer sb = new StringBuffer();
			System.out.println();
			//����ǰ�ļ�
			while((str = br.readLine()) != null){
				sb.append(str);
				System.out.println(str);
			}
			
			//���ƺ�
			bw.write(sb.toString());
			bw.flush();
			file.length();
			br = new BufferedReader(new FileReader("D:\\target.txt"));
			String str1 = null;
			StringBuffer sb1 = new StringBuffer();
			System.out.println();
			while((str1 = br.readLine()) != null){
				sb.append(str1);
				System.out.println(str1);
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
					// TODO: handle exception
				}
			}
		}
		
	}
}
