#include <iostream>
#include <stack>
#include <vector>
#include <algorithm>

using namespace std;

int main()
{
    ios::sync_with_stdio(false); // 이 코드들은 빠른 입출력에 도움이 됨.
    cin.tie(NULL); // C의 입출력과 C++의 입출력을 분리해서 속도를 2배 가까이 올려줌.
    cout.tie(NULL); // 대신 이렇게 하면 C의 입출력을 사용하진 못함.

    string s, bomb;
    bool isBoom = false;
    stack<char> revAns;
    cin >> s >> bomb;
    for (int i = 0; i < s.size(); ++i)
    {
        revAns.push(s[i]);
        if (revAns.size() >= bomb.size())
        {
            stack<char> temp;
            isBoom = true;
            for (int j = bomb.size() - 1; j >= 0; --j)
            {
                if (revAns.top() != bomb[j])
                {
                    isBoom = false;
                    break;
                }
                temp.push(revAns.top());
                revAns.pop();
            }
            if (!isBoom) // 바이츠 더 더스트 성공!
            {
                while (!temp.empty())
                {
                    revAns.push(temp.top());
                    temp.pop();
                }
            }
        }
    }
    vector<char> answer;
    while (!revAns.empty())
    {
        answer.push_back(revAns.top());
        revAns.pop();
    }
    reverse(answer.begin(), answer.end());
    if (answer.size() == 0) cout << "FRULA";
    else
    {
        for (int i = 0; i < answer.size(); ++i)
        {
            cout << answer[i];
        }
    }
}