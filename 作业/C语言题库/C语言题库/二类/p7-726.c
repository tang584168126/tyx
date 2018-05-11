#include<stdio.h>

int main(void)
{
	int i1 = -1, j1, ch;
	char str[100];

	printf("input a string: ");
	
	do  
	{
		i1++;
		ch = scanf("%c", &str[i1]);

		if (str[i1] == '\n' || str[i1] == '\0' || ch != 1)
		{	
			i1 = i1 - 1;
			break;
		}
	} while (i1 < 99);		//若读入过程中发生错误或遇到文件结束
	
	//scanf以%s输入时，当输入'\0', '\t', ' '都会结束的哈。
	//%c	可以接受'\0', 't', '\n'的哈。

	printf("\nThe string lenth is: %d", i1 + 1);
	printf("\nThe string is: ");
	for (j1 = 0; j1 <= i1; j1++)
	{
		printf("%c", str[j1]);
	}

	return 0;   
}