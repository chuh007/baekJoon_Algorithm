#include <iostream>
#include<math.h>
#include<algorithm>
using namespace std;

void PrintStar(bool map[3072][6144], int now, int row, int col);

bool map[3072][6144];

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int a;
	cin >> a;
	PrintStar(map, a, 0, 0);
	for (int i = 0; i < a; i++)
	{
		for (int j = 0; j < a * 2; j++)
		{
			cout << (map[i][j] ? "*" : " ");
		}
		cout << "\n";
	}
}

void PrintStar(bool map[3072][6144], int now, int row, int col)
{
	if (now == 3)
	{
		map[row][col + 2] = true;
		map[row + 1][col + 1] = true;
		map[row + 1][col + 3] = true;
		map[row + 2][col] = true;
		map[row + 2][col + 1] = true;
		map[row + 2][col + 2] = true;
		map[row + 2][col + 3] = true;
		map[row + 2][col + 4] = true;
		return;
	}
	int next = now / 2;
	PrintStar(map, next, row, col + next);
	PrintStar(map, next, row + next, col);
	PrintStar(map, next, row + next, col + next * 2);
	
}
