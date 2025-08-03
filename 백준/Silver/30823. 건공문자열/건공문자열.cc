#include <iostream>
#include <algorithm>
using namespace std;

int main() {
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    int n, k;
    string s;
    cin >> n >> k >> s;
    int ren = n - k;
    string left = s.substr(0, k - 1);
    string right = s.substr(k - 1);
    if (ren % 2 == 0)
    {
        reverse(left.begin(), left.end());
        cout << right << left;
    }
    else
    {
        cout << right << left;
    }

    return 0;
}