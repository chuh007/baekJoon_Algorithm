#include <iostream>
#include <vector>

using namespace std;

vector<int> tree[100001];
int arr[100001];

int dfs(int u, int parent)
{
    int ans = 0, cnt = 0;
    for (int v : tree[u])
    {
        if (v == parent) continue;
        int sum = dfs(v, u);
        ans += sum;
        cnt++;
    }
    ans += cnt;
    arr[u] = ans + 1;

    return ans;
}

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(nullptr); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(nullptr); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int n, r, q;
    cin >> n >> r >> q;
    for (int i = 0; i < n - 1; ++i)
    {
        int u, v;
        cin >> u >> v;
        tree[u].push_back(v);
        tree[v].push_back(u);
    }
    dfs(r, 0);
    
    for (int i = 0; i < q; ++i)
    {
        int u;
        cin >> u;
        cout << arr[u] << '\n';
    }
    return 0;
}
