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

	/*�����жϰ���*/
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
		/*������i�������ֵΪnum[i][max]*/
		/*�������max���е���Сֵ*/
		min = num[0][max];
		for (j = 0; j < m; j++)
		{
			if (num[j][max] < min)
			{
				min = num[j][max];
			}
		}

		/*�жϰ���*/
		if (min == num[i][max])
		{
			printf("\nyou an dian, wei:a[%d][%d]=%d\n", i, max, min);
			break;
		}
	}
	/*�жϰ���*/
	if (i == m)
	{
		printf("\nmei you an dian.\n");
	}

	return 0;

}