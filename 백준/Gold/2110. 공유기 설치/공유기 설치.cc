#include <iostream>
#include <algorithm>
using namespace std;

int arr[200000];

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int n, c;
    cin >> n >> c;
    for (int i = 0; i < n; ++i)
    {
        cin >> arr[i];
    }
    sort(arr, arr + n);
    int left = 0, right = arr[n - 1], mid = 0;
    while (left <= right)
    {
        mid = (left + right) / 2;
        int idx1 = 0, cnt = 1;
        for (int i = 1; i < n; ++i)
        {
            if (arr[i] - arr[idx1] >= mid)
            {
                cnt++;
                idx1 = i;
            }
        }
        if (cnt >= c) left = mid + 1;
        else right = mid - 1;
    }
    cout << right;

    return 0;
}
