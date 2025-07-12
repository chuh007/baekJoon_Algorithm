#include <iostream>
#include <set>
#include <vector>
#include <algorithm>
using namespace std;

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
	int na, nb, a;
	vector<int> answer;
	set<int> seta, setb;
	cin >> na >> nb;
	for (int i = 0;i < na;++i)
	{
		cin >> a;
		seta.insert(a);
	}
	for (int i = 0;i < nb;++i)
	{
		cin >> a;
		setb.insert(a);
	}
	for (auto i : seta)
	{
		if (setb.find(i) == setb.end()) answer.push_back(i);
	}
	cout << answer.size() <<'\n';
	for (auto i : answer) cout << i << ' ';
	return 0;
}