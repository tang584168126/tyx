#include <stdio.h>
#include <string.h>

int main(void)
{
	int arr1[10], arr2[10], i, j, temp;

	printf("please input 10 integer numbers:");
	for (i = 0; i < 10; i++)
	{
		scanf(" %d", &arr1[i]);
	}
	for (i = 0; i < 10; i++)
	{
		arr2[i] = arr1[i];
	}
	for (i = 0; i < 10; i++)
	{
		for (j = i + 1; j < 10; j++)
		{
			if (arr2[i] > arr2[j])
			{
				temp = arr2[i];
				arr2[i] = arr2[j];
				arr2[j] = temp;
			}
		}
	}
	printf("the array before sorted:\n");
	for (i = 0; i < 10; i++)
	{
		printf("%d  ", arr1[i]);
	}
	printf("\nthe array after sorted:\n");
	for (i = 0; i < 10; i++)
	{
		printf("%d  ", arr2[i]);
	}

	return 0;
}