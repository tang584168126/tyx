#include<stdio.h>

int main(void)
{
	int arr[3][3], line, list;		//����λdouble�ͣ����ǵĻ�line < 3���ж�
	double jg = 0;					//arr[][]�е�һ��Ҫλ int �͵�
	 
	for (line = 0; line < 3; line++)
	{
		for (list = 0; list < 3; list++)
		{
			scanf("%d", &arr[line][list]);
		}
	}
	for (line = 0; line < 3; line++)
	{
		for (list = 0; list < 3; list++)
		{
			jg += arr[line][list];
		}
	}
	printf("sum=%.0f", jg);
	return 0;
}