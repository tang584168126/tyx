
public class ����������8��8 {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		
		int i,j = 0;//ѭ������ ��ͬʱ�������ι���ֵ
		int k = 0; //����i*j �Ļ�
		
		//�ۼӹ���ֵ�Դﵽ����
		for(i = 1;i<9;i++){
			for(j = 1; j<9; j++){
				k = i+j;
				if(k%2 == 0){
					System.out.print("��");
				}else{
					System.out.print("��");
				}
				
			}
			System.out.println(" ");  //�ڶ���for����  �𵽴�ӡ���е�����
		}



	}

}
