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
	} while (i1 < 99);		//����������з�������������ļ�����
	
	//scanf��%s����ʱ��������'\0', '\t', ' '��������Ĺ���
	//%c	���Խ���'\0', 't', '\n'�Ĺ���

	printf("\nThe string lenth is: %d", i1 + 1);
	printf("\nThe string is: ");
	for (j1 = 0; j1 <= i1; j1++)
	{
		printf("%c", str[j1]);
	}

	return 0;   
}