#include <iostream>
#include <climits>

using namespace std;

int arr[100001];

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int n, k;
    cin >> n >> k;
    for (int i = 1; i <= n; ++i)
    {
        cin >> arr[i];
        arr[i] += arr[i - 1];
    }
    int max = -INT_MAX;
    for (int i = k; i <= n; ++i)
    {
        max = max > arr[i] - arr[i - k] ? max: arr[i] - arr[i - k];
    }
    cout << max;
}