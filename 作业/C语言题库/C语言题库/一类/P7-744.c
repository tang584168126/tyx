#include<stdio.h>

int main(void)
{
	float score;
	char grade;
	
	do
	{
		printf("please input the score(0-100):");
		scanf("%f", &score);
	} while (score > 100 || score < 0);
	switch ((int)(score / 10))
	{
		case 10:
		case 9 :
			grade = 'A'; 
			break; 
		case 8 :
			grade = 'B'; 
			break;
		case 7 : 
			grade = 'C'; 
			break;
		case 6 :
			grade = 'D';
			break;
		default:
			{
				grade = 'E'; 
				break;
			}
	
	}
	printf("score=%0.1f,grade=%c", score, grade);
	return 0;
}