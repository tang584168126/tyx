#include<stdio.h>

int main(void)
{
	int arr[100], i1, j1, m, n1 = 0, n2 = 0, t1 = 0;
	//这个arr为什么定义为100而非101

	printf("input a number: ");
	scanf("%d", &m);

	if (m <= 0)
	{
		n2 = 2;
		printf("error");
	}
	
	for (i1 = 2; i1 < m; i1++)
	{
		t1 = 0;								//这个每执行一次就要初始化
		for (j1 = 2; j1 < i1; j1++)
		{
			if (i1 % j1 == 0)
			{
				t1 = 1;
			}
		}
		if (t1 == 0)
		{
			arr[n1] = i1;
			n1++;						//会自加个一

			if (n1 > 100)				//为什么是100，而不是99
			{
				n2 = 1;
			}
		}
	}

	if (n2 == 1)
	{
		printf("overflow");
	}
	if (n2 == 0)
	{
		printf("n=%d\n", n1);

		for (i1 = 0; i1 < n1; i1++)			//为什么从0开始，而非从1
		{
			printf("%5d", arr[i1]);

			if ((i1 + 1) % 15 == 0)
			{
				printf("\n");
			}
		}
	}

	return 0;
}