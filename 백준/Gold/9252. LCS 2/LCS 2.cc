#include <iostream>
#include <vector>
#include <stack>

using namespace std;

int dp[1001][1001];

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(nullptr); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(nullptr); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    string s1, s2;
    cin >> s1 >> s2;
    for (int i = 1; i <= s1.size(); ++i)
    {
        for (int j = 1; j <= s2.size(); ++j)
        {
            if (s1[i - 1] == s2[j - 1]) dp[i][j] = dp[i - 1][j - 1] + 1;
            else dp[i][j] = dp[i - 1][j] > dp[i][j - 1] ? dp[i - 1][j] : dp[i][j - 1];
        }
    }
    stack<char> answer;
    int idx1 = s1.size();
    int idx2 = s2.size();
    while (idx1 > 0 && idx2 > 0)
    {
        if (s1[idx1 - 1] == s2[idx2 - 1])
        {
            answer.push(s1[idx1 - 1]);
            idx1--;
            idx2--;
            continue;
        }
        if (dp[idx1 - 1][idx2] > dp[idx1][idx2 - 1]) idx1--;
        else idx2--;
    }
    cout << dp[s1.size()][s2.size()] << '\n';
    while (!answer.empty())
    {
        cout << answer.top();
        answer.pop();
    }

    return 0;
}
