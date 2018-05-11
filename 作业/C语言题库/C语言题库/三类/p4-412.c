#include<stdio.h>

int  main(void)
{
	int arr[10000], i1 = 0, t1, j1, n1;

	printf("Please input numbers:");

	while (1)
	{
		scanf("%d", &arr[i1]);
		if (arr[i1] == -222)
		{
			i1--;
			t1 = i1;
			break;
		}
		i1++;
	}
	
	printf("Output:\n");
	for (i1 = 0; i1 <= t1; i1++)
	{
		for (j1 = i1; j1 <= t1; j1++)
		{
			if (arr[i1] > arr[j1])
			{
				n1 = arr[i1];
				arr[i1] = arr[j1];
				arr[j1] = n1;
			}
		}

		printf("%-6d", arr[i1]);

		if (i1 != t1)
		{
			if ((i1 + 1) % 6 == 0)
			{
				printf("\n");
			}
			else 
			{
				printf(",");
			}
		}
	}

	return 0;
}
