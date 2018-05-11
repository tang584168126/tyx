#include <stdio.h>

int main(void)
{
	int profit;
	double salary;

	printf("Input profit:");
	scanf("%d", &profit);
	if (profit <= 1000)
	{
		salary = 500;
	}
	else if (profit >1000 && profit <= 2000)
	{
		salary = 500 + profit * 0.1;
	}
	else if (profit > 2000 && profit <= 5000)
	{
		salary = 500 + profit * 0.15;
	}
	else if (profit > 5000 && profit <= 10000)
	{
		salary = 500 + profit * 0.2;
	}
	else 
	{
		salary = 500 + profit * 0.25;
	}
	printf("salary=%4.2f", salary);
	
	return 0;
}