#include <iostream>
#include <vector>
using namespace std;

int injupList[100][100];
int main()
{
	int n, a;
	cin >> n;
	for (int i = 0;i < 100;i++)
	{
		for (int j = 0; j < 100;j++)
		{
			injupList[i][j] = 10000000;
		}
	}
	for (int i = 0;i < n;i++)
	{
		for (int j = 0; j < n;j++)
		{
			cin >> a;
			if (a == 1) injupList[i][j] = 1;
		}
	}
	for (int m = 0; m < n; m++)
	{
		for (int s = 0; s < n; s++)
		{
			for (int e = 0; e < n; e++)
				if (injupList[s][e] > injupList[s][m] + injupList[m][e])
					injupList[s][e] = injupList[s][m] + injupList[m][e];
		}
	}
	for (int i = 0;i < n;i++)
	{
		for (int j = 0; j < n;j++)
		{
			if (injupList[i][j] == 10000000) cout << 0 << ' ';
			else cout << 1 << ' ';
		}
		cout << '\n';
	}
	return 0;
}