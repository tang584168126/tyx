import java.util.Scanner;


public class �ֽ������� {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		 int a = 0;//���������û��������
		 int b = 2;//ѭ������ ������С������ ��ʼֵΪ2  ��Ϊ�κ�����С������Ϊ2
		 
		 
		 Scanner sc = new Scanner(System.in);
		 
		 System.out.println("������һ��������");
		  a = sc.nextInt();
		  
		  System.out.print(a + "=");
		  
		  //�жϵ�����С�걻����ʱ����ѭ��  ��b++ �ֽ��ʱ�������δ�С����ֽ�����������
		  for(b = 2;a>b;b++){
			 do{
			  if(a%b == 0){			//�ж��û������ֵ��������ȡĤΪ0ʱ˵�������ܱ�b����
				  System.out.print(b);
				  if(a == b){
					  
				  }else{
					  System.out.print("*");
				  }
				  a=a/b;  //���ڷֽ��˵�һ�ε�����Ҫִ�зֽ�
			  }else{
			  break;
			  }
			  } while(a%b == 0);
			  
		  }
		  if(a == 1){//��A����1��ʱ�����ô�ӡa
			 
		  }
		  else{
		  System.out.println(a);//��a����b��ʱ��˵�����ֽܷ���
		  }
		 
			 
		 

	}

}
