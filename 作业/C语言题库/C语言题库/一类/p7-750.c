#include<stdio.h>
#include<string.h>

int main(void)
{
	char str1[101], str2[101], i1, j1 = 0;
	
	printf("Please input a string: ");
	gets(str1);

	for (i1 = 0; (unsigned int)i1 
		< strlen(str1); i1++)
	{
		if (str1[i1] != '*')
		{
			str2[j1] = str1[i1];
			j1++;
		}
	}

	str2[j1] = '\0';
	
	puts(str2);
	return 0;
}