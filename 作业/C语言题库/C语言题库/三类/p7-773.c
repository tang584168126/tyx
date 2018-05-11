#include<stdio.h>

int main(void)
{
	int year, year1, year2, mon, mon1, mon2
		, day, day1, day2;
	int sum = 0, i1, i2, i3, xs = 0;
	int arr[13] = {0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

	printf("from the date (****/**/**):\n");
	scanf("%d/%d/%d", &year1, &mon1, &day1);

	printf("to the date(****/**/**):\n");
	scanf("%d/%d/%d", &year2, &mon2, &day2);

	if (year1 > year2)
	{
		year  = year2;
		year2 = year1;
		year1 = year; 

		mon	  = mon2;
		mon2  = mon1;
		mon1  = mon;

		day   = day2;
		day2  = day1;
		day1  = day;
	}

	for (i1 = year1; i1 <= year2; i1++)
	{
		if (i1 % 400 == 0 || (i1 % 4 == 0 && i1 % 100 != 0))
		{
			arr[2] = 29;
		}
		else 
		{
			arr[2] = 28;
		}

		for (i2 = 1; i2 <= 12; i2++)
		{

			for (i3 = 1; i3 <= arr[i2]; i3++)
			{
				if (i1 == year1 && i2 == mon1 && i3 == day1)
				{
					xs = 1;
				}
				else if (i1 == year2 && i2 ==mon2 && i3 ==day2)
				{
					xs = 0;
				}
				else
				{
					sum = sum + xs;
				}
			}
		}
	}

	printf("\nsum=%d\n", sum + 1);

	return 0;
}