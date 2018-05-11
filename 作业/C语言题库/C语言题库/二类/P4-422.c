#include <stdio.h>

#define maxNums 10000
#define endFlag -222

/* �����ִ��빦�ܽ��飺����ԭ������ */
/* User Code Begin(Limit: lines<=1, lineLen<=50, �������ڱ��к���Ӵ��롢���1�С�ÿ�г�<=50�ַ�) */
rep(int *m1, int *i1, int t1);
/* User Code End(������Ӵ��������ע�⣺���к͵���Ϊһ�е�{��}�������������г���������tab����) */

int main(void)
{
	int i, j, mini;
	int inputData[maxNums] = {0}, dataCount=0;  /* inputData���ڱ�����������ݣ�dataCount��¼�������ݵĸ��� */
	
	printf("\nPlease input numbers:");
	for (i=0; i<maxNums; i++)
	{
		scanf("%d", &inputData[i]);
		if (endFlag == inputData[i])
		{
			break;
		}
		dataCount++;
	}

	for (i=0; i<dataCount-1; i++)
	{
		mini = i;
		for (j=i; j<dataCount; j++)
		{
			if (inputData[j] < inputData[mini])
			{
				mini = j;
			}
		}

		/* �����ִ��빦�ܽ��飺������Ӧ�ĺ���ʵ������λ�õĽ��� */
		/* User Code Begin(Limit: lines<=1, lineLen<=50, �������ڱ��к���Ӵ��롢���1�С��г�<=40�ַ�) */
		rep(&inputData[mini], &inputData[i], 0);
		/* User Code End(������Ӵ��������ע�⣺���к͵���Ϊһ�е�{��}�������������г���������tab����) */
	}

	printf("\nOutput:\n");
	for (i=0; i<dataCount; i++)
	{
		printf("%-6d", inputData[i]);

		if (((i + 1) % 6) != 0 && i != dataCount - 1)
		{
			printf(",");
		}
		else
		{
			printf("\n");
		}
	}

	return 0;
}

/* �����ִ��빦�ܽ��飺ʵ�������������ݵĽ��� */
/* User Code Begin(Limit: lines<=5, lineLen<=30, �������ڱ��к���Ӵ��롢���5�С�ÿ�г�<=30�ַ�) */
rep(int *m1, int *i1, int t1)
{
	t1  = *i1;
	*i1 = *m1;
	*m1 = t1;
/* User Code End(������Ӵ��������ע�⣺���к͵���Ϊһ�е�{��}�������������г���������tab����) */
}
/* Program End(���򵽴˽������˺���������ݣ�����0��) */
