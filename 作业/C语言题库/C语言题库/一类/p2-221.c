�Ӽ��̶���һ���ַ���(Լ�����ַ�����127�ֽ�)�������ַ����Ƿ��ǻ��ġ���ν���ļ������뷴���ƴд��һ�������磺adgda����̿����زģ�printf("Please input string:")...��printf("\n... shi hui wen."...��printf("\n... bu shi hui wen."...��


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
	str1[strlen(str)] = '\0'; //����Ǳ����Ӵ
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