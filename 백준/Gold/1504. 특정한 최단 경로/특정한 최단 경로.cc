#include <iostream>
#include <climits>
#include <queue>
#include <vector>
using namespace std;


// 공통 부분 (V는 정점의 개수, E는 간선의 개수)
vector<pair<int, int>> graph[801];
bool isVisit[801];
int dist[801];


#pragma region 개선 다익스트라 (ElogV)

void Dijkstra(int n, int start) // n은 정점 개수, start는 시작점
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
	int n, m, s, e, d, v1, v2;
	cin >> n >> m;
	for (int i = 0; i < m; ++i)
	{
		cin >> s >> e >> d;
		graph[s].push_back({ e,d });
		graph[e].push_back({ s,d });
	}
	cin >> v1 >> v2;
	bool can = true;
	Dijkstra(n, 1);
	int starttov1 = dist[v1];
	int starttov2 = dist[v2];
	if (dist[v1] == INT_MAX || dist[v2] == INT_MAX) can = false;
	Dijkstra(n, v1);
	int vdist = dist[v2];
	if (dist[v2] == INT_MAX) can = false;
	Dijkstra(n, n);
	int v1toend = dist[v1];
	int v2toend = dist[v2];
	if (dist[v1] == INT_MAX || dist[v2] == INT_MAX) can = false;
	int answer = (starttov1 + vdist + v2toend) > (starttov2 + vdist + v1toend)
		? (starttov2 + vdist + v1toend) : (starttov1 + vdist + v2toend);
	if (!can) answer = -1;
	cout << answer;
	return 0;
}