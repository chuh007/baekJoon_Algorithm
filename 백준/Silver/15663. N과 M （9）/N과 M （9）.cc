#include <iostream>
#include <vector>
#include <algorithm>
using namespace std;

vector<int> v;
int arr[12];
bool isVisit[12];
int n, m;
void DFS(int nowcnt, int startidx)
{
    if (nowcnt == m)
    {
        for (int i = 0; i < m; ++i)
        {
            cout << arr[i] << ' ';
        }
        cout << '\n';
        return;
    }
    int before = 0;
    for (int i = 0; i < n; ++i)
    {
        if (before == v[i]) continue;
        if (isVisit[i]) continue;
        isVisit[i] = true;
        arr[nowcnt] = v[i];
        DFS(nowcnt + 1, i);
        isVisit[i] = false;
        before = v[i];
    }
}

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int temp;
    cin >> n >> m;
    for (int i = 0; i < n; ++i)
    {
        cin >> temp;
        v.push_back(temp);
    }
    sort(v.begin(), v.end());
    DFS(0, -1);

    return 0;
}