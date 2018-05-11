#include<stdio.h>
#include<string.h>

int main(void)
{
	int m, n, i1, i2 = 0, j1, t1, t2, flag, flag1 = 0;
	char str[5];

	printf("please input m, n(5<=m<=n<=100000): ");
	scanf("%d,%d", &m, &n);
	printf("Result(%d-%d):\n", m, n);
	
	for (i1 = m; i1 <= n; i1++)
	{
		flag = 0;
		for (j1 = 2; j1 < i1 / 2; j1++)
		{
			if (i1 % j1 == 0)
			{
				flag = 1;
				break;
			}
		}

		if (flag == 0)
		{	
			str[0] = i1 / 10000;
			str[1] = i1 / 1000 % 10;
			str[2] = i1 / 100  % 10;
			str[3] = i1 / 10   % 10;
			str[4] = i1 % 10;

			for (t1 = 0; t1 <= 4; t1++)
			{
				if (str[t1] != 0)
				{
					break;
				}
			}
			i2 = 0;
			flag1 = 0;
			for (t2 = t1; t2 <= 4; t2++, i2++)
			{
				if (str[t2] != str[4 - i2])
				{
					flag1 = 1;
				}
				
			}
			if (flag1 == 0)
			{
				printf("%d ", i1);
			}
		}
	}
	return 0;
}
