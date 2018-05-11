#include<stdio.h>
#include<math.h>

int main(void)
{
	int i, ab, arr[3];

	printf("\nInput an integer:");
	scanf("%d", &ab);

	for (i = 0; i < 3; i++)
	{
		arr[i] = ab / (int)pow(10, i) % 10;
	}

	printf("\nThe result is ");
	for (i = 0; i < 3; i++)
	{
		printf("%d", arr[i]);
	}
	printf("\n");

	return 0;
}