#include <stdio.h>
#include <math.h>

int main(void)
{
	double b1, b2, b3, p0, area;

	printf("please input triange sides:");
	scanf("%lf,%lf,%lf", &b1, &b2, &b3);
	if (b1 + b2 <= b3 || b1 + b3 <= b2 || b2 + b3 <= b1)
	{
		printf("\ndata error");
	}
	else
	{
		p0 = (b1 + b2 + b3) / 2;
		area = sqrt(p0 * (p0 - b1) * (p0 - b2) * (p0 - b3));
		printf("\narea=%.2f", area);
	}
	return 0;
}
