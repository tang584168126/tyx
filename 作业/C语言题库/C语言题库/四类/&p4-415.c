#include<stdio.h>

struct 
{
	int score[6];
	float aver;
} stu[10];


int main(void)
{
	int i1, j1, t1, no;
	float t2;

	printf("Please input:");

	for (i1 = 0; i1 < 10; i1++)
	{
		scanf("%d%d%d%d%d%d", &stu[i1].score[0], &stu[i1].score[1], &stu[i1].score[2],
			&stu[i1].score[3], &stu[i1].score[4], &stu[i1].score[5]);
			
		for (j1 = 0; j1 < 6; j1++)
		{
			if (stu[i1].score[5] < stu[i1].score[j1])	//最大
			{
				t1				  = stu[i1].score[5];
				stu[i1].score[5]  = stu[i1].score[j1];
				stu[i1].score[j1] = t1;
			}
		}

		for (j1 = 0; j1 < 6; j1++)
		{
			if (stu[i1].score[4] > stu[i1].score[j1])	//最小
			{
				t1				  = stu[i1].score[4];
				stu[i1].score[4]  = stu[i1].score[j1];
				stu[i1].score[j1] = t1;
			}
		}

		stu[i1].aver = (float)(stu[i1].score[0] + stu[i1].score[1] + stu[i1].score[2] +
			stu[i1].score[3]) / 4;
	}
	
	printf("\nscores:\n");

	for (i1 = 0; i1 < 10; i1++)
	{
		t2 = stu[0].aver;
		no = 0;
		for (j1 = 1; j1 < 10; j1++)
		{
			if (t2 < stu[j1].aver)
			{
				t2 = stu[j1].aver;
				no = j1;
			}
		}
		stu[no].aver = -1;					//命为负数，就不是最大值了
		printf("No.%d:%.2f\n", no + 1, t2);
	}
	
	return 0;
}