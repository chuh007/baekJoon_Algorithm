#include <iostream>
#include <climits>
using namespace std;

int arr[3][100001];
int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int T, n;
	cin >> T;
	for (int t = 0; t < T; ++t)
	{
		cin >> n;
		for (int i = 1; i <= n; ++i)
		{
			cin >> arr[0][i];
		}
		for (int i = 1; i <= n; ++i)
		{
			cin >> arr[1][i];
		}
		for (int i = 1;i <= n; ++i)
		{
			for (int j = 0; j < 3; ++j)
			{
				arr[j][i] = arr[j][i] + max(arr[(j + 1) % 3][i - 1], arr[(j + 2) % 3][i - 1]);
			}
		}
		cout << max(max(arr[0][n], arr[1][n]), arr[2][n]) << '\n';
		fill(arr[2], arr[2] + n + 1, 0);
	}

	return 0;
}