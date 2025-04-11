#include <iostream>
#include<math.h>
#include<algorithm>
using namespace std;

void PrintStar(bool map[3125][3125], int now, int row, int col);

bool map[3125][3125];

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int a;
	cin >> a;
	int size = pow(5, a);
	if (a == 0)
	{
        cout<<"*";
		return 0;
	}
	PrintStar(map, size, 0, 0);
	for (int i = 0; i < size; i++)
	{
		for (int j = 0; j < size; j++)
		{
			cout << (map[i][j] ? "*" : " ");
		}
		cout << "\n";
	}
}

void PrintStar(bool map[3125][3125], int now, int row, int col)
{
	if (now == 5)
	{
		map[row][col + 2] = true;
		map[row + 1][col + 2] = true;
		map[row + 2][col] = true;
		map[row + 2][col + 1] = true;
		map[row + 2][col + 2] = true;
		map[row + 2][col + 3] = true;
		map[row + 2][col + 4] = true;
		map[row + 3][col + 1] = true;
		map[row + 3][col + 2] = true;
		map[row + 3][col + 3] = true;
		map[row + 4][col + 1] = true;
		map[row + 4][col + 3] = true;
		return;
	}
	int next = now / 5;
	PrintStar(map, next, row, col + next * 2);
	PrintStar(map, next, row + next, col + next * 2);
	PrintStar(map, next, row + next * 2, col);
	PrintStar(map, next, row + next * 2, col + next);
	PrintStar(map, next, row + next * 2, col + next * 2);
	PrintStar(map, next, row + next * 2, col + next * 3);
	PrintStar(map, next, row + next * 2, col + next * 4);
	PrintStar(map, next, row + next * 3, col + next);
	PrintStar(map, next, row + next * 3, col + next * 2);
	PrintStar(map, next, row + next * 3, col + next * 3);
	PrintStar(map, next, row + next * 4, col + next);
	PrintStar(map, next, row + next * 4, col + next * 3);
}
