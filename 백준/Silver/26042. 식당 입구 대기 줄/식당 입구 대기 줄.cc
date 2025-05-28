#include <iostream>
#include <queue>
using namespace std;

int main()
{
    ios_base::sync_with_stdio(false);
    cin.tie(NULL);
    cout.tie(NULL);

    queue<int> q;
    int n, a, maxsize = 0, nowsize = 0, num = 99999999;
    cin >> n;
    for (int i = 0;i < n;i++)
    {
        cin >> a;
        if (a == 1)
        {
            cin >> a;
            nowsize++;
            q.push(a);
            if (nowsize == maxsize) num = num > a ? a : num;
            if (nowsize > maxsize)
            {
                maxsize = nowsize;
                num = a;
            }
        }
        else
        {
            q.pop();
            nowsize--;
        }
    }
    cout << maxsize << " " << num;
}