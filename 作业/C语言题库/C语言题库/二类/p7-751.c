#include<stdio.h>

int main(void)
{
	int arr[100], i1, j1, m, n1 = 0, n2 = 0, t1 = 0;
	//���arrΪʲô����Ϊ100����101

	printf("input a number: ");
	scanf("%d", &m);

	if (m <= 0)
	{
		n2 = 2;
		printf("error");
	}
	
	for (i1 = 2; i1 < m; i1++)
	{
		t1 = 0;								//���ÿִ��һ�ξ�Ҫ��ʼ��
		for (j1 = 2; j1 < i1; j1++)
		{
			if (i1 % j1 == 0)
			{
				t1 = 1;
			}
		}
		if (t1 == 0)
		{
			arr[n1] = i1;
			n1++;						//���ԼӸ�һ

			if (n1 > 100)				//Ϊʲô��100��������99
			{
				n2 = 1;
			}
		}
	}

	if (n2 == 1)
	{
		printf("overflow");
	}
	if (n2 == 0)
	{
		printf("n=%d\n", n1);

		for (i1 = 0; i1 < n1; i1++)			//Ϊʲô��0��ʼ�����Ǵ�1
		{
			printf("%5d", arr[i1]);

			if ((i1 + 1) % 15 == 0)
			{
				printf("\n");
			}
		}
	}

	return 0;
}