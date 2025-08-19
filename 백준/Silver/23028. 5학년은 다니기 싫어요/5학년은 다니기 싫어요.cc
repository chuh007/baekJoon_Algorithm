#include <iostream>
using namespace std;

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int n, a, b, x, y;
    cin >> n >> a >> b;
    for (int i = 0; i < 10; ++i)
    {
        cin >> x >> y;
        if (i + n >= 8) continue;
        int cur = 6;
        a += x * 3;
        cur -= x;
        b += x * 3;
        y = y < 6 ? y : 6;
        b += (cur > y ? y * 3 : cur * 3);
    }
    if (b >= 130 && a >= 66)
    {
        cout << "Nice";
    }
    else
    {
        cout << "Nae ga wae";
    }
}