#include <iostream>
#include <climits>
#include <queue>
#include <vector>
using namespace std;

vector<pair<int, int>> graph[300001];
int dist[300001];
bool isVisited[300001];

void Dijkstra(int start, int n)
{
	fill(dist, dist + n + 1, INT_MAX);
	fill(isVisited, isVisited + n + 1, false);

	priority_queue<pair<int, int>, vector<pair<int, int>>, greater<>> pq;

	dist[start] = 0;
	pq.push({ 0, start });

	while (!pq.empty())
	{
		int curD = pq.top().first;
		int curIdx = pq.top().second;
		pq.pop();

		if (isVisited[curIdx]) continue;
		isVisited[curIdx] = true;

		for (auto& [next, d] : graph[curIdx])
		{
			if (dist[next] > curD + d)
			{
				dist[next] = curD + d;
				pq.push({ dist[next], next });
			}
		}

	}
}

int main()
{
	int n, m, k, x, a, b;
	cin >> n >> m >> k >> x;
	for (int i = 0; i < m; ++i)
	{
		cin >> a >> b;
		graph[a].push_back({ b, 1 });
	}
	bool can = false;
	Dijkstra(x, n);
	for (int i = 1; i <= n; ++i)
	{
		if (dist[i] == k)
		{
			cout << i << '\n';
			can = true;
		}
	}
	if (!can) cout << -1;

	return 0;
}