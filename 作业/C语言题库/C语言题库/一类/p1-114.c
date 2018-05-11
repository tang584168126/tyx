
编写一个简单计算器程序，输入格式为：data1 op data2。其中data1和data2是参加运算的两个数(data1、data2必须定义为int，但二者相加可能超出int能表示的范围)，op为运算符，它的取值只能是+、-、*、/、%。编程可用素材：printf("Please input data1 op data2: ")...、printf("\nError! chu shu wei 0.\n")...。


#include<stdio.h>

int main(void)
{
	int data1, data2;
	double jg;
	char op;

	printf("Please input data1 op data2:");
	scanf("%d %c %d", &data1, &op, &data2);
	if (op == '+')
	{
		jg = 0.0 + data1 + data2;	//如果这里写成 data1 + data2 + 0.0 就是错的了。
	}
	if (op == '-')
	{
		jg = 0.0 + data1 - data2;	//同理哈
	}
	if (op == '*')
	{
		jg = 1.0 * data1 * data2;
	}
	if (op == '%')
	{
		if (data2 == 0)
		{
			printf("Error! chu shu wei 0.");
		}
		else
		{
			jg = data1 % data2 * 1.0;
		}
	}
	if (op == '/')
	{
		if (data2 == 0)
		{
			printf("Error! chu shu wei 0.");
		}
		else
		{
			jg = 1.0 * data1 / data2;
		}
	}
	if (data2 != 0)
	{
		printf("%d%c%d=%.2f", data1, op, data2, jg);
	}
	return 0;
}