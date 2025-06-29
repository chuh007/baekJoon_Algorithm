#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

char arr1[100][100];
char arr2[100][100];
int maxX, maxY;

void DFS1(int x, int y, char c)
{
	arr1[y][x] = 'X';
	if (0 <= x - 1 && x - 1 < maxX && 0 <= y && y < maxY)
	{
		if (arr1[y][x - 1] == c) DFS1(x - 1, y, c);
	}
	if (0 <= x + 1 && x + 1 < maxX && 0 <= y && y < maxY)
	{
		if (arr1[y][x + 1] == c) DFS1(x + 1, y, c);
	}
	if (0 <= x && x < maxX && 0 <= y + 1 && y + 1 < maxY)
	{
		if (arr1[y + 1][x] == c) DFS1(x, y + 1, c);
	}
	if (0 <= x && x < maxX && 0 <= y - 1 && y - 1 < maxY)
	{
		if (arr1[y - 1][x] == c) DFS1(x, y - 1, c);
	}
}

void DFS2(int x, int y, char c)
{
	arr2[y][x] = 'X';
	if (c == 'B')
	{
		if (0 <= x - 1 && x - 1 < maxX && 0 <= y && y < maxY)
		{
			if (arr2[y][x - 1] == c) DFS2(x - 1, y, c);
		}
		if (0 <= x + 1 && x + 1 < maxX && 0 <= y && y < maxY)
		{
			if (arr2[y][x + 1] == c) DFS2(x + 1, y, c);
		}
		if (0 <= x && x < maxX && 0 <= y + 1 && y + 1 < maxY)
		{
			if (arr2[y + 1][x] == c) DFS2(x, y + 1, c);
		}
		if (0 <= x && x < maxX && 0 <= y - 1 && y - 1 < maxY)
		{
			if (arr2[y - 1][x] == c) DFS2(x, y - 1, c);
		}
	}
	else
	{
		if (0 <= x - 1 && x - 1 < maxX && 0 <= y && y < maxY)
		{
			if (arr2[y][x - 1] != 'B' && arr2[y][x - 1] != 'X') DFS2(x - 1, y, c);
		}
		if (0 <= x + 1 && x + 1 < maxX && 0 <= y && y < maxY)
		{
			if (arr2[y][x + 1] != 'B' && arr2[y][x + 1] != 'X') DFS2(x + 1, y, c);
		}
		if (0 <= x && x < maxX && 0 <= y + 1 && y + 1 < maxY)
		{
			if (arr2[y + 1][x] != 'B' && arr2[y + 1][x] != 'X') DFS2(x, y + 1, c);
		}
		if (0 <= x && x < maxX && 0 <= y - 1 && y - 1 < maxY)
		{
			if (arr2[y - 1][x] != 'B' && arr2[y - 1][x] != 'X') DFS2(x, y - 1, c);
		}
	}
	
}

int main()
{
	int a, noCnt = 0, yesCnt = 0;
	cin >> a;
	maxX = maxY = a;
	string s;
	for (int i = 0;i < a;i++)
	{
		cin >> s;
		for (int j = 0;j < a;j++)
		{
			arr1[i][j] = s[j];
			arr2[i][j] = s[j];
		}
	}
	for (int i = 0;i < a;i++)
	{
		for (int j = 0;j < a;j++)
		{
			if (arr1[i][j] == 'R')
			{
				noCnt++;
				DFS1(j, i, 'R');
			}
			else if (arr1[i][j] == 'G')
			{
				noCnt++;
				DFS1(j, i, 'G');
			}
			else if (arr1[i][j] == 'B')
			{
				noCnt++;
				DFS1(j, i, 'B');
			}

			if (arr2[i][j] == 'R')
			{
				yesCnt++;
				DFS2(j, i, 'R');
			}
			else if (arr2[i][j] == 'G')
			{
				yesCnt++;
				DFS2(j, i, 'G');
			}
			else if (arr2[i][j] == 'B')
			{
				yesCnt++;
				DFS2(j, i, 'B');
			}
		}
	}
	cout << noCnt <<' ';
	cout << yesCnt;
	return 0;
}