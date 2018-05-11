#include<stdio.h>

int main(void)
{
	char ch; 

	printf("Please input the letter of someday:");
	do
	{
		ch = getchar();
		if (ch == 'M')
		{
			printf("Monday\n");
		}
		else if (ch == 'W')
		{
			printf("Wednesday\n");
		}
		else if (ch == 'F')
		{
			printf("Friday\n");
		}
		else if (ch == 'T')
		{
			loop1: ch = getchar();
		
			if (ch == 'u')
			{
				printf("Tuesday\n");
			}
			else if (ch == 'h')
			{
				printf("Thrusday\n");
			}
			else if (ch == 'T')
			{
				printf("data error\n");
				goto loop1;
			}
			else if (ch == 'M')
			{
				printf("data error\n");
				printf("Monday\n");
			}
			else if (ch == 'W')
			{
				printf("data error\n");
				printf("Wednesday\n");
			}
			else if (ch == 'F')
			{
				printf("data error\n");
				printf("Friday\n");
			}
			else if (ch == 'Y')
			{
				printf("data error\n");
				break;
			}
			else 
			{
				printf("data error\n");
				printf("data error\n");
			}

		}
		else if (ch == 'S')
		{
			loop2: ch = getchar();
			if (ch == 'a')
			{
				printf("Saturday\n");
			}
			else if (ch == 'u')
			{
				printf("Sunday\n");
			}
			else if (ch == 'S')
			{
				printf("data error\n");
				goto loop2;
			}
			else if (ch == 'M')
			{
				printf("data error\n");
				printf("Monday\n");
			}
			else if (ch == 'W')
			{
				printf("data error\n");
				printf("Wednesday\n");
			}
			else if (ch == 'F')
			{
				printf("data error\n");
				printf("Friday\n");
			}
			else if (ch == 'Y')
			{
				printf("data error\n");
				break;
			}
			else 
			{
				printf("data error\n");
				printf("data error\n");
			}
		}
		else 
		{	
			if (ch != 'Y')
			{
				printf("data error\n");
			}
		}
	} while (ch != 'Y');
	return 0;

}
