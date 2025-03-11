#include <iostream>
using namespace std;

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	std::cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int a;
	cin >> a;
	int dp[502][502];
	for (int i = 1;i < a + 1;i++)
	{
		dp[1][i] = 0;
	}
	for (int i = 2;i < a+2;i++)
	{
		for (int j = 1;j < i;j++)
		{
			cin >> dp[i][j];
			dp[i][j] = dp[i][j] + (dp[i - 1][j - 1] > dp[i - 1][j] ? dp[i - 1][j - 1] : dp[i - 1][j]);
		}
	}
	int max = dp[a + 1][1];
	for (int i = 1;i < a + 1;i++) {
		max = max > dp[a + 1][i] ? max : dp[a + 1][i];
	}
	cout << max;
}