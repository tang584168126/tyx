#include <stdio.h>
#include <stdlib.h>

/* User Code Begin(考生可在本行后添加代码，例如全局变量的定义、函数原型声明等，行数不限) */

void move(int array[], int n, int m);

/* User Code End(考生添加代码结束) */

int main(void)
{
	int *number, n, m, i;

	printf("the total numbers is:");
	scanf("%d", &n);
	printf("back m:");
	scanf("%d", &m);

	number = (int *)malloc(n * sizeof(int));	

	printf("input %d integers:", n);
	for (i=0; i<n; i++)
	{
		scanf("%d", &number[i]);
	}
	
	move(number, n, m);

	printf("after move %d: \n", m);
	for (i=0; i<n; i++)
	{
		printf("%d ", number[i]);
	}
	printf("\n");

	return 0;
}

/* User Code Begin(考生在此后根据设计需要完成程序的其它部分，如函数move，行数不限) */

void move(int array[], int n, int m)
{
	int i1,  *arr;							//不用arr[n]??	

	arr = (int *)malloc(n * sizeof(int));	//就等于arr[n];
												//有了自己的空间相当于数组了
	for (i1 = 0; i1 < n; i1++)
	{
		arr[i1] = array[i1];
	}

	for (i1 = 0; i1 < n; i1++)
	{
		if (i1 + m > n - 1)
		{
			array[i1 + m - n] = arr[i1];	//为什么减去的是10而不是9；
		}
		else
		{
			array[i1 + m] = arr[i1];
		}
	}
}

