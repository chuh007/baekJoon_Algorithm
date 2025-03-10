#include <iostream>
using namespace std;

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	std::cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int a, b;
	cin >> a >> b;
	cout << a + b << '\n' << a - b << '\n' << a * b << '\n' << a / b << '\n' << a % b;
}