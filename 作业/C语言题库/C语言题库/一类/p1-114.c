
��дһ���򵥼��������������ʽΪ��data1 op data2������data1��data2�ǲμ������������(data1��data2���붨��Ϊint����������ӿ��ܳ���int�ܱ�ʾ�ķ�Χ)��opΪ�����������ȡֵֻ����+��-��*��/��%����̿����زģ�printf("Please input data1 op data2: ")...��printf("\nError! chu shu wei 0.\n")...��


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
		jg = 0.0 + data1 + data2;	//�������д�� data1 + data2 + 0.0 ���Ǵ���ˡ�
	}
	if (op == '-')
	{
		jg = 0.0 + data1 - data2;	//ͬ���
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