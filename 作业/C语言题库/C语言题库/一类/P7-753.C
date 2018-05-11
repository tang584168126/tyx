#include <stdio.h>

int main (void)
{
	int y, i;
	double sum = 1, x;

	printf("Input x, y:");
	scanf("%lf,%d", &x, &y);
	if (y < 0)
	{
		for (i = 1; i <= -y; i++)
		{
			sum = sum * 1 / x;
		}
	}
	if (y > 0)
	{
		for (i = 1; i <= y; i++)
		{
			sum = sum * x;
		}
	}
	printf("%lf^%d=%lf\n", x, y, sum);
	return 0;
}