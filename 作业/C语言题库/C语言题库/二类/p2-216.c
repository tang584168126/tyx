#include<stdio.h>

int main(void)
{
	int m, i1, j1, arr[20][20], max = 0, n1, m1;

	printf("Please input m:");
	scanf("%d", &m);
	printf("Please input array:\n");
	for (i1 = 0; i1 < m; i1++)
	{
		for (j1 = 0; j1 < m; j1++)
		{
			scanf("%d", &arr[i1][j1]);
			if (max < arr[i1][j1])
			{
				max = arr[i1][j1];
				n1 = i1;
				m1 = j1;
			}
		}
	}
	printf("max=%d,i=%d,j=%d", max, n1, m1);
	return 0;
}