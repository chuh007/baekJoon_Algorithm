#include <iostream>
#include <vector>
using namespace std;

int arr[1000000];
vector<int> dp;

int main() 
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int n;
    cin >> n;
    for (int i = 0; i < n; ++i)
    {
        cin >> arr[i];
    }
    for (int i = 0; i < n; ++i)
    {
        if (dp.size() == 0 || dp.back() < arr[i]) dp.push_back(arr[i]);
        else dp[lower_bound(dp.begin(), dp.end(), arr[i]) - dp.begin()] = arr[i];
    }
    cout << dp.size();
    return 0;
}
