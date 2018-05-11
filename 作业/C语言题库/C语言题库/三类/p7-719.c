#include<stdio.h>
#include<string.h>

int main(void)
{
	char str1[5][80], *str2[5];
	char *t1; 
	int i1, j1;

	printf("Input 5 strings:\n");
	for (i1 = 0; i1 < 5; i1++)
	{
		gets(str1[i1]);
		str2[i1] = str1[i1];
	}
	printf("----------------------------\n");
	for (i1 = 0; i1 < 5 - 1; i1++)
	{
		for (j1 = i1 + 1 ; j1 < 5; j1++)
		{
			if (strcmp(str2[i1], str2[j1]) > 0)
			{
				t1 = str2[i1];

				str2[i1] = str2[j1];
				
				str2[j1] = t1;
			}
		}
	}
	for (i1 = 0; i1 < 5; i1++)
	{
		puts(str2[i1]);
	}
	return 0;
}