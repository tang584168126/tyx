#include<stdio.h>

int main(void)
{
	int arr[10], i1, j1 = 1, shu;

	printf("please input 10 numbers:\n");
	for (i1 = 0; i1 < 10; i1++)
	{
		scanf("%d", &arr[i1]);
		if (i1 > 0)
		{
			if (arr[i1] <= arr[i1 - 1])
			{
				i1 = i1 - 1;
			}
		}
	}
	for (i1 = 0; i1 < 10; i1++)
	{
		printf("%5d", arr[i1]);
		if (i1 != 9)
		{
			printf(",");
		}
	}
	printf("\ninput the num to look for:\n");
	scanf("%d", &shu);
	for (i1 = 0; i1 < 10; i1++)
	{
		if (shu == arr[i1])
		{
			j1 = 0;
			printf("the position of %d is %d", shu, i1 + 1);
		}
	}
	if (j1 == 1)
	{
		printf("Not Find!");
	}
	return 0;
}
