#include<stdio.h>

int main(void)
{
	printf("Input 2 integer to determine the range.");
	scanf("%d %d", &from, &to);
	
	return 0;
}
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
