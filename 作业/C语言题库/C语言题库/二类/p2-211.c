#include<stdio.h>
#include<math.h>

int main(void)
{
	int n, i1, j1;

	printf("Please input n:");
	scanf("%d", &n);
	for (i1 = 1; i1 <= 2 * n + 1; i1++)
	{
		for (j1 = 1; j1 <= abs(n + 1 - i1); j1++)
		{
			printf(" ");
		}
		for (j1 = 1; j1 <= 2 * n + 1 - 2 * abs(n + 1 - i1); j1++)
		{
			printf("#");
		}
		printf("\n");
	}
	return 0;
}