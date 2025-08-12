#include <iostream>
#include <vector>
using namespace std;



pair<int,int> vertexs[10000];

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    long n, x, y, firstx, firsty, beforex, beforey;
    long double sum1 = 0, sum2 = 0;
    cin >> n;
    cin >> x >> y;
    firstx = x;
    firsty = y;
    beforex = x;
    beforey = y;
    for (int i = 1; i < n; ++i)
    {
        cin >> x >> y;
        sum1 += beforex * y;
        sum2 += beforey * x;
        beforex = x;
        beforey = y;
    }
    x = firstx;
    y = firsty;
    sum1 += beforex * y;
    sum2 += beforey * x;
    long double answer = abs(sum1 - sum2);
    cout << fixed;
    cout.precision(1);
    cout << answer * 0.5f;
    return 0;
}