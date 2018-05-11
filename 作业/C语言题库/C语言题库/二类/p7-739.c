#include<stdio.h>

int main(void)
{
	int year, month, day, i1, j1;
	double th = 0;

	printf("input a data(year-month-day):");
	scanf("%d-%d-%d", &year, &month, &day);

	for (j1 = 1; j1 < year; j1++)
	{
		if (j1 % 400 == 0 || (j1 % 4 == 0 && j1 % 100 != 0))
		{
			th = th + 366;
		} 
		else 
		{
			th = th + 365; 
		} 
	}

	if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
	{
		int arr[13] = {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		
		for (i1 = 1; i1 < month; i1++)
		{
			th = th + arr[i1]; 
		}
		th = th + day;
	} 
	else 
	{
		int arr[13] = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

		for (i1 = 1; i1 < month; i1++)
		{
			th = th + arr[i1]; 
		}
		th = th + day;
	}

	printf("The result is %.0f.", th);

	return 0;
}