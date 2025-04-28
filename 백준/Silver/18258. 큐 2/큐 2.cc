#include <iostream>
#include <queue>
using namespace std;


int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
    queue<int> q;
    int a, b;
    string s;
    cin >> a;
    for (int i = 0; i < a; i++)
    {
        cin >> s;
        switch (s[1])
        {
        case 'u':
            cin >> b;
            q.push(b);
            break;
        case 'o':
            if (q.empty())
            {
                cout << -1 << '\n';
                break;
            }
            cout << q.front() << '\n';
            q.pop();
            break;
        case 'i':
            cout << q.size() << '\n';
            break;
        case 'm':
            cout << q.empty() << '\n';
            break;
        case 'r':
            if (q.empty())
            {
                cout << -1 << '\n';
                break;
            }
            cout << q.front() << '\n';
            break;
        case 'a':
            if (q.empty())
            {
                cout << -1 << '\n';
                break;
            }
            cout << q.back() << '\n';
            break;
        }

    }
    return 0;
}