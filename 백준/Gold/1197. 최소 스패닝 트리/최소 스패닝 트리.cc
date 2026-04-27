#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;

int parent[10001];

struct Edge
{
    int s, e, dist;
    bool operator < (const Edge& e)
    {
        return dist < e.dist;
    }
};

bool unionFind(int a, int b);
int check(int a);

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(nullptr); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(nullptr); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int v, e, ans = 0;
    cin >> v >> e;
    Edge* Edges = new Edge[e];
    for (int i = 0; i < e; ++i)
    {
        cin >> Edges[i].s >> Edges[i].e >> Edges[i].dist;
    }
    for (int i = 0; i < v; ++i)
    {
        parent[i] = i;
    }
    sort(Edges, Edges + e);
    for (int i = 0; i < e; ++i)
    {
        if (unionFind(Edges[i].s, Edges[i].e)) ans += Edges[i].dist;
    }
    cout << ans;

    return 0;
}

bool unionFind(int a, int b)
{
    a = check(a);
    b = check(b);
    if (a == b) return false;
    parent[a] = b;
    return true;
}

int check(int a)
{
    if (parent[a] == a) return a;
    parent[a] = check(parent[a]);
    return parent[a];
}
