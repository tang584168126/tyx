
public class ���ǺŴ�ӡ������ {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		//Ӳ˼·    ����� 
		int a = 0;//ѭ������ 
		int b = 0;//ѭ������

		//��һ���ִ�ӡһ�������*
		for(a = 1;a<=7;a+=2){
			for(b = 1;b<=7;b++){
				if(a<b){
					break;   //b��ֵ����aʱ ����ѭ��
				}
			
			System.out.print("*");
			
			
		}
			System.out.println("");//��ӡ����
		}
		//�ڶ����ִ�ӡ���μ��ٵ�*
			for(a = 5;a>=1;a-=2){
				for(b = 5;b>=1;b--){
					if(a == 3){ //�����ж�a��ֵ��С���·�����bug
						if(a>b){
							break;//����b�Ǽ�С�� ���Կ��ԴӴ�������ӡ����
		}
		}else{				//��������ڶ����ֵ�һѭ��A��ֵ��С����bug
					if(a<5){ 
						System.out.print("*");
					} if(a<b){
						break;
					}
					}
			System.out.print("*");	
					}
			System.out.println("");
		}

	}

}
