#include<stdio.h>

int main(void)
{
	int i1, j1, n1;

	printf("input a number(1~9):");
	scanf("%d", &n1);

	for (i1 = 1; i1 <= n1; i1++)
	{
		for (j1 = 1; j1 <= i1; j1++)
		{
			printf("%d*%d=%-3d", i1, j1, i1 * j1);
		}

		printf("\n");
	}

	return 0;
}