#include<stdio.h>

int main(void)
{
	int n, arr[14][14], i1, j1, sum1 = 0, sum2 = 0;

	printf("Enter n:");
	scanf("%d", &n);

	for (i1 = 0; i1 < n; i1++)
	{
		for (j1 = 0; j1 < n; j1++)
		{
			arr[i1][j1] = (i1 + j1) * n;

			if (i1 != 0 && i1 != n - 1 
				&& j1 != 0 && j1 != n - 1)
			{
				sum1 += arr[i1][j1];
			}
			
			if (i1 == j1)
			{
				sum2 += arr[i1][j1];
			}

			printf("%4d", arr[i1][j1]);
		}
		printf("\n");
	}
	
	printf("sum1=%d\nsum2=%d", sum1, sum2);

	return 0;
}