#include <iostream>
#include <vector>
#include <climits>
using namespace std;

vector<pair<int, int>> graph[501];
long dist[501];

bool BellmanFord(int n, int start)
{
    fill(dist, dist + n + 1, INT_MAX);
    dist[start] = 0;

    for (int i = 0; i < n; ++i)
    {
        for (int j = 1; j <= n; ++j)
        {
            if (dist[j] == INT_MAX) continue;
            for (auto& [next, d] : graph[j])
            {
                if (dist[next] > d + dist[j])
                {
                    dist[next] = d + dist[j];
                    if (i == n - 1) return false;
                }
            }
        }
    }
    return true;
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
    bool isSafe = BellmanFord(n, 1);
    if (isSafe)
    {
        for (int i = 2; i <= n; ++i)
        {
            cout << (dist[i] == INT_MAX ? -1 : dist[i]) << '\n';
        }
    }
    else cout << -1;

    return 0;
}