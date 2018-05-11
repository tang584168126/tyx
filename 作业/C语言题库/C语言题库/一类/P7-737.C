#include <stdio.h>
#include <math.h>

int main(void)
{
	int aa, bb, cc;
	int max, max1 = 0, max2 = 0;

	printf("Input 3 numbers: ");
	scanf("%d,%d,%d", &aa, &bb, &cc);

	if (fabs(aa) > fabs(bb))
	{
		max = aa;
		if (fabs(aa) > fabs(cc))
		{
			max = aa;
		}
		else if (fabs(aa) == fabs(cc))
		{
			max = aa;
			max1 = cc;
		}
		else 
		{
			max = cc;
		}
	}
	else if (fabs(aa) == fabs(bb))
	{
		max = aa;
		max1 = bb;
		if (fabs(aa) > fabs(cc))
		{
			max = aa;
			max1 = bb;
		}
		else if (fabs(aa) == fabs(cc))
		{
			max = aa;
			max1 = bb;
			max2 = cc;
		}
		else 
		{
			max = cc;
		}
	}
	else 
	{
		max = bb;
		if (fabs(bb) > fabs(cc))
		{
			max = bb;
		}
		else if (fabs(bb) == fabs(cc))
		{
			max = bb;
			max1 = cc;
		}
		else 
		{
			max = cc;
		}
	}
	printf("The number with maximum absolute value is %d.", max);

	return 0;
}
