package class10;

import java.util.*;

/**
 * ������LuckMS
 * ���˳齱����ϵͳ
 * @author fun
 *
 */

public class LMS {
	
	public static void main(String[] args) {
		
		//��Ա�û�Ҫ�洢 �� �˺� �� ���� �� ��Ա�� �� ���� , ����
		String zhs = "";
		String pwds = "";
		int ids = 0;
		String birthdays = "";
		String names = "";
		
		//�����������������
		int luckNum = 0 ;
		
		//�����û�ѡ��ı���
		int num = 0 ;
		
		//�ж��û��Ƿ��¼�ɹ�  true ��ʾ �ɹ���¼ �� false ��ʾ δ��¼
		boolean isLogin = false;
		
		//�洢�û���¼��Ϣ�ı���
		String loginName = "" , loginPwd = "";
		
		//�洢 ���� ��Ա�ŵ�����
		String[] luckIds = new String[5];
		
		int i = 0 ;
		
		Scanner sc = new Scanner(System.in);
		
		do{
			System.out.println("****************************************");
			System.out.println("*                                      *");
			System.out.println("*           ���˳齱ϵͳ                 *");
			System.out.println("*                                      *");
			System.out.println("*                   �� -- �齱Ƥ����˾    *");
			System.out.println("*                                      *");
			System.out.println("****************************************");
			
			System.out.println("\t\t1��ע��");
			System.out.println("\t\t2����¼");
			System.out.println("\t\t3�����˳齱");
			System.out.println("\t\t0���˳�");
			
			System.out.println("\n��ѡ�����Ϲ��ܣ�");
			num = sc.nextInt();
			
			switch(num){
			case 1:
				System.out.println("����д����ע����Ϣ");
				System.out.println("�û�����");
				zhs = sc.next();
				
				System.out.println("���룺");
				pwds = sc.next();
				
				//��� 1000 - 9999 ��ֵ�� ��Ա��
				ids = (int)(Math.random() * 9000 + 1000);
				
				System.out.println("\n����ע����ϢΪ��\n");
				System.out.println("�˺� \t ���� \t\t ��Ա�� ");
				System.out.println(zhs + " \t " + pwds + " \t " + ids);
				System.out.println("\n���س�����...\n");
				
				sc.nextLine();
				sc.nextLine();
				
				break;
			case 2:
				
				System.out.println("�������¼��Ϣ��");
				
				System.out.println("�û�����");
				loginName = sc.next();
				
				System.out.println("���룺");
				loginPwd = sc.next();
				
				//�ж��û���¼��Ϣ�Ƿ����ע����Ϣ
				if(loginName.equals(zhs) && loginPwd.equals(pwds)){
					//�û�����ɹ���¼�����ĵ�¼״̬Ϊ true
					isLogin = true ;
					System.out.println("�ɹ���¼�����س��ص�������...");
					
					sc.nextLine();
					sc.nextLine();
				}
				else{
					//�û����û�е�¼�����ĵ�¼״̬Ϊ false
					isLogin = false ;
					
					System.out.println("��¼ʧ�ܣ����س��ص�������...");
				}
				
				break;
			case 3:
				
				//�жϵ�¼״̬
				if(!isLogin){
					
					//����û�û�о�����¼����˹��ܣ�������������
					System.out.println("���¼�����˹��ܣ����س�������...");
					
					sc.nextLine();
					sc.nextLine();
					
					continue;
				}
				
				System.out.println("�������˳齱���ڣ��齱��Ե�¼�û��� ��Ա�� ����(�˴����鲻һ��)");
				//�齱��Ե�¼�û��� ��Ա�� ����(�˴����鲻һ��)
				
				System.out.print("\n�������˻�Ա��Ϊ��");
				
				//������� 5 �� 4λ�����˻�Ա��
				for(i = 0 ; i < 5 ; i++){
					luckIds[i] = (int)(Math.random() * 9000 + 1000) + "";
					
					System.out.print(luckIds[i] + "  ");
				}
				System.out.println();
				
				//�жϵ�¼�û��Ƿ�Ϊ���˻�Ա
				//1�������������˻�Ա��
				for(i = 0 ; i < luckIds.length ; i++){
					
					//2���ж����˻�Ա���Ƿ����¼�û��Ļ�Ա��һ��
					if((ids + "").equals(luckIds[i])){
						break;
					}
					
				}
				
				//�ж��û��Ƿ��н�
				if(i < luckIds.length){
					System.out.println("��ϲ������Ա��Ϊ��" + ids + " �Ļ�Ա�н��ˣ�");
				}
				else{
					System.out.println("���ź�����û���н���");
				}
				
				sc.nextLine();
				sc.nextLine();
				
				break;
			case 0:
				System.out.println("��ӭ�´μ���ʹ�ã�");
				System.exit(1);
				break;
			default:
				System.out.println("ѡ�����");
				break;
			}
		
		}while(true);
	}
	
}











