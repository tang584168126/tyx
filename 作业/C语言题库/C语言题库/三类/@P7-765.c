#include <stdio.h>
#include <stdlib.h>

/* User Code Begin(�������ڱ��к���Ӵ��룬��������) */
typedef struct
{
	int num;
	char name[20];
	int math;
	int english;
	int computer;
	float average;

} STUDENT;
/* User Code End(������Ӵ������) */

int main(void)
{
	STUDENT myclass[5], *pStu = myclass;
	int i;
	const int N = 5;

	/* User Code Begin(�������ڱ��к���Ӵ��룬��������) */
	int j1;
	STUDENT myclass1;
	
	for (i = 0; i < N; i++)
	{
		printf("%d:", i + 1);
		scanf("%d%s%d%d%d", &myclass[i].num, myclass[i].name,
			&myclass[i].math, &myclass[i].english, &myclass[i].computer);
		myclass[i].average = (float)((myclass[i].math + myclass[i].english + myclass[i].computer) / 3.0);
	}

	for (i = 0; i < N; i++)
	{
		for (j1 = i; j1 < N; j1++)
		{
			if (myclass[i].average < myclass[j1].average)
			{
				myclass1 = myclass[i];
				myclass[i] = myclass[j1];
				myclass[j1] = myclass1;				
			}
		}
	}

	/* User Code End(������Ӵ������) */
	
	printf("\nResult of sort:\n");
	printf("Num   Name                 Math     English  Computer Average\n");
	for (i=0; i<N; i++)
	{
		printf("%-5d %-20s %-8d %-8d %-8d %-.2f\n", (pStu+i)->num, (pStu+i)->name,
			(pStu+i)->math, (pStu+i)->english, (pStu+i)->computer, (pStu+i)->average);
	}

	return 0;
}

/* User Code Begin(�����ڴ˺���������Ҫ��ɳ�����������֣���������) */



