#include <iostream>
#include <climits>
#include <queue>
#include <vector>
using namespace std;


// 공통 부분 (V는 정점의 개수, E는 간선의 개수)
vector<pair<int, int>> graph[20001];
bool isVisit[20001];
int dist[20001];

#pragma region 일반 다익스트라 (V^2)

//int Dijkstra(int n, int start, int end)
//{
//	fill(dist, dist + n + 1, INT_MAX);
//	fill(isVisit, isVisit + n + 1, false);
//	dist[start] = 0;
//	for (int i = 0; i < n; ++i)
//	{
//		int minD = INT_MAX;
//		int minIdx = -1;
//		for (int j = 1; j <= n; ++j)
//		{
//			if (!isVisit[j] && dist[j] < minD)
//			{
//				minD = dist[j];
//				minIdx = j;
//			}
//		}
//		if (minIdx == -1) break;
//		isVisit[minIdx] = true;
//		for (auto& edge : graph[minIdx])
//		{
//			int next = edge.first;
//			int cost = edge.second;
//			if (dist[next] > dist[minIdx] + cost)
//				dist[next] = dist[minIdx] + cost;
//		}
//	}
//	return dist[end];
//}

#pragma endregion

#pragma region 개선 다익스트라 (ElogV)

void Dijkstra(int n, int start)
{
	fill(dist, dist + n + 1, INT_MAX);
	fill(isVisit, isVisit + n + 1, false);

	priority_queue<pair<int, int>, vector<pair<int, int>>, greater<>> pq;
	dist[start] = 0;
	pq.push({ 0, start });

	while (!pq.empty()) {
		int curD = pq.top().first;
		int curIdx = pq.top().second;
		pq.pop();

		if (isVisit[curIdx]) continue;
		isVisit[curIdx] = true;

		for (auto [next, d] : graph[curIdx]) {
			if (dist[next] > curD + d) {
				dist[next] = curD + d;
				pq.push({ dist[next], next });
			}
		}
	}
}

#pragma endregion


int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
	int n, m, s, e, d, start;
	cin >> n >> m;
	cin >> start;
	for (int i = 0; i < m; ++i)
	{
		cin >> s >> e >> d;
		graph[s].push_back({ e,d });
	}
	Dijkstra(n, start);
	for (int i = 1; i <= n; ++i)
	{
		if(dist[i] == INT_MAX) cout << "INF" << '\n';
		else cout << dist[i] <<'\n';
	}
	return 0;
}