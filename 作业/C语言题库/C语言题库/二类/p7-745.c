#include<stdio.h>

int main(void)
{
	int n1, n2, i1, t1, m1;

	printf("please input two integer numbers: ");
	scanf("%d %d", &n1, &n2);
	
	if (n1 > n2)
	{
		t1 = n1;
		n1 = n2;
		n2 = t1;
	}

	for (i1 = 1; i1 <= n1; i1++)		//不能用n1/2万一是它本身怎么办呀
	{
		if (n1 % i1 ==0 && n2 % i1 ==0)
		{
			m1 = i1;
		}
	}
	
	for (i1 = n2; ; i1++)
	{
		if (i1 % n1 ==0 && i1 % n2 == 0)
		{
			break;
		}
	}
	printf("the greatest common divisor is %d\n", m1);
	printf("the lease common multiple is %d", i1);

	return 0;
}