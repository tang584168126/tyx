#include<stdio.h>

int main(void)
{
	int n, i1;
	float sn = 10000, hn = 10000;

	printf("Please input n:");
	scanf("%d", &n);
	for (i1 = 1; i1 <= n; i1++)
	{
		if (i1 != 1)
		{
			sn = (float)(sn + hn * 2);
		}
		hn = (float)(hn / 2);
	}
	printf("sn=%f,hn=%f", sn, hn);
	return 0;
}