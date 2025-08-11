#include <iostream>
#include <vector>
#include <queue>
#include <climits>
using namespace std;

vector<pair<int, int>> graph[1001];
int dist[1001];
bool isVisit[1001];

void Dijkstra(int n, int start, int end)
{
    fill(dist, dist + n + 1, INT_MAX);
    fill(isVisit, isVisit + n + 1, false);
    priority_queue<pair<int, int>, vector<pair<int, int>>, greater<>> pq;
    dist[start] = 0;
    pq.push({ 0, start });
    while (!pq.empty())
    {
        int curD = pq.top().first;
        int curIdx = pq.top().second;
        pq.pop();
        if (isVisit[curIdx]) continue;
        isVisit[curIdx] = true;
        if (curIdx == end) return;
        for (auto &[next, d] : graph[curIdx])
        {
            if (dist[next] > curD + d)
            {
                dist[next] = curD + d;
                pq.push({ dist[next], next });
            }
        }
    }
}

void Dijkstra(int n, int start)
{
    fill(dist, dist + n + 1, INT_MAX);
    fill(isVisit, isVisit + n + 1, false);
    priority_queue<pair<int, int>, vector<pair<int, int>>, greater<>> pq;
    dist[start] = 0;
    pq.push({ 0, start });
    while (!pq.empty())
    {
        int curD = pq.top().first;
        int curIdx = pq.top().second;
        pq.pop();
        if (isVisit[curIdx]) continue;
        isVisit[curIdx] = true;
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
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int n, m, x, s, e, d, answer = 0;
    cin >> n >> m >> x;
    vector<int> homedist(n + 1);
    for (int i = 0; i < m; ++i)
    {
        cin >> s >> e >> d;
        graph[s].push_back({ e,d });
    }
    for (int i = 1; i <= n; ++i)
    {
        if (i == x) continue;
        Dijkstra(n, i, x);
        homedist[i] = dist[x];
    }
    Dijkstra(n, x);
    for (int i = 1; i <= n; ++i)
    {
        homedist[i] += dist[i];
        answer = answer > homedist[i] ? answer : homedist[i];
    }
    cout << answer;
    return 0;
}