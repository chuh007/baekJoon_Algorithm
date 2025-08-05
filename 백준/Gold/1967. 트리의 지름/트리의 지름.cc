#include <iostream>
#include <vector>
using namespace std;

vector<pair<int, int>> graph[10001];

int DFS(int s);
int maxValue = 0;

int main() {
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int n, s, e, d, answer = 0;
    cin >> n;
    for (int i = 0; i < n - 1; ++i)
    {
        cin >> s >> e >> d;
        graph[s].push_back({ e,d });
    }
    DFS(1);
    cout << maxValue;
    return 0;
}


int DFS(int s)
{
    int value = 0, max = 0, maxnext1 = 0, maxnext2 = 0;
    for (int i = 0; i < graph[s].size(); ++i)
    {
        int next = DFS(graph[s][i].first);
        if (maxnext1 < next + graph[s][i].second && maxnext1 < maxnext2)
            maxnext1 = next + graph[s][i].second;
        else if (maxnext2 < next + graph[s][i].second)
            maxnext2 = next + graph[s][i].second;
        max = max > graph[s][i].second + next ? max : graph[s][i].second + next;
    }
    value += maxnext1;
    value += maxnext2;
    maxValue = maxValue > value ? maxValue : value;
    return max;
}