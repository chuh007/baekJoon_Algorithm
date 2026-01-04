#include <iostream>
#include <queue>
using namespace std;

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	bool isZero = true;
	int n, m, a, b;
	cin >> n >> m;
	queue<int> q;
	vector<vector<int>> isLink(n + 1);
	int* inCount = new int[n + 1]; // 진입차수 배열
	for (int i = 0; i <= n; ++i)
	{
		inCount[i] = 0;
	}
	for (int i = 0; i < m; ++i)
	{
		cin >> a >> b;
		isLink[a].push_back(b);
		inCount[b]++;
	}
	// 이상 입력

	for (int i = 1; i <= n; ++i) // 초기 진입차수 0인 애들 찾기
	{
		if (inCount[i] == 0) q.push(i);
	}

	vector<int> answer;
	while (!q.empty())
	{
		int v = q.front();
		q.pop();
		answer.push_back(v); // 나온 순서대로 정렬
		for (int next : isLink[v]) // 현재 노드와 인접한 애들의 진입차수 1씩 감소
		{
			inCount[next]--;
			if (inCount[next] == 0) // 진입차수가 0이 되면 Queue의 끝에 추가
			{
				q.push(next);
			}
		}
	}
	for (int i : answer)
	{
		cout << i << ' ';
	}

}
