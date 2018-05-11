#include<stdio.h>
#include<string.h>

int main(void)
{
	char s1[128], s2[128], s3[255];
	unsigned int  i1, t, cs1 = 0, cs2 = 0;

	printf("Please input string1:");
	gets(s1);
	printf("Please input string2:");
	gets(s2);
	if (strlen(s1) > strlen(s2))
	{
		t = strlen(s2);
		for (i1 = 0; i1 < 2 * t - 1; i1++)
		{
			if (i1 % 2 == 0)
			{
				s3[i1] = s1[cs1];
				cs1 = cs1 + 1;
			}
			else
			{
				s3[i1] = s2[cs2];
				cs2++;
			}
			
		}
		for (i1 = 2 * t - 1; i1 < strlen(s1) + strlen(s2) ; i1++)
		{
			s3[i1] = s1[cs1++];
		}
	}
	else 
	{
		t = strlen(s1);
		for (i1 = 0; i1 < 2 * t - 1; i1++)
		{
			if (i1 % 2 == 0)
			{
				s3[i1] = s1[cs1];
				cs1++;
			}
			else
			{
				s3[i1] = s2[cs2];
				cs2++;
			}
		}
		for (i1 = 2 * t - 1; i1 < strlen(s1) + strlen(s2); i1++)
		{
			s3[i1] = s2[cs2++];
		}


	}
	for(i1 = 0; i1 < strlen(s1) + strlen(s2) ; i1++)
	{
		printf("%c",s3[i1]);
	}
	
	return 0;
}