#include <iostream>
#include<algorithm>
using namespace std;

void PrintStar(bool** map, int now, int row, int col);

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int a;
	cin >> a;
	bool** map = new bool* [a];
	for (int i = 0; i < a; i++)
	{
		map[i] = new bool[a]();
	}
	PrintStar(map, a, 0, 0);
	for (int i = 0; i < a; i++)
	{
		for (int j = 0; j < a; j++)
		{
			cout << (map[i][j] ? "*" : " ");
		}
		cout << "\n";
	}
	delete[] map;
}

void PrintStar(bool** map, int now, int row, int col)
{
	if (now == 3)
	{
		for (int i = row;i < now + row; i++)
		{
			for (int j = col;j < now + col; j++)
			{
				if (i == row + 1 && j == col + 1)
					map[i][j] = false;
				else
					map[i][j] = true;
			}
		}
		return;
	}
	int next = now / 3;
	PrintStar(map, next, row, col);
	PrintStar(map, next, row, col + next);
	PrintStar(map, next, row + next, col);
	PrintStar(map, next, row + next, col + next * 2);
	PrintStar(map, next, row + next * 2, col + next);
	PrintStar(map, next, row + next * 2, col);
	PrintStar(map, next, row, col + next * 2);
	PrintStar(map, next, row + next * 2, col + next * 2);
}