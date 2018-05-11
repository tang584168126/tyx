#include<stdio.h>
#include<string.h>

int main(void)
{
	char str1[5][81], *str2[5];
	char *t1; 
	int i1, j1, n1, len ;

	printf("Input 5 strings:\n");
	for (i1 = 0; i1 < 5; i1++)
	{
		gets(str1[i1]);

		if (i1 != 0)
		{
			if (strlen(str1[i1]) > strlen(str1[i1 - 1]))
			{
				len = strlen(str1[i1]);
			}
			else 
			{
				len = strlen(str1[i1 - 1]);
			}
		}
		str2[i1] = str1[i1];
	}
	printf("----------------------------\n");
	for (i1 = 0; i1 < 5 - 1; i1++)
	{
		for (j1 = i1 + 1 ; j1 < 5; j1++)
		{
			for (n1 = 0; n1 < len; n1++)
			{
				if (str2[i1][n1] < str2[j1][n1])
				{
					break;
				}
				else if (str2[i1][n1] > str2[j1][n1])
				{
					t1 = str2[i1];
					str2[i1] = str2[j1];
					str2[j1] = t1;
					break;
				}
				else
				{
					continue;
				}

			}
		}
	}
	for (i1 = 0; i1 < 5; i1++)
	{
		puts(str2[i1]);
	}

	return 0;
}