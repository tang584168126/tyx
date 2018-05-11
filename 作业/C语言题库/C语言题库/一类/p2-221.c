从键盘读入一个字符串(约定：字符数≤127字节)，检查该字符串是否是回文。所谓回文即正向与反向的拼写都一样，例如：adgda。编程可用素材：printf("Please input string:")...、printf("\n... shi hui wen."...、printf("\n... bu shi hui wen."...。


#include<stdio.h>
#include<string.h>

int main(void)
{
	char str[128], str1[128];
	int i1;

	printf("Please input string:");
	gets(str);
	for (i1 = 0; (unsigned int)i1 < strlen(str); i1++)
	{
		str1[strlen(str) - 1 - i1] = str[i1];
	}
	str1[strlen(str)] = '\0'; //这个是必须的哟
	printf("%s", str);
	if (strcmp(str, str1) == 0)
	{
		printf(" shi hui wen.");
	}
	else 
	{
		printf(" bu shi hui wen.");
	}
	return 0;
}