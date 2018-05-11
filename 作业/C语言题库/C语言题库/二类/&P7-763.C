#include <stdio.h>

/* User Code Begin(考生可在本行后添加代码，例如全局变量的定义、函数原型声明等，行数不限) */
typedef struct 
{
	int num;
	char name[20];
	float score1;
	float score2;
	float score3;
	float aver	;
} STU;
/* User Code End(考生添加代码结束) */

int main(void)
{
	int high;  /* high记录平均分最高的学生的序号，具体使用参考后面的代码 */

	/* User Code Begin(考生可在本行后添加代码，行数不限) */
	int i1;
	float t1 = 0;
	STU myClass[5];

	printf("Please input students  info:Num Name score1 score2 score3\n");
	
	for (i1 = 1; i1 <= 5; i1++)
	{
		printf("%d:", i1);
		scanf("%d %s %f %f %f", &myClass[i1 -1].num,
			myClass[i1 - 1].name, &myClass[i1 - 1].score1,

			&myClass[i1 - 1].score2, &myClass[i1 - 1].score3);	
	}

	for (i1 = 1; i1 <= 5; i1++)
	{
		myClass[i1 - 1].aver = (myClass[i1 - 1].score1 + myClass[i1 - 1].score2 
			+ myClass[i1 - 1].score3) / 3;
		if (t1 < myClass[i1 - 1].aver)
		{
			t1 = myClass[i1 - 1].aver;
			high = i1 - 1;
		}
	}

	/* User Code End(考生添加代码结束) */

	printf("\nThe Highest is %s(%d)\nscore1=%.2f  score2=%.2f  score3=%.2f  aver=%.2f\n",
		myClass[high].name, myClass[high].num,
		myClass[high].score1, myClass[high].score2, myClass[high].score3, myClass[high].aver);

	return 0;
}

/* User Code Begin(考生在此后根据设计需要完成程序的其它部分，行数不限) */



