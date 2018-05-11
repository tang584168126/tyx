#include<stdio.h>
#include<math.h>

int main(void)
{
	int a1, n, i1, j1;
	double total = 0, t1;

	printf("Please input a1,n: ");
	scanf("%d,%d", &a1, &n);
	for (i1 = 1; i1 <= n; i1++)
	{
		t1 = 0;
		for (j1 = 0; j1 < i1; j1++)
		{
			t1 += a1 * pow(10., j1); 
		}
		total += t1;
	}
	printf("a+aa+...=%.0f", total);
	return 0;
}