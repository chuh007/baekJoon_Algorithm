#include <iostream>
#include <vector>
#include <algorithm>

using namespace std;


int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int answer = 0;
    int n, k, t;
    int count[5];
    vector<int> arr[5];
    cin >> n;
    for (int i = 0; i < 5; ++i)
    {
        cin >> count[i];
    }
    for (int i = 0; i < n; ++i)
    {
        cin >> k;
        switch (k)
        {
        case 1:
            cin >> t;
            arr[0].push_back(t);
            break;
        case 2:
            cin >> t;
            arr[1].push_back(t);
            break;
        case 3:
            cin >> t;
            arr[2].push_back(t);
            break;
        case 4:
            cin >> t;
            arr[3].push_back(t);
            break;
        case 5:
            cin >> t;
            arr[4].push_back(t);
            break;
        }
    }
    for (int i = 0; i < 5; ++i)
    {
        sort(arr[i].begin(),arr[i].end());
    }
    for (int i = 0; i < 5; ++i)
    {
        answer += arr[i][0];
        int temp = 0;
        for (int j = 1; j < count[i]; ++j)
        {
            temp = arr[i][j] - arr[i][j - 1];
            answer += temp;
            answer += arr[i][j];
        }
        answer += 60;
    }
    cout << answer - 60;
    return 0;
}
