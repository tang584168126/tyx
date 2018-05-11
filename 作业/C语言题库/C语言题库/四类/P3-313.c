#include<stdio.h>

int main(void)
{
	int num[20][20], i, j, m, n, max, min;

	printf("please input m and n:");
	scanf("%d%d", &m, &n);
	

	for (i = 0; i < m; i++)
	{
		for (j = 0; j < n; j++)
		{
			scanf("%d", &num[i][j]);
		}
	}

	/*以下判断鞍点*/
	for (i = 0; i < m; i++)
	{
		max = 0;
		for (j = 0; j < n; j++)
		{
			if (num[i][j] > num[i][max])
			{
				max = j;
			}
		}
		/*以上求i行中最大值为num[i][max]*/
		/*以下求第max列中的最小值*/
		min = num[0][max];
		for (j = 0; j < m; j++)
		{
			if (num[j][max] < min)
			{
				min = num[j][max];
			}
		}

		/*判断鞍点*/
		if (min == num[i][max])
		{
			printf("\nyou an dian, wei:a[%d][%d]=%d\n", i, max, min);
			break;
		}
	}
	/*判断鞍点*/
	if (i == m)
	{
		printf("\nmei you an dian.\n");
	}

	return 0;

}