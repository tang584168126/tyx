��֪ĳ����������ȡ��ͬ���޵���Ϣ���ʷֱ�Ϊ��3.15%����һ�꣬3.63%���޶��꣬ 4.02%�������꣬4.69%�������꣬5.36%���ް��ꡣ�Ӽ����������Ǯ�ı���(��ԪΪ��λ�����붨��Ϊint��Ӧ���ǽ��ܴ�����)�ʹ������(ֻ����1,2,3,5,8)������ʱ�ܴ����еõ�����Ϣ(��ԪΪ��λ��Ӧ������С�������Ƹ���)����̿����زģ�printf("\nPlease input benjin,cunqi:")...��printf("\nlixi = ... yuan"...��
�������������Ч��Ӧ���Ƶ���ͼ1��ʾ��ͼ1�е�10000,8�ǴӼ�����������ݡ�


#include <stdio.h>

int main(void)
{
	int benjin, cunqi;
	double lixi, lilv;

	printf("Please input benjin,cunqi:");
	scanf("%d,%d", &benjin, &cunqi);
	if (1 == cunqi)
	{
		lilv = 0.0315;
		lixi = benjin * lilv * cunqi;
		printf("\nlixi = %.2f yuan", lixi);

	}
	else if (2 == cunqi)
	{
		lilv = 0.0363;
		lixi = benjin * lilv * cunqi;
		printf("\nlixi = %.2f yuan", lixi);
	}
	else if (3 == cunqi)
	{
		lilv = 0.0402;
		lixi = benjin * lilv * cunqi;
		printf("\nlixi = %.2f yuan", lixi);
	}
	else if (5 == cunqi)
	{
		lilv = 0.0469;
		lixi = benjin * lilv * cunqi;
		printf("\nlixi = %.2f yuan", lixi);
	}
	else if (8 == cunqi)
	{
		lilv = 0.0536;
		lixi = benjin * lilv * cunqi;
		printf("\nlixi = %.2f yuan", lixi);
	}
	else 
	{
		printf("Error!");
	}

	return 0;
}

