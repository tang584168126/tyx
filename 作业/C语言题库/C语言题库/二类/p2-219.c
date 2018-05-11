#include<stdio.h>
#include<string.h>

int main(void)
{
	char str[128], str1[128];
	int  i1, j1 = 0, n1 = 0;

	printf("Please input string:");
	gets(str);
	for (i1 = 0; (unsigned)i1 < strlen(str); i1++)
	{
		if ('0' <= str[i1] && str[i1] <= '9')
		{
			n1++;
			str1[j1] = str[i1];
			j1++;
		}
	}
	str1[j1] = '\0';
	printf("shu zi ge shu wei:%d", n1);
	printf("\nshu zi wei:");
	puts(str1);

	return 0;
}