#include <iostream>
#include <queue>

using namespace std;

int arr[1000001];

void DFS(int start, int end)
{
    queue<pair<int, int>> q;
    q.push({ start, 0 });
    while (!q.empty())
    {
        int idx = q.front().first;
        int cur = q.front().second;
        q.pop();
        arr[idx] = cur;
        if (idx == end)
        {
            cout << cur;
            return;
        }
        if (idx * 2 <= 1000000 && arr[idx * 2] == 0 && idx * 2 <= end) q.push({ idx * 2, cur + 1 });
        if (idx + 1 <= 1000000 && arr[idx + 1] == 0 && idx + 1 <= end) q.push({ idx + 1, cur + 1 });
    }
}

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int a, k;
    cin >> a >> k;
    DFS(a, k);
}