#include<stdio.h>
#include<string.h>

int main(void)
{
	char str[128];
	int i1, sign1, sign2, test = 0, test1 = 0;

	printf("input a string:");
	gets(str);
	for (i1 = 0; (unsigned int)i1 < strlen(str); i1++)	//这个i1为什么小于strlen(str)
	{
		if (str[i1] == '/' && str[i1 + 1] == '*')
		{
			test = i1 + 1;
			sign1 = i1;
		}
		else if (str[i1] == '*' && str[i1 + 1] == '/')
		{
			test1 = i1 + 1;
			sign2 = i1 + 1;
		}
		
	}
	
	if ((test == 0 && test1 > 0) || (test > 0 && test1 ==0) || test1 < test)
	{
		printf("\ncomment is error\n");
	}
	else
	{
		printf("\nThe result is :");
		
		for (i1 = 0; (unsigned int)i1 < strlen(str); i1++)
		{
			if (sign1 <= i1 && i1 <= sign2)
			{

			}
			else
			{
				printf("%c", str[i1]);
			}
		}
	}

	return 0;
}
