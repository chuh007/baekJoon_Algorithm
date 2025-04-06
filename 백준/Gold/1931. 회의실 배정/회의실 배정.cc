#include <iostream>
#include<algorithm>
using namespace std;
int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	pair<int, int>* v = new pair<int, int>[100000];
	int a, b, c, cnt = 1, start, end;
	cin >> a;
	for (int i = 0;i < a;i++)
	{
		cin >> b >> c;
		v[i] = { b, c };
	}
	sort(v, v + a);
	start = v[0].first;
	end = v[0].second;
	for (int i = 1;i < a;i++)
	{
		if (v[i].second < end)
		{
			start = v[i].first;
			end = v[i].second;
		}
		else if (end <= v[i].first)
		{
			start = v[i].first;
			end = v[i].second;
			cnt++;
		}
	}
	cout << cnt;
	delete[] v;
}