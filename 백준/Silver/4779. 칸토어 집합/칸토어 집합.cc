#include <iostream>
#include <math.h>;
using namespace std;

void cantor(int nowSize, int start, bool* arr)
{
	if (nowSize < 3) return;
	int nextSize = nowSize / 3;
	for (int i = 0; i < nextSize; i++)
	{
		arr[start + nextSize + i] = true;
	}
	cantor(nextSize, start, arr);
	cantor(nextSize, start + nextSize * 2, arr);
}

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	std::cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int n;
	while (cin >> n)
	{
		int scale = pow(3, n);
		bool* arr = new bool[scale]();
		cantor(scale, 0, arr);
		for (int i = 0; i < scale; i++)
		{
			if (arr[i]) cout << " ";
			else cout << "-";
		}
		cout << '\n';
		delete[] arr;
	}
}