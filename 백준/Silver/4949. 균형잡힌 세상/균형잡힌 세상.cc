#include <string>
#include <vector>
#include<iostream>
#include<algorithm>
#include<stack>
using namespace std;

int main()
{
    string s;
    stack<char> stack1;
    while (true)
    {
        bool answer = true;
        getline(cin, s);
        if (s == ".") break;
        for (char c : s) {
            if (c == '('|| c == '[') {
                stack1.push(c);
            }
            else if (c == ')') {
                if (stack1.empty()||stack1.top() !='(') {
                    answer = false;
                    break;
                }
                stack1.pop();
            }
            else if (c == ']') {
                if (stack1.empty()||stack1.top()!='[') {
                    answer = false;
                    break;
                }
                stack1.pop();
            }
        }
        if (!stack1.empty()) {
            answer = false;
        }
        while (!stack1.empty())
        {
            stack1.pop();
        }
        if (answer)cout << "yes\n";
        else cout << "no\n";
    }
    return 0;
}
