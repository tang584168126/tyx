#include<stdio.h>


int main(void)
{
	int n, i1, j1;

	printf("Please input n:");
	scanf("%d", &n);
	for (i1 = 0; i1 < 2 * n - 1; i1++)
	{
		for (j1 = 0; j1 < 2 * n - 1; j1++)
		{
			if (j1 == 0)
			{
				printf("$");
			}
			else if (j1 + i1 == n - 1)
			{
				printf("$");
			}
			else if (i1 - j1 == n - 1)
			{
				printf("$");	
			}
			else 
			{
				printf(" ");
			}
		}
		printf("\n");
	}
	return 0;
}