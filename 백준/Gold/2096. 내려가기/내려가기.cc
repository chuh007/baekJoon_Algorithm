#include <iostream>
#include <climits>
using namespace std;

int arr[6][2];
int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int n, a, b, c;
	cin >> n;
	for (int i = 0;i < n; ++i)
	{
		cin >> a >> b >> c;
		arr[0][1] = a + max(arr[0][0], arr[1][0]);
		arr[1][1] = b + max(max(arr[0][0], arr[1][0]), arr[2][0]);
		arr[2][1] = c + max(arr[2][0], arr[1][0]);
		arr[3][1] = a + min(arr[3][0], arr[4][0]);
		arr[4][1] = b + min(min(arr[3][0], arr[4][0]), arr[5][0]);
		arr[5][1] = c + min(arr[5][0], arr[4][0]);
		arr[0][0] = arr[0][1];
		arr[1][0] = arr[1][1];
		arr[2][0] = arr[2][1];
		arr[3][0] = arr[3][1];
		arr[4][0] = arr[4][1];
		arr[5][0] = arr[5][1];
	}
	cout << max(max(arr[0][1], arr[1][1]), arr[2][1]) << ' ';
	cout << min(min(arr[3][1], arr[4][1]), arr[5][1]);

	return 0;
}