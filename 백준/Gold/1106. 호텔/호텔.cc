#include <iostream>
#include <vector>
#include <climits>
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);
    cout.tie(nullptr);

    int c, n;
    cin >> c >> n;
    int* cost = new int[n];
    int* man= new int[n];
    for (int i = 0; i < n; ++i)
    {
        cin >> cost[i] >> man[i];
    }
    vector<int> dp(c + 1, INT_MAX);
    dp[0] = 0;
    for (int i = 1; i <= c; ++i)
    {
        for (int j = 0; j < n; ++j)
        {
            int prev = max(0, i - man[j]);
            dp[i] = min(dp[i], dp[prev] + cost[j]);
        }
    }
    cout << dp[c];
    return 0;
}