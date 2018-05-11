#include <stdio.h>

int main (void)
{
	int m, n, i, tt;

	printf("Input m,n:");
	scanf("%d,%d", &m, &n);
	if (m > n)
	{
		tt = m;
		m = n;
		n = tt;
	}
	for (i = m; i <= n; i++)
	{
		if (i % 3 == 0 && (i % 10 == 5 || i % 100 / 10 == 5 || i / 100 == 5))
		{
			printf("%d ", i);
		}
	}
	printf("\n");
	return 0;
}
