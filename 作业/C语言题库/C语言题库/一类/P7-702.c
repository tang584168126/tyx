#include <stdio.h>

int main(void)
{
	int month;

	printf("please input the month number :");
	scanf("%d", &month);
	switch (month)
	{
		case 1:
		case 3:
		case 5:
		case 7:
		case 8:
		case 10:
		case 12:
			printf("2003.%d has 31 days", month);
			break;
		case 2:
			printf("2003.2 has 28 days");
			break;
		case 4:
		case 6:
		case 9:
		case 11:
			printf("2003.%d has 30 days", month);
			break;
		default:
			printf("Invalid month input !");
	}
	return 0;
}