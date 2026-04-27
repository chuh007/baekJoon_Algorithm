#include <iostream>

using namespace std;

int N, M;
int coin[100];
int dp[10001];

int main() {
    cin >> N >> M;

    for (int i = 0; i < N; i++)
    {
        cin >> coin[i];
    }
    for(int i = 1; i <= M; ++i)
    {
        dp[i] = 10001;
        for(int j = 0; j < N; ++j)
        {
            if(i - coin[j] < 0) continue;
            dp[i] = dp[i] < dp[i-coin[j]] + 1 ? dp[i] : dp[i-coin[j]] + 1;
        }
    }
    if(dp[M] == 10001) cout << -1;
    else cout << dp[M];

    return 0;
}
