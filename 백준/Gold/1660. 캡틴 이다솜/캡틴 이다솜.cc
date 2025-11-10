#include <iostream>
using namespace std;

int dp[300001];

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
	
	// n(n+1)(n+2)/6
	int n;
	cin >> n;
	int a = 1, triangle = 0;
	while (true)
	{
		triangle = a * (a + 1) * (a + 2) / 6;
		if (triangle > n) break;
		dp[triangle] = 1;
		a++;
	}
	for (int i = 1; i <= n; ++i)
	{
		if (dp[i] != 1)
			dp[i] = dp[i - 1] + 1;
		a = 1;
		while (true)
		{
			triangle = a * (a + 1) * (a + 2) / 6;
			if (triangle > i) break;
			dp[i] = dp[i] < dp[i - triangle] + 1 ? dp[i] : dp[i - triangle] + 1;
			a++;
		}
	}
	cout << dp[n];
	return 0;
}