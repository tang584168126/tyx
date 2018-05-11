#include<stdio.h>

int main(void)
{
	int n1, i1;
	double arr[14]; 

	arr[0] = 0;
	arr[1] = 1;
	arr[2] = 2;
	printf("Input n (13>=n>=2):");
	scanf("%d", &n1);
	for (i1 = 3; i1 <= n1; i1++)
	{
		arr[i1] = 2 * arr[i1 - 1] + arr[i1 - 2] * arr[i1 - 3];
	}
	printf("f(%d)=%.0f", n1, arr[n1]);
	return 0;
}
