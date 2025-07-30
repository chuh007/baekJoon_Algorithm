#include <iostream>
using namespace std;

int arr[3][1001];
int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int n, a;
	cin >> n;
	for (int i = 1;i <= n; ++i)
	{
		for (int j = 0; j < 3; ++j)
		{
			cin >> a;
			arr[j][i] = a + min(arr[(j + 1) % 3][i - 1], arr[(j + 2) % 3][i - 1]);
		}
	}
	cout << min(min(arr[0][n], arr[1][n]), arr[2][n]);
	return 0;
}