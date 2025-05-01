#include <iostream>
#include <stack>

using namespace std;

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    std::cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
	stack<int> stack;
	int a, b,c;
	cin >> a;
	for (int i = 0; i < a; i++)
	{
		cin >> b;
		switch (b)
		{
		case 1:
			cin >> c;
			stack.push(c);
			break;
		case 2:
			if (stack.empty()) cout << -1 << '\n';
			else
			{
				cout << stack.top() << '\n';
				stack.pop();
			}
			break;
		case 3:
			cout << stack.size() << '\n';
			break;
		case 4:
			cout << (stack.empty() ? 1 : 0) << '\n';
			break;
		case 5:
			if (stack.empty()) cout << -1 << '\n';
			else cout << stack.top() << '\n';
			break;
		}
	}
}
