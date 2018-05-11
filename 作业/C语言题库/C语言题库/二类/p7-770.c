#include<stdio.h>
#include<string.h>

int main(void)
{
	int num, R, i1 = 0;
	char arr[34];		//最大的是33个哈。

	printf("input the num, R: ");
	scanf("%d,%d", &num, &R);

	printf("Result:\n");
	
	if (num < 0)
	{
		printf("-");
		num = -num;
	}

	do
	{
		arr[i1] = num % R;

		if (0 <= arr[i1] && arr[i1] <= 9)
		{
			arr[i1] += 48; 
		}
		else
		{
			arr[i1] += 55;
		}

		num = num / R;
		i1++;
	} while (num != 0);

	arr[i1] = '\0';

	for (i1 = strlen(arr) - 1; i1 >= 0; i1--)
	{
		printf("%c", arr[i1]);
	}
	return 0;
}