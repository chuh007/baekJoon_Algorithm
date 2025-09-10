#include <iostream>
#include <vector>

using namespace std;

int ans[2000][2000];

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(nullptr); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(nullptr); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int n, m, s, e, left, right;
    cin >> n;
    int* arr = new int[n];
    for (int i = 0; i < n; ++i)
    {
        cin >> arr[i];
    }
    for (int i = 0; i < n; ++i)
    {
        left = i;
        right = i;
        while (left >= 0 && right < n && arr[left] == arr[right])
        {
            ans[left][right] = 1;
            left--;
            right++;
        }
    }
    for (int i = 0; i + 1 < n; ++i)
    {
        left = i;
        right = i + 1;
        while (left >= 0 && right < n && arr[left] == arr[right])
        {
            ans[left][right] = 1;
            left--;
            right++;
        }
    }
    cin >> m;
    for (int i = 0; i < m; ++i)
    {
        cin >> s >> e;
        cout << ans[s - 1][e - 1] << '\n';
    }
    delete[] arr;

    return 0;
}
