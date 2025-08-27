#include <iostream>
#include <unordered_map>

using namespace std;

int main()
{
    ios::sync_with_stdio(false);
    cin.tie(nullptr);
    cout.tie(nullptr);

    int q, x, maxValue = 0;
    unordered_map<int, int> map;
    cin >> q;
    for (int i = 0; i < q; i++)
    {
        cin >> x;
        switch (x)
        {
        case 1:
            cin >> x;
            maxValue = 0;
            for (int j = x; j < x + 4; j++)
            {
                maxValue = maxValue > map[j] ? maxValue : map[j];
            }
            for (int j = x; j < x + 4; j++)
            {
                map[j] = maxValue + 1;
            }
            break;
        case 2:
            cin >> x;
            map[x] += 4;
            break;
        case 3:
            cin >> x;
            cout << map[x] << '\n';
            break;
        }
    }

    return 0;
}