#include<stdio.h>
#include<string.h>

int main(void)
{
	char str[1000], tmp;
	int i, j, len;

	printf("\nInput a string: ");
	gets(str);

	len = strlen(str);
	for (i = 1; i < len; i++)
	{
		for (j = 0; j < len - i; j++)
		{
			tmp = str[j];
			str[j] = str[j + 1];
			str[j + 1] = tmp;
		}
	}

	printf("The result is: ");
	puts(str);

	return 0;
}
