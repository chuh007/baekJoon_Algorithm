#include <iostream>
#include <vector>

using namespace std;

int answer[1001][1001];

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int n, m;
    cin >> n >> m;
    if (n == 1 || m == 1)
    {
        if (n != m)
        {
            cout << 2 <<'\n';
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if ((i + j) % 2 == 0) cout << 1 << ' ';
                    else cout << 2 << ' ';
                }
                cout << '\n';
            }
        }
        else cout << 1 << '\n' << 1;
    }
    else
    {
        cout << 4 << '\n';
        for (int i = 0; i < n; ++i)
        {
            for (int j = 0; j < m; ++j)
            {
                if (j % 2 == 0) cout << (i % 2 == 0 ? 2 : 1) << ' ';
                else cout << (i % 2 == 0 ? 3 : 4) << ' ';
            }
            cout << '\n';
        }
    }
    return 0;
}
