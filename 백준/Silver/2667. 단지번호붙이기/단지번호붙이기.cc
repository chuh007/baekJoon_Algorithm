#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

int arr[25][25];
int maxX, maxY, cnt = 0;

void DFS(int x, int y)
{
	arr[y][x] = 0;
	cnt++;
	if (0 <= x - 1 && x - 1 < maxX && 0 <= y && y < maxY)
	{
		if (arr[y][x - 1] == 1) DFS(x - 1, y);
	}
	if (0 <= x + 1 && x + 1 < maxX && 0 <= y && y < maxY)
	{
		if (arr[y][x + 1] == 1) DFS(x + 1, y);
	}
	if (0 <= x && x < maxX && 0 <= y + 1 && y + 1 < maxY)
	{
		if (arr[y + 1][x] == 1) DFS(x, y + 1);
	}
	if (0 <= x && x < maxX && 0 <= y - 1 && y - 1 < maxY)
	{
		if (arr[y - 1][x] == 1) DFS(x, y - 1);
	}
}

int main()
{
	int a, answercount = 0;
	cin >> a;
	maxX = maxY = a;
	vector<int> v;
	string s;
	for (int i = 0;i < a;i++)
	{
		cin >> s;
		for (int j = 0;j < a;j++)
		{
			arr[i][j] = s[j] - '0';
		}
	}
	for (int i = 0;i < a;i++)
	{
		for (int j = 0;j < a;j++)
		{
			if (arr[i][j] == 1)
			{
				answercount++;
				DFS(j, i);
				v.push_back(cnt);
				cnt = 0;
			}
		}
	}
	sort(v.begin(), v.end());
	cout << answercount <<'\n';
	for (auto i : v)
	{
		cout << i << '\n';
	}
	return 0;
}