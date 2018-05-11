#include<stdio.h>
#include<string.h>

int main(void)
{
	char arr[128];
	int  i1, j1 = 0, n1 = 0;

	printf("please input a string:\n");
	gets(arr);
	for (i1 = 0; arr[i1] != '\0'; i1++)
	/*for (i1 = 0; (unsigned int)i1 <= strlen(arr); i1++)       */
	{
		if (arr[i1] != ' ' && arr[i1] != '\0')
		{
			j1++;
		}
		if (arr[i1] == ' ' || arr[i1] == '\0')		/*结束符号有两种' '和'\0' */
		{
			if (j1 > n1)
			{
				n1 = j1;
			}
			j1 = 0;
		}
	}
	printf("\nmax_length of the string is: %d\n", n1);/*这里的这个空格哟   */
	return 0;
}