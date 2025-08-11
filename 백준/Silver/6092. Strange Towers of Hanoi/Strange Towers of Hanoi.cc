#include <iostream>
#include <vector>
#include <climits>
using namespace std;

int dp[13];

int Hanoi3(int n)
{
    return (1 << n) - 1;
}
int Hanoi4(int n)
{
    if (dp[n] != 0) return dp[n];
    if (n == 0) return dp[n] = 0;
    if (n == 1) return dp[n] = 1;
    int minsum = INT_MAX;
    for (int i = 1; i <= n; ++i)
    {
        int sum = 0;
        sum += 2 * Hanoi4(n - i);
        sum += Hanoi3(i);
        minsum = minsum < sum ? minsum : sum;
    }
    dp[n] = minsum;
    return dp[n];
}

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    Hanoi4(12);
    for (int i = 1; i <= 12; ++i)
    {
        cout << dp[i] << '\n';
    }

    return 0;
}