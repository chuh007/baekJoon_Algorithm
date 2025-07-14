#include <iostream>
#include <climits>
#include <vector>
using namespace std;

vector<pair<int, int>> graph[1001];
bool isVisit[1001];
int dist[1001];
// N^2 ver
int Dijkstra(int n, int start, int end)
{
	fill(dist, dist + n + 1, INT_MAX);
	fill(isVisit, isVisit + n + 1, false);
	dist[start] = 0;
	for (int i = 0; i < n; ++i)
	{
		int minD = INT_MAX;
		int minIdx = -1;
		for (int j = 1; j <= n; ++j)
		{
			if (!isVisit[j] && dist[j] < minD)
			{
				minD = dist[j];
				minIdx = j;
			}
		}
		if (minIdx == -1) break;
		isVisit[minIdx] = true;
		for (auto& edge : graph[minIdx])
		{
			int next = edge.first;
			int cost = edge.second;
			if (dist[next] > dist[minIdx] + cost)
				dist[next] = dist[minIdx] + cost;
		}
	}
	return dist[end];
}

int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
	int n, m, s, e, d;
	cin >> n >> m;
	for (int i = 0; i < m; ++i)
	{
		cin >> s >> e >> d;
		graph[s].push_back({ e,d });
	}
	cin >> s >> e;
	cout << Dijkstra(n, s, e);
	return 0;
}