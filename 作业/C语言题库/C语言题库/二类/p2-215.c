#include<stdio.h>

int main(void)
{
	int n, i1;
	double z1 = 0, j1 = 1;

	printf("Please input n:");
	scanf("%d", &n);
	for (i1 = 1; i1 <= n; i1++)
	{
		j1 *= i1;
		z1 += 1. / j1; 
	}
	printf("1/1!+1/2!+...+1/%d!=%0.16f", n, z1);
	return 0;
}