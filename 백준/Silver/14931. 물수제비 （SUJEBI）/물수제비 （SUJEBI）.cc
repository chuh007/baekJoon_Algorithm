#include <iostream>
#include <vector>
#include <climits>
using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);
    cout.tie(nullptr);

    long long l, ansD = 0, maxcnt = 0;
    cin >> l;
    long long* arr = new long long[l];
    for (int i = 0; i < l; ++i)
    {
        cin >> arr[i];
    }
    for (int i = 1; i <= l; ++i)
    {
        long long idx = 0, curcnt = 0;
        while (idx + i <= l)
        {
            idx += i;
            curcnt += arr[idx - 1];
        }
        if (curcnt > maxcnt)
        {
            ansD = i;
            maxcnt = curcnt;
        }
    }
    cout << ansD << ' ' << maxcnt;
    return 0;
}