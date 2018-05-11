#include<stdio.h>
#include<math.h>

int main(void)
{
	int num, sum, i;

	printf("\nInput a number with 4-digit: ");
	scanf("%d", &num);

	sum = 0;
	for (i = 1; i <= 4; i++)
	{
		sum = sum + num % (int)pow(10, i) / (int)pow(10, i - 1);
	}

	printf("sum=%d\n", sum);

	return 0;
}
