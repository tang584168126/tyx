package ������;

import java.util.Calendar;
import java.util.Scanner;

/**
 * ʹ��������̷���
 * @author fun
 *
 */
public class GuoCheng {
	public static void main(String[] args){
		
		int year = 0;			//��
		int month = 0;			//��
		int day = 0;			//��
		int i = 0 , j = 0;
		int count = 0;
		
		Scanner sc = new Scanner(System.in);
		
		System.out.println("*****************������******************");
		System.out.print("��������ݣ�");
		year = sc.nextInt();
		System.out.print("�������·�");
		month = sc.nextInt();
		//����֮ʱ
		if(year / 4 == 0 && year / 100 != 0 || year / 400 == 0){
			if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12){
				day = 31;
			}else if(month == 4 || month == 6 || month == 9 || month == 11){
				day = 30;
			}else if(month == 2){
				day = 29;
			}
		}else{			//ƽ��֮ʱ
			if(month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12){
				day = 31;
			}else if(month == 4 || month == 6 || month == 9 || month == 11){
				day = 30;
			}else if(month == 2){
				day = 28;
			}
		}
		//������ڼ�
		/*
		 weekday = (year +��year / 4 + year / 100 / 4 - 2 * (year / 100) + 26 * (month + 1 )/ 10 + day - 1);
		 
		 */
		Calendar ff = Calendar.getInstance();
		ff.set(year, month - 1, 1);
		int l = ff.get(Calendar.DAY_OF_WEEK) - 1;
		
		System.out.println("������\t����һ\t���ڶ�\t������\t������\t������\t������\t");
		for(i = 0 ;i <l ;i++){
			System.out.print(" \t");
		}
		for(j = 1 ; j <= day ;j++){
			System.out.print(j + "\t");
			count++;
			if(count % 7 == 0){
				System.out.println();
			}
		}
			
		
	}

}
