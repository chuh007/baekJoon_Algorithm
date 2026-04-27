#include <iostream>
using namespace std;

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	std::cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int x, n, a, b;
	cin >> x >> n;
	for (int i = 0; i < n; i++)
	{
		cin >> a >> b;
		x -= a * b;
	}
	if (x == 0)
		cout << "Yes";
	else
		cout << "No";
}