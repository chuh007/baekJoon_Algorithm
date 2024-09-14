#include <string>
#include <vector>
#include<iostream>
#include<algorithm>
#include<stack>

using namespace std;

int DP[41][2] = {0};
int countZero = 0;
int countOne = 0;

void fibonacci(int n) {
    if (n == 0) {
        countZero++;
        DP[n][0] = 1;
        DP[n][1] = 0;
    }
    else if (n == 1) {
        countOne++;
        DP[n][0] = 0;
        DP[n][1] = 1;
    }
    else if (DP[n][0] == 0&& DP[n][1] == 0) {
        fibonacci(n - 1);
        fibonacci(n - 2);
        DP[n][0] = DP[n - 1][0] + DP[n - 2][0];
        DP[n][1] = DP[n - 1][1] + DP[n - 2][1];
    }
    countZero = DP[n][0];
    countOne = DP[n][1];
}
int main()
{
    ios::sync_with_stdio(false); // 지우지 말 것.
    cin.tie(NULL); // 지우지 말 것.
    cout.tie(NULL); // 지우지 말 것.
    
    int T;
    cin >> T;
    for (int i = 0;i < T;i++) {
        countZero = 0;
        countOne = 0;
        int a;
        cin >> a;
        fibonacci(a);
        cout << countZero << " " << countOne<<'\n';
    }
    
    return 0;
}