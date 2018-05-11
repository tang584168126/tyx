#include<stdio.h>

int main(void)
{
	int n1, i1, j1, sn = 0;

	printf("Please input an integer:");
	scanf("%d", &n1);
	for (i1 = 6; i1 <= n1; i1++)	//初值和末值而非算的个数哈
	{
		for (j1 = 1; j1 <= i1 / 2; j1++)
		{
			if (i1 % j1 == 0)
			{
				sn += j1;
			}
		}
		if (sn == i1)
		{
			printf("%6d is a wanshu", i1);
			for (j1 = 1; j1 <= i1 / 2; j1++)
			{
				if (i1 % j1 == 0)
				{
					printf("%5d", j1);
				}
			}
			printf("\n");
			sn = 0;
		}

	}
	return 0;
}