#include <iostream>
#include <vector>
#include <climits>
#include <queue>
using namespace std;

vector<pair<int, int>> graph[50];
long long money[50];
int price[50];
bool isVisit[50];

bool BellmanFord(int n, int start, int end)
{
    fill(money, money + n, INT_MAX);
    vector<int> cycleVertex;
    money[start] = -price[start];
    bool cycle = false;

    for (int i = 0; i < n; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            if (money[j] == INT_MAX) continue;
            for (auto& [next, d] : graph[j])
            {
                if (money[next] > d + money[j])
                {
                    money[next] = d + money[j];
                    if (i == n - 1)
                    {
                        cycle = true;
                        cycleVertex.push_back(j);
                    }
                }
            }
        }
    }

    queue<int> q;

    for (int v : cycleVertex)
    {
        q.push(v);
    }
    while (!q.empty())
    {
        int cur = q.front();
        q.pop();
        if (isVisit[cur]) continue;
        isVisit[cur] = true;
        if (cur == end) return true;
        for (auto& [next, d] : graph[cur])
        {
            q.push(next);
        }
    }

    return false;
}

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int n, start, end, m, s, e, d;
    cin >> n >> start >> end >> m;
    for (int i = 0; i < m; ++i)
    {
        cin >> s >> e >> d;
        graph[s].push_back({ e,d });
    }
    for (int i = 0; i < n; ++i)
    {
        cin >> price[i];
    }
    for (int i = 0; i < n; ++i)
    {
        for (auto& [next, d] : graph[i])
        {
            d -= price[next];
        }
    }
    bool gee = BellmanFord(n, start, end);
    if (gee)
    {
        cout << "Gee";
    }
    else
    {
        if (money[end] == INT_MAX) cout << "gg";
        else cout << -money[end];
    }

    return 0;
}