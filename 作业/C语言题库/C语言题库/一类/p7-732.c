#include<stdio.h>

int main(void)
{
	int arr[3][3], line, list;		//不能位double型，不是的话line < 3难判断
	double jg = 0;					//arr[][]中的一定要位 int 型的
	 
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