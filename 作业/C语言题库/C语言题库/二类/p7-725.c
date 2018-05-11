#include<stdio.h>

int main(void)
{
	int n1, arr[21], i1;

	arr[1] = 1;
	arr[2] = 1;

	printf("input a data(3--20):");
	scanf("%d", &n1);
	
	for (i1 = 3; i1 <= n1; i1++)
	{
		arr[i1] = arr[i1 - 1] + arr[i1 - 2];
	}
	
	for (i1 = 1; i1 < n1; i1++)
	{
		printf("%d\t", arr[i1]);
	}

	printf("%d", arr[i1]);

	return 0;
}