#include <iostream>
#include <climits>
#include <queue>
#include <vector>
using namespace std;

// 공통 부분 (V는 정점의 개수, E는 간선의 개수)
vector<pair<int, int>> graph[101]; // graph[s].push_back({d,e}); s에서 시작해 e로 가는 비용 d짜리 길이 있다.
bool isVisit[101]; // 해당 노드에 가본적 있나?
int dist[101]; // 거기까지 가는 최소 거리
int value[101]; // 정점의 값들

int Dijkstra(int n, int start, int m) // n은 정점 개수, start는 시작점, m은 탐색 범위
{
	fill(dist, dist + n + 1, INT_MAX);
	fill(isVisit, isVisit + n + 1, false);

	priority_queue<pair<int, int>, vector<pair<int, int>>, greater<>> pq;
	int sum = 0;
	dist[start] = 0;
	pq.push({ 0, start });

	while (!pq.empty()) {
		// 지금 있는 노드 정보 가져오기
		int curD = pq.top().first;
		int curIdx = pq.top().second;
		pq.pop();

		if (isVisit[curIdx]) continue; // 중복 방문 방지
		isVisit[curIdx] = true;
		sum += value[curIdx];

		for (auto [d, next] : graph[curIdx]) {
			if (curD + d <= m) // 지금까지 온 거리랑 다음 방문할 놈 거리 합이 m보다 작거나 같은지
			{
				if (dist[next] > curD + d) { // 거리 최적화
					dist[next] = curD + d;
					pq.push({ dist[next], next });
				}
			}
		}
	}
	return sum;
}


int main()
{
	ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
	cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
	cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

	int n, m, r, s, e, d, answer = 0;
	cin >> n >> m >> r;
	for (int i = 1; i <= n; ++i)
	{
		cin >> value[i];
	}
	for (int i = 0; i < r; ++i)
	{
		cin >> s >> e >> d;
		graph[s].push_back({ d,e });
		graph[e].push_back({ d,s });
	}
	for (int i = 1; i <= n; i++)
	{
		int sum = Dijkstra(n, i, m);
		if (answer < sum) answer = sum;
	}
	cout << answer;

	return 0;
}