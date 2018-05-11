#include<stdio.h>
#include<string.h>

int main(void)
{
	char str1[128], str2[128];
	int jg, i1, j1, line;

	printf("Input a string:");
	gets(str1);
	printf("\nInput jiange:");
	scanf("%d", &jg);
	printf("\nThe string of deleted space:");

	for (i1 = 0, j1 = 0; (unsigned int)i1 < strlen(str1); i1++, j1++)
	{
		if (str1[i1] == ' ')
		{
			j1--;
		}
		else
		{
			str2[j1] = str1[i1];
		}
	}
	str2[j1] = '\0';
	puts(str2);
	
	if (strlen(str2) % jg != 0 )
	{
		line = strlen(str2) / jg + 1;
	}
	else
	{
		line = strlen(str2) / jg;
	}


	printf("\nThe result is:");

	for (i1 = 0; i1 < jg; i1++)
	{
		for (j1 = 0; j1 < line; j1++)
		{
			if (i1 + j1 * jg > (int)strlen(str2) - 1)
			{
				break;
			}
			printf("%c", str2[i1 + j1 * jg]);
		}
		printf(" ");
	
	}

	return 0;
}