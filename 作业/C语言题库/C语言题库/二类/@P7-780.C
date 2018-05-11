#include<stdio.h>

/* 本部分代码功能建议：函数原型声明 */
/* User Code Begin(Limit: lines<=1, lineLen<=50, 考生可在本行后添加代码、最多1行、每行长<=50字符) */
int deal(char *str);
/* User Code End(考生添加代码结束。注意：空行和单独为一行的{与}均不计行数、行长不计行首tab缩进) */

int main(void)
{
	int Len;
	char String[101];/* = "?????????????????????????????????????????????????????????????";          */

	printf("\ninput a string: ");
	/* 本部分代码功能建议：调用考生自定义函数实现输入 */
	/* User Code Begin(Limit: lines<=1, lineLen<=50, 考生可在本行后添加代码、最多1行、每行长<=50字符) */
	Len = deal(String);
	/* User Code End(考生添加代码结束。注意：空行和单独为一行的{与}均不计行数、行长不计行首tab缩进) */

	printf("\nThe string lenth is: %d\n", Len);
	printf("The string is: %s\n", String);

	return 0;
}

/* User Code Begin(考生在此后完成自定义函数的设计，行数不限) */
int deal(char *str)
{
	int i1 = -1, ch;

	do
	{
		i1++;
		ch = scanf("%c", &str[i1]);

		if (str[i1] == '\n' || str[i1] == '\0' || ch != 1)
		{
		/*	i1 = i1;         */
			break;
		}
	} while (i1 < 100);
	str[i1] = '\0';
	return i1;
}




