#include<stdio.h>

int main(void)
{
	int year, month, day, th = 0, i1;

	printf("Please input : year-month-day\n");
	scanf("%d-%d-%d", &year, &month, &day);
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
	printf("It is the %dth dat.", th);
	return 0;
}