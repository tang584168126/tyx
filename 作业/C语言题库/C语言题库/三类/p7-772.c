#include<stdio.h>
#include<string.h>

int main(void)
{
	char arr[128];
	unsigned int  i1, j1, t1;

	printf("input the string:\n");
	for (i1 = 0; i1 <= 127; i1++)
	{
		scanf("%c", &arr[i1]);
		if (arr[i1] == '\n')			//不会以回车来结束了
		{
			arr[i1] = '\0';
			break;
		}
	}
	arr[127] = '\0';				   //程序加上以防止前面输入的字符不止127个。
	printf("Result:");
	for (i1 = 0; i1 < strlen(arr) - 1; i1++)	 //	排序法。
	{
		for (j1 = i1 + 1; j1 < strlen(arr); j1++)
		{
			if (arr[i1] > arr[j1])
			{
				t1 = arr[i1];
				arr[i1] = arr[j1];
				arr[j1] = t1;
			}
		}
	}
	puts(arr);
	return 0;
}