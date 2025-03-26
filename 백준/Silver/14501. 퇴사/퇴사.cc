#include <iostream>
using namespace std;

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	std::cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int T[15]{}, P[15]{};
	int n, max = 0;
	cin >> n;
	for (int i = 0;i < n;i++)
	{
		cin >> T[i] >> P[i];
		if (T[i] + i > n)
		{
			P[i] = 0;
		}
	}
	for (int i = 0; i < n; i++)
	{
		max = P[i];
		for (int j = 0;j < i; j++)
		{
			
			if (i - j >= T[j])
			{
				max = max > P[j] + P[i] ? max : P[j] + P[i];
			}
		}
		P[i] = max;
	}
	for (int i = 0;i < n;i++)
	{
		max = max > P[i] ? max : P[i];
	}
	cout << max;

}