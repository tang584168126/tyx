#include<stdio.h>

int main(void)
{
	int i, sz[10];
	double zhengshu=0, fushu=0, all=0;

	printf("Input 10 integers.\n");
	for (i = 0; i < 10; i++)
	{
		scanf("%d", &sz[i]);
	}
	for (i = 0; i < 10; i++)
	{
		if (sz[i] > 0)
		{
			zhengshu += sz[i];
		}
		else if (sz[i] < 0 )
		{
			fushu += sz[i];
		}
	}
	for (i = 0; i < 10; i++)
	{
		all += sz[i];
	}
	printf("\nzhengshu=%.0f,fushu=%.0f,all=%.0f", zhengshu, fushu, all);
	return 0;
}