#include<stdio.h>
#include<string.h>

typedef struct
{
	char name[20];
	char size[12];
	long total;
	float price;
} GOODS;

int main(void)
{
	int i1 = -1, flag = 0;
	char name1[20] = {0};
	GOODS good[10];
	FILE *fp;

	printf("\nplease input shang pin pin ming:");
	scanf("%s", name1);

	fp = fopen("sp.dat", "rb");
	if (fp == NULL)
	{
		printf("Cannot open this file\n");
	}
	
	while (feof(fp) == 0)
	{
		i1++;
		fread(&good[i1], sizeof(GOODS), 1, fp);
		
		if (strcmp(name1, good[i1].name) == 0)
		{
			flag = 1;
		}
	}

	printf("\ncha zhao qing kuang :\n");

	for (i1 = 0; i1 < 10; i1++)
	{
		if (flag == 0)
		{
			printf("\nmei you shang pin :%s", name1);
			break;
		}

		if (strcmp(name1, good[i1].name) == 0)
		{
			printf("%s,%s,%d,%.2f\n", good[i1].name,
				good[i1].size, good[i1].total, good[i1].price);
		}
	}

	fclose(fp);

	return 0;
}