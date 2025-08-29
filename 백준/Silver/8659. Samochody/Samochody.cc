#include <iostream>

using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);
    cout.tie(nullptr);

    long n, ans = 0, cnt = 0, cur;
    cin >> n;
    for (int i = 0; i < n; ++i)
    {
        cin >> cur;
        if (cur == 0) cnt++;
        else ans += cnt;
    }
    cout << ans;

    return 0;
}