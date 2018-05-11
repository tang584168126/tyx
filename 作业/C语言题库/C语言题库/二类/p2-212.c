根据输入的n在屏幕上显示对应的以#组成的菱形图案。编程可用素材：printf("Please input n: ")...。
　　程序的运行效果应类似地如图1和图2所示，图1中的1和图2中的5是从键盘输入的内容。

#include<stdio.h>
#include<math.h>

int main(void)
{
	int n, i1, j1;

	printf("Please input n:");
	scanf("%d", &n);
	for (i1 = 0; i1 < 2 * n - 1; i1++)
	{
		for (j1 = 0; j1 < 2 * n - 1; j1++)
		{
			if (abs(j1 + i1) == n - 1)
			{
				printf("%c", 'a' + n - 1 - abs(n - 1 - i1));
			}
			else if (abs(j1 - i1) == n - 1 )
			{
				printf("%c", 'a' + n - 1 - abs(n - 1 - i1));
			}
			else if (abs(j1 + i1) == 3*(n - 1))
			{
				printf("%c", 'a' + n - 1 - abs(n - 1 - i1));
			}
			else 
			{
				printf(" ");
			}
		}
		printf("\n");
	}
	return 0;
}
//if else if else if if  
