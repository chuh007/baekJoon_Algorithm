#include <iostream>
#include <vector>
#include <stack>
#include <algorithm>
using namespace std;

vector<pair<int,int>> arr;
vector<int> dp;
int idxList[1000001];
bool isLIS[1000001];

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int n, lastIdx = 0, a, b;
    cin >> n;
    for (int i = 0; i < n; ++i)
    {
        cin >> a >> b;
        arr.push_back({ a - 1, b - 1 });
    }
    sort(arr.begin(), arr.end());
    for (int i = 0; i < n; ++i)
    {
        if (dp.size() == 0 || dp.back() < arr[i].second)
        {
            idxList[i] = dp.size();
            dp.push_back(arr[i].second);
        }
        else
        {
            int idx = lower_bound(dp.begin(), dp.end(), arr[i].second) - dp.begin();
            idxList[i] = idx;
            dp[idx] = arr[i].second;
        }
    }
    stack<int> lisStack;
    lastIdx = dp.size() - 1;
    for (int i = n - 1; i >= 0; --i)
    {
        if (idxList[i] == lastIdx)
        {
            lisStack.push(arr[i].first);
            isLIS[arr[i].first] = true;
            lastIdx--;
        }
    }
    cout << n - dp.size() << '\n';
    for (int i = 0; i < n; ++i)
    {
        if (!isLIS[arr[i].first])
        {
            cout << arr[i].first + 1 << '\n';
        }
    }

    return 0;
}
