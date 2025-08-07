#include <iostream>
#include <vector>
#include <climits>
#include <queue>
#include <stack>
using namespace std;

vector<pair<int, int>> graph[1001];
int channel[1001];
int dist[1001];
bool isVisit[1001];


void Dijkstra(int n, int start)
{
    fill(dist, dist + n + 1, INT_MAX);
    fill(isVisit, isVisit + n + 1, false);

    priority_queue<pair<int, int>, vector<pair<int, int>>, greater<>> pq;
    dist[start] = 0;
    channel[start] = start;
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
                channel[next] = curIdx;
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

    int n, m, s, e, d;
    cin >> n >> m;
    for (int i = 0; i < m; ++i)
    {
        cin >> s >> e >> d;
        graph[s].push_back({ e,d });
    }
    cin >> s >> e;
    Dijkstra(n, s);
    stack<int> stack;
    stack.push(channel[e]);
    while (true)
    {
        if (stack.top() == s) break;
        stack.push(channel[stack.top()]);
    }
    cout << dist[e] << '\n';
    cout << stack.size() + 1 << '\n';
    while (!stack.empty())
    {
        cout << stack.top() << ' ';
        stack.pop();
    }
    cout << e;

    return 0;
}