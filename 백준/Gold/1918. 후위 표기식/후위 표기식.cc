#include <iostream>
#include <stack>
using namespace std;


int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.
    
    string s;
    cin >> s;
    stack<char> stack;
    for (char c : s)
    {
        if (c >= 'A' && c <= 'Z')
        {
            cout << c;
        }
        else if (c == '(')
        {
            stack.push(c);
        }
        else if (c == ')')
        {
            while (!stack.empty() && stack.top() != '(')
            {
                cout << stack.top();
                stack.pop();
            }
            stack.pop();
        }
        else if (c == '*' || c == '/')
        {
            while (!stack.empty() && stack.top() != '+' && stack.top() != '-' && stack.top() != '(')
            {
                cout << stack.top();
                stack.pop();
            }
            stack.push(c);
        }
        else
        {
            while (!stack.empty() && stack.top() != '(')
            {
                cout << stack.top();
                stack.pop();
            }
            stack.push(c);
        }
    }
    while (!stack.empty())
    {
        cout << stack.top();
        stack.pop();
    }

    return 0;
}