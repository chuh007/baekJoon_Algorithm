#include <iostream>
#include <vector>
using namespace std;

bool isvisit[100001];
int answer[100001];
vector<int> graph[100001];

void DFS(int n)
{
	isvisit[n] = true;
	for (int i = 0;i < graph[n].size();i++)
	{
		if (isvisit[graph[n][i]]) continue;
		answer[graph[n][i]] = n;
		DFS(graph[n][i]);
	}
}

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
	int n, a, b;
	cin >> n;
	for (int i = 0; i < n - 1; ++i)
	{
		cin >> a >> b;
		graph[a].push_back(b);
		graph[b].push_back(a);
	}

	DFS(1);
	for (int i = 2; i <= n; i++)
		cout << answer[i] << '\n';
	return 0;
}