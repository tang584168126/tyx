#include <stdio.h>

int main(void)
{
	int i, j, m, sum = 0, arr[20][20];

	printf("Please input m:");
	scanf("%d", &m);

	printf("Please input array:\n");
	for (i = 0; i < m; i++)
	{
		for (j = 0; j < m; j++)
		{
			scanf("%d", &arr[i][j]);
		}
	}
	for (i = 0; i < m; i++)
	{
		for (j = 0; j < m; j++)
		{
			if (i == 0 || i == (m - 1) || j == 0 || j == (m - 1))
			{
				sum = sum + arr[i][j];
			}
		}
	}

	printf("sum=%d", sum);
	return 0;
}