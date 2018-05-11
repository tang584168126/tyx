#include<stdio.h>

int main(void)
{
	int n, i1;
	double total = 1;

	printf("Please input n:");
	scanf("%d", &n);
	for (i1 = 1; i1 < n; i1++) //这里的i1是天数 - 1
	{
		total = (total + 1) * 2;
	}
	printf("total=%.0f", total);
	return 0;
}