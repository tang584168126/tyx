import java.util.Scanner;


public class ���Լ�� {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		int a = 0;//ѭ������
		int b = 0;//�����һ����
		int c = 0;//����ڶ�����
		int d = 0;//
		int e = 0;//
		double f = 0;
		double h = 0;
		double i = 0;
		
		
		Scanner sc  = new Scanner(System.in);
		System.out.print("�������һ������");
		b = sc.nextInt();
		h = b;
		System.out.print("������ڶ�������");
		c = sc.nextInt();
		i = c;
		for(a = 1;a<10000000; a++){
			d = b/c;
			e = c/b;
			if(b%c == 0 || c%b == 0){
			if(b == d*c || c == e*b){
			if(a == d*c ||a == e*b){
				System.out.println("���ǵ���С��������"+a);
			}
			}else{
				continue;
			}
			}else if(a == b*c){
				System.out.println("���ǵ���С��������"+a);
			}
		}
		h = b;
		f = c;
		
		if (h>f){
			h = h+f;
			f =h-f;
			h = h-f;
		}
		if(f%h== 0){
			
			System.out.println("������С��Լ����"+h);
		}else{
			
			while(h%f != 0){
			i = h%f;
			f = h;
			h = i;
			
			
			}
			
			System.out.println("������С��Լ����"+i);
			
		}
			/*���Լ��15  9  ���Լ��Ϊ3
			 * ��ͬ���� ����һ��
			 * 
			 */
		/*	
		for(a = 2;a<=b;a++){
			
			while(b % a ==0){
			if(b%a == 0){
				b = b/a;
				if(e<a){
					e=a;
					System.out.println(b+"��Լ��"+e);
				}
			}
			}
			
		}
		
		e = 0;
		
		for(a = 2;a<=c;a++){
			
			while(c % a ==0){
			if(c%a == 0){
				c = c/a;
				if(e<a){
					e=a;
				}
			}
			}
			
		}
		System.out.println(b+"��Լ��"+e);
		*/
		/*if(h>i){
			h = h+i;
			i = h-i;
			h = h-i;
		}
		if(h<i && i%h==0){
			f = h;
		}
		while(f!=0){
			
		}
		System.out.println("���Լ��Ϊ"+f);
		*/
			
		
			
			
			
		

	}

	}
