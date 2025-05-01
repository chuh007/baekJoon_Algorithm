#include <iostream>
#include <queue>
#include <stack>

using namespace std;

int main()
{
	queue<int> q;
	stack<int> stack; // 1은 원래 사람 있는곳, 2는 저장소
	int a, b, nowNum = 1;
	bool can = true;
	cin >> a;
	for (int i = 0; i < a; i++)
	{
		cin >> b;
		q.push(b);
	}
	while (!q.empty() || !stack.empty())
	{
		if (q.empty() && stack.top() != nowNum)
		{
			can = false;
			break;
		}
		if (!q.empty() && q.front() == nowNum)
		{
			q.pop();
			nowNum++;
		}
		else if (!stack.empty() && stack.top() == nowNum)
		{
			stack.pop();
			nowNum++;
		}
		else
		{
			stack.push(q.front());
			q.pop();
		}
	}
	if (can) cout << "Nice";
	else cout << "Sad";
}
 