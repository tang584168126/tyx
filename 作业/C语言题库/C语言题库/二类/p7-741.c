#include<stdio.h>

int main(void)
{
	int m, n, i1, j1, t1 = 1, n1 = 0;

	printf("Input the m,n: ");
	scanf("%d,%d", &m, &n);
	printf("The result:\n");

	for (i1 = m; ; i1++)
	{
		t1 = 1;

		for (j1 = 2; j1 <= i1 / 2; j1++)
		{
			if (i1 % j1 == 0)
			{
				t1 = 0;
			}
		}

		if (t1 == 1)
		{
			n1++;
			printf("%d ", i1);
		}

		if (n1 == n)
		{
			break;
		}
	}

	return 0;
}