#include<stdio.h>

int main(void)
{
	int num, cook, hen, chick;
	double mon;

	printf("Input the money: ");
	scanf("%lf", &mon);
	printf("Input the number: ");
	scanf("%d", &num);
	printf("  cook   hen chick\n");

	for (cook = 0; cook <= mon / 5; cook++)					//就是没写出= 
	{
		for (chick = 0; chick <= mon * 3; chick = chick + 3)
		{
			for (hen = 0; hen <= mon / 3; hen++)
			{
				if (cook + hen + chick == num && cook * 5 + hen * 3 + chick / 3 == mon)
				{
					printf("%6d%6d%6d\n", cook, hen, chick);
				}
			}
		}
	}
	return 0;
}