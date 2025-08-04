#include <iostream>
using namespace std;

int dp1[1000];
int dp2[1000];

int main() {
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int arr[1000];
    int n, max = 0;
    cin >> n;
    for (int i = 0; i < n; ++i)
    {
        cin >> arr[i];
    }
    for (int i = 0; i < n; i++)
    {
        max = 1;
        for (int j = 0; j < i; ++j)
        {
            if (arr[i] > arr[j]) max = max > dp1[j] + 1 ? max : dp1[j] + 1;
        }
        dp1[i] = max;

    }
    for (int i = n - 1; i >= 0; --i)
    {
        max = 1;
        for (int j = n - 1; j >= i; --j)
        {
            if (arr[i] > arr[j]) max = max > dp2[j] + 1 ? max : dp2[j] + 1;
        }
        dp2[i] = max;
    }
    for (int i = 0; i < n; ++i)
    {
        max = max > dp1[i] + dp2[i] - 1 ? max : dp1[i] + dp2[i] - 1;
    }
    cout << max;

    return 0;
}
