#include <stdio.h>
#include <string.h>

int main(void)
{
	int arr[10], i, count = 0;

	printf("Input 10 integer.\n");
	for (i = 0; i < 10; i++)
	{
		scanf("%d", &arr[i]);
	}
	for (i = 0; i < 10; i++)
	{
		if (i % 2 != 0)
		{
			if (arr[i] % 2 != 0)
			{
				count++;
			}
		}
	}
	printf("count=%d\n", count);
	for (i = 0; i < 10; i++)
	{
		if (i % 2 != 0)
		{
			if (arr[i] % 2 != 0)
			{
				printf("a[%d]=%d\n", i, arr[i]);
			}
		}
	}

	return 0;
}