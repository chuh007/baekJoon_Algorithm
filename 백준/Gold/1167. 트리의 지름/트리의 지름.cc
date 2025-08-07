#include <iostream>
#include <vector>
#include <climits>
#include <queue>
using namespace std;

vector<pair<int, int>> graph[100001];
int dist[100001];
bool isVisit[100001];


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

        for (auto& [next, d] : graph[curIdx]) {
            if (dist[next] > curD + d) {
                dist[next] = curD + d;
                pq.push({ dist[next], next });
            }
        }
    }
}

int main() 
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int v, s, e, d;
    cin >> v;
    for (int i = 0; i < v; ++i)
    {
        cin >> s;
        while (true)
        {
            cin >> e;
            if (e == -1) break;
            cin >> d;
            graph[s].push_back({ e,d });
            graph[e].push_back({ s,d });
        }
    }
    Dijkstra(v, 1);
    int start = 0, maxDist = 0;
    for (int i = 1; i <= v; ++i)
    {
        if (maxDist < dist[i])
        {
            maxDist = dist[i];
            start = i;
        }
    }
    Dijkstra(v, start);
    maxDist = 0;
    for (int i = 1; i <= v; ++i)
    {
        maxDist = maxDist > dist[i] ? maxDist : dist[i];
    }
    cout << maxDist;
    return 0;
}