#include <iostream>
#include <vector>
#include <climits>
using namespace std;

vector<pair<int, int>> graph[501];
int dist[501];

bool BellmanFord(int n)
{
    fill(dist, dist + n + 1, INT_MAX);
    dist[0] = 0;

    for (int i = 1; i <= n; ++i)
    {
        graph[0].push_back({ i, 0 });
    }

    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j <= n; ++j)
        {
            if (dist[j] == INT_MAX) continue;
            for (auto& [next, d] : graph[j])
            {
                if (dist[next] > dist[j] + d)
                {
                    dist[next] = dist[j] + d;
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

    int T, n, m, w, s, e, d;
    cin >> T;
    for (int t = 0; t < T; ++t)
    {
        cin >> n >> m >> w;
        for (int i = 0; i <= n; ++i)
        {
            graph[i].clear();
        }
        for (int i = 0; i < m; ++i)
        {
            cin >> s >> e >> d;
            graph[s].push_back({ e,d });
            graph[e].push_back({ s,d });
        }
        for (int i = 0; i < w; ++i)
        {
            cin >> s >> e >> d;
            graph[s].push_back({ e,-d });
        }
        bool noMinusCycle = BellmanFord(n);
        if (noMinusCycle) cout << "NO\n";
        else cout << "YES\n";
    }

    return 0;
}