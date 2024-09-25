#include<iostream>
#include<string>
#include<sstream>
#include<stack>
using namespace std;


int dp[1000001];

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    std::cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int N = 0;
    cin >> N;
    for (int i = 2;i <= N;i++) {
        dp[i] = dp[i - 1] + 1;
        if (i % 2 == 0) {
            dp[i] = min(dp[i], dp[i / 2] + 1);

        }
        if (i % 3 == 0) {
            dp[i] = min(dp[i], dp[i / 3] + 1);
        }
    }
    cout << dp[N];
    return 0;
}