���������n����Ļ����ʾ��Ӧ����#��ɵ�����ͼ������̿����زģ�printf("Please input n: ")...��
�������������Ч��Ӧ���Ƶ���ͼ1��ͼ2��ʾ��ͼ1�е�1��ͼ2�е�5�ǴӼ�����������ݡ�

#include<stdio.h>
#include<math.h>

int main(void)
{
	int n, i1, j1;

	printf("Please input n:");
	scanf("%d", &n);
	for (i1 = 0; i1 < 2 * n - 1; i1++)
	{
		for (j1 = 0; j1 < 2 * n - 1; j1++)
		{
			if (abs(j1 + i1) == n - 1)
			{
				printf("%c", 'a' + n - 1 - abs(n - 1 - i1));
			}
			else if (abs(j1 - i1) == n - 1 )
			{
				printf("%c", 'a' + n - 1 - abs(n - 1 - i1));
			}
			else if (abs(j1 + i1) == 3*(n - 1))
			{
				printf("%c", 'a' + n - 1 - abs(n - 1 - i1));
			}
			else 
			{
				printf(" ");
			}
		}
		printf("\n");
	}
	return 0;
}
//if else if else if if  
