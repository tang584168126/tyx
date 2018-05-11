#include<stdio.h>

/* User Code Begin(考生可在本行后添加代码，例如全局变量的定义、函数原型声明等，行数不限) */

#include<math.h>
#include<string.h>

int i1, i2 = 0;							//为什么用j1不行呀

/* User Code End(考生添加代码结束) */

int main(void)
{
	int flag;  /* 标志输入数据是否合法，0表示不合法 */
	long int result10;  /* 转换结果 */
	char str[20];

	printf("input a data:");
	gets(str);

	/* User Code Begin(考生可在本行后添加代码，行数不限) */
	result10 = 0;

	for (i1 = strlen(str) - 1; i1 >= 0 ; i1--, i2++)
	{
		if ('0' <= str[i1] && str[i1] <= '9') 
		{
			result10 += (str[i1] - '0') * (int)pow(16, i2); 	
		}
		else if ('a' <= str[i1] && str[i1] <= 'f') 
		{
			result10 += (str[i1] - 'a' + 10) * (int)pow(16, i2);
		}
		else if ('A' <= str[i1] && str[i1] <= 'F')
		{
			result10 += (str[i1] - 'A' + 10) * (int)pow(16, i2);
		}
		else 
		{
			flag = 0;
			break;
		}
	}


	/* User Code End(考生添加代码结束) */

	if (0 == flag)
	{
		printf("\ndata is error.\n");
	}
	else
	{
		printf("\nThe result is: %ld\n", result10);
	}

	return 0;
}

/* User Code Begin(考生在此后根据设计需要完成程序的其它部分，行数不限) */



