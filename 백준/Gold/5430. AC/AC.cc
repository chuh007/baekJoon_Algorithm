#include <iostream>
#include <deque>
using namespace std;

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int T, n, x;
	string p;
	char c;
	deque <int> arr;
	cin >> T;
	bool trigger = false, isFail = false;
	for (int t = 0; t < T;t++)
	{
		cin.clear();
		cin.ignore(1024, '\n');
		arr.clear();
		cin >> p;
		cin >> n;
		cin >> c;
		isFail = false;
		trigger = false;
		if (n == 0) cin >> c;
		else
		{
			while (true)
			{
				if (!(cin >> x)) break;
				arr.push_back(x);
				cin >> c;
				if (c == ']') break;
			}
		}
		
		for(int i = 0;i < p.size();i++)
		{
			if (p[i] == 'R') trigger = !trigger;
			else
			{
				if (arr.empty())
				{
					cout << "error\n";
					isFail = true;
					break;
				}
				if (trigger) arr.pop_back();
				else arr.pop_front();
			}
		}
		if (!isFail)
		{
			cout << "[";
			if (trigger)
			{
				for (int i = 1; i < (int)arr.size(); i++)
				{
					cout << arr[arr.size() - i];
					cout << ",";
				}
				if (arr.size() != 0) cout << arr[0];
			}
			else
			{
				for (int i = 0; i < (int)arr.size() - 1; i++)
				{
					cout << arr[i];
					cout << ",";
				}
				if (arr.size() != 0) cout << arr[arr.size() - 1];

			}
			cout << "]\n";
		}
	}
		
}
