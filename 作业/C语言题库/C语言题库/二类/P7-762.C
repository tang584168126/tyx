#include <stdio.h>

/* User Code Begin(考生可在本行后添加代码，例如全局变量的定义、函数原型声明等，行数不限) */

int FindMin(int num[], int n, int *pMinPos)
{
	int min = num[0], i;

	for (i = 0; i < n; i++)
	{
		if (min > num[i])
		{
			min = num[i];
			*pMinPos = i;
		}
	}

	return min;
}

/* User Code End(考生添加代码结束) */

int main(void)
{
	int num[10], i, MinVal, MinPos;

	printf("Input 10 integers.\n");
	for (i=0; i<10; i++)
	{
		scanf("%d", &num[i]);
	}

	MinVal = FindMin(num, 10, &MinPos);
	printf("MinVal=%d MinPos=%d\n", MinVal, MinPos);

	return 0;
}

/* User Code Begin(考生在此后根据设计需要完成程序的其它部分，如函数FindMin，行数不限) */



