#include<stdio.h>

int  main(void)
{
	int i1, a1[5], a2[5], sum = 0;

	printf("Input A: ");
	
	for (i1 = 0; i1 < 5; i1++)
	{
		scanf("%d", &a1[i1]);
	}

	printf("Input B: ");

	for (i1 = 0; i1 < 5; i1++)
	{
		scanf("%d", &a2[i1]);
	}

	for (i1 = 0; i1 < 5; i1++)
	{
		sum += a1[i1] * a2[4 - i1];
	}

	printf("sum=%d", sum);

	return 0;
}
