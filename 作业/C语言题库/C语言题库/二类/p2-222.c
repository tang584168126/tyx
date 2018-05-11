#include<stdio.h>
#include<string.h>

int main(void)
{
	char str[128];
	int len, i;

	printf("Please input string:");
	gets(str);
	len = strlen(str);
	for (i = 0; i < len; i++)
	{
		if (str[i] >= 65 && str[i] <= 90)
		{
			str[i] = 155 - str[i];	
		}
		if (str[i] >=97 && str[i] <= 122)
		{
			str[i] = 219 - str[i];
		}
	}
	printf("\nzi fu chuan chang du:%d", i);
	printf("\nmi wen:%s", str);
	return 0;
}