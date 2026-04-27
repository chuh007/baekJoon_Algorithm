#include <iostream>
#include<vector>
using namespace std;

int main()
{
	vector<vector<int>> v(9, vector<int>(9));
	int max = -1, indexX = 0, indexY = 0;
	for (int i = 0; i < 9; i++)
	{
		for (int j = 0; j < 9; j++)
		{
			cin >> v[i][j];
			if (max < v[i][j])
			{
				max = v[i][j];
				indexX = i + 1;
				indexY = j + 1;
			}
		}
	}
	cout << max << '\n' << indexX << " " << indexY;
}
